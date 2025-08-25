using System;
using System.Collections.Generic;
using Top.Api.Util;

namespace Top.Api.Request
{
    /// <summary>
    /// TOP API: wdk.rexout.device.info.get
    /// </summary>
    public class WdkRexoutDeviceInfoGetRequest : BaseTopRequest<Top.Api.Response.WdkRexoutDeviceInfoGetResponse>
    {
        /// <summary>
        /// ak
        /// </summary>
        public string AccessKey { get; set; }

        /// <summary>
        /// 签名
        /// </summary>
        public string AccessSign { get; set; }

        /// <summary>
        /// 设备ID
        /// </summary>
        public string Uuid { get; set; }

        #region ITopRequest Members

        public override string GetApiName()
        {
            return "wdk.rexout.device.info.get";
        }

        public override IDictionary<string, string> GetParameters()
        {
            TopDictionary parameters = new TopDictionary();
            parameters.Add("access_key", this.AccessKey);
            parameters.Add("access_sign", this.AccessSign);
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
