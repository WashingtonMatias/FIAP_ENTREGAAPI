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
            services.AddScoped<ICadastroApplicaionService, CadastroApplicationService>();

            //Domain
            services.AddScoped<ICadastroRepository, CadastroRepository>();
            services.AddScoped<ICadastroService, CadastroService>();

            //Data
            services.AddScoped<FiapContext>();

        }
    }
}
