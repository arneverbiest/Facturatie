using Facturatie.Interfaces;
using Facturatie.Shared;

namespace Facturatie.Services
{
    public class ProductService : ServiceBase<Product> , IProductService
    {
        public ProductService(ApplicationDbContext context) : base(context)
        {
        }


        public List<Product> GetProductsByInvoiceId(Guid invoiceId)
        {
            // Assuming your Product entity has an InvoiceId property
            return Entities.Where(p => p.InvoiceID == invoiceId).ToList();
        }
    }
}
