using AutoMapper;
using Database.Models;
using Domain.DTOs;

namespace Repository.Mappers
{
    public sealed class ProductMapper : Profile
    {
        public ProductMapper()
        {
            CreateMap<ProductDTO, Product>().ReverseMap();
        }
    }
}
