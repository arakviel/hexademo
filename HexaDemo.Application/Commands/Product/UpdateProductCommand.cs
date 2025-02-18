using HexaDemo.Application.Dtos;
using MediatR;

namespace HexaDemo.Application.Commands;

public record UpdateProductCommand(UpdateProductDto UpdateProductDto) : IRequest;