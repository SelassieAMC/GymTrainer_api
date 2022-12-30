using GymTrainingControl.Domain.Models;

namespace GymTrainingControl.Domain.Interfaces;

public interface IRoutineRepository : IRepository<Routine>
{
    public IEnumerable<Routine> GetAllWithExercises();
}