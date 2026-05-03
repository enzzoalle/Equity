using App.Application.Services;
using App.Domain.Interfaces.Services;
using Microsoft.Extensions.DependencyInjection;

namespace App.Application;

public static class DependencyInjectionConfig
{
    public static void Inject(IServiceCollection services)
    {
        services.AddTransient<IUsuarioService, UsuarioService>();
    }
}