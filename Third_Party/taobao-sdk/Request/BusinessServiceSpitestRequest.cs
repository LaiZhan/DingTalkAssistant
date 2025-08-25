using System;
using System.Xml.Serialization;
using System.Collections.Generic;
using Top.Api.Util;

namespace Top.Api.Request
{
    /// <summary>
    /// TOP API: taobao.business.service.spitest
    /// </summary>
    public class BusinessServiceSpitestRequest : BaseTopRequest<Top.Api.Response.BusinessServiceSpitestResponse>
    {
        /// <summary>
        /// 条件
        /// </summary>
        public string Condition { get; set; }

        public ConditionDomain Condition_ { set { this.Condition = TopUtils.ObjectToJson(value); } } 

        /// <summary>
        /// null
        /// </summary>
        public string Unnamed { get; set; }

        #region ITopRequest Members

        public override string GetApiName()
        {
            return "taobao.business.service.spitest";
        }

        public override IDictionary<string, string> GetParameters()
        {
            TopDictionary parameters = new TopDictionary();
            parameters.Add("condition", this.Condition);
            parameters.Add("unnamed", this.Unnamed);
            if (this.otherParams != null)
            {
                parameters.AddAll(this.otherParams);
            }
            return parameters;
        }

        public override void Validate()
        {
            RequestValidator.ValidateRequired("condition", this.Condition);
            RequestValidator.ValidateRequired("unnamed", this.Unnamed);
        }

	/// <summary>
/// ConditionDomain Data Structure.
/// </summary>
[Serializable]

public class ConditionDomain : TopObject
{
	        /// <summary>
	        /// 操作
	        /// </summary>
	        [XmlElement("option")]
	        public string Option { get; set; }
	
	        /// <summary>
	        /// 用户名
	        /// </summary>
	        [XmlElement("username")]
	        public string Username { get; set; }
}

        #endregion
    }
}
