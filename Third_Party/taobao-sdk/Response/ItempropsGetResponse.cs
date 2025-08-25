using System;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace Top.Api.Response
{
    /// <summary>
    /// ItempropsGetResponse.
    /// </summary>
    public class ItempropsGetResponse : TopResponse
    {
        /// <summary>
        /// 商品属性
        /// </summary>
        [XmlArray("item_props")]
        [XmlArrayItem("item_prop")]
        public List<Top.Api.Domain.ItemProp> ItemProps { get; set; }

        /// <summary>
        /// 最近修改时间(只有取全量或增量的时候会返回该字段)。格式:yyyy-MM-dd HH:mm:ss
        /// </summary>
        [XmlElement("last_modified")]
        public string LastModified { get; set; }

    }
}
