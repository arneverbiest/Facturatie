using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Facturatie.Shared
{
    public class Client
    {
        public Guid ClientId { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Btw { get; set; } //restricties opleggen
        public string Addres { get; set; }
        public List <Invoice> Invoices { get; set; }
    }
}
