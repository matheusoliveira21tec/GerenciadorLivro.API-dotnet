using GerenciadorLivro.Application.Commands.CreateUser;
using Microsoft.Extensions.DependencyInjection;

namespace GerenciadorLivro.Application;

public static class ApplicationModule
{
    public static IServiceCollection AddApplication(this IServiceCollection services) {
        services
            .AddMediatR(config => config.RegisterServicesFromAssemblyContaining<CreateUserCommand>());

        return services;
    }
   
}