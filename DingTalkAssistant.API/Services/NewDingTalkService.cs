using Tea;

namespace DingTalkAssistant.API.Services;

public interface INewDingTalkService
{
    Task<string> GetAccessToken(string appkey, string appsecret);
    Task<string> SendGroupMessage(
        string accessToken,
        string type,
        string message,
        string? openConversationId,
        string? robotCode
    );
}

public class NewDingTalkService : INewDingTalkService
{
    public static AlibabaCloud.SDK.Dingtalkoauth2_1_0.Client CreateClient()
    {
        AlibabaCloud.OpenApiClient.Models.Config config =
            new AlibabaCloud.OpenApiClient.Models.Config();
        config.Protocol = "https";
        config.RegionId = "central";
        return new AlibabaCloud.SDK.Dingtalkoauth2_1_0.Client(config);
    }

    public async Task<string> GetAccessToken(string appkey, string appsecret)
    {
        AlibabaCloud.SDK.Dingtalkoauth2_1_0.Models.GetAccessTokenRequest getAccessTokenRequest =
            new() { AppKey = appkey, AppSecret = appsecret };
        try
        {
            var response = await CreateClient().GetAccessTokenAsync(getAccessTokenRequest);
            return response.Body.AccessToken;
        }
        catch (TeaException err)
        {
            if (
                !AlibabaCloud.TeaUtil.Common.Empty(err.Code)
                && !AlibabaCloud.TeaUtil.Common.Empty(err.Message)
            )
            {
                // err 中含有 code 和 message 属性，可帮助开发定位问题
                Console.WriteLine($"Error Code: {err.Code}, Error Message: {err.Message}");
            }
            throw;
        }
        catch (Exception _err)
        {
            TeaException err = new(new Dictionary<string, object> { { "message", _err.Message } });
            if (
                !AlibabaCloud.TeaUtil.Common.Empty(err.Code)
                && !AlibabaCloud.TeaUtil.Common.Empty(err.Message)
            )
            {
                // err 中含有 code 和 message 属性，可帮助开发定位问题
                Console.WriteLine($"Error Code: {err.Code}, Error Message: {err.Message}");
            }
            throw err;
        }
    }

    // 机器人在群内安装后，群内机器人的webhook属性中中的`access_token`的参数值。
    // 发送群聊：
    // - 方式一：使用`openConversationId`参数值和`robotCode`参数值，发送群聊消息。
    // - 方式二：使用webhook的`access_token`参数值值，发送群聊消息。 > 此access_token为机器人属性，并非API访问凭证的accessToken。![](https://img.alicdn.com/imgextra/i3/O1CN01nuIHHs22zWqgwEWFj_!!6000000007191-2-tps-718-563.png)
    public async Task<string> SendGroupMessage(
        string accessToken,
        string type,
        string message,
        string? openConversationId,
        string? robotCode
    )
    {
        AlibabaCloud.OpenApiClient.Models.Config config = new()
        {
            Protocol = "https",
            RegionId = "central",
        };
        AlibabaCloud.SDK.Dingtalkrobot_1_0.Client client = new(config);
        AlibabaCloud.SDK.Dingtalkrobot_1_0.Models.OrgGroupSendHeaders orgGroupSendHeaders = new()
        {
            XAcsDingtalkAccessToken = accessToken,
        };
        AlibabaCloud.SDK.Dingtalkrobot_1_0.Models.OrgGroupSendRequest orgGroupSendRequest = new()
        {
            MsgParam = message, //"{\"content\":\"钉钉，让进步发生\"}",
            MsgKey = type, //"sampleText",
            OpenConversationId = openConversationId,
            RobotCode = robotCode,
        };
        try
        {
            var response = await client.OrgGroupSendWithOptionsAsync(
                orgGroupSendRequest,
                orgGroupSendHeaders,
                new AlibabaCloud.TeaUtil.Models.RuntimeOptions()
            );

            return response.Body.ProcessQueryKey;
        }
        catch (TeaException err)
        {
            if (
                !AlibabaCloud.TeaUtil.Common.Empty(err.Code)
                && !AlibabaCloud.TeaUtil.Common.Empty(err.Message)
            )
            {
                // err 中含有 code 和 message 属性，可帮助开发定位问题
                Console.WriteLine($"Error Code: {err.Code}, Error Message: {err.Message}");
            }
            throw;
        }
        catch (Exception _err)
        {
            TeaException err = new TeaException(
                new Dictionary<string, object> { { "message", _err.Message } }
            );
            if (
                !AlibabaCloud.TeaUtil.Common.Empty(err.Code)
                && !AlibabaCloud.TeaUtil.Common.Empty(err.Message)
            )
            {
                // err 中含有 code 和 message 属性，可帮助开发定位问题

                Console.WriteLine($"Error Code: {err.Code}, Error Message: {err.Message}");
            }
            throw err;
        }
    }
}
