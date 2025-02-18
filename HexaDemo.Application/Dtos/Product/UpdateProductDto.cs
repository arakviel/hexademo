using System.ComponentModel.DataAnnotations;

namespace HexaDemo.Application.Dtos;

public record UpdateProductDto
{
    [Required] 
    public Guid Id { get; init; }

    [Required] 
    [MaxLength(100)] 
    public string Name { get; init; }

    [Range(0.01, double.MaxValue)] 
    public decimal Price { get; init; }

    [Required] 
    [Url] 
    public string Photo { get; init; }
}