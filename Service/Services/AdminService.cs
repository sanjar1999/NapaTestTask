using Domain.DTOs;
using Domain.RepositoryInterfaces;
using Domain.ServiceInterfaces;

namespace Service.Services
{
    public sealed class AdminService : IAdminService
    {
        private readonly IAdminRepository _adminRepository;
        public AdminService(IAdminRepository adminRepository)
        {
            _adminRepository = adminRepository;
        }


        public async Task CreateProduct(ProductDTO product)
        {
            try
            {
                if (product != null)
                {
                    await _adminRepository.CreateProduct(product);
                }
            }
            catch (Exception)
            {
                throw;
            }
        }

        public async Task DeleteProduct(int id)
        {
            try
            {
                if (id != 0)
                {
                    await _adminRepository.DeleteProduct(id);
                }
            }
            catch (Exception)
            {
                throw;
            }
        }

        public async Task<List<ProductDTO>> GetAllProducts()
        {
            try
            {
                return await _adminRepository.GetAllProducts();
            }
            catch (Exception)
            {
                throw;
            }
        }

        public async Task<ProductDTO> GetProductById(int id)
        {
            try
            {
                return await _adminRepository.GetProductById(id);
            }
            catch (Exception)
            {
                throw;
            }
        }

        public async Task UpdateProduct(ProductDTO product, int id)
        {
            try
            {
                if (id != 0 || product != null)
                {
                  await _adminRepository.UpdateProduct(product, id);
                }
            }
            catch (Exception)
            {
                throw;
            }
        }
    }
}
