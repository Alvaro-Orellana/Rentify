﻿// <auto-generated />
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Rentify.Data;

namespace Rentify.Migrations
{
    [DbContext(typeof(MyDBContext))]
    [Migration("20210212154925_AgregarTiposMemebresia")]
    partial class AgregarTiposMemebresia
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "5.0.3");

            modelBuilder.Entity("Rentify.Models.Cliente", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<bool>("EstaSubscrito")
                        .HasColumnType("INTEGER");

                    b.Property<string>("Nombre")
                        .HasColumnType("TEXT");

                    b.Property<byte>("TipoMembresiaId")
                        .HasColumnType("INTEGER");

                    b.HasKey("Id");

                    b.HasIndex("TipoMembresiaId");

                    b.ToTable("Clientes");
                });

            modelBuilder.Entity("Rentify.Models.Pelicula", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<string>("Nombre")
                        .HasColumnType("TEXT");

                    b.HasKey("Id");

                    b.ToTable("Peliculas");
                });

            modelBuilder.Entity("Rentify.Models.TipoMembresia", b =>
                {
                    b.Property<byte>("Id")
                        .HasColumnType("INTEGER");

                    b.Property<short>("CostoRegistro")
                        .HasColumnType("INTEGER");

                    b.Property<byte>("Descuento")
                        .HasColumnType("INTEGER");

                    b.Property<byte>("DuracionEnMeses")
                        .HasColumnType("INTEGER");

                    b.HasKey("Id");

                    b.ToTable("TipoMembresia");
                });

            modelBuilder.Entity("Rentify.Models.Cliente", b =>
                {
                    b.HasOne("Rentify.Models.TipoMembresia", "TipoMembresia")
                        .WithMany()
                        .HasForeignKey("TipoMembresiaId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("TipoMembresia");
                });
#pragma warning restore 612, 618
        }
    }
}
