using System;
using System.Xml.Serialization;
using System.Collections.Generic;
using Top.Api.Util;

namespace Top.Api.Request
{
    /// <summary>
    /// TOP API: tmall.device.trade.precreate
    /// </summary>
    public class TmallDeviceTradePrecreateRequest : BaseTopRequest<Top.Api.Response.TmallDeviceTradePrecreateResponse>
    {
        /// <summary>
        /// 导购员手机号码
        /// </summary>
        public string BaPhone { get; set; }

        /// <summary>
        /// 导购员所属门店
        /// </summary>
        public Nullable<long> BaStoreId { get; set; }

        /// <summary>
        /// 回调地址，当订单创建，付款成功后，会收到回调。必须是https地址，HTTP响应必须包含success，否则系统会重发
        /// </summary>
        public string CallbackUrl { get; set; }

        /// <summary>
        /// 设备业务编码
        /// </summary>
        public string DeviceCode { get; set; }

        /// <summary>
        /// 商品列表
        /// </summary>
        public string ItemList { get; set; }

        public List<TradeItemDoDomain> ItemList_ { set { this.ItemList = TopUtils.ObjectToJson(value); } } 

        /// <summary>
        /// 外部订单ID，用户下保证唯一。最大长度22
        /// </summary>
        public string OutTradeId { get; set; }

        /// <summary>
        /// 交易类型。1，售卖。2，派样
        /// </summary>
        public Nullable<long> Type { get; set; }

        #region ITopRequest Members

        public override string GetApiName()
        {
            return "tmall.device.trade.precreate";
        }

        public override IDictionary<string, string> GetParameters()
        {
            TopDictionary parameters = new TopDictionary();
            parameters.Add("ba_phone", this.BaPhone);
            parameters.Add("ba_store_id", this.BaStoreId);
            parameters.Add("callback_url", this.CallbackUrl);
            parameters.Add("device_code", this.DeviceCode);
            parameters.Add("item_list", this.ItemList);
            parameters.Add("out_trade_id", this.OutTradeId);
            parameters.Add("type", this.Type);
            if (this.otherParams != null)
            {
                parameters.AddAll(this.otherParams);
            }
            return parameters;
        }

        public override void Validate()
        {
            RequestValidator.ValidateRequired("device_code", this.DeviceCode);
            RequestValidator.ValidateRequired("item_list", this.ItemList);
            RequestValidator.ValidateObjectMaxListSize("item_list", this.ItemList, 20);
            RequestValidator.ValidateRequired("out_trade_id", this.OutTradeId);
            RequestValidator.ValidateMaxLength("out_trade_id", this.OutTradeId, 22);
        }

	/// <summary>
/// TradeItemDoDomain Data Structure.
/// </summary>
[Serializable]

public class TradeItemDoDomain : TopObject
{
	        /// <summary>
	        /// 购买件数，默认为1
	        /// </summary>
	        [XmlElement("buy_amount")]
	        public Nullable<long> BuyAmount { get; set; }
	
	        /// <summary>
	        /// 商品ID
	        /// </summary>
	        [XmlElement("item_id")]
	        public Nullable<long> ItemId { get; set; }
	
	        /// <summary>
	        /// 商品SKU ID
	        /// </summary>
	        [XmlElement("sku_id")]
	        public Nullable<long> SkuId { get; set; }
	
	        /// <summary>
	        /// 售卖单价，单位分
	        /// </summary>
	        [XmlElement("unit_price")]
	        public Nullable<long> UnitPrice { get; set; }
	
	        /// <summary>
	        /// 是否使用开放定价。这里的价格由 tmall.device.item.openprice.update API预先设置
	        /// </summary>
	        [XmlElement("use_open_price")]
	        public Nullable<bool> UseOpenPrice { get; set; }
}

        #endregion
    }
}
