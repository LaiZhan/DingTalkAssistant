using System;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace Top.Api.Response
{
    /// <summary>
    /// WdkRexDeviceInfoGetchildrenResponse.
    /// </summary>
    public class WdkRexDeviceInfoGetchildrenResponse : TopResponse
    {
        /// <summary>
        /// 返回结果
        /// </summary>
        [XmlElement("result")]
        public IotResultDomain Result { get; set; }

	/// <summary>
/// AiotOpenDeviceBaseDtoDomain Data Structure.
/// </summary>
[Serializable]

public class AiotOpenDeviceBaseDtoDomain : TopObject
{
	        /// <summary>
	        /// 设备类型
	        /// </summary>
	        [XmlElement("device_type")]
	        public string DeviceType { get; set; }
}

	/// <summary>
/// ItemlistDomain Data Structure.
/// </summary>
[Serializable]

public class ItemlistDomain : TopObject
{
	        /// <summary>
	        /// 基础信息
	        /// </summary>
	        [XmlElement("base")]
	        public AiotOpenDeviceBaseDtoDomain Base { get; set; }
	
	        /// <summary>
	        /// 设备ID
	        /// </summary>
	        [XmlElement("uuid")]
	        public string Uuid { get; set; }
}

	/// <summary>
/// IotPageDoDomain Data Structure.
/// </summary>
[Serializable]

public class IotPageDoDomain : TopObject
{
	        /// <summary>
	        /// 数据列表
	        /// </summary>
	        [XmlArray("item_list")]
	        [XmlArrayItem("itemlist")]
	        public List<ItemlistDomain> ItemList { get; set; }
	
	        /// <summary>
	        /// 页数
	        /// </summary>
	        [XmlElement("page_num")]
	        public long PageNum { get; set; }
	
	        /// <summary>
	        /// 页大小
	        /// </summary>
	        [XmlElement("page_size")]
	        public long PageSize { get; set; }
	
	        /// <summary>
	        /// 总大小
	        /// </summary>
	        [XmlElement("total_size")]
	        public long TotalSize { get; set; }
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
	        public IotPageDoDomain Data { get; set; }
	
	        /// <summary>
	        /// 错误信息
	        /// </summary>
	        [XmlElement("msg_code")]
	        public string MsgCode { get; set; }
	
	        /// <summary>
	        /// 错误信息
	        /// </summary>
	        [XmlElement("msg_info")]
	        public string MsgInfo { get; set; }
	
	        /// <summary>
	        /// 结果成功与否
	        /// </summary>
	        [XmlElement("success")]
	        public bool Success { get; set; }
}

    }
}
