using GymTrainingControl.Domain.Enums;

namespace GymTrainingControl.Application.Dtos;

public class RoutineDto : BaseDto
{
    public Uri? PresentationImage { get; set; }

    public RoutineLevel RoutineLevel { get; set; }
    
    public ICollection<ExerciseSeriesDto> ExercisesSeries { get; set; } = new HashSet<ExerciseSeriesDto>();
}