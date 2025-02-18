using HexaDemo.Domain.ValueObjects;

namespace HexaDemo.Infrastructure.Mappings;

using AutoMapper;
using HexaDemo.Domain.Entities;
using HexaDemo.Infrastructure.Entities;

public class ProductProfile : Profile
{
    public ProductProfile()
    {
        CreateMap<Product, ProductEntity>()
            .ForMember(dest => dest.Name, opt => opt.MapFrom(src => src.Name.Value))
            .ForMember(dest => dest.Price, opt => opt.MapFrom(src => src.Price.Amount))
            .ForMember(dest => dest.Photo, opt => opt.MapFrom(src => src.Photo.Value))
            .ReverseMap()
            .ConstructUsing(src => new Product(src.Id, new ProductName(src.Name), new Money(src.Price), new PhotoUrl(src.Photo)));
    }
}