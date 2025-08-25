using System;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace Top.Api.Response
{
    /// <summary>
    /// UserGaodeGetResponse.
    /// </summary>
    public class UserGaodeGetResponse : TopResponse
    {
        /// <summary>
        /// 用户
        /// </summary>
        [XmlElement("user")]
        public Top.Api.Domain.User User { get; set; }

    }
}
