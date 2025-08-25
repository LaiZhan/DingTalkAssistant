using System;
using System.Collections.Generic;
using Top.Api.Util;

namespace Top.Api.Request
{
    /// <summary>
    /// TOP API: wdk.aiot.device.iot.upsert
    /// </summary>
    public class WdkAiotDeviceIotUpsertRequest : BaseTopRequest<Top.Api.Response.WdkAiotDeviceIotUpsertResponse>
    {
        /// <summary>
        /// 平台颁发key
        /// </summary>
        public string AccessKey { get; set; }

        /// <summary>
        /// 平台签名（规则见文档）
        /// </summary>
        public string AccessSign { get; set; }

        /// <summary>
        /// 签名时间
        /// </summary>
        public string AccessTime { get; set; }

        /// <summary>
        /// 上报设备数据内容（规则见文档）
        /// </summary>
        public string Content { get; set; }

        #region ITopRequest Members

        public override string GetApiName()
        {
            return "wdk.aiot.device.iot.upsert";
        }

        public override IDictionary<string, string> GetParameters()
        {
            TopDictionary parameters = new TopDictionary();
            parameters.Add("access_key", this.AccessKey);
            parameters.Add("access_sign", this.AccessSign);
            parameters.Add("access_time", this.AccessTime);
            parameters.Add("content", this.Content);
            if (this.otherParams != null)
            {
                parameters.AddAll(this.otherParams);
            }
            return parameters;
        }

        public override void Validate()
        {
            RequestValidator.ValidateRequired("access_key", this.AccessKey);
            RequestValidator.ValidateRequired("content", this.Content);
        }

        #endregion
    }
}
