using System;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace Top.Api.Response
{
    /// <summary>
    /// BusinessServiceSpitestResponse.
    /// </summary>
    public class BusinessServiceSpitestResponse : TopResponse
    {
        /// <summary>
        /// 操作结果
        /// </summary>
        [XmlElement("result")]
        public ResultDomain Result { get; set; }

	/// <summary>
/// UserDomain Data Structure.
/// </summary>
[Serializable]

public class UserDomain : TopObject
{
	        /// <summary>
	        /// 昵称
	        /// </summary>
	        [XmlElement("nickname")]
	        public string Nickname { get; set; }
	
	        /// <summary>
	        /// 用户名
	        /// </summary>
	        [XmlElement("username")]
	        public string Username { get; set; }
}

	/// <summary>
/// ResultDomain Data Structure.
/// </summary>
[Serializable]

public class ResultDomain : TopObject
{
	        /// <summary>
	        /// 用户
	        /// </summary>
	        [XmlElement("user")]
	        public UserDomain User { get; set; }
}

    }
}
