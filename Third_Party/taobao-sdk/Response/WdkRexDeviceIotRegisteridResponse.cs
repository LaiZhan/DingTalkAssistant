using System;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace Top.Api.Response
{
    /// <summary>
    /// WdkRexDeviceIotRegisteridResponse.
    /// </summary>
    public class WdkRexDeviceIotRegisteridResponse : TopResponse
    {
        /// <summary>
        /// 结果
        /// </summary>
        [XmlElement("result")]
        public IotResultDomain Result { get; set; }

	/// <summary>
/// IotRegisterResultDomain Data Structure.
/// </summary>
[Serializable]

public class IotRegisterResultDomain : TopObject
{
	        /// <summary>
	        /// device_name
	        /// </summary>
	        [XmlElement("device_name")]
	        public string DeviceName { get; set; }
	
	        /// <summary>
	        /// device_secret
	        /// </summary>
	        [XmlElement("device_secret")]
	        public string DeviceSecret { get; set; }
	
	        /// <summary>
	        /// pk
	        /// </summary>
	        [XmlElement("product_key")]
	        public string ProductKey { get; set; }
}

	/// <summary>
/// IotResultDomain Data Structure.
/// </summary>
[Serializable]

public class IotResultDomain : TopObject
{
	        /// <summary>
	        /// 数据
	        /// </summary>
	        [XmlElement("data")]
	        public IotRegisterResultDomain Data { get; set; }
	
	        /// <summary>
	        /// code
	        /// </summary>
	        [XmlElement("msg_code")]
	        public string MsgCode { get; set; }
	
	        /// <summary>
	        /// 信息
	        /// </summary>
	        [XmlElement("msg_info")]
	        public string MsgInfo { get; set; }
	
	        /// <summary>
	        /// 结果
	        /// </summary>
	        [XmlElement("success")]
	        public bool Success { get; set; }
}

    }
}
