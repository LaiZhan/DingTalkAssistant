using System;
using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace DingTalkAssistant.API.Models
{
    public class AtUser
    {
        [JsonPropertyName("dingtalkId")]
        public string? DingtalkId { get; set; }

        [JsonPropertyName("staffId")]
        public string? StaffId { get; set; }
    }

    public class TextContent
    {
        [JsonPropertyName("content")]
        public string? Content { get; set; }
    }

    public class AssistantRequest
    {
        [JsonPropertyName("conversationId")]
        public string? ConversationId { get; set; }

        [JsonPropertyName("atUsers")]
        public List<AtUser>? AtUsers { get; set; }

        [JsonPropertyName("chatbotCorpId")]
        public string? ChatbotCorpId { get; set; }

        [JsonPropertyName("chatbotUserId")]
        public string? ChatbotUserId { get; set; }

        [JsonPropertyName("msgId")]
        public string? MsgId { get; set; }

        [JsonPropertyName("senderNick")]
        public string? SenderNick { get; set; }

        [JsonPropertyName("isAdmin")]
        public bool IsAdmin { get; set; }

        [JsonPropertyName("senderStaffId")]
        public string? SenderStaffId { get; set; }

        [JsonPropertyName("sessionWebhookExpiredTime")]
        public long SessionWebhookExpiredTime { get; set; }

        [JsonPropertyName("createAt")]
        public long CreateAt { get; set; }

        [JsonPropertyName("senderCorpId")]
        public string? SenderCorpId { get; set; }

        [JsonPropertyName("conversationType")]
        public string? ConversationType { get; set; }

        [JsonPropertyName("senderId")]
        public string? SenderId { get; set; }

        [JsonPropertyName("conversationTitle")]
        public string? ConversationTitle { get; set; }

        [JsonPropertyName("isInAtList")]
        public bool IsInAtList { get; set; }

        [JsonPropertyName("sessionWebhook")]
        public string? SessionWebhook { get; set; }

        [JsonPropertyName("text")]
        public TextContent? Text { get; set; }

        [JsonPropertyName("robotCode")]
        public string? RobotCode { get; set; }

        [JsonPropertyName("msgtype")]
        public string? MsgType { get; set; }
    }
}
