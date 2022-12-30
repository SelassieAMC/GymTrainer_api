using GymTrainingControl.Application.Services.Interfaces;
using Microsoft.AspNetCore.Mvc;

namespace GymTrainingControl.Web.Controllers;

[ApiController]
[Route("api/v1/[controller]")]
public class RoutineController : ControllerBase
{
    private readonly IRoutineService _routineService;

    public RoutineController(IRoutineService routineService)
    {
        _routineService = routineService;
    }
    
    [HttpGet("get-all")]
    public IActionResult GetAll(bool includeExercises)
    {
        var routines = _routineService.GetAll(includeExercises);
        return Ok(routines);
    }
}