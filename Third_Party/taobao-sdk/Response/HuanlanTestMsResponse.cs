using System;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace Top.Api.Response
{
    /// <summary>
    /// HuanlanTestMsResponse.
    /// </summary>
    public class HuanlanTestMsResponse : TopResponse
    {
        /// <summary>
        /// 结果
        /// </summary>
        [XmlElement("result")]
        public UserInfoDomain Result { get; set; }

	/// <summary>
/// UserInfoDomain Data Structure.
/// </summary>
[Serializable]

public class UserInfoDomain : TopObject
{
	        /// <summary>
	        /// 授权码AccessToken
	        /// </summary>
	        [XmlElement("access_token")]
	        public string AccessToken { get; set; }
	
	        /// <summary>
	        /// 1
	        /// </summary>
	        [XmlElement("basic_user_info")]
	        public string BasicUserInfo { get; set; }
}

    }
}
