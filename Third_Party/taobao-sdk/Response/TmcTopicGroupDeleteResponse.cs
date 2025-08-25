using System;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace Top.Api.Response
{
    /// <summary>
    /// TmcTopicGroupDeleteResponse.
    /// </summary>
    public class TmcTopicGroupDeleteResponse : TopResponse
    {
        /// <summary>
        /// true
        /// </summary>
        [XmlElement("result")]
        public bool Result { get; set; }

    }
}
