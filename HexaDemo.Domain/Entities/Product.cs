using HexaDemo.Domain.ValueObjects;

namespace HexaDemo.Domain.Entities;

public class Product
{
    public Guid Id { get; private set; }
    public ProductName Name { get; private set; }
    public Money Price { get; private set; }
    public PhotoUrl Photo { get; private set; }

    public Product(Guid id, ProductName name, Money price, PhotoUrl photo)
    {
        if (id == Guid.Empty)
            throw new ArgumentException("Id cannot be empty.", nameof(id));
        
        Id = id;
        Name = name ?? throw new ArgumentNullException(nameof(name));
        Price = price ?? throw new ArgumentNullException(nameof(price));
        Photo = photo ?? throw new ArgumentNullException(nameof(photo));
    }
}