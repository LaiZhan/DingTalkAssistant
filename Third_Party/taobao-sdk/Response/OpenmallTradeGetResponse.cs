using System;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace Top.Api.Response
{
    /// <summary>
    /// OpenmallTradeGetResponse.
    /// </summary>
    public class OpenmallTradeGetResponse : TopResponse
    {
        /// <summary>
        /// 返回结果
        /// </summary>
        [XmlElement("result")]
        public TopTradeDetailVoDomain Result { get; set; }

	/// <summary>
/// TopOrderVoDomain Data Structure.
/// </summary>
[Serializable]

public class TopOrderVoDomain : TopObject
{
	        /// <summary>
	        /// 子订单发货时间，当卖家对订单进行了多次发货，子订单的发货时间和主订单的发货时间可能不一样了，那么就需要以子订单的时间为准。（没有进行多次发货的订单，主订单的发货时间和子订单的发货时间都一样）
	        /// </summary>
	        [XmlElement("consign_time")]
	        public string ConsignTime { get; set; }
	
	        /// <summary>
	        /// 子订单的交易结束时间说明：子订单有单独的结束时间，与主订单的结束时间可能有所不同，在有退款发起的时候或者是主订单分阶段付款的时候，子订单的结束时间会早于主订单的结束时间，所以开放这个字段便于订单结束状态的判断
	        /// </summary>
	        [XmlElement("end_time")]
	        public string EndTime { get; set; }
	
	        /// <summary>
	        /// 子订单预计发货时间
	        /// </summary>
	        [XmlElement("estimate_con_time")]
	        public string EstimateConTime { get; set; }
	
	        /// <summary>
	        /// 子订单包裹运输号
	        /// </summary>
	        [XmlElement("invoice_no")]
	        public string InvoiceNo { get; set; }
	
	        /// <summary>
	        /// 是否发货
	        /// </summary>
	        [XmlElement("is_sh_ship")]
	        public bool IsShShip { get; set; }
	
	        /// <summary>
	        /// 商品备注
	        /// </summary>
	        [XmlElement("item_memo")]
	        public string ItemMemo { get; set; }
	
	        /// <summary>
	        /// 物流公司名称
	        /// </summary>
	        [XmlElement("logistics_company")]
	        public string LogisticsCompany { get; set; }
	
	        /// <summary>
	        /// 购买数量。取值范围:大于零的整数
	        /// </summary>
	        [XmlElement("num")]
	        public long Num { get; set; }
	
	        /// <summary>
	        /// 商品数字ID
	        /// </summary>
	        [XmlElement("num_iid")]
	        public long NumIid { get; set; }
	
	        /// <summary>
	        /// 子订单编号
	        /// </summary>
	        [XmlElement("oid")]
	        public long Oid { get; set; }
	
	        /// <summary>
	        /// 外部网店自己定义的Sku编号
	        /// </summary>
	        [XmlElement("outer_sku_id")]
	        public string OuterSkuId { get; set; }
	
	        /// <summary>
	        /// 子订单实付金额。精确到2位小数，单位:元。如:200.07，表示:200元7分。对于多子订单的交易，计算公式如下：payment = price * num + adjust_fee - discount_fee ；单子订单交易，payment与主订单的payment一致，对于退款成功的子订单，由于主订单的优惠分摊金额，会造成该字段可能不为0.00元。建议使用退款前的实付金额减去退款单中的实际退款金额计算。
	        /// </summary>
	        [XmlElement("payment")]
	        public string Payment { get; set; }
	
	        /// <summary>
	        /// 商品价格。精确到2位小数;单位:元。如:200.07，表示:200元7分
	        /// </summary>
	        [XmlElement("price")]
	        public string Price { get; set; }
	
	        /// <summary>
	        /// 最近退款ID
	        /// </summary>
	        [XmlElement("refund_id")]
	        public long RefundId { get; set; }
	
	        /// <summary>
	        /// 退款状态。退款状态。可选值 WAIT_SELLER_AGREE(买家已经申请退款，等待卖家同意) WAIT_BUYER_RETURN_GOODS(卖家已经同意退款，等待买家退货) WAIT_SELLER_CONFIRM_GOODS(买家已经退货，等待卖家确认收货) SELLER_REFUSE_BUYER(卖家拒绝退款) CLOSED(退款关闭) SUCCESS(退款成功)
	        /// </summary>
	        [XmlElement("refund_status")]
	        public string RefundStatus { get; set; }
	
	        /// <summary>
	        /// 商品SKUID
	        /// </summary>
	        [XmlElement("sku_id")]
	        public string SkuId { get; set; }
	
	        /// <summary>
	        /// SKU的值。如：机身颜色:黑色;手机套餐:官方标配
	        /// </summary>
	        [XmlElement("sku_properties_name")]
	        public string SkuPropertiesName { get; set; }
	
	        /// <summary>
	        /// 订单状态。可选值: TRADE_NO_CREATE_PAY(没有创建支付宝交易，暂无) WAIT_BUYER_PAY(等待买家付款) WAIT_SELLER_SEND_GOODS(等待卖家发货,即:买家已付款) WAIT_BUYER_CONFIRM_GOODS(等待买家确认收货,即:卖家已发货) TRADE_BUYER_SIGNED(买家已签收,货到付款专用，暂无) TRADE_FINISHED(交易成功) TRADE_CLOSED(付款以后用户退款成功，交易自动关闭) TRADE_CLOSED_BY_TAOBAO(付款以前，卖家或买家主动关闭交易) PAY_PENDING(国际信用卡支付付款确认中，暂无)
	        /// </summary>
	        [XmlElement("status")]
	        public string Status { get; set; }
	
	        /// <summary>
	        /// 商品标题
	        /// </summary>
	        [XmlElement("title")]
	        public string Title { get; set; }
	
	        /// <summary>
	        /// 应付金额（商品价格 * 商品数量 + 手工调整金额 - 子订单级订单优惠金额）。精确到2位小数;单位:元。如:200.07，表示:200元7分
	        /// </summary>
	        [XmlElement("total_fee")]
	        public string TotalFee { get; set; }
}

	/// <summary>
/// TopTradeDetailVoDomain Data Structure.
/// </summary>
[Serializable]

public class TopTradeDetailVoDomain : TopObject
{
	        /// <summary>
	        /// 支付宝交易号
	        /// </summary>
	        [XmlElement("alipay_no")]
	        public string AlipayNo { get; set; }
	
	        /// <summary>
	        /// 下单用户渠道
	        /// </summary>
	        [XmlElement("buyer_channel")]
	        public string BuyerChannel { get; set; }
	
	        /// <summary>
	        /// 下单用户渠道openid
	        /// </summary>
	        [XmlElement("buyer_channel_id")]
	        public string BuyerChannelId { get; set; }
	
	        /// <summary>
	        /// 买家备注
	        /// </summary>
	        [XmlElement("buyer_memo")]
	        public string BuyerMemo { get; set; }
	
	        /// <summary>
	        /// 卖家发货时间。格式:yyyy-MM-dd HH:mm:ss
	        /// </summary>
	        [XmlElement("consign_time")]
	        public string ConsignTime { get; set; }
	
	        /// <summary>
	        /// 交易创建时间。格式:yyyy-MM-dd HH:mm:ss
	        /// </summary>
	        [XmlElement("created")]
	        public string Created { get; set; }
	
	        /// <summary>
	        /// 下单媒体渠道
	        /// </summary>
	        [XmlElement("distributor")]
	        public string Distributor { get; set; }
	
	        /// <summary>
	        /// 交易结束时间。交易成功时间(更新交易状态为成功的同时更新)/确认收货时间或者交易关闭时间 。格式:yyyy-MM-dd HH:mm:ss
	        /// </summary>
	        [XmlElement("end_time")]
	        public string EndTime { get; set; }
	
	        /// <summary>
	        /// 商家的预计发货时间
	        /// </summary>
	        [XmlElement("est_con_time")]
	        public string EstConTime { get; set; }
	
	        /// <summary>
	        /// 是否包含邮费
	        /// </summary>
	        [XmlElement("has_post_fee")]
	        public bool HasPostFee { get; set; }
	
	        /// <summary>
	        /// 订单出现异常问题的时候，给予用户的描述,没有异常的时候，此值为空
	        /// </summary>
	        [XmlElement("mark_desc")]
	        public string MarkDesc { get; set; }
	
	        /// <summary>
	        /// 交易修改时间(用户对订单的任何修改都会更新此字段)。格式:yyyy-MM-dd HH:mm:ss
	        /// </summary>
	        [XmlElement("modified")]
	        public string Modified { get; set; }
	
	        /// <summary>
	        /// 商品购买数量。取值范围：大于零的整数,对于一个trade对应多个order的时候（一笔主订单，对应多笔子订单），num=0，num是一个跟商品关联的属性，一笔订单对应多比子订单的时候，主订单上的num无意义。
	        /// </summary>
	        [XmlElement("num")]
	        public long Num { get; set; }
	
	        /// <summary>
	        /// 商品数字编号
	        /// </summary>
	        [XmlElement("num_iid")]
	        public long NumIid { get; set; }
	
	        /// <summary>
	        /// 订单列表
	        /// </summary>
	        [XmlArray("orders")]
	        [XmlArrayItem("top_order_vo")]
	        public List<TopOrderVoDomain> Orders { get; set; }
	
	        /// <summary>
	        /// 付款时间。格式:yyyy-MM-dd HH:mm:ss。订单的付款时间即为物流订单的创建时间。
	        /// </summary>
	        [XmlElement("pay_time")]
	        public string PayTime { get; set; }
	
	        /// <summary>
	        /// 实付金额。精确到2位小数;单位:元。如:200.07，表示:200元7分
	        /// </summary>
	        [XmlElement("payment")]
	        public string Payment { get; set; }
	
	        /// <summary>
	        /// 邮费。精确到2位小数;单位:元。如:200.07，表示:200元7分
	        /// </summary>
	        [XmlElement("post_fee")]
	        public string PostFee { get; set; }
	
	        /// <summary>
	        /// 商品价格。精确到2位小数；单位：元。如：200.07，表示：200元7分
	        /// </summary>
	        [XmlElement("price")]
	        public string Price { get; set; }
	
	        /// <summary>
	        /// 收货人的详细地址
	        /// </summary>
	        [XmlElement("receiver_address")]
	        public string ReceiverAddress { get; set; }
	
	        /// <summary>
	        /// 收货人的所在城市 注：因为国家对于城市和地区的划分的有：省直辖市和省直辖县级行政区（区级别的）划分的，淘宝这边根据这个差异保存在不同字段里面比如：广东广州：广州属于一个直辖市是放在的receiver_city的字段里面；而河南济源：济源属于省直辖县级行政区划分，是区级别的，放在了receiver_district里面 建议：程序依赖于城市字段做物流等判断的操作，最好加一个判断逻辑：如果返回值里面只有receiver_district参数，该参数作为城市
	        /// </summary>
	        [XmlElement("receiver_city")]
	        public string ReceiverCity { get; set; }
	
	        /// <summary>
	        /// 收货人国籍
	        /// </summary>
	        [XmlElement("receiver_country")]
	        public string ReceiverCountry { get; set; }
	
	        /// <summary>
	        /// 收货人的所在地区 注：因为国家对于城市和地区的划分的有：省直辖市和省直辖县级行政区（区级别的）划分的，淘宝这边根据这个差异保存在不同字段里面比如：广东广州：广州属于一个直辖市是放在的receiver_city的字段里面；而河南济源：济源属于省直辖县级行政区划分，是区级别的，放在了receiver_district里面 建议：程序依赖于城市字段做物流等判断的操作，最好加一个判断逻辑：如果返回值里面只有receiver_district参数，该参数作为城市
	        /// </summary>
	        [XmlElement("receiver_district")]
	        public string ReceiverDistrict { get; set; }
	
	        /// <summary>
	        /// 收货人手机号
	        /// </summary>
	        [XmlElement("receiver_mobile")]
	        public string ReceiverMobile { get; set; }
	
	        /// <summary>
	        /// 收货人姓名
	        /// </summary>
	        [XmlElement("receiver_name")]
	        public string ReceiverName { get; set; }
	
	        /// <summary>
	        /// 收货人电话
	        /// </summary>
	        [XmlElement("receiver_phone")]
	        public string ReceiverPhone { get; set; }
	
	        /// <summary>
	        /// 收货人的所在省份
	        /// </summary>
	        [XmlElement("receiver_state")]
	        public string ReceiverState { get; set; }
	
	        /// <summary>
	        /// 收货人街道地址
	        /// </summary>
	        [XmlElement("receiver_town")]
	        public string ReceiverTown { get; set; }
	
	        /// <summary>
	        /// 收货人的邮编
	        /// </summary>
	        [XmlElement("receiver_zip")]
	        public string ReceiverZip { get; set; }
	
	        /// <summary>
	        /// 商家
	        /// </summary>
	        [XmlElement("seller_nick")]
	        public string SellerNick { get; set; }
	
	        /// <summary>
	        /// 创建交易时的物流方式（交易完成前，物流方式有可能改变，但系统里的这个字段一直不变）。可选值：free(卖家包邮),post(平邮),express(快递)
	        /// </summary>
	        [XmlElement("shipping_type")]
	        public string ShippingType { get; set; }
	
	        /// <summary>
	        /// 运单号，订单实际物流单号取 orders中的invoice_no和logistics_company
	        /// </summary>
	        [XmlElement("sid")]
	        public string Sid { get; set; }
	
	        /// <summary>
	        /// 交易状态。可选值: * TRADE_NO_CREATE_PAY(没有创建支付宝交易，暂无) * WAIT_BUYER_PAY(等待买家付款) * SELLER_CONSIGNED_PART(卖家部分发货，暂无) * WAIT_SELLER_SEND_GOODS(等待卖家发货,即:买家已付款) * WAIT_BUYER_CONFIRM_GOODS(等待买家确认收货,即:卖家已发货) * TRADE_BUYER_SIGNED(买家已签收,货到付款专用，暂无) * TRADE_FINISHED(交易成功) * TRADE_CLOSED(付款以后用户退款成功，交易自动关闭) * TRADE_CLOSED_BY_TAOBAO(付款以前，卖家或买家主动关闭交易) * PAY_PENDING(国际信用卡支付付款确认中，暂无) * WAIT_PRE_AUTH_CONFIRM(0元购合约中，暂无) * PAID_FORBID_CONSIGN(拼团中订单或者发货强管控的订单，已付款但禁止发货)
	        /// </summary>
	        [XmlElement("status")]
	        public string Status { get; set; }
	
	        /// <summary>
	        /// 淘宝交易单号
	        /// </summary>
	        [XmlElement("tid")]
	        public string Tid { get; set; }
	
	        /// <summary>
	        /// 交易标题，以店铺名作为此标题的值。注:taobao.trades.get接口返回的Trade中的title是商品名称
	        /// </summary>
	        [XmlElement("title")]
	        public string Title { get; set; }
	
	        /// <summary>
	        /// 商品金额（商品价格乘以数量的总金额）。精确到2位小数;单位:元。如:200.07，表示:200元7分
	        /// </summary>
	        [XmlElement("total_fee")]
	        public string TotalFee { get; set; }
	
	        /// <summary>
	        /// 交易备注。
	        /// </summary>
	        [XmlElement("trade_memo")]
	        public string TradeMemo { get; set; }
}

    }
}
