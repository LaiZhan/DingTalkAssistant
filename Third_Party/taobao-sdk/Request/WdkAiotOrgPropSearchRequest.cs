using System;
using System.Collections.Generic;
using Top.Api.Util;

namespace Top.Api.Request
{
    /// <summary>
    /// TOP API: wdk.aiot.org.prop.search
    /// </summary>
    public class WdkAiotOrgPropSearchRequest : BaseTopRequest<Top.Api.Response.WdkAiotOrgPropSearchResponse>
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
        /// 要查询的机构编码
        /// </summary>
        public string Keywords { get; set; }

        #region ITopRequest Members

        public override string GetApiName()
        {
            return "wdk.aiot.org.prop.search";
        }

        public override IDictionary<string, string> GetParameters()
        {
            TopDictionary parameters = new TopDictionary();
            parameters.Add("access_key", this.AccessKey);
            parameters.Add("access_sign", this.AccessSign);
            parameters.Add("keywords", this.Keywords);
            if (this.otherParams != null)
            {
                parameters.AddAll(this.otherParams);
            }
            return parameters;
        }

        public override void Validate()
        {
        }

        #endregion
    }
}
