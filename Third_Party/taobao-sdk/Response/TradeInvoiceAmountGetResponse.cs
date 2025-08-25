using System;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace Top.Api.Response
{
    /// <summary>
    /// TradeInvoiceAmountGetResponse.
    /// </summary>
    public class TradeInvoiceAmountGetResponse : TopResponse
    {
        /// <summary>
        /// 应开票给消费者的金额，单位分
        /// </summary>
        [XmlElement("consumer_invoice_amount")]
        public string ConsumerInvoiceAmount { get; set; }

        /// <summary>
        /// 应开票给平台的金额，单位分
        /// </summary>
        [XmlElement("platform_invoice_amount")]
        public string PlatformInvoiceAmount { get; set; }

    }
}
