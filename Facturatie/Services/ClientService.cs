using Facturatie.Shared;

namespace Facturatie.Services
{
    public class ClientService : ServiceBase<Client>
    {
        public ClientService(ApplicationDbContext context) : base(context)
        {

        }
    }
}
