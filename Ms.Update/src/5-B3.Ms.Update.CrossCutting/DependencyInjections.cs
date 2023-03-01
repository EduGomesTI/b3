using B3.Ms.Update.Application.ToDos.Interfaces;
using B3.Ms.Update.Application.ToDos.Services;
using B3.Ms.Update.Data.Repositories.Base.MySql;
using B3.Ms.Update.Data.Repositories.ToDos;
using B3.Ms.Update.Domain.Aggregates.ToDos.Interfaces;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

namespace B3.Ms.Update.CrossCutting
{
    public static class DependencyInjections
    {
        public static void AddDependencyInjection(this IServiceCollection services, IConfiguration configuration)
        {
            var connectionString = configuration["ConnectionString"];

            services.AddDbContext<MySqlDbContext>(options =>
                options.UseMySql(connectionString, ServerVersion.AutoDetect(connectionString), 
                    m => m.MigrationsHistoryTable("Migration_History")));

            services.AddTransient<IToDoService, ToDoService>();
            services.AddTransient<IToDoRepository, ToDoRepository>();            
        }
    }
}
