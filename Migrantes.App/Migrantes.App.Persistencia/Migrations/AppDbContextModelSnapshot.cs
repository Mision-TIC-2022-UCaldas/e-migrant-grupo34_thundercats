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

            modelBuilder.Entity("AmigosyfamiliaresMigrante", b =>
                {
                    b.Property<int>("AmigosYFamiliaresId")
                        .HasColumnType("int");

                    b.Property<int>("MigranteId")
                        .HasColumnType("int");

                    b.HasKey("AmigosYFamiliaresId", "MigranteId");

                    b.HasIndex("MigranteId");

                    b.ToTable("AmigosyfamiliaresMigrante");
                });

            modelBuilder.Entity("Migrantes.App.Dominio.Amigosyfamiliares", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Relacion")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("idMigranteAmigo")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.ToTable("Amigosyfamiliares1");
                });

            modelBuilder.Entity("Migrantes.App.Dominio.CalificacionApp", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("ValorCalificacion")
                        .HasColumnType("int");

                    b.Property<int>("numeroDocumentoMigrante")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.ToTable("CalificacionApp");
                });

            modelBuilder.Entity("Migrantes.App.Dominio.CalificacionServicios", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("TipoServicio")
                        .HasColumnType("int");

                    b.Property<int>("ValorCalificacion")
                        .HasColumnType("int");

                    b.Property<int>("numeroDocumentoMigrante")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.ToTable("CalificacionesServicios");
                });

            modelBuilder.Entity("Migrantes.App.Dominio.Emergencias", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Descripcion")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("TipoEmergencia")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.ToTable("Emergencias");
                });

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

            modelBuilder.Entity("Migrantes.App.Dominio.Necesidades", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Descripcion")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int?>("MigranteId")
                        .HasColumnType("int");

                    b.Property<int>("Prioridad")
                        .HasColumnType("int");

                    b.Property<int>("Tipo")
                        .HasColumnType("int");

                    b.Property<int>("Validacion")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("MigranteId");

                    b.ToTable("NecesidadesDb");
                });

            modelBuilder.Entity("Migrantes.App.Dominio.Novedad", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("DiasActiva")
                        .HasColumnType("int");

                    b.Property<bool>("EstaActiva")
                        .HasColumnType("bit");

                    b.Property<DateTime>("FechaNovedad")
                        .HasColumnType("datetime2");

                    b.Property<string>("TextoExplicativo")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Novedades");
                });

            modelBuilder.Entity("Migrantes.App.Dominio.Persona", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Apellidos")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Discriminator")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("FechaNacimiento")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Nombre")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("NumeroDocumento")
                        .HasColumnType("int");

                    b.Property<string>("PaisOrigen")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("TipoDocumento")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Personas");

                    b.HasDiscriminator<string>("Discriminator").HasValue("Persona");
                });

            modelBuilder.Entity("Migrantes.App.Dominio.Servicio", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("Categoria")
                        .HasColumnType("int");

                    b.Property<int>("EntidadId")
                        .HasColumnType("int");

                    b.Property<bool>("EstaActivo")
                        .HasColumnType("bit");

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

            modelBuilder.Entity("Migrantes.App.Dominio.Usuario", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<bool>("EstaActivo")
                        .HasColumnType("bit");

                    b.Property<string>("Password")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int?>("PersonaId")
                        .HasColumnType("int");

                    b.Property<int>("Rol")
                        .HasColumnType("int");

                    b.Property<string>("Username")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.HasIndex("PersonaId");

                    b.ToTable("Usuarios");
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

            modelBuilder.Entity("AmigosyfamiliaresMigrante", b =>
                {
                    b.HasOne("Migrantes.App.Dominio.Amigosyfamiliares", null)
                        .WithMany()
                        .HasForeignKey("AmigosYFamiliaresId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Migrantes.App.Dominio.Migrante", null)
                        .WithMany()
                        .HasForeignKey("MigranteId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Migrantes.App.Dominio.Necesidades", b =>
                {
                    b.HasOne("Migrantes.App.Dominio.Migrante", null)
                        .WithMany("Necesidades")
                        .HasForeignKey("MigranteId");
                });

            modelBuilder.Entity("Migrantes.App.Dominio.Servicio", b =>
                {
                    b.HasOne("Migrantes.App.Dominio.Entidad", null)
                        .WithMany("Servicios")
                        .HasForeignKey("EntidadId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Migrantes.App.Dominio.Usuario", b =>
                {
                    b.HasOne("Migrantes.App.Dominio.Persona", "Persona")
                        .WithMany()
                        .HasForeignKey("PersonaId");

                    b.Navigation("Persona");
                });

            modelBuilder.Entity("Migrantes.App.Dominio.Entidad", b =>
                {
                    b.Navigation("Servicios");
                });

            modelBuilder.Entity("Migrantes.App.Dominio.Migrante", b =>
                {
                    b.Navigation("Necesidades");
                });
#pragma warning restore 612, 618
        }
    }
}
