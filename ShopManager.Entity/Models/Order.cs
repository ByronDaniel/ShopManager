using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ShopManager.Entity.Models
{
    public class Order
    {
        [Key]
        public int ID { get; set; }
        [ForeignKey("USER")]
        public string USER_ID { get; set; }
        public User? USER { get; set; }
        public DateTime CREATION_DATE { get; set; } = DateTime.Now;
    }
}
