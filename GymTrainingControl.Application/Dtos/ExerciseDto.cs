namespace GymTrainingControl.Application.Dtos;

public class ExerciseDto : BaseDto
{
    public Uri? Image { get; set; }

    public Uri? PresentationImage { get; set; }

    public Uri? Video { get; set; }

    public int Calories { get; set; }
    
    public IEnumerable<MuscleDto> MusclesWorked { get; set; } = new HashSet<MuscleDto>();
    
    public IEnumerable<CategoryDto> Categories { get; set; } = new HashSet<CategoryDto>();
}
