using GymTrainingControl.Application.Dtos;

namespace GymTrainingControl.Application.Services.Interfaces;

public interface IMuscleService
{
    IEnumerable<MuscleDto> GetMuscles();
}
