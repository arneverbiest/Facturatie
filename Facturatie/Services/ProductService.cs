using Facturatie.Interfaces;
using Facturatie.Shared;

namespace Facturatie.Services
{
    public class ProductService : ServiceBase<Product> , IProductService
    {
        public ProductService(ApplicationDbContext context) : base(context)
        {
        }


        public List<Product> GetProductsByClientId(Guid clientId)
        {
            // Assuming your Product entity has an InvoiceId property
            return Entities.Where(p => p.ClientId == clientId).ToList();
        }
    }
}
