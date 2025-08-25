using System;
using System.Collections.Generic;
using Top.Api.Util;

namespace Top.Api.Request
{
    /// <summary>
    /// TOP API: taobao.top.appinfo.get
    /// </summary>
    public class TopAppinfoGetRequest : BaseTopRequest<Top.Api.Response.TopAppinfoGetResponse>
    {
        /// <summary>
        /// 查询应用信息的appkey
        /// </summary>
        public string Appkey { get; set; }

        #region ITopRequest Members

        public override string GetApiName()
        {
            return "taobao.top.appinfo.get";
        }

        public override IDictionary<string, string> GetParameters()
        {
            TopDictionary parameters = new TopDictionary();
            parameters.Add("appkey", this.Appkey);
            if (this.otherParams != null)
            {
                parameters.AddAll(this.otherParams);
            }
            return parameters;
        }

        public override void Validate()
        {
            RequestValidator.ValidateRequired("appkey", this.Appkey);
        }

        #endregion
    }
}
