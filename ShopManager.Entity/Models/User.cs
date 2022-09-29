using System.ComponentModel.DataAnnotations;

namespace ShopManager.Entity.Models
{
    public class User
    {
        [Key]
        public string ID { get; set; } = string.Empty;
        public string USER_NAME { get; set; } = string.Empty;
        public DateTime CREATION_DATE { get; set; } = DateTime.Now;
    }
}
