import { Component, ElementRef, OnInit, ViewChild } from '@angular/core';
import { FormControl, FormGroup } from '@angular/forms';
import { Title } from '@angular/platform-browser';
import { Observer } from 'rxjs';
import { Filme } from 'src/app/Filme';
import { Sala } from 'src/app/Sala';
import { Venda } from 'src/app/Venda';
import { VendaService } from 'src/app/venda.service';

@Component({
  selector: 'app-venda',
  templateUrl: './venda.component.html',
  styleUrls: ['./venda.component.css']
})
export class VendaComponent implements OnInit {
  @ViewChild('cancelarButton') cancelarButton!: ElementRef;
  formulario: any;
  formularioBuscar: any;
  ListVenda: Venda[] = [];
  ListFilmes: Filme[] = [];
  ListSalas: Sala[] = [];
  nomeVendaEncontrado: Venda | null = null;
  tiposingresso = [
    { tipoIngresso: 'Meia' },
    { tipoIngresso: 'Inteira' }
  ]

  constructor(private vendaService: VendaService, private titleService: Title) { }

  ngOnInit(): void {
    this.formulario = new FormGroup({
      idVenda: new FormControl(null),
      //data: new FormControl(null),
      //cliente: new FormControl(null),
      //ingresso: new FormControl(null),
      //snack: new FormControl(null),
      precoTotal: new FormControl(null)
    });
    this.listar();
    this.formularioBuscar = new FormGroup({
      idVenda: new FormControl(null),
    });
    this.titleService.setTitle('Venda MidnightCity');
  }

  cadastrar(): void {
    const venda: Venda = this.formulario.value;
    if (!venda.idVenda) {
      venda.idVenda = 0;
    }
    const observer: Observer<Venda> = {
      next(_result): void {
        alert('Venda cadastrada com sucesso.');
      },
      error(error): void {
        console.error(error);
        alert('Erro de cadastro, verifique se todos os campos foram preenchidos corretamente.');
      },
      complete(): void {},
    };
    this.vendaService.cadastrar(venda).subscribe(observer);
  }

  listar(): void {
    this.vendaService.listar().subscribe(
      (vendas: Venda[]) => {
        this.ListVenda = vendas;
      },
      (error) => {
        console.error(error);
        alert('Erro ao carregar a lista de vendas!');
      }
    );
  }

  buscar(): void {
    const idVenda: number = this.formularioBuscar.get('idVenda').value;
    
    if (idVenda) {
      this.vendaService.buscar(idVenda).subscribe(
        (vendaEncontrado: any) => {
          console.log(vendaEncontrado);
          this.formularioBuscar.get('idVenda')?.setValue(vendaEncontrado.idVenda);
          this.nomeVendaEncontrado = vendaEncontrado;    
        },
        (error) => {
          console.error(error);
          alert('Erro ao buscar venda');
        }
      );
    } else {
      alert('Por favor, insira um ID válido para buscar.');
    }
  }

  alterar(): void {
    const venda: Venda = this.formulario.value;
    if (venda.idVenda === null) {
      alert('Por favor, busque uma venda antes de tentar alterar.');
      return;
    }
    /*if (!venda.data) {
      venda.data = 'date';
    }*/
    /*if (!venda.cliente) {
      venda.cliente = 'string';
    }*/
    /*if (!venda.ingresso) {
      venda.ingresso = 'string';
    }*/
    /*if (!venda.snack) {
      venda.snack = 'string';
    }*/
    if (!venda.precoTotalVenda || isNaN(venda.precoTotalVenda)) { venda.precoTotalVenda = 0; }
  
    const observer: Observer<Venda> = {
      next(_result): void {
        alert('Venda alterada com sucesso.');
      },
      error(error): void {
        console.error(error);
        alert('Erro ao alterar!');
      },
      complete(): void {},
    };
    this.vendaService.alterar(venda).subscribe(observer);
  }  

  excluir(): void {
    const idVenda: number = this.formulario.get('idVenda').value;
  
    if (idVenda) {
      if (confirm('Tem certeza que deseja excluir a sala?')) {
        this.vendaService.excluir(idVenda).subscribe(
          () => {
            alert('Sala excluída com sucesso.');
            this.reloadPage();
          },
          (error) => {
            console.error(error);
            alert('Erro ao excluir venda!');
          }
        );
      }
    } else {
      alert('Por favor, insira um ID válido para excluir.');
    }
  }

  meiaentrada(): void {
    const tipoIngresso: string = this.formulario.get('tipoIngresso').value;
    const sala: Sala | null = this.nomeVendaEncontrado?.ingresso?.filme?.sala || null;
  
    if (sala) {
      if (tipoIngresso.toLowerCase() === 'Meia') {
        this.formulario.get('precoTotal').setValue(sala.preco / 2);
      } else {
        this.formulario.get('precoTotal').setValue(sala.preco);
      }
    } else {
      console.error('Erro: Sala não encontrada para o filme associado à venda.');
    }
  }

  reloadPage(): void {
    window.location.reload();
  }
}