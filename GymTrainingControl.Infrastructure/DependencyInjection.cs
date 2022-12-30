using GymTrainingControl.Domain.Interfaces;
using GymTrainingControl.Infrastructure.Persistence;
using GymTrainingControl.Infrastructure.Repositories;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;

namespace GymTrainingControl.Infrastructure;

public static class DependencyInjection
{
    public static void AddInfrastructure(this IServiceCollection services, string connectionString)
    {
        services.AddScoped<IExerciseRepository, ExerciseRepository>();
        services.AddScoped<ICategoryRepository, CategoryRepository>();
        services.AddScoped<IMuscleRepository, MuscleRepository>();
        services.AddScoped<IRoutineRepository, RoutineRepository>();
        services.AddDbContext<ApplicationDbContext>(x => x.UseSqlServer(connectionString));
    }
}