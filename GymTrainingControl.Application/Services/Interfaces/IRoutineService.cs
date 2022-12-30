using GymTrainingControl.Application.Dtos;

namespace GymTrainingControl.Application.Services.Interfaces;

public interface IRoutineService
{
    public IEnumerable<RoutineDto> GetAll(bool includeExercises);
}