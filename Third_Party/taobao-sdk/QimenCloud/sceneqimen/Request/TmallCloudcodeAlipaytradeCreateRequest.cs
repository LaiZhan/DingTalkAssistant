using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using Top.Api.Util;
using Top.Api;

namespace QimenCloud.Api.sceneqimen.Request
{
    /// <summary>
    /// TOP API: tmall.cloudcode.alipaytrade.create
    /// </summary>
    public class TmallCloudcodeAlipaytradeCreateRequest : BaseQimenCloudRequest<QimenCloud.Api.sceneqimen.Response.TmallCloudcodeAlipaytradeCreateResponse>
    {
        /// <summary>
        /// 支付宝用户ID
        /// </summary>
        public string AlipayUid { get; set; }

        /// <summary>
        /// 设备平台编码
        /// </summary>
        public string DeviceCode { get; set; }

        /// <summary>
        /// 设备类型
        /// </summary>
        public string DeviceType { get; set; }

        /// <summary>
        /// 用户唯一编码
        /// </summary>
        public string HolderId { get; set; }

        /// <summary>
        /// 设备外部编码
        /// </summary>
        public string OuterCode { get; set; }

        /// <summary>
        /// 平台权益金额
        /// </summary>
        public string PromotionPrice { get; set; }

        /// <summary>
        /// 云码请求URL上的QueryString
        /// </summary>
        public string QueryStr { get; set; }

        /// <summary>
        /// 请求唯一ID
        /// </summary>
        public string Version { get; set; }

        #region IQimenCloudRequest Members

        public override string GetApiName()
        {
            return "tmall.cloudcode.alipaytrade.create";
        }
        
        public override IDictionary<string, string> GetParameters()
        {
            TopDictionary parameters = new TopDictionary();
            parameters.Add("alipayUid", this.AlipayUid);
            parameters.Add("deviceCode", this.DeviceCode);
            parameters.Add("deviceType", this.DeviceType);
            parameters.Add("holderId", this.HolderId);
            parameters.Add("outerCode", this.OuterCode);
            parameters.Add("promotionPrice", this.PromotionPrice);
            parameters.Add("queryStr", this.QueryStr);
            parameters.Add("version", this.Version);
            if (this.otherParams != null)
            {
                parameters.AddAll(this.otherParams);
            }
            return parameters;
        }

        public override void Validate()
        {
            RequestValidator.ValidateRequired("alipayUid", this.AlipayUid);
            RequestValidator.ValidateRequired("deviceCode", this.DeviceCode);
            RequestValidator.ValidateRequired("deviceType", this.DeviceType);
            RequestValidator.ValidateRequired("holderId", this.HolderId);
            RequestValidator.ValidateRequired("outerCode", this.OuterCode);
            RequestValidator.ValidateRequired("queryStr", this.QueryStr);
            RequestValidator.ValidateRequired("version", this.Version);
        }

        #endregion
    }
}
