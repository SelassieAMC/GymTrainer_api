namespace GymTrainingControl.Domain.Models;

public class Category : BaseModel
{ 
    public ICollection<Exercise> Exercises { get; set; } = new HashSet<Exercise>();
}
