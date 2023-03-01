using B3.Ms.Onboarding.Application.ToDos.Interfaces;
using B3.Ms.Onboarding.Application.ToDos.Services;
using B3.Ms.Onboarding.Data.Messaging;
using B3.Ms.Onboarding.Data.Repositories.Base.MySql;
using B3.Ms.Onboarding.Data.Repositories.ToDos;
using B3.Ms.Onboarding.Domain.Aggregates.ToDos.Interfaces;
using B3.Ms.Onboarding.Domain.Base.Messaging;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

namespace B3.Ms.Onboarding.CrossCutting
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

            services.AddScoped<IMessageBusService, RabbitMqService>();
        }
    }
}
