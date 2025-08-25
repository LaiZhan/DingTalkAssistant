using System;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace Top.Api.Response
{
    /// <summary>
    /// OpenmallRefundModifyResponse.
    /// </summary>
    public class OpenmallRefundModifyResponse : TopResponse
    {
        /// <summary>
        /// 结果
        /// </summary>
        [XmlElement("result")]
        public bool Result { get; set; }

    }
}
