using System;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace Top.Api.Response
{
    /// <summary>
    /// OpenmallRefundMessageGetResponse.
    /// </summary>
    public class OpenmallRefundMessageGetResponse : TopResponse
    {
        /// <summary>
        /// 留言列表
        /// </summary>
        [XmlArray("results_list")]
        [XmlArrayItem("refund_message")]
        public List<RefundMessageDomain> ResultsList { get; set; }

	/// <summary>
/// RefundMessagePicDomain Data Structure.
/// </summary>
[Serializable]

public class RefundMessagePicDomain : TopObject
{
	        /// <summary>
	        /// 退款单图片留言
	        /// </summary>
	        [XmlElement("desc")]
	        public string Desc { get; set; }
	
	        /// <summary>
	        /// 退款单图片地址
	        /// </summary>
	        [XmlElement("pic")]
	        public string Pic { get; set; }
}

	/// <summary>
/// RefundMessageDomain Data Structure.
/// </summary>
[Serializable]

public class RefundMessageDomain : TopObject
{
	        /// <summary>
	        /// 退款留言
	        /// </summary>
	        [XmlElement("refund_message")]
	        public string RefundMessage_ { get; set; }
	
	        /// <summary>
	        /// 退款单结构
	        /// </summary>
	        [XmlArray("refund_message_pics")]
	        [XmlArrayItem("refund_message_pic")]
	        public List<RefundMessagePicDomain> RefundMessagePics { get; set; }
	
	        /// <summary>
	        /// 操作角色ID，1（卖家主账户），2（卖家子账户），3（小二）、4（买家）、5（系统）、6（系统超时）、7（服务商）；openmall中提交的留言角色均为4买家身份
	        /// </summary>
	        [XmlElement("role")]
	        public long Role { get; set; }
	
	        /// <summary>
	        /// 留言时间
	        /// </summary>
	        [XmlElement("time")]
	        public string Time { get; set; }
}

    }
}
