using System;
using System.Xml.Serialization;
using System.Collections.Generic;
using Top.Api.Util;

namespace Top.Api.Request
{
    /// <summary>
    /// TOP API: taobao.qimen.events.produce
    /// </summary>
    public class QimenEventsProduceRequest : BaseTopRequest<Top.Api.Response.QimenEventsProduceResponse>
    {
        /// <summary>
        /// 奇门事件列表, 最多50条
        /// </summary>
        public string Messages { get; set; }

        public List<QimenEventDomain> Messages_ { set { this.Messages = TopUtils.ObjectToJson(value); } } 

        #region ITopRequest Members

        public override string GetApiName()
        {
            return "taobao.qimen.events.produce";
        }

        public override IDictionary<string, string> GetParameters()
        {
            TopDictionary parameters = new TopDictionary();
            parameters.Add("messages", this.Messages);
            if (this.otherParams != null)
            {
                parameters.AddAll(this.otherParams);
            }
            return parameters;
        }

        public override void Validate()
        {
            RequestValidator.ValidateRequired("messages", this.Messages);
            RequestValidator.ValidateObjectMaxListSize("messages", this.Messages, 50);
        }

	/// <summary>
/// EventDomain Data Structure.
/// </summary>
[Serializable]

public class EventDomain : TopObject
{
	        /// <summary>
	        /// 订单创建时间,数字
	        /// </summary>
	        [XmlElement("create")]
	        public Nullable<long> Create { get; set; }
	
	        /// <summary>
	        /// 扩展属性
	        /// </summary>
	        [XmlElement("ext")]
	        public string Ext { get; set; }
	
	        /// <summary>
	        /// 外部商家名称。必须同时填写platform
	        /// </summary>
	        [XmlElement("nick")]
	        public string Nick { get; set; }
	
	        /// <summary>
	        /// 商家平台编码.MAIN:官方渠道,JD:京东,DD:当当,PP:拍拍,YX:易讯,EBAY:ebay,AMAZON:亚马逊,SN:苏宁,GM:国美,WPH:唯品会,JM:聚美,MGJ:蘑菇街,YT:银泰,YHD:1号店,1688:1688,POS:POS门店,OTHER:其他
	        /// </summary>
	        [XmlElement("platform")]
	        public string Platform { get; set; }
	
	        /// <summary>
	        /// 事件状态，如QIMEN_ERP_TRANSFER，QIMEN_ERP_CHECK
	        /// </summary>
	        [XmlElement("status")]
	        public string Status { get; set; }
	
	        /// <summary>
	        /// 淘宝订单号
	        /// </summary>
	        [XmlElement("tid")]
	        public string Tid { get; set; }
}

	/// <summary>
/// QimenEventDomain Data Structure.
/// </summary>
[Serializable]

public class QimenEventDomain : TopObject
{
	        /// <summary>
	        /// 奇门事件对象
	        /// </summary>
	        [XmlElement("event")]
	        public EventDomain Event { get; set; }
}

        #endregion
    }
}
