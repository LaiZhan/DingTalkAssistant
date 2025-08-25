using System;
using System.Collections.Generic;
using Top.Api.Util;

namespace Top.Api.Request
{
    /// <summary>
    /// TOP API: taobao.store.followurl.get
    /// </summary>
    public class StoreFollowurlGetRequest : BaseTopRequest<Top.Api.Response.StoreFollowurlGetResponse>
    {
        /// <summary>
        /// 关注完成后的回调地址,需要是EWS地址。如果不设置，会跳转到店铺首页
        /// </summary>
        public string CallbackUrl { get; set; }

        /// <summary>
        /// 商家ID
        /// </summary>
        public Nullable<long> UserId { get; set; }

        /// <summary>
        /// 商家nick
        /// </summary>
        public string UserNick { get; set; }

        #region ITopRequest Members

        public override string GetApiName()
        {
            return "taobao.store.followurl.get";
        }

        public override IDictionary<string, string> GetParameters()
        {
            TopDictionary parameters = new TopDictionary();
            parameters.Add("callback_url", this.CallbackUrl);
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
        }

        #endregion
    }
}
