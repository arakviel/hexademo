using HexaDemo.Application.Queries;
using HexaDemo.Domain.Entities;
using HexaDemo.Domain.Interfaces;
using MediatR;

namespace HexaDemo.Application.Handlers;

public class GetAllProductsQueryHandler : IRequestHandler<GetAllProductsQuery, IEnumerable<Product>>
{
    private readonly IProductRepository _repository;

    public GetAllProductsQueryHandler(IProductRepository repository)
    {
        _repository = repository;
    }

    public async Task<IEnumerable<Product>> Handle(GetAllProductsQuery request, CancellationToken cancellationToken)
    {
        return await _repository.GetAllAsync();
    }
}