using System;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace Top.Api.Response
{
    /// <summary>
    /// WdkRexUserOrgFetchResponse.
    /// </summary>
    public class WdkRexUserOrgFetchResponse : TopResponse
    {
        /// <summary>
        /// 有权限的机构codes
        /// </summary>
        [XmlArray("data")]
        [XmlArrayItem("string")]
        public List<string> Data { get; set; }

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
        /// 成功状态
        /// </summary>
        [XmlElement("succeed")]
        public bool Succeed { get; set; }

    }
}
