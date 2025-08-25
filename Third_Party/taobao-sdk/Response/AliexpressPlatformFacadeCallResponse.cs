using System;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace Top.Api.Response
{
    /// <summary>
    /// AliexpressPlatformFacadeCallResponse.
    /// </summary>
    public class AliexpressPlatformFacadeCallResponse : TopResponse
    {
        /// <summary>
        /// Response body
        /// </summary>
        [XmlElement("res_body")]
        public string ResBody { get; set; }

        /// <summary>
        /// Response http status code
        /// </summary>
        [XmlElement("res_code")]
        public long ResCode { get; set; }

        /// <summary>
        /// Response headers: Map<String, List<String>>?
        /// </summary>
        [XmlElement("res_headers")]
        public string ResHeaders { get; set; }

    }
}
