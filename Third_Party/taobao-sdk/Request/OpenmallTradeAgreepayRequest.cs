using System;
using System.Collections.Generic;
using Top.Api.Util;

namespace Top.Api.Request
{
    /// <summary>
    /// TOP API: taobao.openmall.trade.agreepay
    /// </summary>
    public class OpenmallTradeAgreepayRequest : BaseTopRequest<Top.Api.Response.OpenmallTradeAgreepayResponse>
    {
        /// <summary>
        /// 媒体渠道，代表分销者的身份，签约支付宝代扣的渠道商淘宝账号nick
        /// </summary>
        public string Distributor { get; set; }

        /// <summary>
        /// 淘宝交易单号
        /// </summary>
        public Nullable<long> Tid { get; set; }

        #region ITopRequest Members

        public override string GetApiName()
        {
            return "taobao.openmall.trade.agreepay";
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
            RequestValidator.ValidateRequired("distributor", this.Distributor);
            RequestValidator.ValidateRequired("tid", this.Tid);
        }

        #endregion
    }
}
