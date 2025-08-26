namespace DingTalkAssistant.API.Models;

public class DingTalkConfig
{
    public List<DingTalkRobotConfig> Robot { get; set; } = [];
}

public class DingTalkRobotConfig
{
    public string Title { get; set; }
    public string AppKey { get; set; }
    public string AppSecret { get; set; }
}
