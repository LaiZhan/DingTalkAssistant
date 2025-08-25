using System;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace Top.Api.Response
{
    /// <summary>
    /// HuanlangTestServiceCombineResponse.
    /// </summary>
    public class HuanlangTestServiceCombineResponse : TopResponse
    {
        /// <summary>
        /// 结果
        /// </summary>
        [XmlElement("result")]
        public ResultDomain Result { get; set; }

	/// <summary>
/// ResultDomain Data Structure.
/// </summary>
[Serializable]

public class ResultDomain : TopObject
{
	        /// <summary>
	        /// 11
	        /// </summary>
	        [XmlElement("time")]
	        public string Time { get; set; }
	
	        /// <summary>
	        /// 11
	        /// </summary>
	        [XmlElement("user")]
	        public string User { get; set; }
}

    }
}
