using System;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace Top.Api.Response
{
    /// <summary>
    /// OpenmallTradeConfirmResponse.
    /// </summary>
    public class OpenmallTradeConfirmResponse : TopResponse
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
	        /// 淘宝交易单ID
	        /// </summary>
	        [XmlElement("tid")]
	        public string Tid { get; set; }
}

    }
}
