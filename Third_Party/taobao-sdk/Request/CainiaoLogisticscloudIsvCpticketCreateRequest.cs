using System;
using System.Xml.Serialization;
using System.Collections.Generic;
using Top.Api.Util;

namespace Top.Api.Request
{
    /// <summary>
    /// TOP API: cainiao.logisticscloud.isv.cpticket.create
    /// </summary>
    public class CainiaoLogisticscloudIsvCpticketCreateRequest : BaseTopRequest<Top.Api.Response.CainiaoLogisticscloudIsvCpticketCreateResponse>
    {
        /// <summary>
        /// 请求分装对象
        /// </summary>
        public string Param0 { get; set; }

        public TicketOrderDomain Param0_ { set { this.Param0 = TopUtils.ObjectToJson(value); } } 

        #region ITopRequest Members

        public override string GetApiName()
        {
            return "cainiao.logisticscloud.isv.cpticket.create";
        }

        public override IDictionary<string, string> GetParameters()
        {
            TopDictionary parameters = new TopDictionary();
            parameters.Add("param0", this.Param0);
            if (this.otherParams != null)
            {
                parameters.AddAll(this.otherParams);
            }
            return parameters;
        }

        public override void Validate()
        {
        }

	/// <summary>
/// QuestionInfoDomain Data Structure.
/// </summary>
[Serializable]

public class QuestionInfoDomain : TopObject
{
	        /// <summary>
	        /// 旧的地址
	        /// </summary>
	        [XmlElement("address")]
	        public string Address { get; set; }
	
	        /// <summary>
	        /// 快递单号
	        /// </summary>
	        [XmlElement("mail_no")]
	        public string MailNo { get; set; }
	
	        /// <summary>
	        /// 旧的手机
	        /// </summary>
	        [XmlElement("mobile")]
	        public string Mobile { get; set; }
	
	        /// <summary>
	        /// 旧的姓名
	        /// </summary>
	        [XmlElement("name")]
	        public string Name { get; set; }
	
	        /// <summary>
	        /// 新的地址
	        /// </summary>
	        [XmlElement("new_address")]
	        public string NewAddress { get; set; }
	
	        /// <summary>
	        /// 新的手机号
	        /// </summary>
	        [XmlElement("new_mobile")]
	        public string NewMobile { get; set; }
	
	        /// <summary>
	        /// 新的姓名
	        /// </summary>
	        [XmlElement("new_name")]
	        public string NewName { get; set; }
	
	        /// <summary>
	        /// 问题描述
	        /// </summary>
	        [XmlElement("question")]
	        public string Question { get; set; }
	
	        /// <summary>
	        /// 拦截件类型
	        /// </summary>
	        [XmlElement("question_type")]
	        public Nullable<long> QuestionType { get; set; }
	
	        /// <summary>
	        /// 站点名称
	        /// </summary>
	        [XmlElement("site_name")]
	        public string SiteName { get; set; }
}

	/// <summary>
/// TicketOrderDomain Data Structure.
/// </summary>
[Serializable]

public class TicketOrderDomain : TopObject
{
	        /// <summary>
	        /// isv身份标识，由我们提供
	        /// </summary>
	        [XmlElement("customer_code")]
	        public string CustomerCode { get; set; }
	
	        /// <summary>
	        /// 请求列表
	        /// </summary>
	        [XmlArray("question_info_list")]
	        [XmlArrayItem("question_info")]
	        public List<QuestionInfoDomain> QuestionInfoList { get; set; }
	
	        /// <summary>
	        /// 商家公司ID
	        /// </summary>
	        [XmlElement("seller_id")]
	        public Nullable<long> SellerId { get; set; }
}

        #endregion
    }
}
