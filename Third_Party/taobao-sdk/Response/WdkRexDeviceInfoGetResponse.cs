using System;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace Top.Api.Response
{
    /// <summary>
    /// WdkRexDeviceInfoGetResponse.
    /// </summary>
    public class WdkRexDeviceInfoGetResponse : TopResponse
    {
        /// <summary>
        /// 设备详情
        /// </summary>
        [XmlElement("data")]
        public AiotTopOpenDeviceDtoDomain Data { get; set; }

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
        /// 结果是否成功
        /// </summary>
        [XmlElement("succeed")]
        public bool Succeed { get; set; }

	/// <summary>
/// AiotOpenDeviceOrganizationDtoDomain Data Structure.
/// </summary>
[Serializable]

public class AiotOpenDeviceOrganizationDtoDomain : TopObject
{
	        /// <summary>
	        /// 1级组织架构code
	        /// </summary>
	        [XmlElement("l1_code")]
	        public string L1Code { get; set; }
	
	        /// <summary>
	        /// 1级组织架构名
	        /// </summary>
	        [XmlElement("l1_name")]
	        public string L1Name { get; set; }
	
	        /// <summary>
	        /// 2级组织架构code
	        /// </summary>
	        [XmlElement("l2_code")]
	        public string L2Code { get; set; }
	
	        /// <summary>
	        /// 3级组织架构名
	        /// </summary>
	        [XmlElement("l2_name")]
	        public string L2Name { get; set; }
	
	        /// <summary>
	        /// 3级组织架构code
	        /// </summary>
	        [XmlElement("l3_code")]
	        public string L3Code { get; set; }
	
	        /// <summary>
	        /// 4级组织架构名
	        /// </summary>
	        [XmlElement("l3_name")]
	        public string L3Name { get; set; }
	
	        /// <summary>
	        /// 4级组织架构code
	        /// </summary>
	        [XmlElement("l4_code")]
	        public string L4Code { get; set; }
	
	        /// <summary>
	        /// 5级组织架构名
	        /// </summary>
	        [XmlElement("l4_name")]
	        public string L4Name { get; set; }
	
	        /// <summary>
	        /// 5级组织架构code
	        /// </summary>
	        [XmlElement("l5_code")]
	        public string L5Code { get; set; }
	
	        /// <summary>
	        /// 5级组织架构名
	        /// </summary>
	        [XmlElement("l5_name")]
	        public string L5Name { get; set; }
}

	/// <summary>
/// AiotOpenDeviceBaseDtoDomain Data Structure.
/// </summary>
[Serializable]

public class AiotOpenDeviceBaseDtoDomain : TopObject
{
	        /// <summary>
	        /// 品牌
	        /// </summary>
	        [XmlElement("brand_code")]
	        public string BrandCode { get; set; }
	
	        /// <summary>
	        /// 设备名
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
	        /// 设备业务标识
	        /// </summary>
	        [XmlElement("utdid")]
	        public string Utdid { get; set; }
}

	/// <summary>
/// AiotTopOpenDeviceDtoDomain Data Structure.
/// </summary>
[Serializable]

public class AiotTopOpenDeviceDtoDomain : TopObject
{
	        /// <summary>
	        /// 基础信息
	        /// </summary>
	        [XmlElement("base")]
	        public AiotOpenDeviceBaseDtoDomain Base { get; set; }
	
	        /// <summary>
	        /// 业务自定义参数
	        /// </summary>
	        [XmlElement("extend_str")]
	        public string ExtendStr { get; set; }
	
	        /// <summary>
	        /// 组织架构
	        /// </summary>
	        [XmlElement("organization")]
	        public AiotOpenDeviceOrganizationDtoDomain Organization { get; set; }
	
	        /// <summary>
	        /// 租户号
	        /// </summary>
	        [XmlElement("tenant_id")]
	        public long TenantId { get; set; }
	
	        /// <summary>
	        /// 设备唯一标识
	        /// </summary>
	        [XmlElement("uuid")]
	        public string Uuid { get; set; }
}

    }
}
