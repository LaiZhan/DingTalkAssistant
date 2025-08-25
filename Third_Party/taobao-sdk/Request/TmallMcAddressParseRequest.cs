using System;
using System.Collections.Generic;
using Top.Api.Util;

namespace Top.Api.Request
{
    /// <summary>
    /// TOP API: tmall.mc.address.parse
    /// </summary>
    public class TmallMcAddressParseRequest : BaseTopRequest<Top.Api.Response.TmallMcAddressParseResponse>
    {
        /// <summary>
        /// 地址
        /// </summary>
        public string Address { get; set; }

        #region ITopRequest Members

        public override string GetApiName()
        {
            return "tmall.mc.address.parse";
        }

        public override IDictionary<string, string> GetParameters()
        {
            TopDictionary parameters = new TopDictionary();
            parameters.Add("address", this.Address);
            if (this.otherParams != null)
            {
                parameters.AddAll(this.otherParams);
            }
            return parameters;
        }

        public override void Validate()
        {
            RequestValidator.ValidateRequired("address", this.Address);
        }

        #endregion
    }
}
