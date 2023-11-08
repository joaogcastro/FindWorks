import { Component, ElementRef, OnInit, ViewChild } from '@angular/core';
import { FormControl, FormGroup } from '@angular/forms';
import { Sala } from 'src/app/Sala';
import { SalasService } from 'src/app/salas.service';

@Component({
  selector: 'app-salas',
  templateUrl: './salas.component.html',
  styleUrls: ['./salas.component.css']
})
export class SalasComponent implements OnInit {
  @ViewChild('cancelarButton') cancelarButton!: ElementRef;
  formulario!: FormGroup;
  salas: Sala[] = [];
  novaSala: Sala = new Sala(); // Adicione uma nova instância de Sala

  constructor(private salasService: SalasService) { }

  ngOnInit(): void {
    this.formulario = new FormGroup({
      idsala: new FormControl(null),
      tiposala: new FormControl(null),
      capacidade: new FormControl(null)
    });

    this.listarSalas(); // Carregue a lista de salas quando o componente for inicializado
  }

  listarSalas(): void {
    this.salasService.listar().subscribe((result: Sala[]) => {
      this.salas = result;
    });
  }

  cadastrarSala(): void {
    const sala: Sala = this.novaSala;
    if (!sala.idsala) {
      sala.idsala = 0;
    }

    this.salasService.cadastrar(sala).subscribe({
      next: (_result: Sala) => {
        alert('Sala cadastrada com sucesso.');
        this.listarSalas();
      },
      error: (error) => {
        console.error(error);
        alert('Erro ao cadastrar!');
      },
      complete: () => {
      },
    });
  }

  editarSala(sala: Sala): void {
    const sala1: Sala = this.formulario.value;
    if (!sala1.capacidade) {
      sala1.capacidade = "string";
    }
    if (!sala1.tiposala) {
      sala1.tiposala = "string";
    }

    this.salasService.alterar(sala).subscribe({
      next: (_result: Sala) => {
        alert('Sala alterada com sucesso.');
        this.listarSalas();
      },
      error: (error) => {
        console.error(error);
        alert('Erro ao alterar!');
      },
      complete: () => {
      },
    });
  }

  excluirSala(idSala: number): void {
    this.salasService.excluir(idSala).subscribe({
      next: (_result: Sala) => {
        alert('Sala excluída com sucesso.');
        this.listarSalas();
      },
      error: (error) => {
        console.error(error);
        alert('Erro ao excluir!');
      },
      complete: () => {
      },
    });
  }

  reloadPage(): void {
    window.location.reload();
  }
}