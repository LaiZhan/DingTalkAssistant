using System;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace Top.Api.Response
{
    /// <summary>
    /// WdkRexFirmwareUpdateCheckResponse.
    /// </summary>
    public class WdkRexFirmwareUpdateCheckResponse : TopResponse
    {
        /// <summary>
        /// 返回数据
        /// </summary>
        [XmlElement("data")]
        public RexFirmwareUpdateVersionDTODomain Data { get; set; }

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
        /// 成功与否
        /// </summary>
        [XmlElement("succeed")]
        public bool Succeed { get; set; }

	/// <summary>
/// RexFirmwareUpdateVersionDTODomain Data Structure.
/// </summary>
[Serializable]

public class RexFirmwareUpdateVersionDTODomain : TopObject
{
	        /// <summary>
	        /// 下载链接
	        /// </summary>
	        [XmlElement("download_url")]
	        public string DownloadUrl { get; set; }
	
	        /// <summary>
	        /// 创建时间戳（毫秒）
	        /// </summary>
	        [XmlElement("gmt_create")]
	        public long GmtCreate { get; set; }
	
	        /// <summary>
	        /// md5检验码
	        /// </summary>
	        [XmlElement("md5")]
	        public string Md5 { get; set; }
	
	        /// <summary>
	        /// 文件大小
	        /// </summary>
	        [XmlElement("size")]
	        public long Size { get; set; }
	
	        /// <summary>
	        /// 固件状态
	        /// </summary>
	        [XmlElement("status")]
	        public long Status { get; set; }
	
	        /// <summary>
	        /// 升级描述
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
