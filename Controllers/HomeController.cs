using Microsoft.AspNetCore.Mvc;

namespace Vurlux.Controllers;

[ApiController]
[Route("")]
public class HomeController : ControllerBase
{
    public IActionResult Index()
    {
        return Ok(new {
            message = "Hello world!"
        });
    }
}
