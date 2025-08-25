using System;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace Top.Api.Response
{
    /// <summary>
    /// WdkAiotOrgPropParentResponse.
    /// </summary>
    public class WdkAiotOrgPropParentResponse : TopResponse
    {
        /// <summary>
        /// 机构树json
        /// </summary>
        [XmlElement("data")]
        public string Data { get; set; }

        /// <summary>
        /// 错误信息
        /// </summary>
        [XmlElement("msg_code")]
        public string MsgCode { get; set; }

        /// <summary>
        /// 错误码
        /// </summary>
        [XmlElement("msg_info")]
        public string MsgInfo { get; set; }

        /// <summary>
        /// 成功失败结果
        /// </summary>
        [XmlElement("succeed")]
        public bool Succeed { get; set; }

    }
}
