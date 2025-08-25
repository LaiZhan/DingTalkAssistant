using System;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace Top.Api.Response
{
    /// <summary>
    /// WdkRexWotEventPostResponse.
    /// </summary>
    public class WdkRexWotEventPostResponse : TopResponse
    {
        /// <summary>
        /// 数据结果
        /// </summary>
        [XmlElement("data")]
        public bool Data { get; set; }

        /// <summary>
        /// 错误码
        /// </summary>
        [XmlElement("msg_code")]
        public string MsgCode { get; set; }

        /// <summary>
        /// 错误信息
        /// </summary>
        [XmlElement("msg_info")]
        public string MsgInfo { get; set; }

        /// <summary>
        /// 请求结果
        /// </summary>
        [XmlElement("succeed")]
        public bool Succeed { get; set; }

    }
}
