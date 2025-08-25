using System;
using System.Collections.Generic;
using Top.Api.Util;

namespace Top.Api.Request
{
    /// <summary>
    /// TOP API: taobao.openmall.trade.close
    /// </summary>
    public class OpenmallTradeCloseRequest : BaseTopRequest<Top.Api.Response.OpenmallTradeCloseResponse>
    {
        /// <summary>
        /// 分销者信息
        /// </summary>
        public string Distributor { get; set; }

        /// <summary>
        /// 关单原因
        /// </summary>
        public string Reason { get; set; }

        /// <summary>
        /// 淘宝订单号
        /// </summary>
        public Nullable<long> Tid { get; set; }

        #region ITopRequest Members

        public override string GetApiName()
        {
            return "taobao.openmall.trade.close";
        }

        public override IDictionary<string, string> GetParameters()
        {
            TopDictionary parameters = new TopDictionary();
            parameters.Add("distributor", this.Distributor);
            parameters.Add("reason", this.Reason);
            parameters.Add("tid", this.Tid);
            if (this.otherParams != null)
            {
                parameters.AddAll(this.otherParams);
            }
            return parameters;
        }

        public override void Validate()
        {
            RequestValidator.ValidateRequired("distributor", this.Distributor);
            RequestValidator.ValidateRequired("reason", this.Reason);
            RequestValidator.ValidateRequired("tid", this.Tid);
        }

        #endregion
    }
}
