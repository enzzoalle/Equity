using App.Domain.Interfaces;
using Microsoft.Extensions.DependencyInjection;

namespace App.Persistence;

public class DependencyInjectionConfig
{
    public static void Inject(IServiceCollection services)
    {
        services.AddTransient(typeof(IRepositoryBase<>), typeof(RepositoryBase<>));
    }
}