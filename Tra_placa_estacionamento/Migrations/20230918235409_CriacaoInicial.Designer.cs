﻿// <auto-generated />
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace estacionamento.Migrations
{
    [DbContext(typeof(EstacionamentoDbContext))]
    [Migration("20230918235409_CriacaoInicial")]
    partial class CriacaoInicial
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder.HasAnnotation("ProductVersion", "7.0.11");

            modelBuilder.Entity("Veiculo", b =>
                {
                    b.Property<string>("Placa")
                        .HasColumnType("TEXT");

                    b.Property<string>("Id")
                        .HasColumnType("TEXT");

                    b.HasKey("Placa");

                    b.ToTable("veiculo");
                });
#pragma warning restore 612, 618
        }
    }
}
