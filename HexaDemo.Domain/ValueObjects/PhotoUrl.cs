namespace HexaDemo.Domain.ValueObjects;

public record PhotoUrl
{
    public string Value { get; }

    public PhotoUrl(string value)
    {
        if (string.IsNullOrWhiteSpace(value))
            throw new ArgumentException("Photo URL cannot be empty.", nameof(value));
        if (!Uri.TryCreate(value, UriKind.Absolute, out _))
            throw new ArgumentException("Invalid URL format.", nameof(value));
        
        Value = value;
    }

    public override string ToString() => Value;
}