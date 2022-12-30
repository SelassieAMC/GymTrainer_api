using GymTrainingControl.Domain.Interfaces;
using GymTrainingControl.Domain.Models;
using GymTrainingControl.Infrastructure.Persistence;

namespace GymTrainingControl.Infrastructure.Repositories;

public class MuscleRepository : IMuscleRepository
{
    private readonly ApplicationDbContext _dbContext;

    public MuscleRepository(ApplicationDbContext dbContext)
    {
        _dbContext = dbContext;
    }
    public IEnumerable<Muscle> GetAll()
    {
        return _dbContext.Muscles;
    }

    public void Update(Muscle entity)
    {
        throw new NotImplementedException();
    }
}