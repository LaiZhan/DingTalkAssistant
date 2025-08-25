using System;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace Top.Api.Response
{
    /// <summary>
    /// TopApplistGetResponse.
    /// </summary>
    public class TopApplistGetResponse : TopResponse
    {
        /// <summary>
        /// App列表信息
        /// </summary>
        [XmlArray("app_base_infos")]
        [XmlArrayItem("app_base_info")]
        public List<Top.Api.Domain.AppBaseInfo> AppBaseInfos { get; set; }

    }
}
