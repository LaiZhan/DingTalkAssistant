using System;
using System.Collections.Generic;
using Top.Api.Util;

namespace Top.Api.Request
{
    /// <summary>
    /// TOP API: tmall.mc.record.order.sync
    /// </summary>
    public class TmallMcRecordOrderSyncRequest : BaseTopRequest<Top.Api.Response.TmallMcRecordOrderSyncResponse>
    {
        /// <summary>
        /// 设备编码
        /// </summary>
        public string DeviceCode { get; set; }

        /// <summary>
        /// 用户openId
        /// </summary>
        public string OpenId { get; set; }

        /// <summary>
        /// 原价
        /// </summary>
        public Nullable<long> OriginPrice { get; set; }

        /// <summary>
        /// 实付价
        /// </summary>
        public Nullable<long> PayPrice { get; set; }

        /// <summary>
        /// 核销结果
        /// </summary>
        public string Result { get; set; }

        /// <summary>
        /// 云码版本号
        /// </summary>
        public string Version { get; set; }

        #region ITopRequest Members

        public override string GetApiName()
        {
            return "tmall.mc.record.order.sync";
        }

        public override IDictionary<string, string> GetParameters()
        {
            TopDictionary parameters = new TopDictionary();
            parameters.Add("device_code", this.DeviceCode);
            parameters.Add("open_id", this.OpenId);
            parameters.Add("origin_price", this.OriginPrice);
            parameters.Add("pay_price", this.PayPrice);
            parameters.Add("result", this.Result);
            parameters.Add("version", this.Version);
            if (this.otherParams != null)
            {
                parameters.AddAll(this.otherParams);
            }
            return parameters;
        }

        public override void Validate()
        {
            RequestValidator.ValidateRequired("device_code", this.DeviceCode);
            RequestValidator.ValidateRequired("open_id", this.OpenId);
            RequestValidator.ValidateRequired("origin_price", this.OriginPrice);
            RequestValidator.ValidateRequired("pay_price", this.PayPrice);
            RequestValidator.ValidateRequired("result", this.Result);
            RequestValidator.ValidateRequired("version", this.Version);
        }

        #endregion
    }
}
