using Application.Services.ImageService;
using Infrastructure.Adapters.ImageService;
using Microsoft.Extensions.DependencyInjection;

namespace Infrastructure;

public static class InfrastructureServiceRegistration
{
    public static IServiceCollection AddInfrastructureServices(this IServiceCollection services)
    {
        services.AddScoped<ImageServiceBase, CloudinaryImageServiceAdapter>();

        return services;
    }
}
//dev powershell=> cd src/projeadı(5 dosyanın old)=>narchgen=> narchgen generate crud=>entity seç=>cahing,logging, sec operation security
