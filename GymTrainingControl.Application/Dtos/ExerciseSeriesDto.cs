namespace GymTrainingControl.Application.Dtos;

public class ExerciseSeriesDto
{
    public int Id { get; set; }
    
    public ExerciseDto Exercise { get; set; }
    
    public ICollection<SerieDto> Series { get; set; }
    
    public int WeekNumber { get; set; }
    
    public int DayNumber { get; set; }
}