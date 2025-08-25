using System;
using System.Collections.Generic;
using Top.Api.Util;

namespace Top.Api.Request
{
    /// <summary>
    /// TOP API: taobao.openmall.refund.message.get
    /// </summary>
    public class OpenmallRefundMessageGetRequest : BaseTopRequest<Top.Api.Response.OpenmallRefundMessageGetResponse>
    {
        /// <summary>
        /// 分销者身份
        /// </summary>
        public string Distributor { get; set; }

        /// <summary>
        /// 翻页页码
        /// </summary>
        public Nullable<long> PageNo { get; set; }

        /// <summary>
        /// 翻页大小
        /// </summary>
        public Nullable<long> PageSize { get; set; }

        /// <summary>
        /// 退款单号
        /// </summary>
        public Nullable<long> RefundId { get; set; }

        #region ITopRequest Members

        public override string GetApiName()
        {
            return "taobao.openmall.refund.message.get";
        }

        public override IDictionary<string, string> GetParameters()
        {
            TopDictionary parameters = new TopDictionary();
            parameters.Add("distributor", this.Distributor);
            parameters.Add("page_no", this.PageNo);
            parameters.Add("page_size", this.PageSize);
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
