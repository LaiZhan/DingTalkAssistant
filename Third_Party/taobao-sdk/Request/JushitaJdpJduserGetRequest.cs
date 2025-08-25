using System;
using System.Collections.Generic;
using Top.Api.Util;

namespace Top.Api.Request
{
    /// <summary>
    /// TOP API: taobao.jushita.jdp.jduser.get
    /// </summary>
    public class JushitaJdpJduserGetRequest : BaseTopRequest<Top.Api.Response.JushitaJdpJduserGetResponse>
    {
        /// <summary>
        /// 分组
        /// </summary>
        public Nullable<long> GroupId { get; set; }

        #region ITopRequest Members

        public override string GetApiName()
        {
            return "taobao.jushita.jdp.jduser.get";
        }

        public override IDictionary<string, string> GetParameters()
        {
            TopDictionary parameters = new TopDictionary();
            parameters.Add("group_id", this.GroupId);
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
