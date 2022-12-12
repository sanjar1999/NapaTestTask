using AutoMapper;
using Database.Contexts;
using Database.Models;
using Domain.DTOs;
using Domain.RepositoryInterfaces;
using Microsoft.EntityFrameworkCore;

namespace Repository.Repositories
{
    public sealed class AdminRepository : IAdminRepository
    {
        private readonly ApplicationContext _applicationContext;
        private readonly IMapper _mapper;
        public AdminRepository(ApplicationContext applicationContext, IMapper mapper)
        {
            _applicationContext= applicationContext;
            _mapper= mapper;
        }
        public async Task CreateProduct(ProductDTO product)
        {
            await _applicationContext.Products.AddAsync(_mapper.Map<Product>(product));
            await _applicationContext.SaveChangesAsync();
        }

        public async Task DeleteProduct(int id)
        {
          var productToDelete = await _applicationContext.Products.FirstOrDefaultAsync(x => x.Id == id);
            if (productToDelete != null)
            {
                _applicationContext.Products.Remove(productToDelete);
                await  _applicationContext.SaveChangesAsync();
            }
        }

        public async Task<List<ProductDTO>> GetAllProducts()
        {
            var products = await _applicationContext.Products.ToListAsync();
            var result = new List<ProductDTO>();    
            foreach (var product in products)
            {
                result.Add(_mapper.Map<ProductDTO>(product));
            }

            return result;
        }

        public async Task<ProductDTO> GetProductById(int id)
        {
            var product = await _applicationContext.Products.FirstOrDefaultAsync(x =>x.Id == id);

            if (product is null)
            {
                throw new ArgumentNullException("Could not found");
            }

            return _mapper.Map<ProductDTO>(product);
        }

        public async Task UpdateProduct(ProductDTO product, int id)
        {
            var foundProduct = await _applicationContext.Products.FirstOrDefaultAsync(x => x.Id == id);

            if (product is null)
            {
                throw new ArgumentNullException("Could not found");
            }

            foundProduct.ProductName = product.ProductName;
            foundProduct.Price = product.Price;
            foundProduct.Quantity = product.Quantity;

            _applicationContext.Products.Update(foundProduct);
            await _applicationContext.SaveChangesAsync();
        }
    }
}
