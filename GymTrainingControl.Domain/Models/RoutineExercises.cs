namespace GymTrainingControl.Domain.Models;

public class RoutineExercises
{
    public int Id { get; set; }
    public Routine Routine { get; set; }
    public int RoutineId { get; set; }
    public Exercise Exercise { get; set; }
    public int ExerciseId { get; set; }
    public ICollection<Serie> Series { get; set; }
    public RoutinePeriodDetail RoutinePeriodDetail { get; set; }
    public int RoutinePeriodDetailId { get; set; }
}