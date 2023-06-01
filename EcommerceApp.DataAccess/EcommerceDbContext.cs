using EcommerceApp.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EcommerceApp.DataAccess
{

    public class EcommerceDbContext : DbContext
    {

        public EcommerceDbContext(DbContextOptions<EcommerceDbContext> options)
            : base(options)
        {

        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            //Categoria
            modelBuilder.Entity<Categoria>()
            .HasKey(p => p.Id);

            modelBuilder.Entity<Categoria>()
            .Property(p => p.NombreCategoria)
            .HasMaxLength(100);

            //Producto

            modelBuilder.Entity<Producto>()
           .HasKey(p => p.Id);

            modelBuilder.Entity<Producto>()
            .Property(p => p.Nombre)
            .HasMaxLength(100);

            modelBuilder.Entity<Producto>()
           .Property(p => p.CodigoSku)
           .HasMaxLength(20);

            modelBuilder.Entity<Producto>()
           .Property(p => p.PrecioUnitario)
           .HasPrecision(11, 2);

            //Data Seeding

            modelBuilder.Entity<Categoria>()
                .HasData(
                new Categoria { Id = 1, NombreCategoria = "Celulares" },
                new Categoria { Id = 2, NombreCategoria = "Computadoras" },
                new Categoria { Id = 3, NombreCategoria = "Televisores" }
                );


            modelBuilder.Entity<Producto>()
               .HasData(
               new Producto { Id = 1, CategoriaId = 1, Nombre = "Xiamoi a33", CodigoSku = "0001", PrecioUnitario = 340 },
               new Producto { Id = 2, CategoriaId = 2, Nombre = "Azus 6ta Generacion", CodigoSku = "0002", PrecioUnitario = 740.80m },
               new Producto { Id = 3, CategoriaId = 3, Nombre = "Sony Televisor", CodigoSku = "0003", PrecioUnitario = 1240 }
               );

        }
    }
}
