using System;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace Top.Api.Response
{
    /// <summary>
    /// OpenmallTradeCloseResponse.
    /// </summary>
    public class OpenmallTradeCloseResponse : TopResponse
    {
        /// <summary>
        /// 出参
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
	        /// 淘宝交易ID
	        /// </summary>
	        [XmlElement("tid")]
	        public string Tid { get; set; }
}

    }
}
