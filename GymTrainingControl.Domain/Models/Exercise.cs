using System.Xml;
using GymTrainingControl.Domain.Enums;

namespace GymTrainingControl.Domain.Models;

public class Exercise : BaseModel
{
    public Uri? Image { get; set; }
    
    public Uri? PresentationImage { get; set; }

    public Uri? Video { get; set; }

    public float Calories { get; set; }
    
    public int? TimeSpentInSec { get; set; }

    public ExerciseMeasure IntensityMeasure { get; set; }
    
    public ICollection<Muscle> MusclesWorked { get; set; } = new HashSet<Muscle>();
    
    public ICollection<Category> Categories { get; set; } = new HashSet<Category>();

    public ICollection<RoutineExercises> ExercisesRoutine { get; set; } = new HashSet<RoutineExercises>();
}
