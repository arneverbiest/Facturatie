using Facturatie.Shared;

namespace Facturatie.Services
{
    public class ProductService : ServiceBase<Product>
    {
        public ProductService(ApplicationDbContext context) : base(context)
        {
        }
    }
}
