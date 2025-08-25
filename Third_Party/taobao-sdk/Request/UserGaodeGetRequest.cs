using System;
using System.Collections.Generic;
using Top.Api.Util;

namespace Top.Api.Request
{
    /// <summary>
    /// TOP API: taobao.user.gaode.get
    /// </summary>
    public class UserGaodeGetRequest : BaseTopRequest<Top.Api.Response.UserGaodeGetResponse>
    {
        #region ITopRequest Members

        public override string GetApiName()
        {
            return "taobao.user.gaode.get";
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
