using DingTalkAssistant.API.Models;
using DingTalkAssistant.API.Services;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;

namespace DingTalkAssistant.API.Controllers;

[ApiController]
[Route("[controller]/[action]")]
public class DingTalkController : Controller
{
    private readonly IDingTalkService _dingTalkService;

    public DingTalkController(IDingTalkService dingTalkService)
    {
        _dingTalkService = dingTalkService;
    }

    // GET
    [HttpPost]
    public async Task<IActionResult> AssistantAsync(
        [FromBody] AssistantRequest request,
        CancellationToken cancellationToken
    )
    {
        Console.WriteLine(
            $"{request.SenderNick} sent a message to the assistant:\n{JsonConvert.SerializeObject(request, Formatting.Indented)}"
        );

        string content = request.Text?.Content?.Trim() ?? "";
        if (!string.IsNullOrWhiteSpace(content))
        {
            // process the message content
            string replyContent = content;
            // if replyContent is not empty and sessionWebhook is not empty, call the dingtalk service to send the reply message
            if (
                !string.IsNullOrWhiteSpace(replyContent)
                && !string.IsNullOrWhiteSpace(request.SessionWebhook)
            )
            {
                // Call the service to get the reply content
                var atUserIds = string.IsNullOrWhiteSpace(request.SenderStaffId)
                    ? []
                    : new List<string> { request.SenderStaffId };

                await _dingTalkService.ReplyMesasgeBySessionWebhook(
                    request.SessionWebhook,
                    replyContent,
                    atUserIds: atUserIds
                );
            }
        }
        return Json(new { Code = 200 });
    }
}
