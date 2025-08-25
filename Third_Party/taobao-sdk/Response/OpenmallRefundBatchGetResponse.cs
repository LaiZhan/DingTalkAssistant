using System;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace Top.Api.Response
{
    /// <summary>
    /// OpenmallRefundBatchGetResponse.
    /// </summary>
    public class OpenmallRefundBatchGetResponse : TopResponse
    {
        /// <summary>
        /// 退款列表
        /// </summary>
        [XmlArray("entities")]
        [XmlArrayItem("top_refund_vo")]
        public List<TopRefundVoDomain> Entities { get; set; }

        /// <summary>
        /// 范围内总的退款单个数
        /// </summary>
        [XmlElement("total_count")]
        public long TotalCount { get; set; }

	/// <summary>
/// TopRefundVoDomain Data Structure.
/// </summary>
[Serializable]

public class TopRefundVoDomain : TopObject
{
	        /// <summary>
	        /// 退款单创建时间
	        /// </summary>
	        [XmlElement("created")]
	        public string Created { get; set; }
	
	        /// <summary>
	        /// 请求退款金额
	        /// </summary>
	        [XmlElement("refund_fee")]
	        public string RefundFee { get; set; }
	
	        /// <summary>
	        /// 退款单ID
	        /// </summary>
	        [XmlElement("refund_id")]
	        public long RefundId { get; set; }
	
	        /// <summary>
	        /// 退款单状态，此接口存在延迟，详情参考taobao.openmall.refund.get
	        /// </summary>
	        [XmlElement("status")]
	        public string Status { get; set; }
	
	        /// <summary>
	        /// 对应订单ID
	        /// </summary>
	        [XmlElement("tid")]
	        public long Tid { get; set; }
}

    }
}
