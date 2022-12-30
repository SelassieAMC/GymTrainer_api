using GymTrainingControl.Application.Services.Interfaces;
using Microsoft.AspNetCore.Mvc;

namespace GymTrainingControl.Web.Controllers;

[ApiController]
[Route("api/v1/[controller]")]
public class MusclesController : ControllerBase
{
    private readonly IMuscleService _muscleService;

    public MusclesController(IMuscleService muscleService)
    {
        _muscleService = muscleService;
    }
    
    [HttpGet("get-all")]
    public IActionResult GetMuscles()
    {
        var muscles = _muscleService.GetMuscles();
        return new OkObjectResult(muscles);
    }
}