using GymTrainingControl.Application.Services;
using GymTrainingControl.Application.Services.Interfaces;
using Microsoft.Extensions.DependencyInjection;

namespace GymTrainingControl.Application;

public static class DependencyInjection
{
    public static void AddApplicationServices(this IServiceCollection services)
    {
        services.AddScoped<IExerciseService, ExerciseService>();
        services.AddScoped<ICategoryService, CategoryService>();
        services.AddScoped<IMuscleService, MuscleService>();
        services.AddScoped<IRoutineService, RoutineService>();
        services.AddAutoMapper(AppDomain.CurrentDomain.GetAssemblies());
    }
}