using System;
using System.Collections.Generic;
using Top.Api.Util;

namespace Top.Api.Request
{
    /// <summary>
    /// TOP API: tmall.mc.task.charge.launch
    /// </summary>
    public class TmallMcTaskChargeLaunchRequest : BaseTopRequest<Top.Api.Response.TmallMcTaskChargeLaunchResponse>
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
        /// 外部设备编码
        /// </summary>
        public string OuterCode { get; set; }

        /// <summary>
        /// urlID
        /// </summary>
        public string UrlId { get; set; }

        #region ITopRequest Members

        public override string GetApiName()
        {
            return "tmall.mc.task.charge.launch";
        }

        public override IDictionary<string, string> GetParameters()
        {
            TopDictionary parameters = new TopDictionary();
            parameters.Add("alipay_open_id", this.AlipayOpenId);
            parameters.Add("channel_id", this.ChannelId);
            parameters.Add("extra", this.Extra);
            parameters.Add("outer_code", this.OuterCode);
            parameters.Add("url_id", this.UrlId);
            if (this.otherParams != null)
            {
                parameters.AddAll(this.otherParams);
            }
            return parameters;
        }

        public override void Validate()
        {
            RequestValidator.ValidateRequired("alipay_open_id", this.AlipayOpenId);
            RequestValidator.ValidateRequired("channel_id", this.ChannelId);
            RequestValidator.ValidateRequired("outer_code", this.OuterCode);
        }

        #endregion
    }
}
