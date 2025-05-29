using Exchange.Models;
using Microsoft.EntityFrameworkCore;

namespace Exchange.Data
{
    public class AppDbContext: DbContext
    {
       public AppDbContext(DbContextOptions<AppDbContext> options): base(options) 
       { 

       }
        public DbSet<Moneda> Monedas { get; set; }
        public DbSet<Transaccion> Transacciones { get; set;}
    }
}
