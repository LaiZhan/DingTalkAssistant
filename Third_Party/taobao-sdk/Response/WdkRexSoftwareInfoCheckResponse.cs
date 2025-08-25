using System;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace Top.Api.Response
{
    /// <summary>
    /// WdkRexSoftwareInfoCheckResponse.
    /// </summary>
    public class WdkRexSoftwareInfoCheckResponse : TopResponse
    {
        /// <summary>
        /// 应用名称
        /// </summary>
        [XmlElement("app_name")]
        public string AppName { get; set; }

        /// <summary>
        /// 是否自动安装
        /// </summary>
        [XmlElement("auto_install")]
        public bool AutoInstall { get; set; }

        /// <summary>
        /// 配置信息
        /// </summary>
        [XmlElement("config_json")]
        public string ConfigJson { get; set; }

        /// <summary>
        /// 更新链接
        /// </summary>
        [XmlElement("download_url")]
        public string DownloadUrl { get; set; }

        /// <summary>
        /// 应用图标
        /// </summary>
        [XmlElement("icon_url")]
        public string IconUrl { get; set; }

        /// <summary>
        /// 包md5
        /// </summary>
        [XmlElement("md5")]
        public string Md5 { get; set; }

        /// <summary>
        /// 包名
        /// </summary>
        [XmlElement("package_name")]
        public string PackageName { get; set; }

        /// <summary>
        /// 二维码
        /// </summary>
        [XmlElement("qrcode")]
        public string Qrcode { get; set; }

        /// <summary>
        /// 包大小
        /// </summary>
        [XmlElement("size")]
        public long Size { get; set; }

        /// <summary>
        /// 状态
        /// </summary>
        [XmlElement("status")]
        public long Status { get; set; }

        /// <summary>
        /// 更新信息
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
