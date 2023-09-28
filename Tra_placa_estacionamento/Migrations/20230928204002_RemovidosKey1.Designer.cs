﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace estacionamento.Migrations
{
    [DbContext(typeof(EstacionamentoDbContext))]
    [Migration("20230928204002_RemovidosKey1")]
    partial class RemovidosKey1
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder.HasAnnotation("ProductVersion", "7.0.11");

            modelBuilder.Entity("Cliente", b =>
                {
                    b.Property<string>("Cpf")
                        .HasColumnType("TEXT");

                    b.Property<string>("Email")
                        .HasColumnType("TEXT");

                    b.Property<int?>("Id")
                        .HasColumnType("INTEGER");

                    b.Property<string>("Nome")
                        .HasColumnType("TEXT");

                    b.HasKey("Cpf");

                    b.ToTable("cliente");
                });

            modelBuilder.Entity("Marca", b =>
                {
                    b.Property<int?>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<string>("DescricaoMarca")
                        .HasColumnType("TEXT");

                    b.HasKey("Id");

                    b.ToTable("Marca");
                });

            modelBuilder.Entity("Modelo", b =>
                {
                    b.Property<int?>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<string>("DescricaoModelo")
                        .HasColumnType("TEXT");

                    b.Property<int?>("MarcaId")
                        .HasColumnType("INTEGER");

                    b.Property<int>("Porte")
                        .HasColumnType("INTEGER");

                    b.HasKey("Id");

                    b.HasIndex("MarcaId");

                    b.ToTable("Modelo");
                });

            modelBuilder.Entity("Veiculo", b =>
                {
                    b.Property<int?>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<string>("ClienteCpf")
                        .HasColumnType("TEXT");

                    b.Property<int>("CorExterna")
                        .HasColumnType("INTEGER");

                    b.Property<string>("Descricao")
                        .HasColumnType("TEXT");

                    b.Property<string>("Discriminator")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<int?>("ModeloId")
                        .HasColumnType("INTEGER");

                    b.Property<string>("Placa")
                        .HasColumnType("TEXT");

                    b.HasKey("Id");

                    b.HasIndex("ClienteCpf");

                    b.HasIndex("ModeloId");

                    b.ToTable("veiculo");

                    b.HasDiscriminator<string>("Discriminator").HasValue("Veiculo");

                    b.UseTphMappingStrategy();
                });

            modelBuilder.Entity("Caminhonete", b =>
                {
                    b.HasBaseType("Veiculo");

                    b.Property<string>("Combustivel")
                        .HasColumnType("TEXT");

                    b.Property<int?>("NroPortas")
                        .HasColumnType("INTEGER");

                    b.ToTable("veiculo", t =>
                        {
                            t.Property("NroPortas")
                                .HasColumnName("Caminhonete_NroPortas");
                        });

                    b.HasDiscriminator().HasValue("Caminhonete");
                });

            modelBuilder.Entity("Carro", b =>
                {
                    b.HasBaseType("Veiculo");

                    b.Property<int?>("NroPortas")
                        .HasColumnType("INTEGER");

                    b.HasDiscriminator().HasValue("Carro");
                });

            modelBuilder.Entity("Moto", b =>
                {
                    b.HasBaseType("Veiculo");

                    b.Property<bool?>("Bau")
                        .HasColumnType("INTEGER");

                    b.HasDiscriminator().HasValue("Moto");
                });

            modelBuilder.Entity("Modelo", b =>
                {
                    b.HasOne("Marca", "Marca")
                        .WithMany()
                        .HasForeignKey("MarcaId");

                    b.Navigation("Marca");
                });

            modelBuilder.Entity("Veiculo", b =>
                {
                    b.HasOne("Cliente", null)
                        .WithMany("Veiculos")
                        .HasForeignKey("ClienteCpf");

                    b.HasOne("Modelo", "Modelo")
                        .WithMany()
                        .HasForeignKey("ModeloId");

                    b.Navigation("Modelo");
                });

            modelBuilder.Entity("Cliente", b =>
                {
                    b.Navigation("Veiculos");
                });
#pragma warning restore 612, 618
        }
    }
}
