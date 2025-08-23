using Microsoft.AspNetCore.Mvc;

namespace DingTalkAssistant.API.Controllers;

[ApiController]
[Route("[controller]/[action]")]
public class DingTalkController : Controller
{
    // GET
    public IActionResult Assistant()
    {
        return Json(new { Code = 200 });
    }
}