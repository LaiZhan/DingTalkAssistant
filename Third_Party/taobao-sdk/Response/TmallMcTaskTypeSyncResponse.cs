using System;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace Top.Api.Response
{
    /// <summary>
    /// TmallMcTaskTypeSyncResponse.
    /// </summary>
    public class TmallMcTaskTypeSyncResponse : TopResponse
    {
        /// <summary>
        /// 同步是否成功
        /// </summary>
        [XmlElement("data")]
        public bool Data { get; set; }

    }
}
