using System;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace Top.Api.Response
{
    /// <summary>
    /// JdsTradeTracesGetResponse.
    /// </summary>
    public class JdsTradeTracesGetResponse : TopResponse
    {
        /// <summary>
        /// 跟踪信息列表
        /// </summary>
        [XmlArray("traces")]
        [XmlArrayItem("trade_trace")]
        public List<Top.Api.Domain.TradeTrace> Traces { get; set; }

        /// <summary>
        /// 在订单全链路系统中的状态(比如是否存在)
        /// </summary>
        [XmlElement("user_status")]
        public string UserStatus { get; set; }

    }
}
