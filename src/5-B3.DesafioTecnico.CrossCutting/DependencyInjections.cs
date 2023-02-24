using B3.DesafioTecnico.Data.Repositories.Base.MySql;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

namespace B3.DesafioTecnico.CrossCutting
{
    public static class DependencyInjections
    {
        public static void AddDependencyInjection(this IServiceCollection services, IConfiguration configuration)
        {
            var connectionString = configuration["ConnectionString"];

            services.AddDbContext<MySqlDbContext>(options =>
                options.UseMySql(connectionString, ServerVersion.AutoDetect(connectionString), 
                    m => m.MigrationsHistoryTable("Migration_History")));
        }
    }
}
