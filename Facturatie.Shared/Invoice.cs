using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;

namespace Facturatie.Shared
{
    public class Invoice
    {
        public Guid InvoiceId { get; set; } = Guid.NewGuid();
        public string? Name { get; set; }
        public string InvoiceNumber { get; set; }
        public List<Product>? Product { get; set; }
        public DateTime StartDate { get; set; } = DateTime.Now;
        public DateTime EndDate { get; set; } = DateTime.Now.AddMonths(1);
        public double? PriceWithoutVAT { get; set; }
        public double? VAT { get; set; }
        public double? PriceWithVAT { get; set; }
        public Client Client { get; set; }
        public Guid ClientId { get; set; }
    }
}
