using AutoMapper;
using GymTrainingControl.Application.Dtos;
using GymTrainingControl.Application.Services.Interfaces;
using GymTrainingControl.Domain.Interfaces;

namespace GymTrainingControl.Application.Services;

public class RoutineService : IRoutineService
{
    private readonly IRoutineRepository _repository;
    private readonly IMapper _mapper;

    public RoutineService(IRoutineRepository repo, IMapper mapper)
    {
        _repository = repo;
        _mapper = mapper;
    }
    
    public IEnumerable<RoutineDto> GetAll(bool includeExercises)
    {
        var routines = includeExercises ? _repository.GetAllWithExercises() : _repository.GetAll();
        return _mapper.Map<IEnumerable<RoutineDto>>(routines);
    }
}