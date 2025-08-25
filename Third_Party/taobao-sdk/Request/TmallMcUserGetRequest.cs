using System;
using System.Collections.Generic;
using Top.Api.Util;

namespace Top.Api.Request
{
    /// <summary>
    /// TOP API: tmall.mc.user.get
    /// </summary>
    public class TmallMcUserGetRequest : BaseTopRequest<Top.Api.Response.TmallMcUserGetResponse>
    {
        /// <summary>
        /// 品牌用户ID
        /// </summary>
        public string BrandUserId { get; set; }

        /// <summary>
        /// 代理商商户ID
        /// </summary>
        public string ProxyUserId { get; set; }

        #region ITopRequest Members

        public override string GetApiName()
        {
            return "tmall.mc.user.get";
        }

        public override IDictionary<string, string> GetParameters()
        {
            TopDictionary parameters = new TopDictionary();
            parameters.Add("brand_user_id", this.BrandUserId);
            parameters.Add("proxy_user_id", this.ProxyUserId);
            if (this.otherParams != null)
            {
                parameters.AddAll(this.otherParams);
            }
            return parameters;
        }

        public override void Validate()
        {
            RequestValidator.ValidateRequired("brand_user_id", this.BrandUserId);
            RequestValidator.ValidateRequired("proxy_user_id", this.ProxyUserId);
        }

        #endregion
    }
}
