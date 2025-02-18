using HexaDemo.Domain.Interfaces;
using HexaDemo.Infrastructure.Mappings;
using HexaDemo.Infrastructure.Repositories;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;

namespace HexaDemo.Infrastructure;

public static class DependencyInjectionExtension
{
    public static IServiceCollection AddInfrastructure(this IServiceCollection services)
    {
        services.AddDbContext<ApplicationContext>(options => options.UseInMemoryDatabase("HexaDemoDb"));
        services.AddScoped<IProductRepository, InMemoryProductRepository>();
        services.AddAutoMapper(typeof(ProductProfile));

        return services;
    }
}