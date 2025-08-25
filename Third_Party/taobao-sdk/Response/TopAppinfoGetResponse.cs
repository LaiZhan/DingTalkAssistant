using System;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace Top.Api.Response
{
    /// <summary>
    /// TopAppinfoGetResponse.
    /// </summary>
    public class TopAppinfoGetResponse : TopResponse
    {
        /// <summary>
        /// app信息
        /// </summary>
        [XmlElement("app_info")]
        public AppBaseInfoDODomain AppInfo { get; set; }

	/// <summary>
/// AppBaseInfoDODomain Data Structure.
/// </summary>
[Serializable]

public class AppBaseInfoDODomain : TopObject
{
	        /// <summary>
	        /// appkey
	        /// </summary>
	        [XmlElement("appkey")]
	        public string Appkey { get; set; }
	
	        /// <summary>
	        /// ISV对应的淘宝ID
	        /// </summary>
	        [XmlElement("isv_id")]
	        public long IsvId { get; set; }
}

    }
}
