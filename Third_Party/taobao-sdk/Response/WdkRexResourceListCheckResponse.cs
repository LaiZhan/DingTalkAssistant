using System;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace Top.Api.Response
{
    /// <summary>
    /// WdkRexResourceListCheckResponse.
    /// </summary>
    public class WdkRexResourceListCheckResponse : TopResponse
    {
        /// <summary>
        /// 资源列表
        /// </summary>
        [XmlArray("data")]
        [XmlArrayItem("d_t_o")]
        public List<DTODomain> Data { get; set; }

        /// <summary>
        /// 错误码
        /// </summary>
        [XmlElement("msg_code")]
        public string MsgCode { get; set; }

        /// <summary>
        /// 错误内容
        /// </summary>
        [XmlElement("msg_info")]
        public string MsgInfo { get; set; }

        /// <summary>
        /// 是否成功
        /// </summary>
        [XmlElement("succeed")]
        public string Succeed { get; set; }

	/// <summary>
/// DTODomain Data Structure.
/// </summary>
[Serializable]

public class DTODomain : TopObject
{
	        /// <summary>
	        /// 应用名
	        /// </summary>
	        [XmlElement("app_name")]
	        public string AppName { get; set; }
	
	        /// <summary>
	        /// 是否自动安装
	        /// </summary>
	        [XmlElement("auto_install")]
	        public bool AutoInstall { get; set; }
	
	        /// <summary>
	        /// 自定义配置信息
	        /// </summary>
	        [XmlElement("config_json")]
	        public string ConfigJson { get; set; }
	
	        /// <summary>
	        /// 资源文件下载地址
	        /// </summary>
	        [XmlElement("download_url")]
	        public string DownloadUrl { get; set; }
	
	        /// <summary>
	        /// 图标地址
	        /// </summary>
	        [XmlElement("icon_url")]
	        public string IconUrl { get; set; }
	
	        /// <summary>
	        /// 资源MD5
	        /// </summary>
	        [XmlElement("md5")]
	        public string Md5 { get; set; }
	
	        /// <summary>
	        /// 兼容主包名
	        /// </summary>
	        [XmlElement("old_package_name")]
	        public string OldPackageName { get; set; }
	
	        /// <summary>
	        /// 主包名
	        /// </summary>
	        [XmlElement("package_name")]
	        public string PackageName { get; set; }
	
	        /// <summary>
	        /// 二维码地址
	        /// </summary>
	        [XmlElement("qrcode")]
	        public string Qrcode { get; set; }
	
	        /// <summary>
	        /// 资源大小
	        /// </summary>
	        [XmlElement("size")]
	        public long Size { get; set; }
	
	        /// <summary>
	        /// 资源状态
	        /// </summary>
	        [XmlElement("status")]
	        public long Status { get; set; }
	
	        /// <summary>
	        /// 资源描述
	        /// </summary>
	        [XmlElement("update_desc")]
	        public string UpdateDesc { get; set; }
	
	        /// <summary>
	        /// 资源版本号
	        /// </summary>
	        [XmlElement("version_code")]
	        public long VersionCode { get; set; }
	
	        /// <summary>
	        /// 资源版本名
	        /// </summary>
	        [XmlElement("version_name")]
	        public string VersionName { get; set; }
}

    }
}
