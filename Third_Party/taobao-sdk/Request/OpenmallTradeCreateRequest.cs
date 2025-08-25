using System;
using System.Xml.Serialization;
using System.Collections.Generic;
using Top.Api.Util;

namespace Top.Api.Request
{
    /// <summary>
    /// TOP API: taobao.openmall.trade.create
    /// </summary>
    public class OpenmallTradeCreateRequest : BaseTopRequest<Top.Api.Response.OpenmallTradeCreateResponse>
    {
        /// <summary>
        /// 请求入参
        /// </summary>
        public string ParamTopTradeCreateDO { get; set; }

        public TopTradeCreateDoDomain ParamTopTradeCreateDO_ { set { this.ParamTopTradeCreateDO = TopUtils.ObjectToJson(value); } } 

        #region ITopRequest Members

        public override string GetApiName()
        {
            return "taobao.openmall.trade.create";
        }

        public override IDictionary<string, string> GetParameters()
        {
            TopDictionary parameters = new TopDictionary();
            parameters.Add("param_top_trade_create_d_o", this.ParamTopTradeCreateDO);
            if (this.otherParams != null)
            {
                parameters.AddAll(this.otherParams);
            }
            return parameters;
        }

        public override void Validate()
        {
            RequestValidator.ValidateRequired("param_top_trade_create_d_o", this.ParamTopTradeCreateDO);
        }

	/// <summary>
/// TopTradeCreateDoDomain Data Structure.
/// </summary>
[Serializable]

public class TopTradeCreateDoDomain : TopObject
{
	        /// <summary>
	        /// 收货地址的收件人地址
	        /// </summary>
	        [XmlElement("address")]
	        public string Address { get; set; }
	
	        /// <summary>
	        /// 买家来源渠道，可选值 WeiXin（微信渠道），DouYin（抖音）， KuaiShou （快手），Other（其他）
	        /// </summary>
	        [XmlElement("buyer_channel")]
	        public string BuyerChannel { get; set; }
	
	        /// <summary>
	        /// 买家来源渠道对应ID，例如微信的openId
	        /// </summary>
	        [XmlElement("buyer_channel_id")]
	        public string BuyerChannelId { get; set; }
	
	        /// <summary>
	        /// 买家留言
	        /// </summary>
	        [XmlElement("buyer_memo")]
	        public string BuyerMemo { get; set; }
	
	        /// <summary>
	        /// 买家手机号
	        /// </summary>
	        [XmlElement("buyer_phone")]
	        public string BuyerPhone { get; set; }
	
	        /// <summary>
	        /// 媒体渠道，代表分销者的身份，签约支付宝代扣的渠道商淘宝账号nick
	        /// </summary>
	        [XmlElement("distributor")]
	        public string Distributor { get; set; }
	
	        /// <summary>
	        /// 收货地址的区域码，从taobao.areas.get接口获取区域码，文档地址：https://open.taobao.com/api.htm?spm=a219a.7386653.0.0.77e7669aoxOfiV&source=search&docId=59&docType=2
	        /// </summary>
	        [XmlElement("divisioncode")]
	        public string Divisioncode { get; set; }
	
	        /// <summary>
	        /// 计划采购金额（单位元），如最终订单成交价与期望金额不同则直接关单采购失败，计算方式：运费+商品成本价
	        /// </summary>
	        [XmlElement("expect_order_fee")]
	        public string ExpectOrderFee { get; set; }
	
	        /// <summary>
	        /// 收货地址的手机号码
	        /// </summary>
	        [XmlElement("mobile")]
	        public string Mobile { get; set; }
	
	        /// <summary>
	        /// 收货地址的收件人姓名
	        /// </summary>
	        [XmlElement("name")]
	        public string Name { get; set; }
	
	        /// <summary>
	        /// 创建订单传入true的时候，订单支付后会进入半小时的hold单（订单状态为：PAID_FORBID_CONSIGN），此时订单不会发货，用户可以调用Openmall地址修改接口修改订单收货地址，半小时结束后订单自动结束hold单进入发货流程订单状态为（WAIT_SELLER_SEND_GOODS）
	        /// </summary>
	        [XmlElement("need_erp_hold")]
	        public Nullable<bool> NeedErpHold { get; set; }
	
	        /// <summary>
	        /// 商品的id
	        /// </summary>
	        [XmlElement("num_iid")]
	        public Nullable<long> NumIid { get; set; }
	
	        /// <summary>
	        /// 商品数量
	        /// </summary>
	        [XmlElement("nums")]
	        public Nullable<long> Nums { get; set; }
	
	        /// <summary>
	        /// 订单的外部订单号，用来防止重复提交。需要以TOP：  appkey_（如：100000_） 开头，最长32位
	        /// </summary>
	        [XmlElement("out_id")]
	        public string OutId { get; set; }
	
	        /// <summary>
	        /// 外部订单交易金额（单位元），即消费者在渠道的实付金额
	        /// </summary>
	        [XmlElement("outer_order_fee")]
	        public string OuterOrderFee { get; set; }
	
	        /// <summary>
	        /// 收货地址的电话号码
	        /// </summary>
	        [XmlElement("phone")]
	        public string Phone { get; set; }
	
	        /// <summary>
	        /// 收货地址的邮编，为空或者6位数字的邮编
	        /// </summary>
	        [XmlElement("postcode")]
	        public string Postcode { get; set; }
	
	        /// <summary>
	        /// 创建交易时的物流方式。 具体的值从 taobao.openmall.trade.render 接口获取，邮费0说明为包邮
	        /// </summary>
	        [XmlElement("shipping_type")]
	        public string ShippingType { get; set; }
	
	        /// <summary>
	        /// 商品对应的SKUID，无SKU商品传0
	        /// </summary>
	        [XmlElement("sku_iids")]
	        public Nullable<long> SkuIids { get; set; }
}

        #endregion
    }
}
