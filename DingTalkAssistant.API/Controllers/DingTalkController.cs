using System.Text.Json.Nodes;
using Microsoft.AspNetCore.Mvc;

namespace DingTalkAssistant.API.Controllers;

[ApiController]
[Route("[controller]/[action]")]
public class DingTalkController : Controller
{
    // GET
    [HttpPost]
    public IActionResult Assistant([FromBody]JsonObject request)
    {
        Console.WriteLine(request);
        return Json(new { Code = 200 });
    }
}