using System;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace Top.Api.Response
{
    /// <summary>
    /// RarDatasQueryResponse.
    /// </summary>
    public class RarDatasQueryResponse : TopResponse
    {
        /// <summary>
        /// errorMsg
        /// </summary>
        [XmlElement("error_msg")]
        public string ErrorMsg { get; set; }

        /// <summary>
        /// results
        /// </summary>
        [XmlElement("results")]
        public string Results { get; set; }

        /// <summary>
        /// success
        /// </summary>
        [XmlElement("suc")]
        public bool Suc { get; set; }

    }
}
