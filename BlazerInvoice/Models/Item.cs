using System.ComponentModel.DataAnnotations;

namespace BlazerInvoice.Models
{
    public class Item
    {
        public int Id { get; set; }
        [MaxLength(50)]
        public required string Name { get; set; }
        [Range(1, 1000)]
        public required int PurchasePrice { get; set; }
        [Range(1, 10000)]
        public required int SalePrice { get; set; }
        public int QuantityInStock { get; set; }
    }
}
