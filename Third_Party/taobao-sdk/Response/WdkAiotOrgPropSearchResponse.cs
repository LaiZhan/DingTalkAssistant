using System;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace Top.Api.Response
{
    /// <summary>
    /// WdkAiotOrgPropSearchResponse.
    /// </summary>
    public class WdkAiotOrgPropSearchResponse : TopResponse
    {
        /// <summary>
        /// 结果封装
        /// </summary>
        [XmlElement("result")]
        public IotResultDomain Result { get; set; }

	/// <summary>
/// IotResultDomain Data Structure.
/// </summary>
[Serializable]

public class IotResultDomain : TopObject
{
	        /// <summary>
	        /// 结果数据
	        /// </summary>
	        [XmlElement("data")]
	        public string Data { get; set; }
	
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
	        [XmlElement("success")]
	        public bool Success { get; set; }
}

    }
}
