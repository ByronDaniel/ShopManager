using System.ComponentModel.DataAnnotations;

namespace ShopManager.Entity.Models
{
    public class Product
    {
        [Key]
        public int ID { get; set; }
        public string NAME { get; set; } = string.Empty;
        public string DESCRIPTION { get; set; } = string.Empty;
        public decimal PRICE { get; set; }
        public DateTime CREATION_DATE { get; set; } = DateTime.Now;
    }
}
