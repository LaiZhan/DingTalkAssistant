using System;
using System.Collections.Generic;
using Top.Api.Util;

namespace Top.Api.Request
{
    /// <summary>
    /// TOP API: taobao.openmall.trade.address.parse
    /// </summary>
    public class OpenmallTradeAddressParseRequest : BaseTopRequest<Top.Api.Response.OpenmallTradeAddressParseResponse>
    {
        /// <summary>
        /// 渠道商分销者淘宝账号
        /// </summary>
        public string Distributor { get; set; }

        /// <summary>
        /// 需解析的地址信息，建议只传地址选择器中的省市区，街道门牌号等用户手动输入数据不传
        /// </summary>
        public string RawAddress { get; set; }

        #region ITopRequest Members

        public override string GetApiName()
        {
            return "taobao.openmall.trade.address.parse";
        }

        public override IDictionary<string, string> GetParameters()
        {
            TopDictionary parameters = new TopDictionary();
            parameters.Add("distributor", this.Distributor);
            parameters.Add("raw_address", this.RawAddress);
            if (this.otherParams != null)
            {
                parameters.AddAll(this.otherParams);
            }
            return parameters;
        }

        public override void Validate()
        {
            RequestValidator.ValidateRequired("distributor", this.Distributor);
            RequestValidator.ValidateRequired("raw_address", this.RawAddress);
        }

        #endregion
    }
}
