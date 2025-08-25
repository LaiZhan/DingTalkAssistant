using System;
using System.Collections.Generic;
using Top.Api.Util;

namespace Top.Api.Request
{
    /// <summary>
    /// TOP API: taobao.openmall.items.query
    /// </summary>
    public class OpenmallItemsQueryRequest : BaseTopRequest<Top.Api.Response.OpenmallItemsQueryResponse>
    {
        /// <summary>
        /// 当不输入渠道商时，展示全网公有商品池；当输入渠道商的淘宝Nick时，展示该渠道私有供给商品列表
        /// </summary>
        public string Distributor { get; set; }

        /// <summary>
        /// 已废弃，请勿使用
        /// </summary>
        public string ItemIds { get; set; }

        /// <summary>
        /// 第几页，默认：1
        /// </summary>
        public Nullable<long> PageNo { get; set; }

        /// <summary>
        /// 页大小，默认20，1~100
        /// </summary>
        public Nullable<long> PageSize { get; set; }

        #region ITopRequest Members

        public override string GetApiName()
        {
            return "taobao.openmall.items.query";
        }

        public override IDictionary<string, string> GetParameters()
        {
            TopDictionary parameters = new TopDictionary();
            parameters.Add("distributor", this.Distributor);
            parameters.Add("item_ids", this.ItemIds);
            parameters.Add("page_no", this.PageNo);
            parameters.Add("page_size", this.PageSize);
            if (this.otherParams != null)
            {
                parameters.AddAll(this.otherParams);
            }
            return parameters;
        }

        public override void Validate()
        {
        }

        #endregion
    }
}
