using System;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace Top.Api.Response
{
    /// <summary>
    /// OpenmallItemGetResponse.
    /// </summary>
    public class OpenmallItemGetResponse : TopResponse
    {
        /// <summary>
        /// 返回结果
        /// </summary>
        [XmlElement("result")]
        public ResultDoDomain Result { get; set; }

	/// <summary>
/// TopItemImageVoDomain Data Structure.
/// </summary>
[Serializable]

public class TopItemImageVoDomain : TopObject
{
	        /// <summary>
	        /// 图片ID，itemImages中不返回
	        /// </summary>
	        [XmlElement("image_id")]
	        public long ImageId { get; set; }
	
	        /// <summary>
	        /// 图片放在第几张（多图时设置），propertyImages中不返回
	        /// </summary>
	        [XmlElement("position")]
	        public long Position { get; set; }
	
	        /// <summary>
	        /// 商品属性，itemImages中不返回
	        /// </summary>
	        [XmlElement("properties")]
	        public string Properties { get; set; }
	
	        /// <summary>
	        /// 商品图片链接
	        /// </summary>
	        [XmlElement("url")]
	        public string Url { get; set; }
}

	/// <summary>
/// TopPostageVoDomain Data Structure.
/// </summary>
[Serializable]

public class TopPostageVoDomain : TopObject
{
	        /// <summary>
	        /// 增费：支持0.00-999.99（最多包含两位小数）
	        /// </summary>
	        [XmlElement("add_fee")]
	        public string AddFee { get; set; }
	
	        /// <summary>
	        /// 增费标准。 当valuation为0时，支持1-9999范围内的整数；  当valuation为1时，支持0.1-9999.9范围内的小数，只能包含一位小数（单位为千克）；  当valuation为3时，支持0.1-999.9范围内的数值，数值只能包含一位小数（单位为 立方米）。
	        /// </summary>
	        [XmlElement("add_standard")]
	        public string AddStandard { get; set; }
	
	        /// <summary>
	        /// 涉及的地区，多个地区用逗号分隔。地区码可以用taobao.areas.get接口获取，或者参考：http://www.mca.gov.cn/article/sj/xzqh/2020/2020/202003301019.html  当值为1时，表示全国所有地区。
	        /// </summary>
	        [XmlElement("post_area")]
	        public string PostArea { get; set; }
	
	        /// <summary>
	        /// 运费方式，可选值：平邮 (post)、快递公司(express)、EMS (ems)、货到付款(cod)、物流宝保障速递(wlb)、家装物流(furniture)。
	        /// </summary>
	        [XmlElement("post_type")]
	        public string PostType { get; set; }
	
	        /// <summary>
	        /// 首费，范围0.00-999.99（最多包含两位小数）。
	        /// </summary>
	        [XmlElement("start_fee")]
	        public string StartFee { get; set; }
	
	        /// <summary>
	        /// 首费标准。  当valuation(记价方式)为1时，支持0.1-9999.9范围内的小数只能包含一位小数（单位为千克）；  当valuation(记价方式)为3时，支持0.1-999.9范围内的数值，数值只能包含一位小数（单位为 立方米）。
	        /// </summary>
	        [XmlElement("start_standard")]
	        public string StartStandard { get; set; }
	
	        /// <summary>
	        /// 运费计算方式，可选值：0（件数）、1（重量）、3（体积）。
	        /// </summary>
	        [XmlElement("valuation")]
	        public long Valuation { get; set; }
}

	/// <summary>
/// TopItemSkuVoDomain Data Structure.
/// </summary>
[Serializable]

public class TopItemSkuVoDomain : TopObject
{
	        /// <summary>
	        /// sku描述，以分号分隔描述项，### 分隔翻译内容；注意，当为别名时，翻译项中将没有冒号分隔
	        /// </summary>
	        [XmlElement("description")]
	        public string Description { get; set; }
	
	        /// <summary>
	        /// 属于这个sku的商品的价格 取值范围:0-100000000;精确到2位小数;单位:元。如:200.07，表示:200元7分。
	        /// </summary>
	        [XmlElement("price")]
	        public string Price { get; set; }
	
	        /// <summary>
	        /// sku所对应的销售属性串，由 属性名ID(pid)、属性值ID(vid)组成。  格式为：pid1:vid1;pid2:vid2 ;pid3:vid3…    pid和vid对应的中文名称，可以从item_properties字段中获取。
	        /// </summary>
	        [XmlElement("properties")]
	        public string Properties { get; set; }
	
	        /// <summary>
	        /// 属于这个sku的商品的数量
	        /// </summary>
	        [XmlElement("quantity")]
	        public long Quantity { get; set; }
	
	        /// <summary>
	        /// sku的id
	        /// </summary>
	        [XmlElement("sku_id")]
	        public long SkuId { get; set; }
}

	/// <summary>
/// TopItemVoDomain Data Structure.
/// </summary>
[Serializable]

public class TopItemVoDomain : TopObject
{
	        /// <summary>
	        /// 是否区域限购。值为true时，通过taobao.openmall.item.salearea.get获取商品可销售区域；值为false时，该商品所有区域都可销售。
	        /// </summary>
	        [XmlElement("area_limit")]
	        public bool AreaLimit { get; set; }
	
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
	        /// 商品描述, 字数要大于5个字符，小于25000个字符
	        /// </summary>
	        [XmlElement("description")]
	        public string Description { get; set; }
	
	        /// <summary>
	        /// 是否虚拟商品
	        /// </summary>
	        [XmlElement("is_virtual")]
	        public bool IsVirtual { get; set; }
	
	        /// <summary>
	        /// 商品ID
	        /// </summary>
	        [XmlElement("item_id")]
	        public long ItemId { get; set; }
	
	        /// <summary>
	        /// 商品图片
	        /// </summary>
	        [XmlArray("item_images")]
	        [XmlArrayItem("top_item_image_vo")]
	        public List<TopItemImageVoDomain> ItemImages { get; set; }
	
	        /// <summary>
	        /// 商品的属性列表，由属性名ID(pid)、属性值ID(vid)、属性名(pid_name)、属性值(vid_name)组成。格式如：pid1:vid1:pid_name1:vid_name1;pid2:vid2:pid_name2:vid_name2……
	        /// </summary>
	        [XmlElement("item_properties")]
	        public string ItemProperties { get; set; }
	
	        /// <summary>
	        /// 商品状态：上架（1）、下架（0）
	        /// </summary>
	        [XmlElement("item_status")]
	        public long ItemStatus { get; set; }
	
	        /// <summary>
	        /// 商品视频列表，多个视频用逗号分隔。
	        /// </summary>
	        [XmlElement("item_videos")]
	        public string ItemVideos { get; set; }
	
	        /// <summary>
	        /// 商品主图
	        /// </summary>
	        [XmlElement("pic_url")]
	        public string PicUrl { get; set; }
	
	        /// <summary>
	        /// 商品人气
	        /// </summary>
	        [XmlElement("popularity")]
	        public long Popularity { get; set; }
	
	        /// <summary>
	        /// 运费列表
	        /// </summary>
	        [XmlArray("postages")]
	        [XmlArrayItem("top_postage_vo")]
	        public List<TopPostageVoDomain> Postages { get; set; }
	
	        /// <summary>
	        /// 属性值别名,比如颜色的自定义名称
	        /// </summary>
	        [XmlElement("property_alias")]
	        public string PropertyAlias { get; set; }
	
	        /// <summary>
	        /// 商品属性图片
	        /// </summary>
	        [XmlArray("property_images")]
	        [XmlArrayItem("top_item_image_vo")]
	        public List<TopItemImageVoDomain> PropertyImages { get; set; }
	
	        /// <summary>
	        /// 商品所在省份
	        /// </summary>
	        [XmlElement("prov")]
	        public string Prov { get; set; }
	
	        /// <summary>
	        /// 库存
	        /// </summary>
	        [XmlElement("quantity")]
	        public long Quantity { get; set; }
	
	        /// <summary>
	        /// 商品店铺名称
	        /// </summary>
	        [XmlElement("shop_name")]
	        public string ShopName { get; set; }
	
	        /// <summary>
	        /// 表示商品的体积，用于按体积计费的运费模板。该值的单位为立方米（m3）。该值支持两种格式的设置：  格式1：bulk:3，单位为立方米(m3)，表示直接设置为商品的体积；    格式2：width:10;breadth:10;height:10，单位为米（m）。
	        /// </summary>
	        [XmlElement("size")]
	        public string Size { get; set; }
	
	        /// <summary>
	        /// sku列表
	        /// </summary>
	        [XmlArray("skus")]
	        [XmlArrayItem("top_item_sku_vo")]
	        public List<TopItemSkuVoDomain> Skus { get; set; }
	
	        /// <summary>
	        /// 当前商品是否支持hold单，当为false时，下单接口中的need_erp_hold不生效
	        /// </summary>
	        [XmlElement("support_erp_hold")]
	        public string SupportErpHold { get; set; }
	
	        /// <summary>
	        /// 商品标题
	        /// </summary>
	        [XmlElement("title")]
	        public string Title { get; set; }
	
	        /// <summary>
	        /// 商品的重量，用于按重量计费的运费模板。注意：单位为kg
	        /// </summary>
	        [XmlElement("weight")]
	        public string Weight { get; set; }
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
	        /// 商品
	        /// </summary>
	        [XmlElement("item")]
	        public TopItemVoDomain Item { get; set; }
	
	        /// <summary>
	        /// 调用是否成功
	        /// </summary>
	        [XmlElement("success")]
	        public bool Success { get; set; }
}

    }
}
