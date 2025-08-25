using System;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace Top.Api.Response
{
    /// <summary>
    /// RarAuthQueryResponse.
    /// </summary>
    public class RarAuthQueryResponse : TopResponse
    {
        /// <summary>
        /// 授权信息列表
        /// </summary>
        [XmlArray("results")]
        [XmlArrayItem("rar_authorization")]
        public List<RarAuthorizationDomain> Results { get; set; }

	/// <summary>
/// RarAuthorizationDomain Data Structure.
/// </summary>
[Serializable]

public class RarAuthorizationDomain : TopObject
{
	        /// <summary>
	        /// 授权状态。0：无效，1：有效
	        /// </summary>
	        [XmlElement("status")]
	        public long Status { get; set; }
	
	        /// <summary>
	        /// token,调用SQL查询API的时候使用
	        /// </summary>
	        [XmlElement("token")]
	        public string Token { get; set; }
	
	        /// <summary>
	        /// 数据类型 1:会员，2：订单，3：门店，4：商品
	        /// </summary>
	        [XmlElement("type")]
	        public long Type { get; set; }
	
	        /// <summary>
	        /// 授权的用户昵称
	        /// </summary>
	        [XmlElement("user_nick")]
	        public string UserNick { get; set; }
}

    }
}
