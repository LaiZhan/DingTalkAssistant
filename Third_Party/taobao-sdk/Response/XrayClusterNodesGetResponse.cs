using System;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace Top.Api.Response
{
    /// <summary>
    /// XrayClusterNodesGetResponse.
    /// </summary>
    public class XrayClusterNodesGetResponse : TopResponse
    {
        /// <summary>
        /// BODY
        /// </summary>
        [XmlElement("result")]
        public string Result { get; set; }

    }
}
