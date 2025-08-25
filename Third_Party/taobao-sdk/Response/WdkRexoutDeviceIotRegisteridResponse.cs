using System;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace Top.Api.Response
{
    /// <summary>
    /// WdkRexoutDeviceIotRegisteridResponse.
    /// </summary>
    public class WdkRexoutDeviceIotRegisteridResponse : TopResponse
    {
        /// <summary>
        /// 数据
        /// </summary>
        [XmlElement("data")]
        public IotRegisterResultDomain Data { get; set; }

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
        /// 结果
        /// </summary>
        [XmlElement("succeed")]
        public bool Succeed { get; set; }

	/// <summary>
/// IotRegisterResultDomain Data Structure.
/// </summary>
[Serializable]

public class IotRegisterResultDomain : TopObject
{
	        /// <summary>
	        /// 设备名称
	        /// </summary>
	        [XmlElement("device_name")]
	        public string DeviceName { get; set; }
	
	        /// <summary>
	        /// 设备Secret
	        /// </summary>
	        [XmlElement("device_secret")]
	        public string DeviceSecret { get; set; }
	
	        /// <summary>
	        /// 产品Key
	        /// </summary>
	        [XmlElement("product_key")]
	        public string ProductKey { get; set; }
}

    }
}
