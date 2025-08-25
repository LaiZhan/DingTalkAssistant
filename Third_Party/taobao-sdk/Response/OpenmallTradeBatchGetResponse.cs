using System;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace Top.Api.Response
{
    /// <summary>
    /// OpenmallTradeBatchGetResponse.
    /// </summary>
    public class OpenmallTradeBatchGetResponse : TopResponse
    {
        /// <summary>
        /// 订单列表
        /// </summary>
        [XmlArray("entities")]
        [XmlArrayItem("top_trade_detail_vo")]
        public List<TopTradeDetailVoDomain> Entities { get; set; }

        /// <summary>
        /// 范围内总订单数
        /// </summary>
        [XmlElement("total_count")]
        public long TotalCount { get; set; }

	/// <summary>
/// TopTradeDetailVoDomain Data Structure.
/// </summary>
[Serializable]

public class TopTradeDetailVoDomain : TopObject
{
	        /// <summary>
	        /// 商品数量
	        /// </summary>
	        [XmlElement("num")]
	        public long Num { get; set; }
	
	        /// <summary>
	        /// 商品ID
	        /// </summary>
	        [XmlElement("num_iid")]
	        public long NumIid { get; set; }
	
	        /// <summary>
	        /// 外部outid
	        /// </summary>
	        [XmlElement("out_id")]
	        public string OutId { get; set; }
	
	        /// <summary>
	        /// 实付金额
	        /// </summary>
	        [XmlElement("payment")]
	        public string Payment { get; set; }
	
	        /// <summary>
	        /// 邮费
	        /// </summary>
	        [XmlElement("post_fee")]
	        public string PostFee { get; set; }
	
	        /// <summary>
	        /// 订单状态，该字段存在延迟，请参考taoboa.openmall.trade.get
	        /// </summary>
	        [XmlElement("status")]
	        public string Status { get; set; }
	
	        /// <summary>
	        /// 订单ID
	        /// </summary>
	        [XmlElement("tid")]
	        public long Tid { get; set; }
}

    }
}
