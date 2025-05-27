using Exchange.Models;
using Microsoft.EntityFrameworkCore;

namespace Exchange.Data
{
    public class AppContext: DbContext
    {
       public AppContext(DbContextOptions<AppContext> options): base(options) 
       { 

       }
        public DbSet<Moneda> Monedas { get; set; }
        public DbSet<Transaccion> Transacciones { get; set;}
    }
}
