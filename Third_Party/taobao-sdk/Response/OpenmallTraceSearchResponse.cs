using System;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace Top.Api.Response
{
    /// <summary>
    /// OpenmallTraceSearchResponse.
    /// </summary>
    public class OpenmallTraceSearchResponse : TopResponse
    {
        /// <summary>
        /// 返回结果
        /// </summary>
        [XmlElement("result")]
        public TopLogisticsDetailTraceVoDomain Result { get; set; }

	/// <summary>
/// TransitStepInfoVoDomain Data Structure.
/// </summary>
[Serializable]

public class TransitStepInfoVoDomain : TopObject
{
	        /// <summary>
	        /// 节点说明
	        /// </summary>
	        [XmlElement("action")]
	        public string Action { get; set; }
	
	        /// <summary>
	        /// 状态描述
	        /// </summary>
	        [XmlElement("status_desc")]
	        public string StatusDesc { get; set; }
	
	        /// <summary>
	        /// 状态发生的时间
	        /// </summary>
	        [XmlElement("status_time")]
	        public string StatusTime { get; set; }
}

	/// <summary>
/// TopLogisticsDetailTraceVoDomain Data Structure.
/// </summary>
[Serializable]

public class TopLogisticsDetailTraceVoDomain : TopObject
{
	        /// <summary>
	        /// 物流公司名称
	        /// </summary>
	        [XmlElement("company_name")]
	        public string CompanyName { get; set; }
	
	        /// <summary>
	        /// 运单号
	        /// </summary>
	        [XmlElement("out_sid")]
	        public string OutSid { get; set; }
	
	        /// <summary>
	        /// 订单的物流状态（仅支持线上发货online订单，线下发货offline发出后直接变为已签收，OpenMall场景如无法判断请直接忽略，直接获取最后一个trace节点描述） * 等候发送给物流公司 *已提交给物流公司,等待物流公司接单 *已经确认消息接收，等待物流公司接单 *物流公司已接单 *物流公司不接单 *物流公司揽收失败 *物流公司揽收成功 *签收失败 *对方已签收 *对方拒绝签收
	        /// </summary>
	        [XmlElement("status")]
	        public string Status { get; set; }
	
	        /// <summary>
	        /// 淘宝交易单ID
	        /// </summary>
	        [XmlElement("tid")]
	        public string Tid { get; set; }
	
	        /// <summary>
	        /// 流转信息列表
	        /// </summary>
	        [XmlArray("trace_list")]
	        [XmlArrayItem("transit_step_info_vo")]
	        public List<TransitStepInfoVoDomain> TraceList { get; set; }
}

    }
}
