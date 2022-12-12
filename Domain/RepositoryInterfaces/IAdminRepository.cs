
using Domain.DTOs;

namespace Domain.RepositoryInterfaces
{
    public interface IAdminRepository
    {
        public Task<List<ProductDTO>> GetAllProducts();
        public Task<ProductDTO> GetProductById(int id);
        public Task CreateProduct(ProductDTO product);
        public Task UpdateProduct(ProductDTO product, int id);
        public Task DeleteProduct(int id);
    }
}
