using System;
using System.Collections.Generic;
using Top.Api.Util;

namespace Top.Api.Request
{
    /// <summary>
    /// TOP API: wdk.rex.device.iot.registerid
    /// </summary>
    public class WdkRexDeviceIotRegisteridRequest : BaseTopRequest<Top.Api.Response.WdkRexDeviceIotRegisteridResponse>
    {
        /// <summary>
        /// 平台key
        /// </summary>
        public string AccessKey { get; set; }

        /// <summary>
        /// 平台签名
        /// </summary>
        public string AccessSign { get; set; }

        /// <summary>
        /// 签名时间戳（毫秒）
        /// </summary>
        public string AccessTime { get; set; }

        /// <summary>
        /// 设备ID
        /// </summary>
        public string Uuid { get; set; }

        #region ITopRequest Members

        public override string GetApiName()
        {
            return "wdk.rex.device.iot.registerid";
        }

        public override IDictionary<string, string> GetParameters()
        {
            TopDictionary parameters = new TopDictionary();
            parameters.Add("access_key", this.AccessKey);
            parameters.Add("access_sign", this.AccessSign);
            parameters.Add("access_time", this.AccessTime);
            parameters.Add("uuid", this.Uuid);
            if (this.otherParams != null)
            {
                parameters.AddAll(this.otherParams);
            }
            return parameters;
        }

        public override void Validate()
        {
            RequestValidator.ValidateRequired("access_key", this.AccessKey);
            RequestValidator.ValidateRequired("access_sign", this.AccessSign);
            RequestValidator.ValidateRequired("uuid", this.Uuid);
        }

        #endregion
    }
}
