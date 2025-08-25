using System;
using System.Collections.Generic;
using Top.Api.Util;

namespace Top.Api.Request
{
    /// <summary>
    /// TOP API: tmall.mc.device.status.delete
    /// </summary>
    public class TmallMcDeviceStatusDeleteRequest : BaseTopRequest<Top.Api.Response.TmallMcDeviceStatusDeleteResponse>
    {
        /// <summary>
        /// 设备所属渠道
        /// </summary>
        public string Channel { get; set; }

        /// <summary>
        /// 平台设备编码
        /// </summary>
        public string DeviceCode { get; set; }

        #region ITopRequest Members

        public override string GetApiName()
        {
            return "tmall.mc.device.status.delete";
        }

        public override IDictionary<string, string> GetParameters()
        {
            TopDictionary parameters = new TopDictionary();
            parameters.Add("channel", this.Channel);
            parameters.Add("device_code", this.DeviceCode);
            if (this.otherParams != null)
            {
                parameters.AddAll(this.otherParams);
            }
            return parameters;
        }

        public override void Validate()
        {
            RequestValidator.ValidateRequired("channel", this.Channel);
            RequestValidator.ValidateRequired("device_code", this.DeviceCode);
        }

        #endregion
    }
}
