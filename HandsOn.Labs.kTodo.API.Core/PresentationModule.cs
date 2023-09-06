using HandsOn.Labs.kTodo.API.Core.Modules.Authentication;
using HandsOn.Labs.kTodo.API.Core.Modules.CorsExtensions;
using HandsOn.Labs.kTodo.Application.Features.UserFeatures.Queries;
using HandsOn.Labs.kTodo.Application.Interfaces.CQRS;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HandsOn.Labs.kTodo.API.Core
{
    public static class PresentationModule
    {
        public static IServiceCollection AddPresentation(this IServiceCollection services, IConfiguration configuration)
        {
            services.AddFeatureCors(configuration);
            services.AddAuthentication(configuration);

            return services;
        }
    }
}
