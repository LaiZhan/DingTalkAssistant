using System;
using System.Collections.Generic;
using Top.Api.Util;

namespace Top.Api.Request
{
    /// <summary>
    /// TOP API: taobao.user.identity.uc.get
    /// </summary>
    public class UserIdentityUcGetRequest : BaseTopRequest<Top.Api.Response.UserIdentityUcGetResponse>
    {
        #region ITopRequest Members

        public override string GetApiName()
        {
            return "taobao.user.identity.uc.get";
        }

        public override IDictionary<string, string> GetParameters()
        {
            TopDictionary parameters = new TopDictionary();
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
