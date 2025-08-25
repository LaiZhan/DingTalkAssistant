using System;
using System.Collections.Generic;
using Top.Api.Util;

namespace Top.Api.Request
{
    /// <summary>
    /// TOP API: taobao.opensecurity.isv.uid.get
    /// </summary>
    public class OpensecurityIsvUidGetRequest : BaseTopRequest<Top.Api.Response.OpensecurityIsvUidGetResponse>
    {
        /// <summary>
        /// 基于Appkey生成的open security淘宝用户Id
        /// </summary>
        public string OpenUid { get; set; }

        #region ITopRequest Members

        public override string GetApiName()
        {
            return "taobao.opensecurity.isv.uid.get";
        }

        public override IDictionary<string, string> GetParameters()
        {
            TopDictionary parameters = new TopDictionary();
            parameters.Add("open_uid", this.OpenUid);
            if (this.otherParams != null)
            {
                parameters.AddAll(this.otherParams);
            }
            return parameters;
        }

        public override void Validate()
        {
            RequestValidator.ValidateRequired("open_uid", this.OpenUid);
        }

        #endregion
    }
}
