using System;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace Top.Api.Response
{
    /// <summary>
    /// TmallMcUserPromotionSyncResponse.
    /// </summary>
    public class TmallMcUserPromotionSyncResponse : TopResponse
    {
        /// <summary>
        /// 同步结果
        /// </summary>
        [XmlElement("data")]
        public bool Data { get; set; }

    }
}
