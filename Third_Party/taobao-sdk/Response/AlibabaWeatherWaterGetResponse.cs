using System;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace Top.Api.Response
{
    /// <summary>
    /// AlibabaWeatherWaterGetResponse.
    /// </summary>
    public class AlibabaWeatherWaterGetResponse : TopResponse
    {
        /// <summary>
        /// 监控站点的详细信息
        /// </summary>
        [XmlElement("monitor_station")]
        public Top.Api.Domain.Monitorstation MonitorStation { get; set; }

    }
}
