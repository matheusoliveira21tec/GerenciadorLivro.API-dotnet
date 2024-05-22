using GerenciadorLivro.Core.Repositories;
using GerenciadorLivro.Infrastructure.Persistence.Repositories;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

namespace GerenciadorLivro.Infrastructure;

public static class InfrastructureModule
{
    public static IServiceCollection AddInfrastructure(this IServiceCollection services, IConfiguration configuration) {
        services
            .AddPersistence(configuration)
            .AddRepositories();

        return services;
    }

    private static IServiceCollection AddPersistence(this IServiceCollection services, IConfiguration configuration) {
        var connectionString = configuration.GetConnectionString("GerenciadorLivrosCs");

        services.AddDbContext<GerenciadorLivroDbContext>(options => options.UseSqlServer(connectionString));

        return services;
    }
    private static IServiceCollection AddRepositories(this IServiceCollection services) {
        services.AddScoped<ILoanRepository, LoanRepository>();
        services.AddScoped<IUserRepository, UserRepository>();
        services.AddScoped<IBookRepository, BookRepository>();

        return services;
    }
}