namespace Facturatie.Shared
{
    public class Product
    {
        public Guid ProductId { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public double Price { get; set; }
        public Invoice? Invoice { get; set; }
        public Guid InvoiceID { get; set; }
    }
}