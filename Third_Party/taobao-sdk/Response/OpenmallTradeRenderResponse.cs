using System;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace Top.Api.Response
{
    /// <summary>
    /// OpenmallTradeRenderResponse.
    /// </summary>
    public class OpenmallTradeRenderResponse : TopResponse
    {
        /// <summary>
        /// 返回结果
        /// </summary>
        [XmlElement("result")]
        public TopTradeResultVoDomain Result { get; set; }

	/// <summary>
/// PostDoDomain Data Structure.
/// </summary>
[Serializable]

public class PostDoDomain : TopObject
{
	        /// <summary>
	        /// 运费金额，运费0为包邮
	        /// </summary>
	        [XmlElement("amount")]
	        public string Amount { get; set; }
	
	        /// <summary>
	        /// 发货方式 快递，EMS等
	        /// </summary>
	        [XmlElement("name")]
	        public string Name { get; set; }
	
	        /// <summary>
	        /// 物流方式，可选值  ems, post, express
	        /// </summary>
	        [XmlElement("shipping_type")]
	        public string ShippingType { get; set; }
}

	/// <summary>
/// TopTradeResultVoDomain Data Structure.
/// </summary>
[Serializable]

public class TopTradeResultVoDomain : TopObject
{
	        /// <summary>
	        /// 发货地址对应的areaid
	        /// </summary>
	        [XmlElement("area_id")]
	        public long AreaId { get; set; }
	
	        /// <summary>
	        /// 商品ID
	        /// </summary>
	        [XmlElement("item_id")]
	        public long ItemId { get; set; }
	
	        /// <summary>
	        /// 发货地址
	        /// </summary>
	        [XmlElement("location")]
	        public string Location { get; set; }
	
	        /// <summary>
	        /// 运费列表
	        /// </summary>
	        [XmlArray("posts")]
	        [XmlArrayItem("post_do")]
	        public List<PostDoDomain> Posts { get; set; }
}

    }
}
