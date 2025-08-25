using System;
using System.Collections.Generic;
using Top.Api.Util;

namespace Top.Api.Request
{
    /// <summary>
    /// TOP API: wdk.rex.user.org.fetch
    /// </summary>
    public class WdkRexUserOrgFetchRequest : BaseTopRequest<Top.Api.Response.WdkRexUserOrgFetchResponse>
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
        /// 账号ID（非淘系）
        /// </summary>
        public Nullable<long> AccountId { get; set; }

        /// <summary>
        /// 角色CODE
        /// </summary>
        public string RoleCode { get; set; }

        #region ITopRequest Members

        public override string GetApiName()
        {
            return "wdk.rex.user.org.fetch";
        }

        public override IDictionary<string, string> GetParameters()
        {
            TopDictionary parameters = new TopDictionary();
            parameters.Add("access_key", this.AccessKey);
            parameters.Add("access_sign", this.AccessSign);
            parameters.Add("account_id", this.AccountId);
            parameters.Add("role_code", this.RoleCode);
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
            RequestValidator.ValidateRequired("account_id", this.AccountId);
            RequestValidator.ValidateRequired("role_code", this.RoleCode);
        }

        #endregion
    }
}
