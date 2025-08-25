using System;
using System.Collections.Generic;
using Top.Api.Util;

namespace Top.Api.Request
{
    /// <summary>
    /// TOP API: tmall.mc.device.circle.check
    /// </summary>
    public class TmallMcDeviceCircleCheckRequest : BaseTopRequest<Top.Api.Response.TmallMcDeviceCircleCheckResponse>
    {
        /// <summary>
        /// 渠道编码
        /// </summary>
        public string ChannelId { get; set; }

        /// <summary>
        /// 外部设备编码
        /// </summary>
        public string OuterCode { get; set; }

        #region ITopRequest Members

        public override string GetApiName()
        {
            return "tmall.mc.device.circle.check";
        }

        public override IDictionary<string, string> GetParameters()
        {
            TopDictionary parameters = new TopDictionary();
            parameters.Add("channel_id", this.ChannelId);
            parameters.Add("outer_code", this.OuterCode);
            if (this.otherParams != null)
            {
                parameters.AddAll(this.otherParams);
            }
            return parameters;
        }

        public override void Validate()
        {
            RequestValidator.ValidateRequired("channel_id", this.ChannelId);
            RequestValidator.ValidateRequired("outer_code", this.OuterCode);
        }

        #endregion
    }
}
