using System;
using System.Collections.Generic;
using Top.Api.Util;

namespace Top.Api.Request
{
    /// <summary>
    /// TOP API: wdk.aiot.org.prop.parent
    /// </summary>
    public class WdkAiotOrgPropParentRequest : BaseTopRequest<Top.Api.Response.WdkAiotOrgPropParentResponse>
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
        /// 签名时间
        /// </summary>
        public string AccessTime { get; set; }

        /// <summary>
        /// 门店code
        /// </summary>
        public string OrgCode { get; set; }

        #region ITopRequest Members

        public override string GetApiName()
        {
            return "wdk.aiot.org.prop.parent";
        }

        public override IDictionary<string, string> GetParameters()
        {
            TopDictionary parameters = new TopDictionary();
            parameters.Add("access_key", this.AccessKey);
            parameters.Add("access_sign", this.AccessSign);
            parameters.Add("access_time", this.AccessTime);
            parameters.Add("org_code", this.OrgCode);
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
        }

        #endregion
    }
}
