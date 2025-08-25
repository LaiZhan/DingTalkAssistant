using System;
using System.Collections.Generic;
using Top.Api.Util;

namespace Top.Api.Request
{
    /// <summary>
    /// TOP API: taobao.homeai.alg.housedata
    /// </summary>
    public class HomeaiAlgHousedataRequest : BaseTopRequest<Top.Api.Response.HomeaiAlgHousedataResponse>
    {
        #region ITopRequest Members

        public override string GetApiName()
        {
            return "taobao.homeai.alg.housedata";
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
