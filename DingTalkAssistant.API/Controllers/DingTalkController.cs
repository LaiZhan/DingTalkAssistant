using DingTalkAssistant.API.Models;
using DingTalkAssistant.API.Services;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Options;
using Newtonsoft.Json;

namespace DingTalkAssistant.API.Controllers;

[ApiController]
[Route("[controller]/[action]")]
public class DingTalkController : Controller
{
    private readonly IDingTalkService _dingTalkService;
    private readonly INewDingTalkService _newDingTalkService;
    private readonly IOptions<DingTalkConfig> _dingTalkConfig;

    public DingTalkController(
        IDingTalkService dingTalkService,
        INewDingTalkService newDingTalkService,
        IOptions<DingTalkConfig> dingTalkConfig
    )
    {
        _dingTalkService = dingTalkService;
        _newDingTalkService = newDingTalkService;
        _dingTalkConfig = dingTalkConfig;
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
                var atUserIds = string.IsNullOrWhiteSpace(request.SenderId)
                    ? []
                    : new List<string> { request.SenderId };

                atUserIds = ["011322491145279"];
                await _dingTalkService.ReplyMesasgeBySessionWebhook(
                    request.SessionWebhook,
                    replyContent,
                    atUserIds: atUserIds
                );
                try
                {
                    string accessToken = await _dingTalkService.GetAccessToken(
                        _dingTalkConfig.Value.Robot[0].AppKey,
                        _dingTalkConfig.Value.Robot[0].AppSecret
                    );

                    string response = await _newDingTalkService.SendGroupMessage(
                        accessToken,
                        "sampleText",
                        JsonConvert.SerializeObject(new { content = "Test Group message" }),
                        request.ConversationId,
                        request.RobotCode
                    );
                }
                catch (Exception ex)
                {
                    Console.WriteLine($"Error occurred while sending group message: {ex.Message}");
                }
            }
        }
        return Json(new { Code = 200 });
    }

    [HttpGet]
    public async Task<IActionResult> GetAccessToken()
    {
        string appkey = _dingTalkConfig.Value.Robot[0].AppKey;
        string appsecret = _dingTalkConfig.Value.Robot[0].AppSecret;

        string accessToken = await _dingTalkService.GetAccessToken(appkey, appsecret);
        return Json(new { AccessToken = accessToken });
    }

    [HttpPost]
    public async Task<IActionResult> SendGroupMessage(string message)
    {
        string accessToken = await _dingTalkService.GetAccessToken(
            _dingTalkConfig.Value.Robot[0].AppKey,
            _dingTalkConfig.Value.Robot[0].AppSecret
        );

        string response = await _newDingTalkService.SendGroupMessage(
            accessToken,
            "sampleText",
            JsonConvert.SerializeObject(new { content = message }),
            null,
            null
        );

        return Json(new { Response = response });
    }
}
