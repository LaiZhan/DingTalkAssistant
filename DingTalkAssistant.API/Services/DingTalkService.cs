using DingTalk.Api;
using DingTalk.Api.Request;
using DingTalk.Api.Response;

namespace DingTalkAssistant.API.Services;

public interface IDingTalkService
{
    Task ReplyMesasgeBySessionWebhook(
        string sessionWebhook,
        string replyContent,
        List<string> atUserIds
    );
}

public class DingTalkService : IDingTalkService
{
    public async Task ReplyMesasgeBySessionWebhook(
        string sessionWebhook,
        string replyContent,
        List<string> atUserIds
    )
    {
        // Implementation for replying to a message via session webhook
        DefaultDingTalkClient client = new(sessionWebhook);
        OapiRobotSendRequest request = new()
        {
            Msgtype = "text",
            Text = replyContent,
            At_ = new OapiRobotSendRequest.AtDomain { AtUserIds = atUserIds, IsAtAll = false },
        };
        OapiRobotSendResponse response = client.Execute(request);

        Console.WriteLine($"DingTalk reply response: {response.Body}");
        await Task.CompletedTask;
    }
}
