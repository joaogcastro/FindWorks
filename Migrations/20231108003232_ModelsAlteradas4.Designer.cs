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
    [Migration("20231108003232_ModelsAlteradas4")]
    partial class ModelsAlteradas4
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
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("NomeFilme")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<int>("SalaId")
                        .HasColumnType("INTEGER");

                    b.HasKey("IdFilme");

                    b.HasIndex("SalaId");

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

                    b.Property<string>("Data")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<int>("FilmeId")
                        .HasColumnType("INTEGER");

                    b.Property<string>("Preco")
                        .HasColumnType("TEXT");

                    b.Property<int>("SalaId")
                        .HasColumnType("INTEGER");

                    b.Property<string>("TipoIngresso")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<int>("VendaId")
                        .HasColumnType("INTEGER");

                    b.HasKey("IdIngresso");

                    b.HasIndex("FilmeId");

                    b.HasIndex("SalaId");

                    b.HasIndex("VendaId");

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

                    b.Property<string>("TipoSala")
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

                    b.HasKey("IdVenda");

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
                        .HasForeignKey("SalaId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Sala");
                });

            modelBuilder.Entity("MidnightCityTheater.Models.Ingresso", b =>
                {
                    b.HasOne("MidnightCityTheater.Models.Filme", "Filme")
                        .WithMany()
                        .HasForeignKey("FilmeId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("MidnightCityTheater.Models.Sala", "Sala")
                        .WithMany()
                        .HasForeignKey("SalaId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("MidnightCityTheater.Models.Venda", "Venda")
                        .WithMany()
                        .HasForeignKey("VendaId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Filme");

                    b.Navigation("Sala");

                    b.Navigation("Venda");
                });

            modelBuilder.Entity("MidnightCityTheater.Models.Pipoca", b =>
                {
                    b.HasOne("MidnightCityTheater.Models.Snack", null)
                        .WithMany("Pipocas")
                        .HasForeignKey("SnackIdSnack");
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
