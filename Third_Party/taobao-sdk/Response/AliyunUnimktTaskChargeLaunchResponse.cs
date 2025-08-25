using System;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace Top.Api.Response
{
    /// <summary>
    /// AliyunUnimktTaskChargeLaunchResponse.
    /// </summary>
    public class AliyunUnimktTaskChargeLaunchResponse : TopResponse
    {
        /// <summary>
        /// 错误消息
        /// </summary>
        [XmlElement("error_msg")]
        public string ErrorMsg { get; set; }

        /// <summary>
        /// 任务结果
        /// </summary>
        [XmlElement("result")]
        public string Result { get; set; }

        /// <summary>
        /// 错误码
        /// </summary>
        [XmlElement("task_error_code")]
        public long TaskErrorCode { get; set; }

        /// <summary>
        /// 执行结果
        /// </summary>
        [XmlElement("task_success")]
        public bool TaskSuccess { get; set; }

    }
}
