using GymTrainingControl.Application.Services;
using GymTrainingControl.Domain.Interfaces;
using GymTrainingControl.Domain.Models;
using GymTrainingControl.Infrastructure.Persistence;
using Microsoft.EntityFrameworkCore;

namespace GymTrainingControl.Infrastructure.Repositories;

public class ExerciseRepository : IExerciseRepository
{
    private readonly ApplicationDbContext _context;

    public ExerciseRepository(ApplicationDbContext context)
    {
        _context = context;
    }

    public Task<Exercise?> GetExerciseByIdAsync(int id)
    {
        return _context.Exercises
            .Include(x => x.Categories)
            .Include(x => x.MusclesWorked)
            .FirstOrDefaultAsync(x => x.Id == id);
    }

    public List<Exercise> GetExercisesByFilterAsync(Func<Exercise, bool> filter)
    {
        return _context.Exercises.Where(filter).ToList();
    }

    public Task AddExerciseAsync(Exercise exercise)
    {
        var categories = exercise.Categories.ToList();
        var muscles = exercise.MusclesWorked.ToList();

        categories.ForEach(cat => _context.Categories.Attach(cat));
        muscles.ForEach(muscle => _context.Muscles.Attach(muscle));
        
        _context.Exercises.Add(exercise);

        return _context.SaveChangesAsync();
    }

    public IEnumerable<Exercise> GetAll()
    {
        return _context.Exercises
            .Include(x => x.Categories)
            .Include(x => x.MusclesWorked);
    }

    public void Update(Exercise entity)
    {       
        _context.Exercises.Update(entity);
    }
}
