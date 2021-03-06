// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;
using simulacro.Data;

namespace simulacro.Migrations
{
    [DbContext(typeof(ApplicationDbContext))]
    [Migration("20211012234833_Fecha")]
    partial class Fecha
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("Relational:MaxIdentifierLength", 63)
                .HasAnnotation("ProductVersion", "5.0.11")
                .HasAnnotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn);

            modelBuilder.Entity("simulacro.Models.Categoria", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer")
                        .HasAnnotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn);

                    b.Property<string>("nombre")
                        .HasColumnType("text");

                    b.HasKey("Id");

                    b.ToTable("t_categoria");
                });

            modelBuilder.Entity("simulacro.Models.SolicitudCompra", b =>
                {
                    b.Property<int>("id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer")
                        .HasAnnotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn);

                    b.Property<int?>("categoriaId")
                        .HasColumnType("integer");

                    b.Property<string>("celular")
                        .HasColumnType("text");

                    b.Property<string>("comprador")
                        .HasColumnType("text");

                    b.Property<string>("descripcion")
                        .HasColumnType("text");

                    b.Property<DateTime>("fecha")
                        .HasColumnType("timestamp without time zone");

                    b.Property<string>("foto")
                        .HasColumnType("text");

                    b.Property<string>("lugar")
                        .HasColumnType("text");

                    b.Property<string>("nombre")
                        .HasColumnType("text");

                    b.Property<decimal>("precio")
                        .HasColumnType("numeric");

                    b.HasKey("id");

                    b.HasIndex("categoriaId");

                    b.ToTable("t_solicitud");
                });

            modelBuilder.Entity("simulacro.Models.SolicitudCompra", b =>
                {
                    b.HasOne("simulacro.Models.Categoria", "categoria")
                        .WithMany("solicitud")
                        .HasForeignKey("categoriaId");

                    b.Navigation("categoria");
                });

            modelBuilder.Entity("simulacro.Models.Categoria", b =>
                {
                    b.Navigation("solicitud");
                });
#pragma warning restore 612, 618
        }
    }
}
