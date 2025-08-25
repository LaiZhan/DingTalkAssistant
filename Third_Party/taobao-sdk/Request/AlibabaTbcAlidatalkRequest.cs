using System;
using System.Collections.Generic;
using Top.Api.Util;

namespace Top.Api.Request
{
    /// <summary>
    /// TOP API: alibaba.tbc.alidatalk
    /// </summary>
    public class AlibabaTbcAlidatalkRequest : BaseTopRequest<Top.Api.Response.AlibabaTbcAlidatalkResponse>
    {
        #region ITopRequest Members

        public override string GetApiName()
        {
            return "alibaba.tbc.alidatalk";
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
