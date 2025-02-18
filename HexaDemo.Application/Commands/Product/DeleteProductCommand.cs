using MediatR;

namespace HexaDemo.Application.Commands;

public record DeleteProductCommand(Guid Id) : IRequest;