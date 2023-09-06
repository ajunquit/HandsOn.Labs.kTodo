using FluentValidation;
using HandsOn.Labs.kTodo.Application.Features.UserFeatures.Queries;
using HandsOn.Labs.kTodo.Application.Interfaces.CQRS;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace HandsOn.Labs.kTodo.Application
{
    public static class ApplicationModule
    {
        public static IServiceCollection AddApplication(this IServiceCollection services)
        {
            var assembly = typeof(ApplicationModule).Assembly;

            services.AddAutoMapper(Assembly.GetExecutingAssembly());
            services.AddScoped<IUserQueryService, UserQueryService>();

            services.AddMediatR(configuration =>
                configuration.RegisterServicesFromAssembly(assembly));

            services.AddValidatorsFromAssembly(assembly);

            return services;
        }
    }
}
