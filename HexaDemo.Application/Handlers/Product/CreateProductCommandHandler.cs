using HexaDemo.Application.Commands;
using HexaDemo.Domain.Entities;
using HexaDemo.Domain.Interfaces;
using HexaDemo.Domain.ValueObjects;
using MediatR;

namespace HexaDemo.Application.Handlers;

public class CreateProductCommandHandler : IRequestHandler<CreateProductCommand>
{
    private readonly IProductRepository _repository;

    public CreateProductCommandHandler(IProductRepository repository)
    {
        _repository = repository;
    }

    public async Task Handle(CreateProductCommand request, CancellationToken cancellationToken)
    {
        Product product = new(
            Guid.NewGuid(),
            new ProductName(request.StoreProductDto.Name),
            new Money(request.StoreProductDto.Price),
            new PhotoUrl(request.StoreProductDto.Photo)
        );
        await _repository.AddAsync(product);
    }
}