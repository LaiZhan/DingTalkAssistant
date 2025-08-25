using System;
using System.Collections.Generic;
using Top.Api.Util;

namespace Top.Api.Request
{
    /// <summary>
    /// TOP API: taobao.oauth.code.create
    /// </summary>
    public class OauthCodeCreateRequest : BaseTopRequest<Top.Api.Response.OauthCodeCreateResponse>
    {
        /// <summary>
        /// mock param
        /// </summary>
        public Nullable<long> Test { get; set; }

        #region ITopRequest Members

        public override string GetApiName()
        {
            return "taobao.oauth.code.create";
        }

        public override IDictionary<string, string> GetParameters()
        {
            TopDictionary parameters = new TopDictionary();
            parameters.Add("test", this.Test);
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
