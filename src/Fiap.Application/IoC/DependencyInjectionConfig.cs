using Fiap.Application.Interfaces;
using Fiap.Application.Services;
using Fiap.Data.Context;
using Fiap.Data.Repositories;
using Fiap.Domain.Interfaces;
using Fiap.Domain.Services;
using Microsoft.Extensions.DependencyInjection;

namespace Fiap.Application.IoC
{
    public static class DependencyInjectionConfig
    {
        public static void AddResolveDependencies(this IServiceCollection services)
        {
            //Application
            services.AddScoped<IUsuarioApplicaionService, UsuarioApplicationService>();

            //Domain
            services.AddScoped<IUsuarioRepository, UsuarioRepository>();
            services.AddScoped<IUsuarioService, UsuarioService>();

            //Data
            services.AddScoped<FiapContext>();

        }
    }
}
