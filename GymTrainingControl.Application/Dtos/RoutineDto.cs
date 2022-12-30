using GymTrainingControl.Domain.Enums;

namespace GymTrainingControl.Application.Dtos;

public class RoutineDto : BaseDto
{
    public ICollection<ExerciseDto> Exercises { get; set; } = new HashSet<ExerciseDto>();

    public Uri? PresentationImage { get; set; }

    public RoutineLevel RoutineLevel { get; set; }
}