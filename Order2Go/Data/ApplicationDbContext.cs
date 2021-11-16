using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using Order2Go.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace Order2Go.Data
{
    public class ApplicationDbContext : IdentityDbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }
        public DbSet<Restaurante> Restaurante { get; set; }
        public DbSet<Producto> Producto { get; set; }
        public DbSet<Venta> Venta { get; set; }
    }
}
