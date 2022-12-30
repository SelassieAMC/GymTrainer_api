using AutoMapper;
using GymTrainingControl.Application.Dtos;
using GymTrainingControl.Application.Services.Interfaces;
using GymTrainingControl.Domain.Interfaces;

namespace GymTrainingControl.Application.Services;

public class MuscleService : IMuscleService
{
    private readonly IMuscleRepository _muscleRepository;
    private readonly IMapper _mapper;

    public MuscleService(
        IMuscleRepository repo,
        IMapper mapper)
    {
        _muscleRepository = repo;
        _mapper = mapper;
    }
    
    public IEnumerable<MuscleDto> GetMuscles()
    {
        var muscles = _muscleRepository.GetAll();
        return _mapper.Map<IEnumerable<MuscleDto>>(muscles);
    }
}
