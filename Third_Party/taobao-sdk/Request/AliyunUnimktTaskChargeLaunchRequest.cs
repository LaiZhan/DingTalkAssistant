using System;
using System.Collections.Generic;
using Top.Api.Util;

namespace Top.Api.Request
{
    /// <summary>
    /// TOP API: aliyun.unimkt.task.charge.launch
    /// </summary>
    public class AliyunUnimktTaskChargeLaunchRequest : BaseTopRequest<Top.Api.Response.AliyunUnimktTaskChargeLaunchResponse>
    {
        /// <summary>
        /// 支付宝openID
        /// </summary>
        public string AlipayOpenId { get; set; }

        /// <summary>
        /// 渠道ID
        /// </summary>
        public string ChannelId { get; set; }

        /// <summary>
        /// 服务商附加url参数
        /// </summary>
        public string Extra { get; set; }

        /// <summary>
        /// 被代理渠道ID
        /// </summary>
        public string ProxyChannelId { get; set; }

        /// <summary>
        /// urlID
        /// </summary>
        public string UrlId { get; set; }

        /// <summary>
        /// 淘宝ID
        /// </summary>
        public string UserId { get; set; }

        #region ITopRequest Members

        public override string GetApiName()
        {
            return "aliyun.unimkt.task.charge.launch";
        }

        public override IDictionary<string, string> GetParameters()
        {
            TopDictionary parameters = new TopDictionary();
            parameters.Add("alipay_open_id", this.AlipayOpenId);
            parameters.Add("channel_id", this.ChannelId);
            parameters.Add("extra", this.Extra);
            parameters.Add("proxy_channel_id", this.ProxyChannelId);
            parameters.Add("url_id", this.UrlId);
            parameters.Add("user_id", this.UserId);
            if (this.otherParams != null)
            {
                parameters.AddAll(this.otherParams);
            }
            return parameters;
        }

        public override void Validate()
        {
            RequestValidator.ValidateRequired("channel_id", this.ChannelId);
        }

        #endregion
    }
}
