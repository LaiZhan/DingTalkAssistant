using System;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace Top.Api.Response
{
    /// <summary>
    /// TopapiPerformanceTestResponse.
    /// </summary>
    public class TopapiPerformanceTestResponse : TopResponse
    {
        /// <summary>
        /// errorCode
        /// </summary>
        [XmlElement("error_coder")]
        public string ErrorCoder { get; set; }

        /// <summary>
        /// errorMsg
        /// </summary>
        [XmlElement("error_msg")]
        public string ErrorMsg { get; set; }

        /// <summary>
        /// 123
        /// </summary>
        [XmlElement("last_modified")]
        public string LastModified { get; set; }

        /// <summary>
        /// 123
        /// </summary>
        [XmlArray("results")]
        [XmlArrayItem("string")]
        public List<string> Results { get; set; }

        /// <summary>
        /// 123
        /// </summary>
        [XmlElement("total_results")]
        public long TotalResults { get; set; }

    }
}
