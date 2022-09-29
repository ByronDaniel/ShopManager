using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ShopManager.Entity.Models
{
    public class OrderProduct
    {
        [Key]
        public int ID { get; set; }
        [ForeignKey("ORDER")]
        public int ORDER_ID { get; set; }
        [ForeignKey("PRODUCT")]
        public int PRODUCT_ID { get; set; }
        public Order? ORDER { get; set; }
        public Product? PRODUCT { get; set; }

    }
}
