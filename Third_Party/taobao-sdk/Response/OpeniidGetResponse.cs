using System;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace Top.Api.Response
{
    /// <summary>
    /// OpeniidGetResponse.
    /// </summary>
    public class OpeniidGetResponse : TopResponse
    {
        /// <summary>
        /// 商品Open ID
        /// </summary>
        [XmlElement("open_iid")]
        public string OpenIid { get; set; }

    }
}
