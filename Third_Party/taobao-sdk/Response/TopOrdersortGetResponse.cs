using System;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace Top.Api.Response
{
    /// <summary>
    /// TopOrdersortGetResponse.
    /// </summary>
    public class TopOrdersortGetResponse : TopResponse
    {
        /// <summary>
        /// 天时维度排序值
        /// </summary>
        [XmlElement("day_sort_val")]
        public long DaySortVal { get; set; }

        /// <summary>
        /// 小时维度排序值
        /// </summary>
        [XmlElement("hour_sort_val")]
        public long HourSortVal { get; set; }

        /// <summary>
        /// 是否是主订单
        /// </summary>
        [XmlElement("is_main")]
        public string IsMain { get; set; }

        /// <summary>
        /// 订单编号
        /// </summary>
        [XmlElement("order_id")]
        public long OrderId { get; set; }

        /// <summary>
        /// 支付时间
        /// </summary>
        [XmlElement("pay_time")]
        public string PayTime { get; set; }

        /// <summary>
        /// 子订单列表，查询订单id为子订单时，列表为空
        /// </summary>
        [XmlArray("sub_orders")]
        [XmlArrayItem("suborders")]
        public List<SubordersDomain> SubOrders { get; set; }

	/// <summary>
/// SubordersDomain Data Structure.
/// </summary>
[Serializable]

public class SubordersDomain : TopObject
{
	        /// <summary>
	        /// 天时维度排序值
	        /// </summary>
	        [XmlElement("day_sort_val")]
	        public long DaySortVal { get; set; }
	
	        /// <summary>
	        /// 小时维度排序值
	        /// </summary>
	        [XmlElement("hour_sort_val")]
	        public long HourSortVal { get; set; }
	
	        /// <summary>
	        /// 是否是主订单
	        /// </summary>
	        [XmlElement("is_main")]
	        public long IsMain { get; set; }
	
	        /// <summary>
	        /// 订单id
	        /// </summary>
	        [XmlElement("order_id")]
	        public long OrderId { get; set; }
	
	        /// <summary>
	        /// 支付时间
	        /// </summary>
	        [XmlElement("pay_time")]
	        public string PayTime { get; set; }
}

    }
}
