namespace GymTrainingControl.Application.Dtos;

public class DayDto
{
    public int Id { get; set; }
    public int DayNumber { get; set; }
    public string DayName { get; set; } = string.Empty;
    public int WeekId { get; set; }
    public int WeekNumber { get; set; }
}