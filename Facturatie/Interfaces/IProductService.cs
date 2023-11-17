using Facturatie.Shared;

namespace Facturatie.Interfaces
{
    public interface IProductService : ICrud<Product>
    {
        List<Product> GetProductsByInvoiceId(Guid invoiceId);
    }
}
