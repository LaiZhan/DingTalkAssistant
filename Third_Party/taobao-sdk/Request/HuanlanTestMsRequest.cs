using System;
using System.Collections.Generic;
using Top.Api.Util;

namespace Top.Api.Request
{
    /// <summary>
    /// TOP API: taobao.huanlan.test.ms
    /// </summary>
    public class HuanlanTestMsRequest : BaseTopRequest<Top.Api.Response.HuanlanTestMsResponse>
    {
        /// <summary>
        /// oauth 2.0 一次性 authCode
        /// </summary>
        public string Code { get; set; }

        #region ITopRequest Members

        public override string GetApiName()
        {
            return "taobao.huanlan.test.ms";
        }

        public override IDictionary<string, string> GetParameters()
        {
            TopDictionary parameters = new TopDictionary();
            parameters.Add("code", this.Code);
            if (this.otherParams != null)
            {
                parameters.AddAll(this.otherParams);
            }
            return parameters;
        }

        public override void Validate()
        {
            RequestValidator.ValidateRequired("code", this.Code);
        }

        #endregion
    }
}
