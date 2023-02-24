using Microsoft.AspNetCore.Mvc;

namespace B3.DeafioTecnico.API.Extensions; 
public static class ApiVersioningExtension 
{
    public static void AddApiVersioningSetup(this IServiceCollection services) 
    {
        services.AddApiVersioning(
                options => 
                {
                    options.ReportApiVersions = true;
                    options.AssumeDefaultVersionWhenUnspecified = true;
                    options.DefaultApiVersion = new ApiVersion(1, 0);
                })
            .AddVersionedApiExplorer(options => 
            {
                options.GroupNameFormat = "'v'VVV";
                options.SubstituteApiVersionInUrl = true;
            });
    }
}
