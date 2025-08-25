using System;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace Top.Api.Response
{
    /// <summary>
    /// OsfbpmRobotTestResponse.
    /// </summary>
    public class OsfbpmRobotTestResponse : TopResponse
    {
        /// <summary>
        /// 错误码
        /// </summary>
        [XmlElement("error_codee")]
        public long ErrorCodee { get; set; }

        /// <summary>
        /// 错误信息
        /// </summary>
        [XmlElement("error_msge")]
        public string ErrorMsge { get; set; }

        /// <summary>
        /// 饿啊的
        /// </summary>
        [XmlElement("result")]
        public string Result { get; set; }

        /// <summary>
        /// 调用是否成功
        /// </summary>
        [XmlElement("successe")]
        public bool Successe { get; set; }

    }
}
