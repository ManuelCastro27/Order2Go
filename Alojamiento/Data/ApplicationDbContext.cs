using Alojamiento.Models;
using Microsoft.EntityFrameworkCore;

namespace Alojamiento
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
        {

        }

        public DbSet<Restaurante> Restaurante { get; set; }
        public DbSet<Producto> Producto { get; set; }
        public DbSet<Venta> Venta { get; set; }

    }
}
