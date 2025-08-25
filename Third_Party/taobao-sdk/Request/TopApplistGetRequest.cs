using System;
using System.Collections.Generic;
using Top.Api.Util;

namespace Top.Api.Request
{
    /// <summary>
    /// TOP API: taobao.top.applist.get
    /// </summary>
    public class TopApplistGetRequest : BaseTopRequest<Top.Api.Response.TopApplistGetResponse>
    {
        /// <summary>
        /// isv user id
        /// </summary>
        public Nullable<long> IsvId { get; set; }

        #region ITopRequest Members

        public override string GetApiName()
        {
            return "taobao.top.applist.get";
        }

        public override IDictionary<string, string> GetParameters()
        {
            TopDictionary parameters = new TopDictionary();
            parameters.Add("isv_id", this.IsvId);
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
