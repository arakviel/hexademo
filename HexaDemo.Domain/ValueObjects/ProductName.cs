namespace HexaDemo.Domain.ValueObjects;

public record ProductName
{
    public string Value { get; }

    public ProductName(string value)
    {
        if (string.IsNullOrWhiteSpace(value))
            throw new ArgumentException("Product name cannot be empty.", nameof(value));
        
        Value = value;
    }

    public override string ToString() => Value;
}