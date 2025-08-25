using System;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace Top.Api.Response
{
    /// <summary>
    /// JushitaJdpCommonQueryResponse.
    /// </summary>
    public class JushitaJdpCommonQueryResponse : TopResponse
    {
        /// <summary>
        /// 结果的json串
        /// </summary>
        [XmlElement("json_str")]
        public string JsonStr { get; set; }

    }
}
