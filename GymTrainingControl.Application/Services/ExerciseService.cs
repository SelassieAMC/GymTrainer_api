using AutoMapper;
using GymTrainingControl.Application.Dtos;
using GymTrainingControl.Domain.Interfaces;
using GymTrainingControl.Domain.Models;

namespace GymTrainingControl.Application.Services;

public class ExerciseService : IExerciseService
{
    private readonly IExerciseRepository _exerciseRepo;
    private readonly IMapper _mapper;

    public ExerciseService(
        IExerciseRepository exerciseRepo,
        IMapper mapper)
    {
        _exerciseRepo = exerciseRepo;
        _mapper = mapper;
    }
    
    public IEnumerable<ExerciseDto> GetExercises()
    {
        var data = _exerciseRepo.GetAll();
        return _mapper.Map<List<ExerciseDto>>(data);
    }

    public async Task<ExerciseDto?> GetExerciseByIdAsync(int id)
    {
        var data = await _exerciseRepo.GetExerciseByIdAsync(id);
        return _mapper.Map<ExerciseDto>(data);
    }

    public IEnumerable<ExerciseDto>? GetExercisesByFilterAsync(FilterModel filter)
    {
        Func<Exercise, bool>? funcFilter = null;

        throw new NotImplementedException();
        
        var data = _exerciseRepo.GetExercisesByFilterAsync(funcFilter);
        return _mapper.Map<List<ExerciseDto>>(data);
    }

    public Task AddExerciseAsync(ExerciseDto exerciseDto)
    {
        var exercise = _mapper.Map<Exercise>(exerciseDto);
        return _exerciseRepo.AddExerciseAsync(exercise);
    }
}