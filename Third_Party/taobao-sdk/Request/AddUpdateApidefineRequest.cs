using System;
using System.Xml.Serialization;
using System.Collections.Generic;
using Top.Api.Util;

namespace Top.Api.Request
{
    /// <summary>
    /// TOP API: taobao.add.update.apidefine
    /// </summary>
    public class AddUpdateApidefineRequest : BaseTopRequest<Top.Api.Response.AddUpdateApidefineResponse>
    {
        /// <summary>
        /// 定义文件do
        /// </summary>
        public string ApiDefineDo { get; set; }

        public ApiDefineDODomain ApiDefineDo_ { set { this.ApiDefineDo = TopUtils.ObjectToJson(value); } } 

        #region ITopRequest Members

        public override string GetApiName()
        {
            return "taobao.add.update.apidefine";
        }

        public override IDictionary<string, string> GetParameters()
        {
            TopDictionary parameters = new TopDictionary();
            parameters.Add("api_define_do", this.ApiDefineDo);
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
/// ApiDefineDODomain Data Structure.
/// </summary>
[Serializable]

public class ApiDefineDODomain : TopObject
{
	        /// <summary>
	        /// api定义文件
	        /// </summary>
	        [XmlElement("api_define_informal")]
	        public string ApiDefineInformal { get; set; }
	
	        /// <summary>
	        /// api id
	        /// </summary>
	        [XmlElement("api_id")]
	        public Nullable<long> ApiId { get; set; }
	
	        /// <summary>
	        /// api定义文件
	        /// </summary>
	        [XmlElement("api_mapping_informal")]
	        public string ApiMappingInformal { get; set; }
	
	        /// <summary>
	        /// 是否为新的API
	        /// </summary>
	        [XmlElement("new_api")]
	        public Nullable<bool> NewApi { get; set; }
	
	        /// <summary>
	        /// 状态
	        /// </summary>
	        [XmlElement("status")]
	        public Nullable<long> Status { get; set; }
}

        #endregion
    }
}
