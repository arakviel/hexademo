using AutoMapper;
using HexaDemo.Domain.Entities;
using HexaDemo.Domain.Interfaces;
using HexaDemo.Infrastructure.Entities;
using Microsoft.EntityFrameworkCore;

namespace HexaDemo.Infrastructure.Repositories;

public class InMemoryProductRepository : IProductRepository
{
    private readonly ApplicationContext _context;
    private readonly IMapper _mapper;

    public InMemoryProductRepository(ApplicationContext context, IMapper mapper)
    {
        _context = context;
        _mapper = mapper;
    }

    public async Task<IEnumerable<Product>> GetAllAsync()
    {
        var entities = await _context.Products.ToListAsync();
        return _mapper.Map<IEnumerable<Product>>(entities);
    }

    public async Task<Product?> GetByIdAsync(Guid id)
    {
        var entity = await _context.Products.FindAsync(id);
        return entity == null ? null : _mapper.Map<Product>(entity);
    }

    public async Task AddAsync(Product product)
    {
        var entity = _mapper.Map<ProductEntity>(product);
        await _context.Products.AddAsync(entity);
        await _context.SaveChangesAsync();
    }

    public async Task UpdateAsync(Product product)
    {
        var entity = _mapper.Map<ProductEntity>(product);
        _context.Products.Update(entity);
        await _context.SaveChangesAsync();
    }

    public async Task DeleteAsync(Guid id)
    {
        var entity = await _context.Products.FindAsync(id);
        if (entity != null)
        {
            _context.Products.Remove(entity);
            await _context.SaveChangesAsync();
        }
    }
}