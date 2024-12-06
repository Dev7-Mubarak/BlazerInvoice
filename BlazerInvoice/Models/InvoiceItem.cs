namespace BlazerInvoice.Models
{
    public class InvoiceItem
    {
        public int Id { get; set; }
        public int InvoiceId { get; set; }
        public required Invoice Invoice { get; set; }
        public int ItemId { get; set; }
        public required Item Item { get; set; }
        public int Quantity { get; set; }
        public int SalePrice { get; set; }
        public int CostPrice { get; set; }
        public int Total
        {
            get
            {
                return Quantity * SalePrice;
            }
        }
    }
}
