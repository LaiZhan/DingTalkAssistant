using System;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace Top.Api.Response
{
    /// <summary>
    /// WakandaAicameraResponse.
    /// </summary>
    public class WakandaAicameraResponse : TopResponse
    {
        /// <summary>
        /// 返回信息
        /// </summary>
        [XmlElement("result")]
        public GetDeviceSecretFacadeDomain Result { get; set; }

	/// <summary>
/// GetDeviceSecretFacadeDomain Data Structure.
/// </summary>
[Serializable]

public class GetDeviceSecretFacadeDomain : TopObject
{
	        /// <summary>
	        /// 描述
	        /// </summary>
	        [XmlElement("data")]
	        public string Data { get; set; }
	
	        /// <summary>
	        /// 错误码
	        /// </summary>
	        [XmlElement("err_code")]
	        public long ErrCode { get; set; }
	
	        /// <summary>
	        /// 错误信息
	        /// </summary>
	        [XmlElement("err_msg")]
	        public string ErrMsg { get; set; }
	
	        /// <summary>
	        /// 成功状态
	        /// </summary>
	        [XmlElement("success")]
	        public string Success { get; set; }
	
	        /// <summary>
	        /// 时间戳
	        /// </summary>
	        [XmlElement("ts")]
	        public long Ts { get; set; }
}

    }
}
