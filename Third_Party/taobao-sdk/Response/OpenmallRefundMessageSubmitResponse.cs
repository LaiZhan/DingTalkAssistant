using System;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace Top.Api.Response
{
    /// <summary>
    /// OpenmallRefundMessageSubmitResponse.
    /// </summary>
    public class OpenmallRefundMessageSubmitResponse : TopResponse
    {
        /// <summary>
        /// 提交结果
        /// </summary>
        [XmlElement("result")]
        public bool Result { get; set; }

    }
}
