using B3.DeafioTecnico.API.Extensions;
using B3.DesafioTecnico.CrossCutting;

#region Builder

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddSwaggerSetup();

builder.Services.AddApiVersioningSetup();

builder.Services.AddDependencyInjection(builder.Configuration);

builder.Services.AddControllers();

#endregion

#region App

var app = builder.Build();

app.UseSwaggerUi();

app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.Run();

#endregion
