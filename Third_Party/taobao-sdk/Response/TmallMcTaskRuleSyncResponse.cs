using System;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace Top.Api.Response
{
    /// <summary>
    /// TmallMcTaskRuleSyncResponse.
    /// </summary>
    public class TmallMcTaskRuleSyncResponse : TopResponse
    {
        /// <summary>
        /// 同步结果
        /// </summary>
        [XmlElement("data")]
        public bool Data { get; set; }

    }
}
