using System;
using System.Collections.Generic;
using Top.Api.Util;

namespace Top.Api.Request
{
    /// <summary>
    /// TOP API: wdk.rex.wot.event.post
    /// </summary>
    public class WdkRexWotEventPostRequest : BaseTopRequest<Top.Api.Response.WdkRexWotEventPostResponse>
    {
        /// <summary>
        /// 业务key
        /// </summary>
        public string AccessKey { get; set; }

        /// <summary>
        /// 业务签名
        /// </summary>
        public string AccessSign { get; set; }

        /// <summary>
        /// 具体数据
        /// </summary>
        public string Data { get; set; }

        /// <summary>
        /// 物模型uri
        /// </summary>
        public string Href { get; set; }

        /// <summary>
        /// 设备ID
        /// </summary>
        public string Uuid { get; set; }

        /// <summary>
        /// 物模型方法
        /// </summary>
        public string WotMethod { get; set; }

        #region ITopRequest Members

        public override string GetApiName()
        {
            return "wdk.rex.wot.event.post";
        }

        public override IDictionary<string, string> GetParameters()
        {
            TopDictionary parameters = new TopDictionary();
            parameters.Add("access_key", this.AccessKey);
            parameters.Add("access_sign", this.AccessSign);
            parameters.Add("data", this.Data);
            parameters.Add("href", this.Href);
            parameters.Add("uuid", this.Uuid);
            parameters.Add("wot_method", this.WotMethod);
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
            RequestValidator.ValidateRequired("data", this.Data);
            RequestValidator.ValidateRequired("href", this.Href);
            RequestValidator.ValidateRequired("uuid", this.Uuid);
            RequestValidator.ValidateRequired("wot_method", this.WotMethod);
        }

        #endregion
    }
}
