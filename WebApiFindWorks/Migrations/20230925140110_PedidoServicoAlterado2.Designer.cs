﻿// <auto-generated />
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using WebApiFindWorks.Data;

#nullable disable

namespace WebApiFindWorks.Migrations
{
    [DbContext(typeof(WebApiFindWorksDbContext))]
    [Migration("20230925140110_PedidoServicoAlterado2")]
    partial class PedidoServicoAlterado2
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder.HasAnnotation("ProductVersion", "7.0.11");

            modelBuilder.Entity("WebApiFindWorks.Models.Profissional", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<string>("Bairro")
                        .HasColumnType("TEXT");

                    b.Property<string>("Cidade")
                        .HasColumnType("TEXT");

                    b.Property<double>("DistanciaDoCentro")
                        .HasColumnType("REAL");

                    b.Property<string>("Email")
                        .HasColumnType("TEXT");

                    b.Property<string>("Nome")
                        .HasColumnType("TEXT");

                    b.Property<string>("Profissao")
                        .HasColumnType("TEXT");

                    b.Property<string>("Telefone")
                        .HasColumnType("TEXT");

                    b.Property<double>("ValorHora")
                        .HasColumnType("REAL");

                    b.HasKey("Id");

                    b.ToTable("Profissional");
                });

            modelBuilder.Entity("WebApiFindWorks.Models.Rating", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<string>("Comentario")
                        .HasColumnType("TEXT");

                    b.Property<int>("ProfissionalId")
                        .HasColumnType("INTEGER");

                    b.Property<int>("Value")
                        .HasColumnType("INTEGER");

                    b.HasKey("Id");

                    b.HasIndex("ProfissionalId");

                    b.ToTable("Rating");
                });

            modelBuilder.Entity("WebApiFindWorks.Models.Usuario", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<string>("NomeUsuario")
                        .HasColumnType("TEXT");

                    b.Property<string>("Senha")
                        .HasColumnType("TEXT");

                    b.HasKey("Id");

                    b.ToTable("Usuario");
                });

            modelBuilder.Entity("WebApiFindWorks.Models.Rating", b =>
                {
                    b.HasOne("WebApiFindWorks.Models.Profissional", null)
                        .WithMany("Ratings")
                        .HasForeignKey("ProfissionalId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("WebApiFindWorks.Models.Profissional", b =>
                {
                    b.Navigation("Ratings");
                });
#pragma warning restore 612, 618
        }
    }
}