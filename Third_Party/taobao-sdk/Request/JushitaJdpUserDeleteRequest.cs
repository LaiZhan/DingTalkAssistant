using System;
using System.Collections.Generic;
using Top.Api.Util;

namespace Top.Api.Request
{
    /// <summary>
    /// TOP API: taobao.jushita.jdp.user.delete
    /// </summary>
    public class JushitaJdpUserDeleteRequest : BaseTopRequest<Top.Api.Response.JushitaJdpUserDeleteResponse>
    {
        /// <summary>
        /// 要删除用户的昵称
        /// </summary>
        public string Nick { get; set; }

        /// <summary>
        /// 需要删除的用户编号
        /// </summary>
        public Nullable<long> UserId { get; set; }

        #region ITopRequest Members

        public override string GetApiName()
        {
            return "taobao.jushita.jdp.user.delete";
        }

        public override IDictionary<string, string> GetParameters()
        {
            TopDictionary parameters = new TopDictionary();
            parameters.Add("nick", this.Nick);
            parameters.Add("user_id", this.UserId);
            if (this.otherParams != null)
            {
                parameters.AddAll(this.otherParams);
            }
            return parameters;
        }

        public override void Validate()
        {
            RequestValidator.ValidateMinValue("user_id", this.UserId, 1);
        }

        #endregion
    }
}
