using System;
using System.Collections.Generic;
using Top.Api.Util;

namespace Top.Api.Request
{
    /// <summary>
    /// TOP API: taobao.openmall.refund.close
    /// </summary>
    public class OpenmallRefundCloseRequest : BaseTopRequest<Top.Api.Response.OpenmallRefundCloseResponse>
    {
        /// <summary>
        /// 渠道
        /// </summary>
        public string Distributor { get; set; }

        /// <summary>
        /// 退款ID
        /// </summary>
        public Nullable<long> RefundId { get; set; }

        #region ITopRequest Members

        public override string GetApiName()
        {
            return "taobao.openmall.refund.close";
        }

        public override IDictionary<string, string> GetParameters()
        {
            TopDictionary parameters = new TopDictionary();
            parameters.Add("distributor", this.Distributor);
            parameters.Add("refund_id", this.RefundId);
            if (this.otherParams != null)
            {
                parameters.AddAll(this.otherParams);
            }
            return parameters;
        }

        public override void Validate()
        {
            RequestValidator.ValidateRequired("distributor", this.Distributor);
            RequestValidator.ValidateRequired("refund_id", this.RefundId);
        }

        #endregion
    }
}
