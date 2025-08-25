using System;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace Top.Api.Response
{
    /// <summary>
    /// TopOpenpidTestResponse.
    /// </summary>
    public class TopOpenpidTestResponse : TopResponse
    {
        /// <summary>
        /// 1231
        /// </summary>
        [XmlArray("apps")]
        [XmlArrayItem("app_base_info")]
        public List<Top.Api.Domain.AppBaseInfo> Apps { get; set; }

    }
}
