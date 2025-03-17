using Microsoft.AspNetCore.Mvc;

namespace Trainorito.Api.Controllers;

[ApiController]
public class TimeController : ControllerBase
{

    [HttpGet("api/current-time")]
    public IActionResult GetCurrentTimeUtc()
    {
        return Ok(DateTime.UtcNow);
    }

}
