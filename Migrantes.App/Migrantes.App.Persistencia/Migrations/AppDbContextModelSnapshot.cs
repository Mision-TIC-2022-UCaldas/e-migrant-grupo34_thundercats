﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Migrantes.App.Persistencia;

namespace Persistencia.Migrations
{
    [DbContext(typeof(AppDbContext))]
    partial class AppDbContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("ProductVersion", "5.0.4")
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("Migrantes.App.Dominio.Entidad", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Ciudad")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Direccion")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("DireccionElectronica")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("Nit")
                        .HasColumnType("int");

                    b.Property<string>("PaginaWeb")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("RazonSocial")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("Sector")
                        .HasColumnType("int");

                    b.Property<string>("Telefono")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("TipoServicio")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.ToTable("Entidades");
                });

            modelBuilder.Entity("Migrantes.App.Dominio.Servicio", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int?>("EntidadId")
                        .HasColumnType("int");

                    b.Property<int>("EstadoServicio")
                        .HasColumnType("int");

                    b.Property<DateTime>("FechaFinOferta")
                        .HasColumnType("datetime2");

                    b.Property<DateTime>("FechaInicioOferta")
                        .HasColumnType("datetime2");

                    b.Property<int>("MaxMigrantes")
                        .HasColumnType("int");

                    b.Property<string>("NombreServicio")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.HasIndex("EntidadId");

                    b.ToTable("Servicios");
                });

            modelBuilder.Entity("Migrantes.App.Dominio.Servicio", b =>
                {
                    b.HasOne("Migrantes.App.Dominio.Entidad", null)
                        .WithMany("Servicios")
                        .HasForeignKey("EntidadId");
                });

            modelBuilder.Entity("Migrantes.App.Dominio.Entidad", b =>
                {
                    b.Navigation("Servicios");
                });
#pragma warning restore 612, 618
        }
    }
}
