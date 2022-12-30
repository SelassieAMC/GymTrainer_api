using GymTrainingControl.Domain.Models;
using Microsoft.EntityFrameworkCore;

namespace GymTrainingControl.Infrastructure.Persistence;

public class ApplicationDbContext : DbContext
{
    public DbSet<Exercise> Exercises { get; set; } = null!;
    
    public DbSet<Muscle> Muscles { get; set; } = null!;
    
    public DbSet<Category> Categories { get; set; } = null!;

    public DbSet<Routine> Routines { get; set; } = null!;

    public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
    { }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<Exercise>()
            .HasMany(e =>e.Categories)
            .WithMany(c => c.Exercises)
            .UsingEntity(j => j.ToTable("ExerciseCategories"));
        
        modelBuilder.Entity<Exercise>()
            .HasMany(e =>e.MusclesWorked)
            .WithMany(m => m.Exercises)
            .UsingEntity(j => j.ToTable("ExerciseMuscles"));

        modelBuilder.Entity<Routine>()
            .HasMany(r => r.Exercises)
            .WithMany(e => e.Routines)
            .UsingEntity(j => j.ToTable("RoutineExercise"));
    }
}
