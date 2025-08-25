using System;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace Top.Api.Response
{
    /// <summary>
    /// TmallMcDeviceRegistResponse.
    /// </summary>
    public class TmallMcDeviceRegistResponse : TopResponse
    {
        /// <summary>
        /// 平台设备编码
        /// </summary>
        [XmlElement("data")]
        public string Data { get; set; }

    }
}
