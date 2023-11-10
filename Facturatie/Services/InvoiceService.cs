using Facturatie.Shared;

namespace Facturatie.Services
{
    public class InvoiceService : ServiceBase<Invoice>
    {
        public InvoiceService(ApplicationDbContext context) : base(context)
        {
        }
    }
}
