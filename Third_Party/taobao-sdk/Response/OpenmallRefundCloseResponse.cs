using System;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace Top.Api.Response
{
    /// <summary>
    /// OpenmallRefundCloseResponse.
    /// </summary>
    public class OpenmallRefundCloseResponse : TopResponse
    {
        /// <summary>
        /// 是否关闭成功
        /// </summary>
        [XmlElement("result")]
        public bool Result { get; set; }

    }
}
