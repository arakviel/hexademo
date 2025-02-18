namespace HexaDemo.Presentation;

public static class DependencyInjectionExtension
{
    public static IServiceCollection AddPresentation(this IServiceCollection services)
    {
        services.AddControllers();
        services.AddEndpointsApiExplorer();
        // TODO: fix
        //services.AddOpenApi();

        return services;
    }
}