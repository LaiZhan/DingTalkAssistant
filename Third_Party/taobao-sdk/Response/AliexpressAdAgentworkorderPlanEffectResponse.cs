using System;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace Top.Api.Response
{
    /// <summary>
    /// AliexpressAdAgentworkorderPlanEffectResponse.
    /// </summary>
    public class AliexpressAdAgentworkorderPlanEffectResponse : TopResponse
    {
        /// <summary>
        /// 数据对象，预留
        /// </summary>
        [XmlElement("data")]
        public string Data { get; set; }

        /// <summary>
        /// 错误码
        /// </summary>
        [XmlElement("result_code")]
        public string ResultCode { get; set; }

        /// <summary>
        /// 错误码描述
        /// </summary>
        [XmlElement("result_message")]
        public string ResultMessage { get; set; }

    }
}
