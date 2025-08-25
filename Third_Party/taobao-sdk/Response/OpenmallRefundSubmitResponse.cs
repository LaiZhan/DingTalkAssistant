using System;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace Top.Api.Response
{
    /// <summary>
    /// OpenmallRefundSubmitResponse.
    /// </summary>
    public class OpenmallRefundSubmitResponse : TopResponse
    {
        /// <summary>
        /// 提交物流单成功
        /// </summary>
        [XmlElement("result")]
        public bool Result { get; set; }

    }
}
