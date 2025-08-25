using System;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace Top.Api.Response
{
    /// <summary>
    /// AlibabaOpenAccountidGetResponse.
    /// </summary>
    public class AlibabaOpenAccountidGetResponse : TopResponse
    {
        /// <summary>
        /// 1688LoginId
        /// </summary>
        [XmlElement("login_id")]
        public string LoginId { get; set; }

        /// <summary>
        /// 1688 memberId
        /// </summary>
        [XmlElement("member_id")]
        public string MemberId { get; set; }

        /// <summary>
        /// 淘宝Nick
        /// </summary>
        [XmlElement("nick")]
        public string Nick { get; set; }

    }
}
