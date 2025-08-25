using System;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace Top.Api.Response
{
    /// <summary>
    /// TmallMcTaskConfigSyncResponse.
    /// </summary>
    public class TmallMcTaskConfigSyncResponse : TopResponse
    {
        /// <summary>
        /// 同步结果
        /// </summary>
        [XmlElement("data")]
        public bool Data { get; set; }

    }
}
