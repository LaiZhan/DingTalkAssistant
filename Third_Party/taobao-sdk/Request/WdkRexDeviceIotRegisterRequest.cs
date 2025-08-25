using System;
using System.Collections.Generic;
using Top.Api.Util;

namespace Top.Api.Request
{
    /// <summary>
    /// TOP API: wdk.rex.device.iot.register
    /// </summary>
    public class WdkRexDeviceIotRegisterRequest : BaseTopRequest<Top.Api.Response.WdkRexDeviceIotRegisterResponse>
    {
        /// <summary>
        /// 无关系
        /// </summary>
        public string Appk { get; set; }

        /// <summary>
        /// 阿里云deviceId
        /// </summary>
        public string DeviceId { get; set; }

        /// <summary>
        /// 阿里云productKey
        /// </summary>
        public string ProductKey { get; set; }

        /// <summary>
        /// rex平台accessKey
        /// </summary>
        public string RexAccessKey { get; set; }

        /// <summary>
        /// rex平台accessSign
        /// </summary>
        public string RexAccessSecrect { get; set; }

        #region ITopRequest Members

        public override string GetApiName()
        {
            return "wdk.rex.device.iot.register";
        }

        public override IDictionary<string, string> GetParameters()
        {
            TopDictionary parameters = new TopDictionary();
            parameters.Add("appk", this.Appk);
            parameters.Add("device_id", this.DeviceId);
            parameters.Add("product_key", this.ProductKey);
            parameters.Add("rex_access_key", this.RexAccessKey);
            parameters.Add("rex_access_secrect", this.RexAccessSecrect);
            if (this.otherParams != null)
            {
                parameters.AddAll(this.otherParams);
            }
            return parameters;
        }

        public override void Validate()
        {
            RequestValidator.ValidateRequired("device_id", this.DeviceId);
            RequestValidator.ValidateRequired("product_key", this.ProductKey);
        }

        #endregion
    }
}
