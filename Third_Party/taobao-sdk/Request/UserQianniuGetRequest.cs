using System;
using System.Collections.Generic;
using Top.Api.Util;

namespace Top.Api.Request
{
    /// <summary>
    /// TOP API: taobao.user.qianniu.get
    /// </summary>
    public class UserQianniuGetRequest : BaseTopRequest<Top.Api.Response.UserQianniuGetResponse>
    {
        /// <summary>
        /// 用户openId
        /// </summary>
        public string BuyerOpenUid { get; set; }

        /// <summary>
        /// 需返回的字段列表。可选值：User结构体中的所有字段；以半角逗号(,)分隔。需要用户授权才能获取用户对应的uid和user_id。
        /// </summary>
        public string Fields { get; set; }

        /// <summary>
        /// 用户昵称，如果昵称为中文，请使用UTF-8字符集对昵称进行URL编码。
        /// </summary>
        public string Nick { get; set; }

        #region ITopRequest Members

        public override string GetApiName()
        {
            return "taobao.user.qianniu.get";
        }

        public override IDictionary<string, string> GetParameters()
        {
            TopDictionary parameters = new TopDictionary();
            parameters.Add("buyer_open_uid", this.BuyerOpenUid);
            parameters.Add("fields", this.Fields);
            parameters.Add("nick", this.Nick);
            if (this.otherParams != null)
            {
                parameters.AddAll(this.otherParams);
            }
            return parameters;
        }

        public override void Validate()
        {
            RequestValidator.ValidateRequired("fields", this.Fields);
        }

        #endregion
    }
}
