using System;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace Top.Api.Response
{
    /// <summary>
    /// AlibabaBanmaTrackTaskAddResponse.
    /// </summary>
    public class AlibabaBanmaTrackTaskAddResponse : TopResponse
    {
        /// <summary>
        /// taskid
        /// </summary>
        [XmlElement("data")]
        public long Data { get; set; }

        /// <summary>
        /// message
        /// </summary>
        [XmlElement("message")]
        public string Message { get; set; }

        /// <summary>
        /// retcode
        /// </summary>
        [XmlElement("retcode")]
        public string Retcode { get; set; }

    }
}
