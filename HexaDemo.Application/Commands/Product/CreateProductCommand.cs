using HexaDemo.Application.Dtos;
using HexaDemo.Domain.Entities;
using MediatR;

namespace HexaDemo.Application.Commands;

public record CreateProductCommand(StoreProductDto StoreProductDto) : IRequest;