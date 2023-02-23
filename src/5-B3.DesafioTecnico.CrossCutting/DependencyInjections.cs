using B3.DesafioTecnico.Data.Repositories.Base.MySql;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;

namespace B3.DesafioTecnico.CrossCutting
{
    public static class DependencyInjections
    {
        public static void AddDependencyInjection(this IServiceCollection services)
        {
            services.AddDbContext<MySqlDbContext>(options =>
                options.UseMySql("", ServerVersion.AutoDetect(""), 
                    m => m.MigrationsHistoryTable("Migration_History")));
        }
    }
}
