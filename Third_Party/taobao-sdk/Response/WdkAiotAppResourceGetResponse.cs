using System;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace Top.Api.Response
{
    /// <summary>
    /// WdkAiotAppResourceGetResponse.
    /// </summary>
    public class WdkAiotAppResourceGetResponse : TopResponse
    {
        /// <summary>
        /// 结果
        /// </summary>
        [XmlArray("result_list")]
        [XmlArrayItem("n_app_res_mtop_do")]
        public List<NAppResMtopDoDomain> ResultList { get; set; }

	/// <summary>
/// NAppResMtopDoDomain Data Structure.
/// </summary>
[Serializable]

public class NAppResMtopDoDomain : TopObject
{
	        /// <summary>
	        /// 配置内容
	        /// </summary>
	        [XmlElement("config_json")]
	        public string ConfigJson { get; set; }
	
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
	        /// 安装类型
	        /// </summary>
	        [XmlElement("install_type")]
	        public long InstallType { get; set; }
	
	        /// <summary>
	        /// 包md5
	        /// </summary>
	        [XmlElement("ossmd5")]
	        public string Ossmd5 { get; set; }
	
	        /// <summary>
	        /// 包名
	        /// </summary>
	        [XmlElement("package_name")]
	        public string PackageName { get; set; }
	
	        /// <summary>
	        /// 资源名
	        /// </summary>
	        [XmlElement("res_name")]
	        public string ResName { get; set; }
	
	        /// <summary>
	        /// 资源ID
	        /// </summary>
	        [XmlElement("rid")]
	        public long Rid { get; set; }
	
	        /// <summary>
	        /// 资源大小
	        /// </summary>
	        [XmlElement("size")]
	        public long Size { get; set; }
	
	        /// <summary>
	        /// 包信息
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
