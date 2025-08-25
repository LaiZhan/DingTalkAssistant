using System;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace Top.Api.Response
{
    /// <summary>
    /// OpenmallTradeShipaddressUpdateResponse.
    /// </summary>
    public class OpenmallTradeShipaddressUpdateResponse : TopResponse
    {
        /// <summary>
        /// 订单号
        /// </summary>
        [XmlElement("tid")]
        public string Tid { get; set; }

    }
}
