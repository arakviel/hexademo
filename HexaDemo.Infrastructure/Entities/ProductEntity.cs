namespace HexaDemo.Infrastructure.Entities;

public class ProductEntity
{
    public Guid Id { get; set; }
    public string Name { get; set; }
    public decimal Price { get; set; }
    public string Photo { get; set; }
}