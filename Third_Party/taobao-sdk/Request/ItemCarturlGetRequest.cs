using System;
using System.Collections.Generic;
using Top.Api.Util;

namespace Top.Api.Request
{
    /// <summary>
    /// TOP API: taobao.item.carturl.get
    /// </summary>
    public class ItemCarturlGetRequest : BaseTopRequest<Top.Api.Response.ItemCarturlGetResponse>
    {
        /// <summary>
        /// 回调地址，需要是EWS域名地址。可不填，默认到购物车页面
        /// </summary>
        public string CallbackUrl { get; set; }

        /// <summary>
        /// 扩展属性，关注店铺的时候会传递下去，格式为K:V|K:V格式
        /// </summary>
        public string ExtParams { get; set; }

        /// <summary>
        /// 商品信息，格式为 商品ID_SKU ID_数量，多条记录以逗号(,)分割
        /// </summary>
        public string ItemIds { get; set; }

        /// <summary>
        /// 端类型，默认是tb，可选tb,hm
        /// </summary>
        public string Type { get; set; }

        /// <summary>
        /// 商家ID
        /// </summary>
        public Nullable<long> UserId { get; set; }

        /// <summary>
        /// 商家Nick，优先使用user_id
        /// </summary>
        public string UserNick { get; set; }

        #region ITopRequest Members

        public override string GetApiName()
        {
            return "taobao.item.carturl.get";
        }

        public override IDictionary<string, string> GetParameters()
        {
            TopDictionary parameters = new TopDictionary();
            parameters.Add("callback_url", this.CallbackUrl);
            parameters.Add("ext_params", this.ExtParams);
            parameters.Add("item_ids", this.ItemIds);
            parameters.Add("type", this.Type);
            parameters.Add("user_id", this.UserId);
            parameters.Add("user_nick", this.UserNick);
            if (this.otherParams != null)
            {
                parameters.AddAll(this.otherParams);
            }
            return parameters;
        }

        public override void Validate()
        {
            RequestValidator.ValidateRequired("item_ids", this.ItemIds);
            RequestValidator.ValidateMaxListSize("item_ids", this.ItemIds, 9);
        }

        #endregion
    }
}
