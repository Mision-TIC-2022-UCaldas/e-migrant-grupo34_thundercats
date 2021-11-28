﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Migrantes.App.Persistencia;

namespace Migrantes.App.Persistencia.Migrations
{
    [DbContext(typeof(AppContext))]
    partial class AppContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .UseIdentityColumns()
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("ProductVersion", "5.0.0");

            modelBuilder.Entity("Migrantes.App.Dominio.Necesidades", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .UseIdentityColumn();

                    b.Property<string>("Descripcion")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int?>("MigranteId")
                        .HasColumnType("int");

                    b.Property<int>("Prioridad")
                        .HasColumnType("int");

                    b.Property<int>("Tipo")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("MigranteId");

                    b.ToTable("Necesidades1");
                });

            modelBuilder.Entity("Migrantes.App.Dominio.Persona", b =>
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

                    b.Property<string>("FechaNacimiento")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Nombre")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("NumeroDocumento")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("PaisOrigen")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("TipoDocumento")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Personas");

                    b.HasDiscriminator<string>("Discriminator").HasValue("Persona");
                });

            modelBuilder.Entity("Migrantes.App.Dominio.Migrante", b =>
                {
                    b.HasBaseType("Migrantes.App.Dominio.Persona");

                    b.Property<string>("Ciudad")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Correo")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("DireccionActual")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("NumeroTelefono")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("SituacionLaboral")
                        .HasColumnType("nvarchar(max)");

                    b.HasDiscriminator().HasValue("Migrante");
                });

            modelBuilder.Entity("Migrantes.App.Dominio.AmigosYFamiliares", b =>
                {
                    b.HasBaseType("Migrantes.App.Dominio.Migrante");

                    b.Property<int?>("MigranteId")
                        .HasColumnType("int");

                    b.HasIndex("MigranteId");

                    b.HasDiscriminator().HasValue("AmigosYFamiliares");
                });

            modelBuilder.Entity("Migrantes.App.Dominio.Necesidades", b =>
                {
                    b.HasOne("Migrantes.App.Dominio.Migrante", null)
                        .WithMany("Necesidades")
                        .HasForeignKey("MigranteId");
                });

            modelBuilder.Entity("Migrantes.App.Dominio.AmigosYFamiliares", b =>
                {
                    b.HasOne("Migrantes.App.Dominio.Migrante", null)
                        .WithMany("AmigosYFamiliares")
                        .HasForeignKey("MigranteId");
                });

            modelBuilder.Entity("Migrantes.App.Dominio.Migrante", b =>
                {
                    b.Navigation("AmigosYFamiliares");

                    b.Navigation("Necesidades");
                });
#pragma warning restore 612, 618
        }
    }
}
