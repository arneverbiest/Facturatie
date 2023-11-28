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

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Product>()
                .HasOne(p => p.Client)
                .WithMany(c => c.Products)
                .HasForeignKey(p => p.ClientId);


            // If you want to configure any other relationships or constraints, you can do it here.

            base.OnModelCreating(modelBuilder);
        }
    }
}
