using System;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace Top.Api.Response
{
    /// <summary>
    /// ItemcatsGetResponse.
    /// </summary>
    public class ItemcatsGetResponse : TopResponse
    {
        /// <summary>
        /// 商品类目结构
        /// </summary>
        [XmlArray("item_cats")]
        [XmlArrayItem("item_cat")]
        public List<Top.Api.Domain.ItemCat> ItemCats { get; set; }

        /// <summary>
        /// 最近修改时间(如果取增量，会返回该字段)。
        /// </summary>
        [XmlElement("last_modified")]
        public string LastModified { get; set; }

    }
}
