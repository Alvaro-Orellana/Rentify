using System;
using System.Data.Entity;

namespace Rentify.Models
{
    public class MyDBContext : DbContext
    {
        public MyDBContext()
        {

        }
        public DbSet<Cliente> Clientes { get; set; } // My domain models
        public DbSet<Pelicula> Peliculas { get; set; }// My domain models
    }
}



