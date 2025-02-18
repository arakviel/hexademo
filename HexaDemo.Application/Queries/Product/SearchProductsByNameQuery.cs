using HexaDemo.Domain.Entities;
using MediatR;

namespace HexaDemo.Application.Queries;

public record SearchProductsByNameQuery(string Name) : IRequest<IEnumerable<Product>>;