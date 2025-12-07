using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

namespace DocumentService.Infrastructure;

public static class DependencyInjection
{
    public static IServiceCollection AddInfrastructure(this IServiceCollection services, IConfiguration configuration)
    {
        services.AddDbContextPool<DocumentDbContext>((sp, options) =>
        {
            var connectionString = configuration.GetConnectionString("Database");
            options.UseNpgsql(connectionString);
        });
        
        return services;
    }
}