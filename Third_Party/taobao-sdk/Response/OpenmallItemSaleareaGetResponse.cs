using System;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace Top.Api.Response
{
    /// <summary>
    /// OpenmallItemSaleareaGetResponse.
    /// </summary>
    public class OpenmallItemSaleareaGetResponse : TopResponse
    {
        /// <summary>
        /// 返回结果
        /// </summary>
        [XmlElement("result")]
        public ResultDoDomain Result { get; set; }

	/// <summary>
/// TopSaleAreaVoDomain Data Structure.
/// </summary>
[Serializable]

public class TopSaleAreaVoDomain : TopObject
{
	        /// <summary>
	        /// 可售区域信息，JSON数组格式的字符串。区域的层次用树状结构表示。 包含的字段有：     areaId：区域码;  subSaleArea：所属子区域的可售信息;   树的叶子节点表示可售区域。 树的枝节点只是聚合可售区域，表达区域的层次关系。
	        /// </summary>
	        [XmlElement("sale_area_info")]
	        public string SaleAreaInfo { get; set; }
	
	        /// <summary>
	        /// 商品SKU ID
	        /// </summary>
	        [XmlElement("sku_id")]
	        public long SkuId { get; set; }
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
	        /// 可售区域结果
	        /// </summary>
	        [XmlArray("sale_area_list")]
	        [XmlArrayItem("top_sale_area_vo")]
	        public List<TopSaleAreaVoDomain> SaleAreaList { get; set; }
	
	        /// <summary>
	        /// 调用是否成功
	        /// </summary>
	        [XmlElement("success")]
	        public bool Success { get; set; }
}

    }
}
