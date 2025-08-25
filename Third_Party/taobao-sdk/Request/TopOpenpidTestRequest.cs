using System;
using System.Collections.Generic;
using Top.Api.Util;

namespace Top.Api.Request
{
    /// <summary>
    /// TOP API: taobao.top.openpid.test
    /// </summary>
    public class TopOpenpidTestRequest : BaseTopRequest<Top.Api.Response.TopOpenpidTestResponse>
    {
        /// <summary>
        /// isvId
        /// </summary>
        public Nullable<long> IsvId { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public string UnNamed { get; set; }

        #region ITopRequest Members

        public override string GetApiName()
        {
            return "taobao.top.openpid.test";
        }

        public override IDictionary<string, string> GetParameters()
        {
            TopDictionary parameters = new TopDictionary();
            parameters.Add("isv_id", this.IsvId);
            parameters.Add("un_named", this.UnNamed);
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
