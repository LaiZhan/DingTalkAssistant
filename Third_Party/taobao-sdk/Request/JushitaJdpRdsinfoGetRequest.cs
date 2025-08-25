using System;
using System.Collections.Generic;
using Top.Api.Util;

namespace Top.Api.Request
{
    /// <summary>
    /// TOP API: taobao.jushita.jdp.rdsinfo.get
    /// </summary>
    public class JushitaJdpRdsinfoGetRequest : BaseTopRequest<Top.Api.Response.JushitaJdpRdsinfoGetResponse>
    {
        /// <summary>
        /// 查询的appkey
        /// </summary>
        public string TargetAppkey { get; set; }

        #region ITopRequest Members

        public override string GetApiName()
        {
            return "taobao.jushita.jdp.rdsinfo.get";
        }

        public override IDictionary<string, string> GetParameters()
        {
            TopDictionary parameters = new TopDictionary();
            parameters.Add("target_appkey", this.TargetAppkey);
            if (this.otherParams != null)
            {
                parameters.AddAll(this.otherParams);
            }
            return parameters;
        }

        public override void Validate()
        {
            RequestValidator.ValidateRequired("target_appkey", this.TargetAppkey);
        }

        #endregion
    }
}
