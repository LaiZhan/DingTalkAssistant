using System;
using System.Xml.Serialization;
using System.Collections.Generic;
using Top.Api.Util;

namespace Top.Api.Request
{
    /// <summary>
    /// TOP API: taobao.openmall.trade.render
    /// </summary>
    public class OpenmallTradeRenderRequest : BaseTopRequest<Top.Api.Response.OpenmallTradeRenderResponse>
    {
        /// <summary>
        /// 请求入参
        /// </summary>
        public string ParamTopTradeCreateDO { get; set; }

        public TopTradeCreateDoDomain ParamTopTradeCreateDO_ { set { this.ParamTopTradeCreateDO = TopUtils.ObjectToJson(value); } } 

        #region ITopRequest Members

        public override string GetApiName()
        {
            return "taobao.openmall.trade.render";
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
	        /// 收货人地址
	        /// </summary>
	        [XmlElement("address")]
	        public string Address { get; set; }
	
	        /// <summary>
	        /// 买家来源渠道，可选值 WeiXin（微信渠道）,DouYin（抖音渠道），KuaiShou（快手渠道），Other（其他）
	        /// </summary>
	        [XmlElement("buyer_channel")]
	        public string BuyerChannel { get; set; }
	
	        /// <summary>
	        /// 买家来源渠道对应ID，例如微信的openId
	        /// </summary>
	        [XmlElement("buyer_channel_id")]
	        public string BuyerChannelId { get; set; }
	
	        /// <summary>
	        /// 买家手机号
	        /// </summary>
	        [XmlElement("buyer_phone")]
	        public string BuyerPhone { get; set; }
	
	        /// <summary>
	        /// 媒体渠道，代表分销者的身份，签约协议支付的淘宝账号
	        /// </summary>
	        [XmlElement("distributor")]
	        public string Distributor { get; set; }
	
	        /// <summary>
	        /// 收货地址的区域码，具体获取方式参考API:http://open.taobao.com/api.htm?docId=59&docType=2，一般为6位数字。也可以使用Openmall Api来解析收货地址( taobao.openmall.trade.address.parse)获取区域码
	        /// </summary>
	        [XmlElement("divisioncode")]
	        public string Divisioncode { get; set; }
	
	        /// <summary>
	        /// 收货人手机号
	        /// </summary>
	        [XmlElement("mobile")]
	        public string Mobile { get; set; }
	
	        /// <summary>
	        /// 收货人姓名
	        /// </summary>
	        [XmlElement("name")]
	        public string Name { get; set; }
	
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
	        /// 收货人的电话号码
	        /// </summary>
	        [XmlElement("phone")]
	        public string Phone { get; set; }
	
	        /// <summary>
	        /// 收货地址的邮编，空或者6位数字的邮编
	        /// </summary>
	        [XmlElement("postcode")]
	        public string Postcode { get; set; }
	
	        /// <summary>
	        /// 商品SKUID，无sku商品传0
	        /// </summary>
	        [XmlElement("sku_iids")]
	        public Nullable<long> SkuIids { get; set; }
}

        #endregion
    }
}
