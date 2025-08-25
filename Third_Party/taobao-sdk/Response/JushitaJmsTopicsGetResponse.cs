using System;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace Top.Api.Response
{
    /// <summary>
    /// JushitaJmsTopicsGetResponse.
    /// </summary>
    public class JushitaJmsTopicsGetResponse : TopResponse
    {
        /// <summary>
        /// 错误码
        /// </summary>
        [XmlElement("result_code")]
        public string ResultCode { get; set; }

        /// <summary>
        /// 错误信息
        /// </summary>
        [XmlElement("result_message")]
        public string ResultMessage { get; set; }

        /// <summary>
        /// topic列表
        /// </summary>
        [XmlArray("results")]
        [XmlArrayItem("string")]
        public List<string> Results { get; set; }

    }
}
