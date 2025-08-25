using System;
using System.Collections.Generic;
using Top.Api.Util;

namespace Top.Api.Request
{
    /// <summary>
    /// TOP API: alibaba.icbu.http.out.test
    /// </summary>
    public class AlibabaIcbuHttpOutTestRequest : BaseTopRequest<Top.Api.Response.AlibabaIcbuHttpOutTestResponse>
    {
        /// <summary>
        /// 1
        /// </summary>
        public string CoopId { get; set; }

        /// <summary>
        /// 1
        /// </summary>
        public string TbOrderNo { get; set; }

        /// <summary>
        /// 1
        /// </summary>
        public string Version { get; set; }

        #region ITopRequest Members

        public override string GetApiName()
        {
            return "alibaba.icbu.http.out.test";
        }

        public override IDictionary<string, string> GetParameters()
        {
            TopDictionary parameters = new TopDictionary();
            parameters.Add("coop_id", this.CoopId);
            parameters.Add("tb_order_no", this.TbOrderNo);
            parameters.Add("version", this.Version);
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
