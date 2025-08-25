using System;
using System.Collections.Generic;
using Top.Api.Util;

namespace Top.Api.Request
{
    /// <summary>
    /// TOP API: tmall.device.store.followurl.get
    /// </summary>
    public class TmallDeviceStoreFollowurlGetRequest : BaseTopRequest<Top.Api.Response.TmallDeviceStoreFollowurlGetResponse>
    {
        /// <summary>
        /// 页面banner的图片，如果没有传入，会使用系统默认图
        /// </summary>
        public string BannerImg { get; set; }

        /// <summary>
        /// 关注完成后的回调地址,需要是EWS地址
        /// </summary>
        public string CallbackUrl { get; set; }

        /// <summary>
        /// 设备DeviceCode
        /// </summary>
        public string DeviceCode { get; set; }

        /// <summary>
        /// 是否同时关注天猫理想站
        /// </summary>
        public Nullable<bool> FollowRetailAccount { get; set; }

        /// <summary>
        /// 是否使用长期链接
        /// </summary>
        public Nullable<bool> Longterm { get; set; }

        #region ITopRequest Members

        public override string GetApiName()
        {
            return "tmall.device.store.followurl.get";
        }

        public override IDictionary<string, string> GetParameters()
        {
            TopDictionary parameters = new TopDictionary();
            parameters.Add("banner_img", this.BannerImg);
            parameters.Add("callback_url", this.CallbackUrl);
            parameters.Add("device_code", this.DeviceCode);
            parameters.Add("follow_retail_account", this.FollowRetailAccount);
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
        }

        #endregion
    }
}
