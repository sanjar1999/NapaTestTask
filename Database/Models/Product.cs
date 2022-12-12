using System.ComponentModel.DataAnnotations;

namespace Database.Models
{
    public sealed class Product
    {
        [Key]
        public int Id { get; set; }
        [Required]
        public string ProductName { get; set; }
        [Required]
        public int Quantity { get; set; }
        [Required]
        public decimal Price { get; set; }
    }
}
