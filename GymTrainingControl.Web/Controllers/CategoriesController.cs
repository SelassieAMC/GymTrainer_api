using GymTrainingControl.Application.Services.Interfaces;
using Microsoft.AspNetCore.Mvc;

namespace GymTrainingControl.Web.Controllers;

[ApiController]
[Route("api/v1/[controller]")]
public class CategoriesController : ControllerBase
{
    private readonly ICategoryService _categoryService;

    public CategoriesController(ICategoryService cateogoryService)
    {
        _categoryService = cateogoryService;
    }
    
    [HttpGet("get-all")]
    public IActionResult GetCategories()
    {
        var categories = _categoryService.GetCategories();
        return new OkObjectResult(categories);
    }
}
