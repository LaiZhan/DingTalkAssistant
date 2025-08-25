using System;
using System.Collections.Generic;
using Top.Api.Util;

namespace Top.Api.Request
{
    /// <summary>
    /// TOP API: alibaba.da.finorec.xianzhi
    /// </summary>
    public class AlibabaDaFinorecXianzhiRequest : BaseTopRequest<Top.Api.Response.AlibabaDaFinorecXianzhiResponse>
    {
        #region ITopRequest Members

        public override string GetApiName()
        {
            return "alibaba.da.finorec.xianzhi";
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
