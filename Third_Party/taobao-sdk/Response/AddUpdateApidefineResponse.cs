using System;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace Top.Api.Response
{
    /// <summary>
    /// AddUpdateApidefineResponse.
    /// </summary>
    public class AddUpdateApidefineResponse : TopResponse
    {
        /// <summary>
        /// 结果状态
        /// </summary>
        [XmlElement("result")]
        public long Result { get; set; }

    }
}
