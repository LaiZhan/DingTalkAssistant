using System;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace Top.Api.Response
{
    /// <summary>
    /// OpensecurityUidGetResponse.
    /// </summary>
    public class OpensecurityUidGetResponse : TopResponse
    {
        /// <summary>
        /// open security tbUserId，淘宝用户对每个Appkey会有唯一的一个open_uid
        /// </summary>
        [XmlElement("open_uid")]
        public string OpenUid { get; set; }

    }
}
