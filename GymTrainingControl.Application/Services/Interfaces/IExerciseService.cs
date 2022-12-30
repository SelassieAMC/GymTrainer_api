using GymTrainingControl.Application.Dtos;

namespace GymTrainingControl.Application.Services;

public interface IExerciseService
{
    public IEnumerable<ExerciseDto> GetExercises();
    
    public Task<ExerciseDto?> GetExerciseByIdAsync(int id);
    
    public IEnumerable<ExerciseDto>? GetExercisesByFilterAsync(FilterModel filter);

    public Task AddExerciseAsync(ExerciseDto exerciseDto);
}