using Facturatie.Shared;
using Microsoft.EntityFrameworkCore;

namespace Facturatie
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options) 
        {
        
        }

        public virtual DbSet<Invoice> Invoice { get; set; }
        public virtual DbSet<Client> Client { get; set; }
        public virtual DbSet<Product> Product { get; set; }

    }
}
