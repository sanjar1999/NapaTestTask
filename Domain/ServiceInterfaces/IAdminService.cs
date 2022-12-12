using Domain.DTOs;

namespace Domain.ServiceInterfaces
{
    public interface IAdminService
    {
        public Task<List<ProductDTO>> GetAllProducts();
        public Task<ProductDTO> GetProductById(int id);
        public Task UpdateProduct(ProductDTO product, int id);
        public Task DeleteProduct(int id);
        public Task CreateProduct(ProductDTO product);
    }
}
