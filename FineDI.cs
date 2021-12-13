using FineAPI.Repositories;
using FineAPI.Repositories.Abstract;
using FineAPI.Services;
using FineAPI.Services.Abstract;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FineAPI
{
    public static class FineDI
    {
        public static IServiceCollection AddAvtoRepositoriesDI(this IServiceCollection services)
        {
            return services
                .AddScoped<IFineRepository, FineRepository>()
                .AddScoped<ITypeFineRepository, TypeFineRepository>()
                .AddScoped<IEmailSendService, EmailSendService>();
        }
    }
}
