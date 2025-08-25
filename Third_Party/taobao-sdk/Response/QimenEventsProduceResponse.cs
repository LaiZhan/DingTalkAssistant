using System;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace Top.Api.Response
{
    /// <summary>
    /// QimenEventsProduceResponse.
    /// </summary>
    public class QimenEventsProduceResponse : TopResponse
    {
        /// <summary>
        /// 是否全部成功
        /// </summary>
        [XmlElement("is_all_success")]
        public bool IsAllSuccess { get; set; }

        /// <summary>
        /// 发送结果，与发送时的参数顺序一致。如果is_all_success为true时，不用校验result是否成功
        /// </summary>
        [XmlArray("results")]
        [XmlArrayItem("qimen_result")]
        public List<QimenResultDomain> Results { get; set; }

	/// <summary>
/// QimenResultDomain Data Structure.
/// </summary>
[Serializable]

public class QimenResultDomain : TopObject
{
	        /// <summary>
	        /// 错误码
	        /// </summary>
	        [XmlElement("error_code")]
	        public string ErrorCode { get; set; }
	
	        /// <summary>
	        /// 错误信息
	        /// </summary>
	        [XmlElement("error_message")]
	        public string ErrorMessage { get; set; }
	
	        /// <summary>
	        /// 是否成功
	        /// </summary>
	        [XmlElement("is_success")]
	        public bool IsSuccess { get; set; }
}

    }
}
