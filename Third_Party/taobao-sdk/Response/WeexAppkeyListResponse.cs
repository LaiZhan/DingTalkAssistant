using System;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace Top.Api.Response
{
    /// <summary>
    /// WeexAppkeyListResponse.
    /// </summary>
    public class WeexAppkeyListResponse : TopResponse
    {
        /// <summary>
        /// result
        /// </summary>
        [XmlArray("results")]
        [XmlArrayItem("appkey_list")]
        public List<string> Results { get; set; }

    }
}
