using System;
using System.Xml.Serialization;
using System.Collections.Generic;
using Top.Api.Util;

namespace Top.Api.Request
{
    /// <summary>
    /// TOP API: aliexpress.platform.facade.call
    /// </summary>
    public class AliexpressPlatformFacadeCallRequest : BaseTopRequest<Top.Api.Response.AliexpressPlatformFacadeCallResponse>
    {
        /// <summary>
        /// request params
        /// </summary>
        public string Param0 { get; set; }

        public CallRequestDomain Param0_ { set { this.Param0 = TopUtils.ObjectToJson(value); } } 

        #region ITopRequest Members

        public override string GetApiName()
        {
            return "aliexpress.platform.facade.call";
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
            RequestValidator.ValidateRequired("param0", this.Param0);
        }

	/// <summary>
/// CallRequestDomain Data Structure.
/// </summary>
[Serializable]

public class CallRequestDomain : TopObject
{
	        /// <summary>
	        /// Request body 
	        /// </summary>
	        [XmlElement("body")]
	        public string Body { get; set; }
	
	        /// <summary>
	        /// Request headers: Map<String, List<String>>?
	        /// </summary>
	        [XmlElement("headers")]
	        public string Headers { get; set; }
	
	        /// <summary>
	        /// Request method
	        /// </summary>
	        [XmlElement("method")]
	        public string Method { get; set; }
	
	        /// <summary>
	        /// Request url
	        /// </summary>
	        [XmlElement("url")]
	        public string Url { get; set; }
}

        #endregion
    }
}
