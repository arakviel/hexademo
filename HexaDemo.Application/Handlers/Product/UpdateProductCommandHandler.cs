using HexaDemo.Application.Commands;
using HexaDemo.Domain.Entities;
using HexaDemo.Domain.Interfaces;
using HexaDemo.Domain.ValueObjects;
using MediatR;

namespace HexaDemo.Application.Handlers;

public class UpdateProductCommandHandler : IRequestHandler<UpdateProductCommand>
{
    private readonly IProductRepository _repository;

    public UpdateProductCommandHandler(IProductRepository repository)
    {
        _repository = repository;
    }

    public async Task Handle(UpdateProductCommand request, CancellationToken cancellationToken)
    {
        var product = await _repository.GetByIdAsync(request.UpdateProductDto.Id);
        if (product != null)
        {
            product = new Product(request.UpdateProductDto.Id,
                new ProductName(request.UpdateProductDto.Name),
                new Money(request.UpdateProductDto.Price),
                new PhotoUrl(request.UpdateProductDto.Photo));
                
            await _repository.UpdateAsync(product);
        }
        // TODO: якщо не знайшов, то викидуйте ексепшн
    }
}