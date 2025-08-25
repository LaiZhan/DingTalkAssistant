using System;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace Top.Api.Response
{
    /// <summary>
    /// ItemCarturlGetResponse.
    /// </summary>
    public class ItemCarturlGetResponse : TopResponse
    {
        /// <summary>
        /// 加购的URL地址
        /// </summary>
        [XmlElement("result")]
        public string Result { get; set; }

    }
}
