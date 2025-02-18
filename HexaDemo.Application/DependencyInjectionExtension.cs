using HexaDemo.Application.Commands;
using HexaDemo.Application.Handlers;
using HexaDemo.Application.Queries;
using HexaDemo.Domain.Entities;
using MediatR;
using Microsoft.Extensions.DependencyInjection;

namespace HexaDemo.Application;

public static class DependencyInjectionExtension
{
    public static IServiceCollection AddApplicationServices(this IServiceCollection services)
    {
        services.AddMediatR(typeof(CreateProductCommand).Assembly);

        services.AddScoped<IRequestHandler<CreateProductCommand>, CreateProductCommandHandler>();
        services.AddScoped<IRequestHandler<UpdateProductCommand>, UpdateProductCommandHandler>();
        services.AddScoped<IRequestHandler<DeleteProductCommand>, DeleteProductCommandHandler>();
        services.AddScoped<IRequestHandler<GetAllProductsQuery, IEnumerable<Product>>, GetAllProductsQueryHandler>();
        services.AddScoped<IRequestHandler<SearchProductsByNameQuery, IEnumerable<Product>>, SearchProductsByNameQueryHandler>();

        return services;
    }
}