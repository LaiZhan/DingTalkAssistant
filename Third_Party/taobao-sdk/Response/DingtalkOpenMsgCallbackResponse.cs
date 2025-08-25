using System;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace Top.Api.Response
{
    /// <summary>
    /// DingtalkOpenMsgCallbackResponse.
    /// </summary>
    public class DingtalkOpenMsgCallbackResponse : TopResponse
    {
        /// <summary>
        /// 结果
        /// </summary>
        [XmlElement("result")]
        public ServiceResultDomain Result { get; set; }

	/// <summary>
/// ServiceResultDomain Data Structure.
/// </summary>
[Serializable]

public class ServiceResultDomain : TopObject
{
	        /// <summary>
	        /// dsafa
	        /// </summary>
	        [XmlElement("encrypt")]
	        public string Encrypt { get; set; }
	
	        /// <summary>
	        /// adsfa
	        /// </summary>
	        [XmlElement("msg_signature")]
	        public string MsgSignature { get; set; }
	
	        /// <summary>
	        /// fads
	        /// </summary>
	        [XmlElement("nonce")]
	        public string Nonce { get; set; }
	
	        /// <summary>
	        /// fad
	        /// </summary>
	        [XmlElement("time_stamp")]
	        public string TimeStamp { get; set; }
}

    }
}
