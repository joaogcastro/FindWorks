﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using MidnightCityTheater.Data;

#nullable disable

namespace MidnightCityTheater.Migrations
{
    [DbContext(typeof(APIDbContext))]
    [Migration("20231120132600_teste")]
    partial class teste
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder.HasAnnotation("ProductVersion", "7.0.11");

            modelBuilder.Entity("MidnightCityTheater.Models.Bebida", b =>
                {
                    b.Property<int>("IdBebida")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<double>("Preco")
                        .HasColumnType("REAL");

                    b.Property<string>("Sabor")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<int?>("SnackIdSnack")
                        .HasColumnType("INTEGER");

                    b.Property<string>("Tamanho")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.HasKey("IdBebida");

                    b.HasIndex("SnackIdSnack");

                    b.ToTable("Bebida");
                });

            modelBuilder.Entity("MidnightCityTheater.Models.Cliente", b =>
                {
                    b.Property<int>("IdCliente")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<string>("CPF")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("Email")
                        .HasColumnType("TEXT");

                    b.Property<string>("Nome")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("Telefone")
                        .HasColumnType("TEXT");

                    b.HasKey("IdCliente");

                    b.HasIndex("CPF")
                        .IsUnique();

                    b.ToTable("Cliente");
                });

            modelBuilder.Entity("MidnightCityTheater.Models.Doce", b =>
                {
                    b.Property<int>("IdDoce")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<string>("Nome")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<double>("Preco")
                        .HasColumnType("REAL");

                    b.Property<int?>("SnackIdSnack")
                        .HasColumnType("INTEGER");

                    b.HasKey("IdDoce");

                    b.HasIndex("SnackIdSnack");

                    b.ToTable("Doce");
                });

            modelBuilder.Entity("MidnightCityTheater.Models.Filme", b =>
                {
                    b.Property<int>("IdFilme")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<string>("Categoria")
                        .HasColumnType("TEXT");

                    b.Property<string>("Classificacao")
                        .HasColumnType("TEXT");

                    b.Property<string>("Diretor")
                        .HasColumnType("TEXT");

                    b.Property<string>("Duracao")
                        .HasColumnType("TEXT");

                    b.Property<int>("IdSala")
                        .HasColumnType("INTEGER");

                    b.Property<int?>("SalaIdSala")
                        .HasColumnType("INTEGER");

                    b.Property<string>("nomeFilme")
                        .HasColumnType("TEXT");

                    b.HasKey("IdFilme");

                    b.HasIndex("SalaIdSala");

                    b.ToTable("Filme");
                });

            modelBuilder.Entity("MidnightCityTheater.Models.Funcionario", b =>
                {
                    b.Property<int>("IdFuncionario")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<string>("CPFfunc")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("EmailFunc")
                        .HasColumnType("TEXT");

                    b.Property<string>("NomeFunc")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("TelefoneFunc")
                        .HasColumnType("TEXT");

                    b.HasKey("IdFuncionario");

                    b.ToTable("Funcionario");
                });

            modelBuilder.Entity("MidnightCityTheater.Models.Ingresso", b =>
                {
                    b.Property<int>("IdIngresso")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<DateTime>("Data")
                        .HasColumnType("TEXT");

                    b.Property<int?>("FilmeIdFilme")
                        .HasColumnType("INTEGER");

                    b.Property<double?>("PrecoIng")
                        .IsRequired()
                        .HasColumnType("REAL");

                    b.Property<string>("TipoIngresso")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.HasKey("IdIngresso");

                    b.HasIndex("FilmeIdFilme");

                    b.ToTable("Ingresso");
                });

            modelBuilder.Entity("MidnightCityTheater.Models.Pipoca", b =>
                {
                    b.Property<int>("IdPipoca")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<double>("Preco")
                        .HasColumnType("REAL");

                    b.Property<string>("Sabor")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<int?>("SnackIdSnack")
                        .HasColumnType("INTEGER");

                    b.Property<string>("Tamanho")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.HasKey("IdPipoca");

                    b.HasIndex("SnackIdSnack");

                    b.ToTable("Pipoca");
                });

            modelBuilder.Entity("MidnightCityTheater.Models.Sala", b =>
                {
                    b.Property<int>("IdSala")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<string>("Capacidade")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<double>("Preco")
                        .HasColumnType("REAL");

                    b.Property<string>("TipoSala")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.HasKey("IdSala");

                    b.ToTable("Sala");
                });

            modelBuilder.Entity("MidnightCityTheater.Models.Snack", b =>
                {
                    b.Property<int>("IdSnack")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<decimal>("PrecoTotal")
                        .HasColumnType("TEXT");

                    b.HasKey("IdSnack");

                    b.ToTable("Snack");
                });

            modelBuilder.Entity("MidnightCityTheater.Models.Venda", b =>
                {
                    b.Property<int>("IdVenda")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<DateTime>("Data")
                        .HasColumnType("TEXT");

                    b.Property<double>("PrecoTotalVenda")
                        .HasColumnType("REAL");

                    b.Property<int?>("SnackIdSnack")
                        .HasColumnType("INTEGER");

                    b.HasKey("IdVenda");

                    b.HasIndex("SnackIdSnack");

                    b.ToTable("Venda");
                });

            modelBuilder.Entity("MidnightCityTheater.Models.Bebida", b =>
                {
                    b.HasOne("MidnightCityTheater.Models.Snack", null)
                        .WithMany("Bebidas")
                        .HasForeignKey("SnackIdSnack");
                });

            modelBuilder.Entity("MidnightCityTheater.Models.Doce", b =>
                {
                    b.HasOne("MidnightCityTheater.Models.Snack", null)
                        .WithMany("Doces")
                        .HasForeignKey("SnackIdSnack");
                });

            modelBuilder.Entity("MidnightCityTheater.Models.Filme", b =>
                {
                    b.HasOne("MidnightCityTheater.Models.Sala", "Sala")
                        .WithMany()
                        .HasForeignKey("SalaIdSala");

                    b.Navigation("Sala");
                });

            modelBuilder.Entity("MidnightCityTheater.Models.Ingresso", b =>
                {
                    b.HasOne("MidnightCityTheater.Models.Filme", "Filme")
                        .WithMany()
                        .HasForeignKey("FilmeIdFilme");

                    b.Navigation("Filme");
                });

            modelBuilder.Entity("MidnightCityTheater.Models.Pipoca", b =>
                {
                    b.HasOne("MidnightCityTheater.Models.Snack", null)
                        .WithMany("Pipocas")
                        .HasForeignKey("SnackIdSnack");
                });

            modelBuilder.Entity("MidnightCityTheater.Models.Venda", b =>
                {
                    b.HasOne("MidnightCityTheater.Models.Snack", "Snack")
                        .WithMany()
                        .HasForeignKey("SnackIdSnack");

                    b.Navigation("Snack");
                });

            modelBuilder.Entity("MidnightCityTheater.Models.Snack", b =>
                {
                    b.Navigation("Bebidas");

                    b.Navigation("Doces");

                    b.Navigation("Pipocas");
                });
#pragma warning restore 612, 618
        }
    }
}
