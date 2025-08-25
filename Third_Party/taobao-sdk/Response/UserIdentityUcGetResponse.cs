using System;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace Top.Api.Response
{
    /// <summary>
    /// UserIdentityUcGetResponse.
    /// </summary>
    public class UserIdentityUcGetResponse : TopResponse
    {
        /// <summary>
        /// 用户
        /// </summary>
        [XmlElement("user")]
        public UserDomain User { get; set; }

	/// <summary>
/// UserDomain Data Structure.
/// </summary>
[Serializable]

public class UserDomain : TopObject
{
	        /// <summary>
	        /// 用户头像地址
	        /// </summary>
	        [XmlElement("avatar")]
	        public string Avatar { get; set; }
	
	        /// <summary>
	        /// 用户作为卖家是否开过店
	        /// </summary>
	        [XmlElement("has_shop")]
	        public bool HasShop { get; set; }
	
	        /// <summary>
	        /// 用户昵称
	        /// </summary>
	        [XmlElement("nick")]
	        public string Nick { get; set; }
	
	        /// <summary>
	        /// open userId
	        /// </summary>
	        [XmlElement("open_uid")]
	        public string OpenUid { get; set; }
	
	        /// <summary>
	        /// 用户类型。可选值:B(B商家),C(C商家)
	        /// </summary>
	        [XmlElement("type")]
	        public string Type { get; set; }
	
	        /// <summary>
	        /// uid
	        /// </summary>
	        [XmlElement("uid")]
	        public string Uid { get; set; }
	
	        /// <summary>
	        /// 用户数字ID
	        /// </summary>
	        [XmlElement("user_id")]
	        public long UserId { get; set; }
}

    }
}
