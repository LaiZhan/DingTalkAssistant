using System;
using System.Collections.Generic;
using Top.Api.Util;

namespace Top.Api.Request
{
    /// <summary>
    /// TOP API: taobao.openmall.item.salearea.get
    /// </summary>
    public class OpenmallItemSaleareaGetRequest : BaseTopRequest<Top.Api.Response.OpenmallItemSaleareaGetResponse>
    {
        /// <summary>
        /// 商品ID
        /// </summary>
        public Nullable<long> ItemId { get; set; }

        /// <summary>
        /// 商品SKU
        /// </summary>
        public string SkuIds { get; set; }

        #region ITopRequest Members

        public override string GetApiName()
        {
            return "taobao.openmall.item.salearea.get";
        }

        public override IDictionary<string, string> GetParameters()
        {
            TopDictionary parameters = new TopDictionary();
            parameters.Add("item_id", this.ItemId);
            parameters.Add("sku_ids", this.SkuIds);
            if (this.otherParams != null)
            {
                parameters.AddAll(this.otherParams);
            }
            return parameters;
        }

        public override void Validate()
        {
            RequestValidator.ValidateRequired("item_id", this.ItemId);
        }

        #endregion
    }
}
