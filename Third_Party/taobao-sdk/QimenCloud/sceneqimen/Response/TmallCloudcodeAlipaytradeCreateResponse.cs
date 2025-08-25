using System;
using System.Xml.Serialization;
using System.Collections.Generic;
using Top.Api;


namespace QimenCloud.Api.sceneqimen.Response
{
    /// <summary>
    /// TmallCloudcodeAlipaytradeCreateResponse.
    /// </summary>
    public class TmallCloudcodeAlipaytradeCreateResponse : QimenCloudResponse
    {
        /// <summary>
        /// 错误码
        /// </summary>
        [XmlElement("errorCode")]
        public string ErrorCode { get; set; }

        /// <summary>
        /// 错误信息
        /// </summary>
        [XmlElement("errorMsg")]
        public string ErrorMsg { get; set; }

        /// <summary>
        /// 支付宝订单结果
        /// </summary>
        [XmlElement("result")]
        public AlipayTradeDomain Result { get; set; }

        /// <summary>
        /// 业务是否成功
        /// </summary>
        [XmlElement("success")]
        public bool Success { get; set; }

	/// <summary>
/// AlipayTradeDomain Data Structure.
/// </summary>
[Serializable]

public class AlipayTradeDomain : TopObject
{
	        /// <summary>
	        /// 支付宝订单号
	        /// </summary>
	        [XmlElement("aliPayOrderId")]
	        public string AliPayOrderId { get; set; }
	
	        /// <summary>
	        /// 支付宝订单金额
	        /// </summary>
	        [XmlElement("aliPayPrice")]
	        public string AliPayPrice { get; set; }
}

    }
}
