using AvtoAPI.Repositories;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AvtoAPI
{
    public static class AvtoDI
    {
        public static IServiceCollection AddAvtoRepositoriesDI(this IServiceCollection services)
        {
            return services
                .AddScoped<IAvtoRepository, AvtoRepository>()
                .AddScoped<IBodyTypeRepository, BodyTypeRepository>()
                .AddScoped<ICarOwnerRepository, CarOwnerRepository>()
                .AddScoped<IPersonRepository, PersonRepository>()
                .AddScoped<IRudderRepository, RudderRepository>();
        }
    }
}
