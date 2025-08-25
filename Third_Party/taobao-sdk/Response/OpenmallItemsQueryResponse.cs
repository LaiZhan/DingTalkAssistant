using System;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace Top.Api.Response
{
    /// <summary>
    /// OpenmallItemsQueryResponse.
    /// </summary>
    public class OpenmallItemsQueryResponse : TopResponse
    {
        /// <summary>
        /// 返回结果
        /// </summary>
        [XmlElement("result")]
        public ResultDoDomain Result { get; set; }

	/// <summary>
/// TopItemVoDomain Data Structure.
/// </summary>
[Serializable]

public class TopItemVoDomain : TopObject
{
	        /// <summary>
	        /// 商品类目
	        /// </summary>
	        [XmlElement("category_id")]
	        public long CategoryId { get; set; }
	
	        /// <summary>
	        /// 商品所在城市
	        /// </summary>
	        [XmlElement("city")]
	        public string City { get; set; }
	
	        /// <summary>
	        /// 商品成本价，精确到2位小数，单位：元。如：200.07，表示200元7分。
	        /// </summary>
	        [XmlElement("cost_price")]
	        public string CostPrice { get; set; }
	
	        /// <summary>
	        /// 商品ID
	        /// </summary>
	        [XmlElement("item_id")]
	        public long ItemId { get; set; }
	
	        /// <summary>
	        /// 商品主图
	        /// </summary>
	        [XmlElement("pic_url")]
	        public string PicUrl { get; set; }
	
	        /// <summary>
	        /// 商品所在省份
	        /// </summary>
	        [XmlElement("prov")]
	        public string Prov { get; set; }
	
	        /// <summary>
	        /// 库存
	        /// </summary>
	        [XmlElement("quantity")]
	        public string Quantity { get; set; }
	
	        /// <summary>
	        /// 商品状态：上架（1）、下架（0）
	        /// </summary>
	        [XmlElement("status")]
	        public long Status { get; set; }
	
	        /// <summary>
	        /// 商品标题
	        /// </summary>
	        [XmlElement("title")]
	        public string Title { get; set; }
}

	/// <summary>
/// ResultDoDomain Data Structure.
/// </summary>
[Serializable]

public class ResultDoDomain : TopObject
{
	        /// <summary>
	        /// 错误码
	        /// </summary>
	        [XmlElement("error_code")]
	        public string ErrorCode { get; set; }
	
	        /// <summary>
	        /// 错误信息
	        /// </summary>
	        [XmlElement("error_msg")]
	        public string ErrorMsg { get; set; }
	
	        /// <summary>
	        /// 商品列表
	        /// </summary>
	        [XmlArray("item_list")]
	        [XmlArrayItem("top_item_vo")]
	        public List<TopItemVoDomain> ItemList { get; set; }
	
	        /// <summary>
	        /// 调用是否成功
	        /// </summary>
	        [XmlElement("success")]
	        public bool Success { get; set; }
}

    }
}
