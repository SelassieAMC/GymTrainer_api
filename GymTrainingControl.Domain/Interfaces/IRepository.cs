namespace GymTrainingControl.Domain.Interfaces;

public interface IRepository<T>
{
    public IEnumerable<T> GetAll();
    
    public void Update(T entity);
}