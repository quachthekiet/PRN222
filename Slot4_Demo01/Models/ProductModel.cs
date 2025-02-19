using System.ComponentModel.DataAnnotations;

namespace Slot4_Demo01.Models
{
    public class ProductModel
    {
        public int ProductId { get; set; }
        [Required]
        public string Name { get; set; }
        [Required]
        public string Brand { get; set; }
        [Required, Range(0, 50)]
        public double Price { get; set; }
    }
}
