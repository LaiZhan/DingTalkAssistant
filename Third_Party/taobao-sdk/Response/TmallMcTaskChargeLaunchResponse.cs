using System;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace Top.Api.Response
{
    /// <summary>
    /// TmallMcTaskChargeLaunchResponse.
    /// </summary>
    public class TmallMcTaskChargeLaunchResponse : TopResponse
    {
        /// <summary>
        /// 入会页url
        /// </summary>
        [XmlElement("result")]
        public string Result { get; set; }

    }
}
