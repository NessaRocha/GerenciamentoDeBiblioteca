﻿// <auto-generated />
using System;
using GerenciamentoDeBiblioteca.Data.Context;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace GerenciamentoDeBiblioteca.Migrations
{
    [DbContext(typeof(DataContext))]
    [Migration("20230630183752_InitialMigration")]
    partial class InitialMigration
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder.HasAnnotation("ProductVersion", "7.0.7");

            modelBuilder.Entity("GerenciamentoDeBiblioteca.Domain.Entities.Autor", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER")
                        .HasColumnName("id");

                    b.Property<string>("Nome")
                        .IsRequired()
                        .HasColumnType("TEXT")
                        .HasColumnName("nome");

                    b.HasKey("Id");

                    b.ToTable("autor", (string)null);
                });

            modelBuilder.Entity("GerenciamentoDeBiblioteca.Domain.Entities.Livro", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER")
                        .HasColumnName("id");

                    b.Property<int?>("AlugadoPorId")
                        .HasColumnType("INTEGER");

                    b.Property<int?>("AutorId")
                        .HasColumnType("INTEGER");

                    b.Property<string>("Titulo")
                        .IsRequired()
                        .HasColumnType("TEXT")
                        .HasColumnName("titulo");

                    b.HasKey("Id");

                    b.HasIndex("AlugadoPorId");

                    b.HasIndex("AutorId");

                    b.ToTable("livro", (string)null);
                });

            modelBuilder.Entity("GerenciamentoDeBiblioteca.Domain.Entities.Usuario", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<string>("Nome")
                        .HasColumnType("TEXT");

                    b.HasKey("Id");

                    b.ToTable("Usuarios");
                });

            modelBuilder.Entity("GerenciamentoDeBiblioteca.Domain.Entities.Livro", b =>
                {
                    b.HasOne("GerenciamentoDeBiblioteca.Domain.Entities.Usuario", "AlugadoPor")
                        .WithMany()
                        .HasForeignKey("AlugadoPorId");

                    b.HasOne("GerenciamentoDeBiblioteca.Domain.Entities.Autor", "Autor")
                        .WithMany("Livros")
                        .HasForeignKey("AutorId");

                    b.Navigation("AlugadoPor");

                    b.Navigation("Autor");
                });

            modelBuilder.Entity("GerenciamentoDeBiblioteca.Domain.Entities.Autor", b =>
                {
                    b.Navigation("Livros");
                });
#pragma warning restore 612, 618
        }
    }
}
