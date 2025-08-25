using System;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace Top.Api.Response
{
    /// <summary>
    /// JushitaJdpQueryBizResponse.
    /// </summary>
    public class JushitaJdpQueryBizResponse : TopResponse
    {
        /// <summary>
        /// 更新是否成功
        /// </summary>
        [XmlElement("result")]
        public string Result { get; set; }

    }
}
