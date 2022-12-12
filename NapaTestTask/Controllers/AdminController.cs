using Domain.DTOs;
using Domain.ServiceInterfaces;
using Microsoft.AspNetCore.Mvc;

namespace NapaTestTask.Controllers
{
    public sealed class AdminController : BaseApiController
    {
        private readonly IAdminService _adminService;
        public AdminController(IAdminService adminService)
        {
            _adminService = adminService;
        }

        [HttpGet("products")]
        public async Task<IActionResult> GetAllProducts()
        {
             return Ok(await _adminService.GetAllProducts());
        }

        [HttpGet("{id}")]
        public async Task<IActionResult> GetProductById(int id)
        {
            return Ok(await _adminService.GetProductById(id));
        }

        [HttpPost("add")]
        public async Task<IActionResult> CreateProduct(ProductDTO productDTO)
        {
            await _adminService.CreateProduct(productDTO);

            return Ok();
        }

        [HttpDelete("delete")]
        public async Task<IActionResult> DeleteProduct(int id)
        {
            await _adminService.DeleteProduct(id);
            return Ok();
        }

        [HttpPut("update")]
        public async Task<IActionResult> UpdateProduct(ProductDTO productDTO, int id)
        {
            await _adminService.UpdateProduct(productDTO, id);
            return Ok();
        }
    }
}
