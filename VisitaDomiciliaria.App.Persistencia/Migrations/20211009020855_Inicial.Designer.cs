﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using VisitaDomiciliaria.App.Persistencia;

namespace VisitaDomiciliaria.App.Persistencia.Migrations
{
    [DbContext(typeof(AppContext))]
    [Migration("20211009020855_Inicial")]
    partial class Inicial
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .UseIdentityColumns()
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("ProductVersion", "5.0.0");

            modelBuilder.Entity("VisitaDomiciliaria.App.Dominio.Gato", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .UseIdentityColumn();

                    b.Property<string>("Nombre")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int?>("PropietarioId")
                        .HasColumnType("int");

                    b.Property<string>("Raza")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.HasIndex("PropietarioId");

                    b.ToTable("Gatos");
                });

            modelBuilder.Entity("VisitaDomiciliaria.App.Dominio.Persona", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .UseIdentityColumn();

                    b.Property<string>("Apellidos")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Discriminator")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Nombres")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Telefono")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Personas");

                    b.HasDiscriminator<string>("Discriminator").HasValue("Persona");
                });

            modelBuilder.Entity("VisitaDomiciliaria.App.Dominio.Visita", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .UseIdentityColumn();

                    b.Property<string>("EstadoAnimo")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("FechaVisita")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("FrecuenciaCardiaca")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("FrecuenciaRespiratoria")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int?>("GatoId")
                        .HasColumnType("int");

                    b.Property<string>("Peso")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Recomendaciones")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Temperatura")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int?>("VeterinarioId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("GatoId");

                    b.HasIndex("VeterinarioId");

                    b.ToTable("Visitas");
                });

            modelBuilder.Entity("VisitaDomiciliaria.App.Dominio.Propietario", b =>
                {
                    b.HasBaseType("VisitaDomiciliaria.App.Dominio.Persona");

                    b.Property<string>("Correo")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Direccion")
                        .HasColumnType("nvarchar(max)");

                    b.HasDiscriminator().HasValue("Propietario");
                });

            modelBuilder.Entity("VisitaDomiciliaria.App.Dominio.Veterinario", b =>
                {
                    b.HasBaseType("VisitaDomiciliaria.App.Dominio.Persona");

                    b.Property<string>("TarjetaProfesional")
                        .HasColumnType("nvarchar(max)");

                    b.HasDiscriminator().HasValue("Veterinario");
                });

            modelBuilder.Entity("VisitaDomiciliaria.App.Dominio.Gato", b =>
                {
                    b.HasOne("VisitaDomiciliaria.App.Dominio.Propietario", "Propietario")
                        .WithMany()
                        .HasForeignKey("PropietarioId");

                    b.Navigation("Propietario");
                });

            modelBuilder.Entity("VisitaDomiciliaria.App.Dominio.Visita", b =>
                {
                    b.HasOne("VisitaDomiciliaria.App.Dominio.Gato", "Gato")
                        .WithMany()
                        .HasForeignKey("GatoId");

                    b.HasOne("VisitaDomiciliaria.App.Dominio.Veterinario", "Veterinario")
                        .WithMany()
                        .HasForeignKey("VeterinarioId");

                    b.Navigation("Gato");

                    b.Navigation("Veterinario");
                });
#pragma warning restore 612, 618
        }
    }
}
