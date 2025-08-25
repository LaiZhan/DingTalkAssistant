using System;
using System.Collections.Generic;
using Top.Api.Util;

namespace Top.Api.Request
{
    /// <summary>
    /// TOP API: taobao.itemcat.features.get
    /// </summary>
    public class ItemcatFeaturesGetRequest : BaseTopRequest<Top.Api.Response.ItemcatFeaturesGetResponse>
    {
        /// <summary>
        /// 属性的Key，支持多条，以“,”分隔  h_videoshow（该类目是否能发视频）   sameProductLimit（该类目下产品限制）   cod（该类目下是否货到付款）   auto_fill（该类目是否卖家代充）  item_must_image(该类目下的商品是否是主图必传)……
        /// </summary>
        public string AttrKeys { get; set; }

        /// <summary>
        /// 类目ID
        /// </summary>
        public Nullable<long> Cid { get; set; }

        #region ITopRequest Members

        public override string GetApiName()
        {
            return "taobao.itemcat.features.get";
        }

        public override IDictionary<string, string> GetParameters()
        {
            TopDictionary parameters = new TopDictionary();
            parameters.Add("attr_keys", this.AttrKeys);
            parameters.Add("cid", this.Cid);
            if (this.otherParams != null)
            {
                parameters.AddAll(this.otherParams);
            }
            return parameters;
        }

        public override void Validate()
        {
            RequestValidator.ValidateRequired("attr_keys", this.AttrKeys);
            RequestValidator.ValidateRequired("cid", this.Cid);
        }

        #endregion
    }
}
