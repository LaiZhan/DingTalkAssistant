using System;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace Top.Api.Response
{
    /// <summary>
    /// WdkRexSoftwareListCheckResponse.
    /// </summary>
    public class WdkRexSoftwareListCheckResponse : TopResponse
    {
        /// <summary>
        /// 列表
        /// </summary>
        [XmlArray("data")]
        [XmlArrayItem("object")]
        public List<ObjectDomain> Data { get; set; }

        /// <summary>
        /// 错误信息
        /// </summary>
        [XmlElement("msg_code")]
        public string MsgCode { get; set; }

        /// <summary>
        /// 错误码
        /// </summary>
        [XmlElement("msg_info")]
        public string MsgInfo { get; set; }

        /// <summary>
        /// 是否成功
        /// </summary>
        [XmlElement("succeed")]
        public bool Succeed { get; set; }

	/// <summary>
/// ObjectDomain Data Structure.
/// </summary>
[Serializable]

public class ObjectDomain : TopObject
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
	        /// 业务配置信息
	        /// </summary>
	        [XmlElement("config_json")]
	        public string ConfigJson { get; set; }
	
	        /// <summary>
	        /// 下载包地址
	        /// </summary>
	        [XmlElement("download_url")]
	        public string DownloadUrl { get; set; }
	
	        /// <summary>
	        /// 图标url
	        /// </summary>
	        [XmlElement("icon_url")]
	        public string IconUrl { get; set; }
	
	        /// <summary>
	        /// MD5校验
	        /// </summary>
	        [XmlElement("md5")]
	        public string Md5 { get; set; }
	
	        /// <summary>
	        /// 包名
	        /// </summary>
	        [XmlElement("package_name")]
	        public string PackageName { get; set; }
	
	        /// <summary>
	        /// 二维码地址
	        /// </summary>
	        [XmlElement("qrcode")]
	        public string Qrcode { get; set; }
	
	        /// <summary>
	        /// 文件大小
	        /// </summary>
	        [XmlElement("size")]
	        public long Size { get; set; }
	
	        /// <summary>
	        /// 应用状态
	        /// </summary>
	        [XmlElement("status")]
	        public long Status { get; set; }
	
	        /// <summary>
	        /// 更新版本信息
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
