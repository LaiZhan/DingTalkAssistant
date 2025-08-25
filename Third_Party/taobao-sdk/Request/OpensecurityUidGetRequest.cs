using System;
using System.Collections.Generic;
using Top.Api.Util;

namespace Top.Api.Request
{
    /// <summary>
    /// TOP API: taobao.opensecurity.uid.get
    /// </summary>
    public class OpensecurityUidGetRequest : BaseTopRequest<Top.Api.Response.OpensecurityUidGetResponse>
    {
        /// <summary>
        /// 淘宝用户ID
        /// </summary>
        public Nullable<long> TbUserId { get; set; }

        #region ITopRequest Members

        public override string GetApiName()
        {
            return "taobao.opensecurity.uid.get";
        }

        public override IDictionary<string, string> GetParameters()
        {
            TopDictionary parameters = new TopDictionary();
            parameters.Add("tb_user_id", this.TbUserId);
            if (this.otherParams != null)
            {
                parameters.AddAll(this.otherParams);
            }
            return parameters;
        }

        public override void Validate()
        {
            RequestValidator.ValidateRequired("tb_user_id", this.TbUserId);
        }

        #endregion
    }
}
