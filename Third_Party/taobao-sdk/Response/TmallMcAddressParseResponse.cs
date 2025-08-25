using System;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace Top.Api.Response
{
    /// <summary>
    /// TmallMcAddressParseResponse.
    /// </summary>
    public class TmallMcAddressParseResponse : TopResponse
    {
        /// <summary>
        /// JSON格式地址信息
        /// </summary>
        [XmlElement("data")]
        public string Data { get; set; }

    }
}
