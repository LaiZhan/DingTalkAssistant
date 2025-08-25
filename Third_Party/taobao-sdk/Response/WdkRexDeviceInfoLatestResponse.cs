using System;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace Top.Api.Response
{
    /// <summary>
    /// WdkRexDeviceInfoLatestResponse.
    /// </summary>
    public class WdkRexDeviceInfoLatestResponse : TopResponse
    {
        /// <summary>
        /// 接口返回model
        /// </summary>
        [XmlElement("result")]
        public ResultDomain Result { get; set; }

	/// <summary>
/// OrganizationDomain Data Structure.
/// </summary>
[Serializable]

public class OrganizationDomain : TopObject
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
/// BaseDomain Data Structure.
/// </summary>
[Serializable]

public class BaseDomain : TopObject
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
	        /// 生产厂商
	        /// </summary>
	        [XmlElement("manufacturer")]
	        public string Manufacturer { get; set; }
	
	        /// <summary>
	        /// 平台
	        /// </summary>
	        [XmlElement("platform")]
	        public long Platform { get; set; }
	
	        /// <summary>
	        /// 状态
	        /// </summary>
	        [XmlElement("status")]
	        public long Status { get; set; }
	
	        /// <summary>
	        /// 设备唯一标识
	        /// </summary>
	        [XmlElement("utdid")]
	        public string Utdid { get; set; }
}

	/// <summary>
/// DeviceDomain Data Structure.
/// </summary>
[Serializable]

public class DeviceDomain : TopObject
{
	        /// <summary>
	        /// 基础信息
	        /// </summary>
	        [XmlElement("base")]
	        public BaseDomain Base { get; set; }
	
	        /// <summary>
	        /// 额外信息
	        /// </summary>
	        [XmlElement("extend_str")]
	        public string ExtendStr { get; set; }
	
	        /// <summary>
	        /// 组织架构
	        /// </summary>
	        [XmlElement("organization")]
	        public OrganizationDomain Organization { get; set; }
	
	        /// <summary>
	        /// 租户id
	        /// </summary>
	        [XmlElement("tenant_id")]
	        public long TenantId { get; set; }
	
	        /// <summary>
	        /// uuid
	        /// </summary>
	        [XmlElement("uuid")]
	        public string Uuid { get; set; }
}

	/// <summary>
/// DataDomain Data Structure.
/// </summary>
[Serializable]

public class DataDomain : TopObject
{
	        /// <summary>
	        /// 公钥
	        /// </summary>
	        [XmlElement("access_key")]
	        public string AccessKey { get; set; }
	
	        /// <summary>
	        /// 加密secret私钥
	        /// </summary>
	        [XmlElement("access_secret_encrypt")]
	        public string AccessSecretEncrypt { get; set; }
	
	        /// <summary>
	        /// 设备信息
	        /// </summary>
	        [XmlElement("device")]
	        public DeviceDomain Device { get; set; }
	
	        /// <summary>
	        /// 随机数
	        /// </summary>
	        [XmlElement("random_seed")]
	        public string RandomSeed { get; set; }
}

	/// <summary>
/// ResultDomain Data Structure.
/// </summary>
[Serializable]

public class ResultDomain : TopObject
{
	        /// <summary>
	        /// 返回素材id
	        /// </summary>
	        [XmlElement("data")]
	        public DataDomain Data { get; set; }
	
	        /// <summary>
	        /// 是否成功
	        /// </summary>
	        [XmlElement("success")]
	        public bool Success { get; set; }
}

    }
}
