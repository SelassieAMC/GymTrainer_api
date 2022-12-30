using GymTrainingControl.Domain.Interfaces;
using GymTrainingControl.Domain.Models;
using GymTrainingControl.Infrastructure.Persistence;
using Microsoft.EntityFrameworkCore;

namespace GymTrainingControl.Infrastructure.Repositories;

public class RoutineRepository : IRoutineRepository
{
    private readonly ApplicationDbContext _context;

    public RoutineRepository(ApplicationDbContext context)
    {
        _context = context;
    }
    
    public IEnumerable<Routine> GetAllWithExercises()
    {
        return _context.Routines.Include(x => x.Exercises);
    }

    public IEnumerable<Routine> GetAll()
    {
        return _context.Routines;
    }

    public void Update(Routine entity)
    {
        throw new NotImplementedException();
    }
}