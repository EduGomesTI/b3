using B3.Ms.Update.API.Workers;
using B3.Ms.Update.CrossCutting;

#region Builder

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddDependencyInjection(builder.Configuration);

builder.Services.AddHostedService<ToDoUpdateDescriptionWorker>();

builder.Services.AddControllers();

#endregion

#region App

var app = builder.Build();

app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.Run();

#endregion
