using System;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace Top.Api.Response
{
    /// <summary>
    /// TmallMcDeviceStatusDeleteResponse.
    /// </summary>
    public class TmallMcDeviceStatusDeleteResponse : TopResponse
    {
        /// <summary>
        /// 本次操作是否成功
        /// </summary>
        [XmlElement("data")]
        public bool Data { get; set; }

    }
}
