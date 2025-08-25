using System;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace Top.Api.Response
{
    /// <summary>
    /// SmartappSmartformDataWriteResponse.
    /// </summary>
    public class SmartappSmartformDataWriteResponse : TopResponse
    {
        /// <summary>
        /// 操作数据ID
        /// </summary>
        [XmlElement("record_id")]
        public string RecordId { get; set; }

    }
}
