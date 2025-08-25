using System;
using System.Collections.Generic;
using Top.Api.Util;

namespace Top.Api.Request
{
    /// <summary>
    /// TOP API: taobao.jushita.jdp.query.biz
    /// </summary>
    public class JushitaJdpQueryBizRequest : BaseTopRequest<Top.Api.Response.JushitaJdpQueryBizResponse>
    {
        /// <summary>
        /// 返回结果
        /// </summary>
        public string BizResponse { get; set; }

        /// <summary>
        /// 查询密钥
        /// </summary>
        public string QueryKey { get; set; }

        #region ITopRequest Members

        public override string GetApiName()
        {
            return "taobao.jushita.jdp.query.biz";
        }

        public override IDictionary<string, string> GetParameters()
        {
            TopDictionary parameters = new TopDictionary();
            parameters.Add("biz_response", this.BizResponse);
            parameters.Add("query_key", this.QueryKey);
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
