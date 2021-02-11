using System;
using Microsoft.EntityFrameworkCore;
using Rentify.Models;

namespace Rentify.Data
{
    public class MyDBContext : DbContext
    {
        public MyDBContext(DbContextOptions<MyDBContext> options)
                   : base(options)
        {
        }


        public DbSet<Cliente> Clientes { get; set; } 
        public DbSet<Pelicula> Peliculas { get; set; }
    }
}



