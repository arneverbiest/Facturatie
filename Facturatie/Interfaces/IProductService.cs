using Facturatie.Shared;

namespace Facturatie.Interfaces
{
    public interface IProductService : ICrud<Product>
    {
        List<Product> GetProductsByClientId(Guid clientId);
    }
}
