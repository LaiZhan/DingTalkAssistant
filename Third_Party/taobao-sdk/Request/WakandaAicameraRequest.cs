using System;
using System.Collections.Generic;
using Top.Api.Util;

namespace Top.Api.Request
{
    /// <summary>
    /// TOP API: taobao.wakanda.aicamera
    /// </summary>
    public class WakandaAicameraRequest : BaseTopRequest<Top.Api.Response.WakandaAicameraResponse>
    {
        /// <summary>
        /// 设备唯一标识
        /// </summary>
        public string DeviceId { get; set; }

        /// <summary>
        /// 加密码
        /// </summary>
        public string Key { get; set; }

        #region ITopRequest Members

        public override string GetApiName()
        {
            return "taobao.wakanda.aicamera";
        }

        public override IDictionary<string, string> GetParameters()
        {
            TopDictionary parameters = new TopDictionary();
            parameters.Add("device_id", this.DeviceId);
            parameters.Add("key", this.Key);
            if (this.otherParams != null)
            {
                parameters.AddAll(this.otherParams);
            }
            return parameters;
        }

        public override void Validate()
        {
            RequestValidator.ValidateRequired("device_id", this.DeviceId);
            RequestValidator.ValidateRequired("key", this.Key);
        }

        #endregion
    }
}
