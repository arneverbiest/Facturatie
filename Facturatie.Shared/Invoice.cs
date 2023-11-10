using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Facturatie.Shared
{
    public class Invoice
    {
        public Guid InvoiceId { get; set; }
        public string Name { get; set; }
        public double Price { get; set; }
        public Client Client { get; set; }
        public Guid ClientId { get; set; }
    }
}
