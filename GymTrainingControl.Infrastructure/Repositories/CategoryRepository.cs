using GymTrainingControl.Domain.Interfaces;
using GymTrainingControl.Domain.Models;
using GymTrainingControl.Infrastructure.Persistence;

namespace GymTrainingControl.Infrastructure.Repositories;

public class CategoryRepository : ICategoryRepository
{
    private readonly ApplicationDbContext _dbContext;

    public CategoryRepository(ApplicationDbContext context)
    {
        _dbContext = context;
    }
    
    public IEnumerable<Category> GetAll()
    {
        return _dbContext.Categories;
    }

    public void Update(Category entity)
    {
        throw new NotImplementedException();
    }
}