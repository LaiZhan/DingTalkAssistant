using System;
using System.Collections.Generic;
using Top.Api.Util;

namespace Top.Api.Request
{
    /// <summary>
    /// TOP API: aliyun.user.get
    /// </summary>
    public class AliyunUserGetRequest : BaseTopRequest<Top.Api.Response.AliyunUserGetResponse>
    {
        /// <summary>
        /// 淘宝用户ID
        /// </summary>
        public Nullable<long> UserId { get; set; }

        #region ITopRequest Members

        public override string GetApiName()
        {
            return "aliyun.user.get";
        }

        public override IDictionary<string, string> GetParameters()
        {
            TopDictionary parameters = new TopDictionary();
            parameters.Add("user_id", this.UserId);
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
