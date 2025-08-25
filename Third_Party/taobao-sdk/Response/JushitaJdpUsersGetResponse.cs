using System;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace Top.Api.Response
{
    /// <summary>
    /// JushitaJdpUsersGetResponse.
    /// </summary>
    public class JushitaJdpUsersGetResponse : TopResponse
    {
        /// <summary>
        /// 总记录数
        /// </summary>
        [XmlElement("total_results")]
        public long TotalResults { get; set; }

        /// <summary>
        /// 用户列表
        /// </summary>
        [XmlArray("users")]
        [XmlArrayItem("jdp_user")]
        public List<Top.Api.Domain.JdpUser> Users { get; set; }

    }
}
