﻿// <auto-generated />
using System;
using BancoCunha.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace BancoCunha.Migrations
{
    [DbContext(typeof(MySqlContext))]
    [Migration("20210917131153_003")]
    partial class _003
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("Relational:MaxIdentifierLength", 64)
                .HasAnnotation("ProductVersion", "5.0.10");

            modelBuilder.Entity("BancoCunha.Models.Banco", b =>
                {
                    b.Property<int>("Idbanco")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<string>("Codbanco")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<string>("Nomebanco")
                        .IsRequired()
                        .HasColumnType("text");

                    b.HasKey("Idbanco");

                    b.ToTable("Banco");
                });

            modelBuilder.Entity("BancoCunha.Models.Conta", b =>
                {
                    b.Property<int>("IdConta")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<DateTime>("DataAbertura")
                        .HasColumnType("datetime");

                    b.Property<int>("IdPessoa")
                        .HasColumnType("int");

                    b.Property<string>("NumeroAgencia")
                        .HasColumnType("text");

                    b.Property<int>("NumeroConta")
                        .HasColumnType("int");

                    b.Property<int?>("PessoaIdPessoa")
                        .HasColumnType("int");

                    b.HasKey("IdConta");

                    b.HasIndex("PessoaIdPessoa");

                    b.ToTable("Conta");
                });

            modelBuilder.Entity("BancoCunha.Models.MovimentacaoBancaria", b =>
                {
                    b.Property<int>("IdMovimentacaoBancaria")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<string>("AutenticacaoMovimentacao")
                        .HasColumnType("text");

                    b.Property<DateTime>("DataMovimentacao")
                        .HasColumnType("datetime");

                    b.Property<string>("NumeroAgencia")
                        .HasColumnType("text");

                    b.Property<string>("NumeroConta")
                        .HasColumnType("text");

                    b.Property<int>("ValorMovimentacao")
                        .HasColumnType("int");

                    b.HasKey("IdMovimentacaoBancaria");

                    b.ToTable("MovimentacaoBancaria");
                });

            modelBuilder.Entity("BancoCunha.Models.Pessoa", b =>
                {
                    b.Property<int>("IdPessoa")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<string>("DocumentoPessoa")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<string>("NomePessoa")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<string>("TipoPessoa")
                        .HasColumnType("text");

                    b.HasKey("IdPessoa");

                    b.ToTable("Pessoa");
                });

            modelBuilder.Entity("BancoCunha.Models.SaldoPessoa", b =>
                {
                    b.Property<int>("IdSaldo")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<int>("IdConta")
                        .HasColumnType("int");

                    b.Property<int>("IdPessoa")
                        .HasColumnType("int");

                    b.Property<string>("NumeroAgencia")
                        .HasColumnType("text");

                    b.Property<int>("NumeroConta")
                        .HasColumnType("int");

                    b.Property<decimal>("ValorSaldo")
                        .HasColumnType("decimal(18, 2)");

                    b.HasKey("IdSaldo");

                    b.HasIndex("IdConta")
                        .IsUnique();

                    b.HasIndex("IdPessoa");

                    b.ToTable("SaldoPessoa");
                });

            modelBuilder.Entity("BancoCunha.Models.Conta", b =>
                {
                    b.HasOne("BancoCunha.Models.Pessoa", "Pessoa")
                        .WithMany()
                        .HasForeignKey("PessoaIdPessoa");

                    b.Navigation("Pessoa");
                });

            modelBuilder.Entity("BancoCunha.Models.SaldoPessoa", b =>
                {
                    b.HasOne("BancoCunha.Models.Conta", "Conta")
                        .WithOne("SaldoPessoa")
                        .HasForeignKey("BancoCunha.Models.SaldoPessoa", "IdConta")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("BancoCunha.Models.Pessoa", "Pessoa")
                        .WithMany()
                        .HasForeignKey("IdPessoa")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Conta");

                    b.Navigation("Pessoa");
                });

            modelBuilder.Entity("BancoCunha.Models.Conta", b =>
                {
                    b.Navigation("SaldoPessoa");
                });
#pragma warning restore 612, 618
        }
    }
}
