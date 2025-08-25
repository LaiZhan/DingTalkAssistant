using System;
using System.Collections.Generic;
using Top.Api.Util;

namespace Top.Api.Request
{
    /// <summary>
    /// TOP API: taobao.openmall.refund.submit
    /// </summary>
    public class OpenmallRefundSubmitRequest : BaseTopRequest<Top.Api.Response.OpenmallRefundSubmitResponse>
    {
        /// <summary>
        /// 渠道
        /// </summary>
        public string Distributor { get; set; }

        /// <summary>
        /// 物流公司编码
        /// </summary>
        public string LogisticsCompanyCode { get; set; }

        /// <summary>
        /// 物流公司名称
        /// </summary>
        public string LogisticsCompanyName { get; set; }

        /// <summary>
        /// 快递单号
        /// </summary>
        public string LogisticsNo { get; set; }

        /// <summary>
        /// 退款单ID
        /// </summary>
        public Nullable<long> RefundId { get; set; }

        #region ITopRequest Members

        public override string GetApiName()
        {
            return "taobao.openmall.refund.submit";
        }

        public override IDictionary<string, string> GetParameters()
        {
            TopDictionary parameters = new TopDictionary();
            parameters.Add("distributor", this.Distributor);
            parameters.Add("logistics_company_code", this.LogisticsCompanyCode);
            parameters.Add("logistics_company_name", this.LogisticsCompanyName);
            parameters.Add("logistics_no", this.LogisticsNo);
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
            RequestValidator.ValidateRequired("logistics_company_code", this.LogisticsCompanyCode);
            RequestValidator.ValidateRequired("logistics_company_name", this.LogisticsCompanyName);
            RequestValidator.ValidateRequired("logistics_no", this.LogisticsNo);
            RequestValidator.ValidateRequired("refund_id", this.RefundId);
        }

        #endregion
    }
}
