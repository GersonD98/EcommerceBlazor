﻿// <auto-generated />
using EcommerceApp.DataAccess;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace EcommerceApp.DataAccess.Migrations
{
    [DbContext(typeof(EcommerceDbContext))]
    partial class EcommerceDbContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "7.0.5")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("EcommerceApp.Entities.Categoria", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<bool>("Estado")
                        .HasColumnType("bit");

                    b.Property<string>("NombreCategoria")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)");

                    b.HasKey("Id");

                    b.ToTable("Categoria");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Estado = true,
                            NombreCategoria = "Celulares"
                        },
                        new
                        {
                            Id = 2,
                            Estado = true,
                            NombreCategoria = "Computadoras"
                        },
                        new
                        {
                            Id = 3,
                            Estado = true,
                            NombreCategoria = "Televisores"
                        });
                });

            modelBuilder.Entity("EcommerceApp.Entities.Producto", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<int>("CategoriaId")
                        .HasColumnType("int");

                    b.Property<bool>("Estado")
                        .HasColumnType("bit");

                    b.Property<string>("Nombre")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)");

                    b.Property<decimal>("PrecioUnitario")
                        .HasPrecision(11, 2)
                        .HasColumnType("decimal(11,2)");

                    b.Property<string>("codigoSku")
                        .IsRequired()
                        .HasMaxLength(20)
                        .HasColumnType("nvarchar(20)");

                    b.HasKey("Id");

                    b.HasIndex("CategoriaId");

                    b.ToTable("Producto");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            CategoriaId = 1,
                            Estado = true,
                            Nombre = "Xiamoi a33",
                            PrecioUnitario = 340m,
                            codigoSku = "0001"
                        },
                        new
                        {
                            Id = 2,
                            CategoriaId = 2,
                            Estado = true,
                            Nombre = "Azus 6ta Generacion",
                            PrecioUnitario = 740.80m,
                            codigoSku = "0002"
                        },
                        new
                        {
                            Id = 3,
                            CategoriaId = 3,
                            Estado = true,
                            Nombre = "Sony Televisor",
                            PrecioUnitario = 1240m,
                            codigoSku = "0003"
                        });
                });

            modelBuilder.Entity("EcommerceApp.Entities.Producto", b =>
                {
                    b.HasOne("EcommerceApp.Entities.Categoria", "Categoria")
                        .WithMany()
                        .HasForeignKey("CategoriaId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Categoria");
                });
#pragma warning restore 612, 618
        }
    }
}