using GymTrainingControl.Domain.Enums;

namespace GymTrainingControl.Domain.Models;

public class Routine : BaseModel
{
    public ICollection<Exercise> Exercises { get; set; } = new HashSet<Exercise>();

    public Uri? PresentationImage { get; set; }

    public RoutineLevel RoutineLevel { get; set; }
}