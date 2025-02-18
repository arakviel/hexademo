using HexaDemo.Domain.Entities;
using MediatR;

namespace HexaDemo.Application.Queries;

public record GetAllProductsQuery() : IRequest<IEnumerable<Product>>;