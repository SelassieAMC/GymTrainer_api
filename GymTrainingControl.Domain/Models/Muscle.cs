namespace GymTrainingControl.Domain.Models;

public class Muscle : BaseModel
{
    public Uri? Image { get; set; }
    
    public ICollection<Exercise> Exercises { get; set; } = new HashSet<Exercise>();    
}
