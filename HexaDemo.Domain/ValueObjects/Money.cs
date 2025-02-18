namespace HexaDemo.Domain.ValueObjects;

public record Money
{
    public decimal Amount { get; }

    public Money(decimal amount)
    {
        if (amount < 0)
            throw new ArgumentException("Price cannot be negative.", nameof(amount));
        
        Amount = amount;
    }

    public override string ToString() => Amount.ToString("C");
}