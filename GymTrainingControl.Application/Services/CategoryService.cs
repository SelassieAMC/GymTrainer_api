using AutoMapper;
using GymTrainingControl.Application.Dtos;
using GymTrainingControl.Application.Services.Interfaces;
using GymTrainingControl.Domain.Interfaces;

namespace GymTrainingControl.Application.Services;

public class CategoryService : ICategoryService
{
    private readonly ICategoryRepository _repository;
    private readonly IMapper _mapper;

    public CategoryService(
        ICategoryRepository repository,
        IMapper mapper)
    {
        _repository = repository;
        _mapper = mapper;
    }
    
    public IEnumerable<CategoryDto> GetCategories()
    {
        var categories = _repository.GetAll();
        return _mapper.Map<IEnumerable<CategoryDto>>(categories);
    }
}
