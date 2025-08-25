using System;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace Top.Api.Response
{
    /// <summary>
    /// OpenmallTradeCreateResponse.
    /// </summary>
    public class OpenmallTradeCreateResponse : TopResponse
    {
        /// <summary>
        /// 返回结果
        /// </summary>
        [XmlElement("result")]
        public TopTradeResultVoDomain Result { get; set; }

	/// <summary>
/// TopTradeResultVoDomain Data Structure.
/// </summary>
[Serializable]

public class TopTradeResultVoDomain : TopObject
{
	        /// <summary>
	        /// 淘宝交易单号
	        /// </summary>
	        [XmlElement("tid")]
	        public string Tid { get; set; }
}

    }
}
