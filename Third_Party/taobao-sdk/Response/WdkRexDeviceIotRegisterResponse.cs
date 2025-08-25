using System;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace Top.Api.Response
{
    /// <summary>
    /// WdkRexDeviceIotRegisterResponse.
    /// </summary>
    public class WdkRexDeviceIotRegisterResponse : TopResponse
    {
        /// <summary>
        /// 结果封装
        /// </summary>
        [XmlElement("result")]
        public MtopResponseDomain Result { get; set; }

	/// <summary>
/// IotRegisterResultDomain Data Structure.
/// </summary>
[Serializable]

public class IotRegisterResultDomain : TopObject
{
	        /// <summary>
	        /// 阿里云deviceName
	        /// </summary>
	        [XmlElement("device_name")]
	        public string DeviceName { get; set; }
	
	        /// <summary>
	        /// 阿里云deviceSecrect
	        /// </summary>
	        [XmlElement("device_secret")]
	        public string DeviceSecret { get; set; }
}

	/// <summary>
/// MtopResponseDomain Data Structure.
/// </summary>
[Serializable]

public class MtopResponseDomain : TopObject
{
	        /// <summary>
	        /// http头
	        /// </summary>
	        [XmlElement("headers")]
	        public string Headers { get; set; }
	
	        /// <summary>
	        /// http返回值
	        /// </summary>
	        [XmlElement("http_status_code")]
	        public long HttpStatusCode { get; set; }
	
	        /// <summary>
	        /// mtop字段
	        /// </summary>
	        [XmlElement("mapping_code")]
	        public string MappingCode { get; set; }
	
	        /// <summary>
	        /// 业务结果封装
	        /// </summary>
	        [XmlElement("model")]
	        public IotRegisterResultDomain Model { get; set; }
	
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
	        /// 成功与否
	        /// </summary>
	        [XmlElement("success")]
	        public bool Success { get; set; }
}

    }
}
