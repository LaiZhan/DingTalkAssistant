using System;
using System.Collections.Generic;
using Top.Api.Util;

namespace Top.Api.Request
{
    /// <summary>
    /// TOP API: tmall.retail.store.create
    /// </summary>
    public class TmallRetailStoreCreateRequest : BaseTopRequest<Top.Api.Response.TmallRetailStoreCreateResponse>
    {
        #region ITopRequest Members

        public override string GetApiName()
        {
            return "tmall.retail.store.create";
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
