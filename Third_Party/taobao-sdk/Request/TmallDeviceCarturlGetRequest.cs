using System;
using System.Collections.Generic;
using Top.Api.Util;

namespace Top.Api.Request
{
    /// <summary>
    /// TOP API: tmall.device.carturl.get
    /// </summary>
    public class TmallDeviceCarturlGetRequest : BaseTopRequest<Top.Api.Response.TmallDeviceCarturlGetResponse>
    {
        /// <summary>
        /// 设备业务编码
        /// </summary>
        public string DeviceCode { get; set; }

        /// <summary>
        /// 商品信息，格式为 商品ID_SKU ID_数量，多条记录以逗号(,)分割
        /// </summary>
        public string ItemIds { get; set; }

        /// <summary>
        /// 是否申请长期链接
        /// </summary>
        public Nullable<bool> Longterm { get; set; }

        #region ITopRequest Members

        public override string GetApiName()
        {
            return "tmall.device.carturl.get";
        }

        public override IDictionary<string, string> GetParameters()
        {
            TopDictionary parameters = new TopDictionary();
            parameters.Add("device_code", this.DeviceCode);
            parameters.Add("item_ids", this.ItemIds);
            parameters.Add("longterm", this.Longterm);
            if (this.otherParams != null)
            {
                parameters.AddAll(this.otherParams);
            }
            return parameters;
        }

        public override void Validate()
        {
            RequestValidator.ValidateRequired("device_code", this.DeviceCode);
            RequestValidator.ValidateRequired("item_ids", this.ItemIds);
            RequestValidator.ValidateMaxListSize("item_ids", this.ItemIds, 20);
        }

        #endregion
    }
}
