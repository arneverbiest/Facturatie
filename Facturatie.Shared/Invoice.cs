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
        public Guid InvoiceId { get; set; }
        public string? Name { get; set; }
        public string InvoiceNumber { get; set; }
        public List<Product>? Product { get; set; }
        public DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; }
        public double? PriceWithoutVAT { get; set; }
        public double? VAT { get; set; }
        public double? PriceWithVAT { get; set; }
        public Client Client { get; set; }
        public Guid ClientId { get; set; }
    }
}
