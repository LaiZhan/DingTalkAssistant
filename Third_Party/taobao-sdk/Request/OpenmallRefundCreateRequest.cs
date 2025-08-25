using System;
using System.Collections.Generic;
using Top.Api.Util;

namespace Top.Api.Request
{
    /// <summary>
    /// TOP API: taobao.openmall.refund.create
    /// </summary>
    public class OpenmallRefundCreateRequest : BaseTopRequest<Top.Api.Response.OpenmallRefundCreateResponse>
    {
        /// <summary>
        /// 分销者联盟身份
        /// </summary>
        public string Distributor { get; set; }

        /// <summary>
        /// 货品状态，可选值 BUYER_NOT_RECEIVED（买家未收到货）、BUYER_RECEIVED（买家已收到货）、UNSHIPPED（未发货）
        /// </summary>
        public string GoodsStatus { get; set; }

        /// <summary>
        /// 买家的退货描述
        /// </summary>
        public string RefundDesc { get; set; }

        /// <summary>
        /// 退款金额，分
        /// </summary>
        public Nullable<long> RefundFee { get; set; }

        /// <summary>
        /// 退款类别，可选值OTHER_REASON（其他）、SEVEN_DAYS_WITHOUT_REASON（7天无理由，不退邮费）
        /// </summary>
        public string RefundReason { get; set; }

        /// <summary>
        /// 退款类型，可选值refund（仅退款）、return_and_refund（退款退货）
        /// </summary>
        public string RefundType { get; set; }

        /// <summary>
        /// 订单号
        /// </summary>
        public Nullable<long> Tid { get; set; }

        #region ITopRequest Members

        public override string GetApiName()
        {
            return "taobao.openmall.refund.create";
        }

        public override IDictionary<string, string> GetParameters()
        {
            TopDictionary parameters = new TopDictionary();
            parameters.Add("distributor", this.Distributor);
            parameters.Add("goods_status", this.GoodsStatus);
            parameters.Add("refund_desc", this.RefundDesc);
            parameters.Add("refund_fee", this.RefundFee);
            parameters.Add("refund_reason", this.RefundReason);
            parameters.Add("refund_type", this.RefundType);
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
            RequestValidator.ValidateRequired("goods_status", this.GoodsStatus);
            RequestValidator.ValidateRequired("refund_desc", this.RefundDesc);
            RequestValidator.ValidateMaxLength("refund_desc", this.RefundDesc, 180);
            RequestValidator.ValidateRequired("refund_fee", this.RefundFee);
            RequestValidator.ValidateRequired("refund_reason", this.RefundReason);
            RequestValidator.ValidateRequired("refund_type", this.RefundType);
            RequestValidator.ValidateRequired("tid", this.Tid);
        }

        #endregion
    }
}
