using DingTalk.Api;
using DingTalk.Api.Request;
using DingTalk.Api.Response;
using Newtonsoft.Json;

namespace DingTalkAssistant.API.Services;

public interface IDingTalkService
{
    Task ReplyMesasgeBySessionWebhook(
        string sessionWebhook,
        string replyContent,
        List<string> atUserIds
    );

    Task<string> GetAccessToken(string appkey, string appsecret);
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
            Text = JsonConvert.SerializeObject(new { content = replyContent }),
            At_ = new OapiRobotSendRequest.AtDomain { AtUserIds = atUserIds, IsAtAll = false },
        };
        OapiRobotSendResponse response = client.Execute(request);

        Console.WriteLine($"DingTalk reply response: {response.Body}");
        await Task.CompletedTask;
    }

    public async Task<string> GetAccessToken(string appkey, string appsecret)
    {
        // Implementation for getting access token
        DefaultDingTalkClient defaultDingTalkClient = new("https://oapi.dingtalk.com/gettoken");
        // IDingTalkClient client = defaultDingTalkClient;
        OapiGettokenRequest req = new OapiGettokenRequest
        {
            Appkey = appkey,
            Appsecret = appsecret,
        };
        req.SetHttpMethod("GET");
        OapiGettokenResponse rsp = defaultDingTalkClient.Execute(req);

        await Task.CompletedTask;
        return rsp.AccessToken;
    }
}
