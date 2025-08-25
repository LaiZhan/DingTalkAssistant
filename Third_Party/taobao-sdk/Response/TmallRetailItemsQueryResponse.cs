using System;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace Top.Api.Response
{
    /// <summary>
    /// TmallRetailItemsQueryResponse.
    /// </summary>
    public class TmallRetailItemsQueryResponse : TopResponse
    {
        /// <summary>
        /// result
        /// </summary>
        [XmlElement("result")]
        public RopResultToDomain Result { get; set; }

	/// <summary>
/// RopResultToDomain Data Structure.
/// </summary>
[Serializable]

public class RopResultToDomain : TopObject
{
	        /// <summary>
	        /// alipayTradeId
	        /// </summary>
	        [XmlElement("alipay_trade_id")]
	        public string AlipayTradeId { get; set; }
	
	        /// <summary>
	        /// errorCode
	        /// </summary>
	        [XmlElement("error_code")]
	        public long ErrorCode { get; set; }
	
	        /// <summary>
	        /// errorMsg
	        /// </summary>
	        [XmlElement("error_msg")]
	        public string ErrorMsg { get; set; }
	
	        /// <summary>
	        /// itemId
	        /// </summary>
	        [XmlElement("item_id")]
	        public string ItemId { get; set; }
	
	        /// <summary>
	        /// logType
	        /// </summary>
	        [XmlElement("log_type")]
	        public string LogType { get; set; }
	
	        /// <summary>
	        /// outId1
	        /// </summary>
	        [XmlElement("out_id1")]
	        public string OutId1 { get; set; }
	
	        /// <summary>
	        /// outId2
	        /// </summary>
	        [XmlElement("out_id2")]
	        public string OutId2 { get; set; }
	
	        /// <summary>
	        /// outId3
	        /// </summary>
	        [XmlElement("out_id3")]
	        public string OutId3 { get; set; }
	
	        /// <summary>
	        /// outId4
	        /// </summary>
	        [XmlElement("out_id4")]
	        public string OutId4 { get; set; }
	
	        /// <summary>
	        /// outId5
	        /// </summary>
	        [XmlElement("out_id5")]
	        public string OutId5 { get; set; }
	
	        /// <summary>
	        /// result
	        /// </summary>
	        [XmlElement("result")]
	        public string Result { get; set; }
	
	        /// <summary>
	        /// success
	        /// </summary>
	        [XmlElement("success")]
	        public bool Success { get; set; }
	
	        /// <summary>
	        /// tradeId
	        /// </summary>
	        [XmlElement("trade_id")]
	        public string TradeId { get; set; }
	
	        /// <summary>
	        /// userId
	        /// </summary>
	        [XmlElement("user_id")]
	        public string UserId { get; set; }
}

    }
}
