using System;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace Top.Api.Response
{
    /// <summary>
    /// StoreFollowurlGetResponse.
    /// </summary>
    public class StoreFollowurlGetResponse : TopResponse
    {
        /// <summary>
        /// 店铺关注URL
        /// </summary>
        [XmlElement("url")]
        public string Url { get; set; }

    }
}
