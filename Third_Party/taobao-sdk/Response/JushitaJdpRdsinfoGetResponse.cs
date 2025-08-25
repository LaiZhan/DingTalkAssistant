using System;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace Top.Api.Response
{
    /// <summary>
    /// JushitaJdpRdsinfoGetResponse.
    /// </summary>
    public class JushitaJdpRdsinfoGetResponse : TopResponse
    {
        /// <summary>
        /// app的rds列表
        /// </summary>
        [XmlArray("rds_list")]
        [XmlArrayItem("rds_config")]
        public List<Top.Api.Domain.RdsConfig> RdsList { get; set; }

    }
}
