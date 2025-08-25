using System;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace Top.Api.Response
{
    /// <summary>
    /// OpenmallRefundCreateResponse.
    /// </summary>
    public class OpenmallRefundCreateResponse : TopResponse
    {
        /// <summary>
        /// 退款ID
        /// </summary>
        [XmlElement("refund_id")]
        public long RefundId { get; set; }

        /// <summary>
        /// 退款单状态
        /// </summary>
        [XmlElement("status")]
        public string Status { get; set; }

    }
}
