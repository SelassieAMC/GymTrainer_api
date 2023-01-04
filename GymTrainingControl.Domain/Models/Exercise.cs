using System.Xml;

namespace GymTrainingControl.Domain.Models;

public class Exercise : BaseModel
{
    public Uri? Image { get; set; }
    
    public Uri? PresentationImage { get; set; }

    public Uri? Video { get; set; }

    public int Calories { get; set; }
    
    public int? TimeExpendInSec { get; set; }

    public string IntensityMeasure { get; set; } = string.Empty;
    
    public ICollection<Muscle> MusclesWorked { get; set; } = new HashSet<Muscle>();
    
    public ICollection<Category> Categories { get; set; } = new HashSet<Category>();

    public ICollection<RoutineExercises> ExercisesRoutine { get; set; } = new HashSet<RoutineExercises>();
}
