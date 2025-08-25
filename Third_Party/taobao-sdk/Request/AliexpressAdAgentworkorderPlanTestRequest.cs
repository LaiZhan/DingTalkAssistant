using System;
using System.Collections.Generic;
using Top.Api.Util;

namespace Top.Api.Request
{
    /// <summary>
    /// TOP API: aliexpress.ad.agentworkorder.plan.test
    /// </summary>
    public class AliexpressAdAgentworkorderPlanTestRequest : BaseTopRequest<Top.Api.Response.AliexpressAdAgentworkorderPlanTestResponse>
    {
        #region ITopRequest Members

        public override string GetApiName()
        {
            return "aliexpress.ad.agentworkorder.plan.test";
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
