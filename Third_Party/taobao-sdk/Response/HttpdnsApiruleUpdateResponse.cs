using System;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace Top.Api.Response
{
    /// <summary>
    /// HttpdnsApiruleUpdateResponse.
    /// </summary>
    public class HttpdnsApiruleUpdateResponse : TopResponse
    {
        /// <summary>
        /// 操作结果
        /// </summary>
        [XmlElement("modal")]
        public bool Modal { get; set; }

    }
}
