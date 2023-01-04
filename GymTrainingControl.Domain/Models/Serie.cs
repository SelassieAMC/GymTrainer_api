namespace GymTrainingControl.Domain.Models;

public class ExerciseDay
{
    public int Id { get; set; }
    public int DayId { get; set; }
    public int ExerciseId { get; set; }
    public int Repetitions { get; set; }
    public int Intensity { get; set; } //weight or time (kg/sec)
    public bool Fail { get; set; }
    public int RestInSec { get; set; } //sec
    public int SerieNumber { get; set; }
    public int RoutineId { get; set; }
}