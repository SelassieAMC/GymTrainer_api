using GymTrainingControl.Application;
using GymTrainingControl.Infrastructure;
using GymTrainingControl.Infrastructure.Persistence;
using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);

var allowedOrigins = builder.Configuration.GetValue<string>("AllowedOrigins");
var corsPolicyName = "OriginsAllowed";

// Add services to the container.
builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

var connectionString = builder.Configuration.GetConnectionString("Default");
builder.Services.AddInfrastructure(connectionString);
builder.Services.AddApplicationServices();

builder.Services.AddCors(opts =>
{
    opts.AddPolicy(name: corsPolicyName, policy =>
    {
        policy.WithOrigins(allowedOrigins.Split(";"))
            .AllowAnyHeader()
            .AllowAnyMethod(); 
    });
});

var app = builder.Build();

app.UseSwagger();
app.UseSwaggerUI();
//app.UseHttpsRedirection();
app.UseCors(corsPolicyName);

using (var serviceScope = app.Services?.GetService<IServiceScopeFactory>()?.CreateScope())
{
    var context = serviceScope?.ServiceProvider.GetRequiredService<ApplicationDbContext>();
    context?.Database.Migrate();
}

app.MapControllers();

app.Run();

