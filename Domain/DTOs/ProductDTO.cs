namespace Domain.DTOs
{
    public sealed class ProductDTO
    {
        public int Id { get; set; }
        public string ProductName { get; set; }
        public int Quantity { get; set; }
        public decimal Price { get; set; }
    }
}
