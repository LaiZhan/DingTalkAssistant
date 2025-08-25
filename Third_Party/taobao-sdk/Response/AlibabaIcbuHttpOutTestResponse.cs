using System;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace Top.Api.Response
{
    /// <summary>
    /// AlibabaIcbuHttpOutTestResponse.
    /// </summary>
    public class AlibabaIcbuHttpOutTestResponse : TopResponse
    {
        /// <summary>
        /// 1
        /// </summary>
        [XmlElement("test")]
        public string Test { get; set; }

    }
}
