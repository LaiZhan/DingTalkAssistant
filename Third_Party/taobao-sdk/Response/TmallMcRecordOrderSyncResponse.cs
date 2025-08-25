using System;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace Top.Api.Response
{
    /// <summary>
    /// TmallMcRecordOrderSyncResponse.
    /// </summary>
    public class TmallMcRecordOrderSyncResponse : TopResponse
    {
        /// <summary>
        /// 同步成功
        /// </summary>
        [XmlElement("data")]
        public bool Data { get; set; }

    }
}
