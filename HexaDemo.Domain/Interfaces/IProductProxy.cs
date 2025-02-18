using HexaDemo.Domain.Entities;

namespace HexaDemo.Domain.Interfaces;

public interface IProductProxy
{
    Task<IEnumerable<Product>> GetAllAsync();
    Task<Product?> GetByIdAsync(Guid id);
    Task AddAsync(Product product);
    Task UpdateAsync(Product product);
    Task DeleteAsync(Guid id);
}