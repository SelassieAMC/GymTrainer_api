using GymTrainingControl.Application.Dtos;
using GymTrainingControl.Application.Services;
using Microsoft.AspNetCore.Mvc;

namespace GymTrainingControl.Web.Controllers;

[ApiController]
[Route("api/v1/[controller]")]
public class ExercisesController : ControllerBase
{
    private readonly IExerciseService _exerciseService;

    public ExercisesController(IExerciseService exerciseService)
    {
        _exerciseService = exerciseService;
    }
    
    [HttpGet("get-all")]
    public IActionResult GetExercises()
    {
        var exercises = _exerciseService.GetExercises();
        return new OkObjectResult(exercises);
    }
    
    [HttpGet("get-by-id/{id}")]
    public async Task<IActionResult> GetExerciseByIdAsync(int id)
    {
        var exercise = await _exerciseService.GetExerciseByIdAsync(id);
        if (exercise is null)
        {
            return NotFound();
        }
            
        return new OkObjectResult(exercise);
    }
    
    [HttpGet("get-by-filter")]
    public IActionResult GetExerciseByFilterAsync([FromQuery] FilterModel filter)
    {
        var exercises = _exerciseService.GetExercisesByFilterAsync(filter);
        if (exercises is null || !exercises.Any())
        {
            return NotFound();
        }
            
        return new OkObjectResult(exercises);
    }

    [HttpPost("create")]
    public async Task<IActionResult> CreateExerciseAsync(ExerciseDto exercise)
    {
        await _exerciseService.AddExerciseAsync(exercise);
        return new EmptyResult();
    }
}
