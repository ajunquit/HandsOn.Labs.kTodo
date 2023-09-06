using HandsOn.Labs.kTodo.Application.Interfaces.Repositories;
using HandsOn.Labs.kTodo.Persistence.Interceptors;
using HandsOn.Labs.kTodo.Persistence.Persistence;
using HandsOn.Labs.kTodo.Persistence.Persistence.Repositories;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HandsOn.Labs.kTodo.Persistence
{
    public static class PersistenceModule
    {
        public static IServiceCollection AddPersistence(this IServiceCollection services, IConfiguration configuration)
        {
            services.AddScoped<AuditableEntitySaveChangesInterceptor>();
            services.AddDbContext<KTodoDbContext>(options =>
                options.UseSqlServer(
                configuration.GetConnectionString("ProdConnection"))
                //builder => builder.MigrationsAssembly(typeof(KTodoDbContext).Assembly.FullName)
                //options.UseSqlServer("name=ConnectionStrings:DefaultConnection")
                );
            
            services.AddScoped<IUserRepository, UserRepository> ();
            services.AddScoped<IUnitOfWork, UnitOfWork> ();
            return services;
        }
    }
}
