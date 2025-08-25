using System;
using System.Collections.Generic;
using Top.Api.Util;

namespace Top.Api.Request
{
    /// <summary>
    /// TOP API: alibaba.open.accountid.get
    /// </summary>
    public class AlibabaOpenAccountidGetRequest : BaseTopRequest<Top.Api.Response.AlibabaOpenAccountidGetResponse>
    {
        #region ITopRequest Members

        public override string GetApiName()
        {
            return "alibaba.open.accountid.get";
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
