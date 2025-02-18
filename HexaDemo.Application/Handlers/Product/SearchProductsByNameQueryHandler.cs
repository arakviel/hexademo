using HexaDemo.Application.Queries;
using HexaDemo.Domain.Entities;
using HexaDemo.Domain.Interfaces;
using MediatR;

namespace HexaDemo.Application.Handlers;

public class SearchProductsByNameQueryHandler : IRequestHandler<SearchProductsByNameQuery, IEnumerable<Product>>
{
    private readonly IProductRepository _repository;

    public SearchProductsByNameQueryHandler(IProductRepository repository)
    {
        _repository = repository;
    }

    public async Task<IEnumerable<Product>> Handle(SearchProductsByNameQuery request, CancellationToken cancellationToken)
    {
        // return await _repository.SearchByNameAsync(request.Name);
        throw new NotImplementedException();
    }
}