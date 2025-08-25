using System;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace Top.Api.Response
{
    /// <summary>
    /// CainiaoLogisticscloudIsvCpticketCreateResponse.
    /// </summary>
    public class CainiaoLogisticscloudIsvCpticketCreateResponse : TopResponse
    {
        /// <summary>
        /// 返回生成的服务单号
        /// </summary>
        [XmlArray("data")]
        [XmlArrayItem("string")]
        public List<StringDomain> Data { get; set; }

        /// <summary>
        /// 错误码
        /// </summary>
        [XmlElement("error_code_i")]
        public string ErrorCodeI { get; set; }

        /// <summary>
        /// 错误信息
        /// </summary>
        [XmlElement("error_message_i")]
        public string ErrorMessageI { get; set; }

        /// <summary>
        /// 是否下单成功
        /// </summary>
        [XmlElement("success_i")]
        public bool SuccessI { get; set; }

	/// <summary>
/// StringDomain Data Structure.
/// </summary>
[Serializable]

public class StringDomain : TopObject
{
	        /// <summary>
	        /// 下工单的快递单号
	        /// </summary>
	        [XmlElement("mail_no")]
	        public string MailNo { get; set; }
	
	        /// <summary>
	        /// 对应的服务单单号
	        /// </summary>
	        [XmlElement("ticket_id")]
	        public string TicketId { get; set; }
}

    }
}
