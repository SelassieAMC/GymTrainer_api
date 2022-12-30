using GymTrainingControl.Application.Dtos;

namespace GymTrainingControl.Application.Services.Interfaces;

public interface ICategoryService
{
    IEnumerable<CategoryDto> GetCategories();
}