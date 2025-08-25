using System;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace Top.Api.Response
{
    /// <summary>
    /// JushitaJdpJduserGetResponse.
    /// </summary>
    public class JushitaJdpJduserGetResponse : TopResponse
    {
        /// <summary>
        /// result
        /// </summary>
        [XmlElement("result")]
        public ResultSetDomain Result { get; set; }

	/// <summary>
/// JdUserDomain Data Structure.
/// </summary>
[Serializable]

public class JdUserDomain : TopObject
{
	        /// <summary>
	        /// appKey
	        /// </summary>
	        [XmlElement("app_key")]
	        public string AppKey { get; set; }
	
	        /// <summary>
	        /// region
	        /// </summary>
	        [XmlElement("region")]
	        public string Region { get; set; }
	
	        /// <summary>
	        /// userId
	        /// </summary>
	        [XmlElement("user_id")]
	        public long UserId { get; set; }
	
	        /// <summary>
	        /// valid
	        /// </summary>
	        [XmlElement("valid")]
	        public bool Valid { get; set; }
}

	/// <summary>
/// ResultSetDomain Data Structure.
/// </summary>
[Serializable]

public class ResultSetDomain : TopObject
{
	        /// <summary>
	        /// error
	        /// </summary>
	        [XmlElement("error")]
	        public bool Error { get; set; }
	
	        /// <summary>
	        /// errorCode
	        /// </summary>
	        [XmlElement("error_code")]
	        public string ErrorCode { get; set; }
	
	        /// <summary>
	        /// errorMsg
	        /// </summary>
	        [XmlElement("error_msg")]
	        public string ErrorMsg { get; set; }
	
	        /// <summary>
	        /// firstResult
	        /// </summary>
	        [XmlElement("first_result")]
	        public string FirstResult { get; set; }
	
	        /// <summary>
	        /// hasNext
	        /// </summary>
	        [XmlElement("has_next")]
	        public bool HasNext { get; set; }
	
	        /// <summary>
	        /// results
	        /// </summary>
	        [XmlArray("results")]
	        [XmlArrayItem("jd_user")]
	        public List<JdUserDomain> Results { get; set; }
	
	        /// <summary>
	        /// totalCount
	        /// </summary>
	        [XmlElement("total_count")]
	        public long TotalCount { get; set; }
}

    }
}
