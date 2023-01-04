using System.Security.AccessControl;
using GymTrainingControl.Domain.Enums;

namespace GymTrainingControl.Domain.Models;

public class Routine : BaseModel
{
    public Uri? PresentationImage { get; set; }

    public RoutineLevel RoutineLevel { get; set; }
    
    public ICollection<RoutineExercises> RoutineExercises { get; set; } = new HashSet<RoutineExercises>();
}