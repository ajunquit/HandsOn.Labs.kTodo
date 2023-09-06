using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HandsOn.Labs.kTodo.API.Core.Modules.CorsExtensions
{
    public static class CorsExtensions
    {
        public static IServiceCollection AddFeatureCors(this IServiceCollection services, IConfiguration configuration)
        {
            string myPolicy = "policyApiKTodo";

            services.AddCors(options => options.AddPolicy(myPolicy, builder => builder.WithOrigins(configuration["Config:OriginCors"])
                                                                                        .AllowAnyHeader()
                                                                                        .AllowAnyMethod()
                                                                                        .AllowAnyOrigin()));
            //services.AddMvc();
            //services.AddControllers().AddJsonOptions(opts =>
            //{
            //    var enumConverter = new JsonStringEnumConverter();
            //    opts.JsonSerializerOptions.Converters.Add(enumConverter);
            //});

            return services;
        }
    }
}
