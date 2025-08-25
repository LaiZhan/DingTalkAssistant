using System;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace Top.Api.Response
{
    /// <summary>
    /// OpenmallRefundGetResponse.
    /// </summary>
    public class OpenmallRefundGetResponse : TopResponse
    {
        /// <summary>
        /// 系统自动生成
        /// </summary>
        [XmlElement("refund")]
        public TopRefundVoDomain Refund { get; set; }

	/// <summary>
/// RefundRemindTimeoutDomain Data Structure.
/// </summary>
[Serializable]

public class RefundRemindTimeoutDomain : TopObject
{
	        /// <summary>
	        /// 是否存在超时。可选值:true(是),false(否)
	        /// </summary>
	        [XmlElement("exist_timeout")]
	        public bool ExistTimeout { get; set; }
	
	        /// <summary>
	        /// 超时时间。格式:yyyy-MM-dd HH:mm:ss
	        /// </summary>
	        [XmlElement("timeout")]
	        public string Timeout { get; set; }
}

	/// <summary>
/// TopRefundVoDomain Data Structure.
/// </summary>
[Serializable]

public class TopRefundVoDomain : TopObject
{
	        /// <summary>
	        /// 卖家退货地址
	        /// </summary>
	        [XmlElement("address")]
	        public string Address { get; set; }
	
	        /// <summary>
	        /// 当该退款单为 未发货仅退款 申请时，因卖家坚持发货而导致关单的情况下，该字段值为true；其余条件为空或false
	        /// </summary>
	        [XmlElement("closed_by_seller_ship")]
	        public bool ClosedBySellerShip { get; set; }
	
	        /// <summary>
	        /// 物流公司名称
	        /// </summary>
	        [XmlElement("company_name")]
	        public string CompanyName { get; set; }
	
	        /// <summary>
	        /// 退货时收货人姓名
	        /// </summary>
	        [XmlElement("consignee_full_name")]
	        public string ConsigneeFullName { get; set; }
	
	        /// <summary>
	        /// 创建时间
	        /// </summary>
	        [XmlElement("created")]
	        public string Created { get; set; }
	
	        /// <summary>
	        /// 退货时收货人电话
	        /// </summary>
	        [XmlElement("fix_phone")]
	        public string FixPhone { get; set; }
	
	        /// <summary>
	        /// 货物状态。可选值BUYER_NOT_RECEIVED (买家未收到货) BUYER_RECEIVED (买家已收到货) BUYER_RETURNED_GOODS (买家已退货)
	        /// </summary>
	        [XmlElement("good_status")]
	        public string GoodStatus { get; set; }
	
	        /// <summary>
	        /// 买家是否需要退货。可选值:true(是),false(否)
	        /// </summary>
	        [XmlElement("has_good_return")]
	        public bool HasGoodReturn { get; set; }
	
	        /// <summary>
	        /// 退货时收货人手机号
	        /// </summary>
	        [XmlElement("mobile")]
	        public string Mobile { get; set; }
	
	        /// <summary>
	        /// 更新时间
	        /// </summary>
	        [XmlElement("modified")]
	        public string Modified { get; set; }
	
	        /// <summary>
	        /// 商品数量
	        /// </summary>
	        [XmlElement("num")]
	        public long Num { get; set; }
	
	        /// <summary>
	        /// 商品ID
	        /// </summary>
	        [XmlElement("num_iid")]
	        public long NumIid { get; set; }
	
	        /// <summary>
	        /// 实付金额。精确到2位小数;单位:元。如:200.07，表示:200元7分
	        /// </summary>
	        [XmlElement("payment")]
	        public string Payment { get; set; }
	
	        /// <summary>
	        /// 退货邮编
	        /// </summary>
	        [XmlElement("post_code")]
	        public string PostCode { get; set; }
	
	        /// <summary>
	        /// 退还金额(退还给买家的金额)。精确到2位小数;单位:元。如:200.07，表示:200元7分
	        /// </summary>
	        [XmlElement("refund_fee")]
	        public string RefundFee { get; set; }
	
	        /// <summary>
	        /// 退款单ID
	        /// </summary>
	        [XmlElement("refund_id")]
	        public long RefundId { get; set; }
	
	        /// <summary>
	        /// 退款阶段，可选值：onsale/aftersale
	        /// </summary>
	        [XmlElement("refund_phase")]
	        public string RefundPhase { get; set; }
	
	        /// <summary>
	        /// 退款超时结构
	        /// </summary>
	        [XmlElement("refund_remind_timeout")]
	        public RefundRemindTimeoutDomain RefundRemindTimeout { get; set; }
	
	        /// <summary>
	        /// 创建交易时的物流方式。 可选值：ems, express, post, free
	        /// </summary>
	        [XmlElement("shipping_type")]
	        public string ShippingType { get; set; }
	
	        /// <summary>
	        /// 退货运单号
	        /// </summary>
	        [XmlElement("sid")]
	        public string Sid { get; set; }
	
	        /// <summary>
	        /// 商品SKU信息
	        /// </summary>
	        [XmlElement("sku")]
	        public string Sku { get; set; }
	
	        /// <summary>
	        /// 退款状态。可选值WAIT_SELLER_AGREE(买家已经申请退款，等待卖家同意) WAIT_BUYER_RETURN_GOODS(卖家已经同意退款，等待买家退货) WAIT_SELLER_CONFIRM_GOODS(买家已经退货，等待卖家确认收货) SELLER_REFUSE_BUYER(卖家拒绝退款) CLOSED(退款关闭) SUCCESS(退款成功)
	        /// </summary>
	        [XmlElement("status")]
	        public string Status { get; set; }
	
	        /// <summary>
	        /// 交易总金额
	        /// </summary>
	        [XmlElement("total_fee")]
	        public string TotalFee { get; set; }
}

    }
}
