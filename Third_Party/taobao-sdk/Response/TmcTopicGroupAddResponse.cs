using System;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace Top.Api.Response
{
    /// <summary>
    /// TmcTopicGroupAddResponse.
    /// </summary>
    public class TmcTopicGroupAddResponse : TopResponse
    {
        /// <summary>
        /// true
        /// </summary>
        [XmlElement("result")]
        public bool Result { get; set; }

    }
}
