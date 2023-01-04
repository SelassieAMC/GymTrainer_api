namespace GymTrainingControl.Domain.Models;

public class RoutinePeriod
{
    public int Id { get; set; }
    
    public int WeekNumber { get; set; }
    
    public int SerieId { get; set; }
    
    public Serie Serie { get; set; }
    
    public int DayNumber { get; set; }
}