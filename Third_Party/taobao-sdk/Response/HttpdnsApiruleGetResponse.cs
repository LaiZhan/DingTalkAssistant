using System;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace Top.Api.Response
{
    /// <summary>
    /// HttpdnsApiruleGetResponse.
    /// </summary>
    public class HttpdnsApiruleGetResponse : TopResponse
    {
        /// <summary>
        /// modal
        /// </summary>
        [XmlArray("rules")]
        [XmlArrayItem("api_cluster_config_do")]
        public List<ApiClusterConfigDoDomain> Rules { get; set; }

	/// <summary>
/// ApiClusterConfigDoDomain Data Structure.
/// </summary>
[Serializable]

public class ApiClusterConfigDoDomain : TopObject
{
	        /// <summary>
	        /// 权重
	        /// </summary>
	        [XmlElement("power")]
	        public string Power { get; set; }
	
	        /// <summary>
	        /// 区域
	        /// </summary>
	        [XmlElement("region")]
	        public string Region { get; set; }
}

    }
}
