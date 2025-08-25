using System;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace Top.Api.Response
{
    /// <summary>
    /// ItemcatFeaturesGetResponse.
    /// </summary>
    public class ItemcatFeaturesGetResponse : TopResponse
    {
        /// <summary>
        /// Feature对象列表
        /// </summary>
        [XmlArray("features")]
        [XmlArrayItem("feature")]
        public List<Top.Api.Domain.Feature> Features { get; set; }

    }
}
