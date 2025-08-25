using System;
using System.Xml.Serialization;
using System.Collections.Generic;
using Top.Api;


namespace QimenCloud.Api.sceneqimen.Response
{
    /// <summary>
    /// TmallCloudcodeBusinessNotifyResponse.
    /// </summary>
    public class TmallCloudcodeBusinessNotifyResponse : QimenCloudResponse
    {
        /// <summary>
        /// 错误码
        /// </summary>
        [XmlElement("errorCode")]
        public string ErrorCode { get; set; }

        /// <summary>
        /// 错误信息
        /// </summary>
        [XmlElement("errorMsg")]
        public string ErrorMsg { get; set; }

        /// <summary>
        /// 业务处理是否成功
        /// </summary>
        [XmlElement("success")]
        public bool Success { get; set; }

    }
}
