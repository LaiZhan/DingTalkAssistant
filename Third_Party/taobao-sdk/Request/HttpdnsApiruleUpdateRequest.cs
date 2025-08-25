using System;
using System.Xml.Serialization;
using System.Collections.Generic;
using Top.Api.Util;

namespace Top.Api.Request
{
    /// <summary>
    /// TOP API: taobao.httpdns.apirule.update
    /// </summary>
    public class HttpdnsApiruleUpdateRequest : BaseTopRequest<Top.Api.Response.HttpdnsApiruleUpdateResponse>
    {
        /// <summary>
        /// API规则配置
        /// </summary>
        public string Configs { get; set; }

        public List<ApiClusterConfigDomain> Configs_ { set { this.Configs = TopUtils.ObjectToJson(value); } } 

        /// <summary>
        /// API名称
        /// </summary>
        public string Name { get; set; }

        #region ITopRequest Members

        public override string GetApiName()
        {
            return "taobao.httpdns.apirule.update";
        }

        public override IDictionary<string, string> GetParameters()
        {
            TopDictionary parameters = new TopDictionary();
            parameters.Add("configs", this.Configs);
            parameters.Add("name", this.Name);
            if (this.otherParams != null)
            {
                parameters.AddAll(this.otherParams);
            }
            return parameters;
        }

        public override void Validate()
        {
            RequestValidator.ValidateObjectMaxListSize("configs", this.Configs, 20);
        }

	/// <summary>
/// ApiClusterConfigDomain Data Structure.
/// </summary>
[Serializable]

public class ApiClusterConfigDomain : TopObject
{
	        /// <summary>
	        /// 权重
	        /// </summary>
	        [XmlElement("power")]
	        public string Power { get; set; }
	
	        /// <summary>
	        /// 区域
	        /// </summary>
	        [XmlElement("region")]
	        public string Region { get; set; }
}

        #endregion
    }
}
