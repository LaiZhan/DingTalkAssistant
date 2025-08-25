using System;
using System.Xml.Serialization;
using System.Collections.Generic;
using Top.Api.Util;

namespace Top.Api.Request
{
    /// <summary>
    /// TOP API: tmall.mc.data.manager.get
    /// </summary>
    public class TmallMcDataManagerGetRequest : BaseTopRequest<Top.Api.Response.TmallMcDataManagerGetResponse>
    {
        /// <summary>
        /// 请求参数do
        /// </summary>
        public string RequestDTO { get; set; }

        public DataManagerRequestDomain RequestDTO_ { set { this.RequestDTO = TopUtils.ObjectToJson(value); } } 

        #region ITopRequest Members

        public override string GetApiName()
        {
            return "tmall.mc.data.manager.get";
        }

        public override IDictionary<string, string> GetParameters()
        {
            TopDictionary parameters = new TopDictionary();
            parameters.Add("request_d_t_o", this.RequestDTO);
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
/// DataManagerRequestDomain Data Structure.
/// </summary>
[Serializable]

public class DataManagerRequestDomain : TopObject
{
	        /// <summary>
	        /// 渠道id
	        /// </summary>
	        [XmlElement("channel_id")]
	        public string ChannelId { get; set; }
	
	        /// <summary>
	        /// 查询类别
	        /// </summary>
	        [XmlElement("charge_type")]
	        public string ChargeType { get; set; }
	
	        /// <summary>
	        /// 结束时间
	        /// </summary>
	        [XmlElement("end_date")]
	        public string EndDate { get; set; }
	
	        /// <summary>
	        /// 页码
	        /// </summary>
	        [XmlElement("page_index")]
	        public Nullable<long> PageIndex { get; set; }
	
	        /// <summary>
	        /// 每页大小
	        /// </summary>
	        [XmlElement("page_size")]
	        public Nullable<long> PageSize { get; set; }
	
	        /// <summary>
	        /// 查询方式
	        /// </summary>
	        [XmlElement("query_type")]
	        public string QueryType { get; set; }
	
	        /// <summary>
	        /// 开始时间
	        /// </summary>
	        [XmlElement("start_date")]
	        public string StartDate { get; set; }
}

        #endregion
    }
}
