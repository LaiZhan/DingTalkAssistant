using System;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace Top.Api.Response
{
    /// <summary>
    /// WdkRexDeviceInfoBatchgetResponse.
    /// </summary>
    public class WdkRexDeviceInfoBatchgetResponse : TopResponse
    {
        /// <summary>
        /// 数据提
        /// </summary>
        [XmlElement("data")]
        public IotPageDODomain Data { get; set; }

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
        [XmlElement("succeed")]
        public bool Succeed { get; set; }

	/// <summary>
/// AiotOpenDeviceOrganizationDTODomain Data Structure.
/// </summary>
[Serializable]

public class AiotOpenDeviceOrganizationDTODomain : TopObject
{
	        /// <summary>
	        /// l1编码
	        /// </summary>
	        [XmlElement("l1_code")]
	        public string L1Code { get; set; }
	
	        /// <summary>
	        /// l1名称
	        /// </summary>
	        [XmlElement("l1_name")]
	        public string L1Name { get; set; }
	
	        /// <summary>
	        /// l2编码
	        /// </summary>
	        [XmlElement("l2_code")]
	        public string L2Code { get; set; }
	
	        /// <summary>
	        /// l2名称
	        /// </summary>
	        [XmlElement("l2_name")]
	        public string L2Name { get; set; }
	
	        /// <summary>
	        /// l3编码
	        /// </summary>
	        [XmlElement("l3_code")]
	        public string L3Code { get; set; }
	
	        /// <summary>
	        /// l3名称
	        /// </summary>
	        [XmlElement("l3_name")]
	        public string L3Name { get; set; }
}

	/// <summary>
/// AiotOpenDeviceBaseDTODomain Data Structure.
/// </summary>
[Serializable]

public class AiotOpenDeviceBaseDTODomain : TopObject
{
	        /// <summary>
	        /// 品牌
	        /// </summary>
	        [XmlElement("brand_code")]
	        public string BrandCode { get; set; }
	
	        /// <summary>
	        /// 设备名称
	        /// </summary>
	        [XmlElement("device_name")]
	        public string DeviceName { get; set; }
	
	        /// <summary>
	        /// 设备SN
	        /// </summary>
	        [XmlElement("device_sn")]
	        public string DeviceSn { get; set; }
	
	        /// <summary>
	        /// 设备类型
	        /// </summary>
	        [XmlElement("device_type")]
	        public string DeviceType { get; set; }
	
	        /// <summary>
	        /// 硬件型号
	        /// </summary>
	        [XmlElement("hard_code")]
	        public string HardCode { get; set; }
	
	        /// <summary>
	        /// 厂商
	        /// </summary>
	        [XmlElement("manufacturer")]
	        public string Manufacturer { get; set; }
	
	        /// <summary>
	        /// 平台类型
	        /// </summary>
	        [XmlElement("platform")]
	        public long Platform { get; set; }
	
	        /// <summary>
	        /// 状态
	        /// </summary>
	        [XmlElement("status")]
	        public long Status { get; set; }
	
	        /// <summary>
	        /// utdid
	        /// </summary>
	        [XmlElement("utdid")]
	        public string Utdid { get; set; }
}

	/// <summary>
/// ItemListDomain Data Structure.
/// </summary>
[Serializable]

public class ItemListDomain : TopObject
{
	        /// <summary>
	        /// 设备基础信息
	        /// </summary>
	        [XmlElement("base")]
	        public AiotOpenDeviceBaseDTODomain Base { get; set; }
	
	        /// <summary>
	        /// 业务扩展信息
	        /// </summary>
	        [XmlElement("extend_str")]
	        public string ExtendStr { get; set; }
	
	        /// <summary>
	        /// 创建时间
	        /// </summary>
	        [XmlElement("gmt_create")]
	        public string GmtCreate { get; set; }
	
	        /// <summary>
	        /// 更新时间
	        /// </summary>
	        [XmlElement("gmt_modified")]
	        public string GmtModified { get; set; }
	
	        /// <summary>
	        /// 组织架构
	        /// </summary>
	        [XmlElement("organization")]
	        public AiotOpenDeviceOrganizationDTODomain Organization { get; set; }
	
	        /// <summary>
	        /// 租户ID
	        /// </summary>
	        [XmlElement("tenant_id")]
	        public long TenantId { get; set; }
	
	        /// <summary>
	        /// 设备id
	        /// </summary>
	        [XmlElement("uuid")]
	        public string Uuid { get; set; }
}

	/// <summary>
/// IotPageDODomain Data Structure.
/// </summary>
[Serializable]

public class IotPageDODomain : TopObject
{
	        /// <summary>
	        /// 列表内容
	        /// </summary>
	        [XmlArray("item_list")]
	        [XmlArrayItem("item_list")]
	        public List<ItemListDomain> ItemList { get; set; }
	
	        /// <summary>
	        /// 页码
	        /// </summary>
	        [XmlElement("page_num")]
	        public long PageNum { get; set; }
	
	        /// <summary>
	        /// 页大小
	        /// </summary>
	        [XmlElement("page_size")]
	        public long PageSize { get; set; }
	
	        /// <summary>
	        /// 总数
	        /// </summary>
	        [XmlElement("total_num")]
	        public long TotalNum { get; set; }
}

    }
}
