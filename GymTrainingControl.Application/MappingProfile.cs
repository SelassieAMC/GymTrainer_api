using AutoMapper;
using GymTrainingControl.Application.Dtos;
using GymTrainingControl.Domain.Models;

namespace GymTrainingControl.Application;

public class MappingProfile : Profile
{
    public MappingProfile()
    {
        CreateMap<Exercise, ExerciseDto>().ReverseMap();
        CreateMap<Category, CategoryDto>().ReverseMap();
        CreateMap<Muscle, MuscleDto>().ReverseMap();
        CreateMap<Routine, RoutineDto>().ReverseMap();
    }
}