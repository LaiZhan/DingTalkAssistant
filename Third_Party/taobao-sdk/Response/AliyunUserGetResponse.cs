using System;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace Top.Api.Response
{
    /// <summary>
    /// AliyunUserGetResponse.
    /// </summary>
    public class AliyunUserGetResponse : TopResponse
    {
        /// <summary>
        /// 账号信息
        /// </summary>
        [XmlElement("account")]
        public string Account { get; set; }

    }
}
