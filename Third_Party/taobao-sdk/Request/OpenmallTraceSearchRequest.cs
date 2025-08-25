using System;
using System.Collections.Generic;
using Top.Api.Util;

namespace Top.Api.Request
{
    /// <summary>
    /// TOP API: taobao.openmall.trace.search
    /// </summary>
    public class OpenmallTraceSearchRequest : BaseTopRequest<Top.Api.Response.OpenmallTraceSearchResponse>
    {
        /// <summary>
        /// 签约支付宝代扣的账号
        /// </summary>
        public string Distributor { get; set; }

        /// <summary>
        /// 淘宝订单编号
        /// </summary>
        public Nullable<long> Tid { get; set; }

        #region ITopRequest Members

        public override string GetApiName()
        {
            return "taobao.openmall.trace.search";
        }

        public override IDictionary<string, string> GetParameters()
        {
            TopDictionary parameters = new TopDictionary();
            parameters.Add("distributor", this.Distributor);
            parameters.Add("tid", this.Tid);
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
