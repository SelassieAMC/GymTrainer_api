using AutoMapper;
using GymTrainingControl.Application.Dtos;
using GymTrainingControl.Domain.Models;

namespace GymTrainingControl.Application;

public class MappingProfile : Profile
{
    public MappingProfile()
    {
        CreateMap<Exercise, ExerciseDto>().ReverseMap();
        CreateMap<Exercise, ExerciseDto>()
            .ForMember(dest => dest.IntensityMeasure, opt =>
            opt.MapFrom(src => src.IntensityMeasure.ToString()));
        CreateMap<Category, CategoryDto>().ReverseMap();
        CreateMap<Muscle, MuscleDto>().ReverseMap();
        CreateMap<RoutineExercises, ExerciseSeriesDto>()
            .ForMember(dest => dest.DayNumber, opt =>
                opt.MapFrom(x => x.RoutinePeriodDetail.DayNumber))
            .ForMember(dest => dest.WeekNumber, opt =>
                opt.MapFrom(x => x.RoutinePeriodDetail.WeekNumber));
        CreateMap<Routine, RoutineDto>()
            .ForMember(dest => dest.ExercisesSeries, 
                opt => opt.MapFrom(src => src.RoutineExercises))
            .ReverseMap();
        CreateMap<SerieDto, Serie>().ReverseMap();
    }
}