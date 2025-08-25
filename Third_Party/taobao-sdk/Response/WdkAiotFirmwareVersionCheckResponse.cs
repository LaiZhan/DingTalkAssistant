using System;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace Top.Api.Response
{
    /// <summary>
    /// WdkAiotFirmwareVersionCheckResponse.
    /// </summary>
    public class WdkAiotFirmwareVersionCheckResponse : TopResponse
    {
        /// <summary>
        /// result
        /// </summary>
        [XmlElement("result")]
        public NAppVersionMtopDoDomain Result { get; set; }

	/// <summary>
/// NAppVersionMtopDoDomain Data Structure.
/// </summary>
[Serializable]

public class NAppVersionMtopDoDomain : TopObject
{
	        /// <summary>
	        /// appid
	        /// </summary>
	        [XmlElement("app_id")]
	        public long AppId { get; set; }
	
	        /// <summary>
	        /// app名称
	        /// </summary>
	        [XmlElement("app_name")]
	        public string AppName { get; set; }
	
	        /// <summary>
	        /// 是否自动安装
	        /// </summary>
	        [XmlElement("auto_install")]
	        public bool AutoInstall { get; set; }
	
	        /// <summary>
	        /// 下载链接
	        /// </summary>
	        [XmlElement("download_url")]
	        public string DownloadUrl { get; set; }
	
	        /// <summary>
	        /// 创建时间
	        /// </summary>
	        [XmlElement("gmt_create")]
	        public string GmtCreate { get; set; }
	
	        /// <summary>
	        /// 图标地址
	        /// </summary>
	        [XmlElement("icon_url")]
	        public string IconUrl { get; set; }
	
	        /// <summary>
	        /// id
	        /// </summary>
	        [XmlElement("id")]
	        public long Id { get; set; }
	
	        /// <summary>
	        /// 安装类型
	        /// </summary>
	        [XmlElement("install_type")]
	        public long InstallType { get; set; }
	
	        /// <summary>
	        /// 包校验码
	        /// </summary>
	        [XmlElement("md5")]
	        public string Md5 { get; set; }
	
	        /// <summary>
	        /// 包名
	        /// </summary>
	        [XmlElement("package_name")]
	        public string PackageName { get; set; }
	
	        /// <summary>
	        /// 设置
	        /// </summary>
	        [XmlElement("settings")]
	        public string Settings { get; set; }
	
	        /// <summary>
	        /// 签名
	        /// </summary>
	        [XmlElement("sign")]
	        public string Sign { get; set; }
	
	        /// <summary>
	        /// 包大小
	        /// </summary>
	        [XmlElement("size")]
	        public long Size { get; set; }
	
	        /// <summary>
	        /// 描述
	        /// </summary>
	        [XmlElement("update_desc")]
	        public string UpdateDesc { get; set; }
	
	        /// <summary>
	        /// 版本号
	        /// </summary>
	        [XmlElement("version_code")]
	        public long VersionCode { get; set; }
	
	        /// <summary>
	        /// 版本名
	        /// </summary>
	        [XmlElement("version_name")]
	        public string VersionName { get; set; }
}

    }
}
