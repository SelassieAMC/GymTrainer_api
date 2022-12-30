using GymTrainingControl.Domain.Models;

namespace GymTrainingControl.Domain.Interfaces;

public interface IExerciseRepository : IRepository<Exercise>
{
    public Task<Exercise?> GetExerciseByIdAsync(int id);
    
    public List<Exercise> GetExercisesByFilterAsync(Func<Exercise, bool> filter);

    public Task AddExerciseAsync(Exercise exercise);
}