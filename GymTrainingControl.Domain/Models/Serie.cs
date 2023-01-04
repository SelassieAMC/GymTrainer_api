namespace GymTrainingControl.Domain.Models;

public class Serie
{
    public int Id { get; set; }
    public int Repetitions { get; set; }
    public int Intensity { get; set; } //weight or time (kg/sec)
    public bool Fail { get; set; }
    public int RestInSec { get; set; } //sec
    public int SerieNumber { get; set; }
    public RoutineExercises RoutineExercise { get; set; }
    public int RoutineExerciseId { get; set; }
}