using System;
using System.Collections.Generic;
using Top.Api.Util;

namespace Top.Api.Request
{
    /// <summary>
    /// TOP API: taobao.jushita.jdp.common.query
    /// </summary>
    public class JushitaJdpCommonQueryRequest : BaseTopRequest<Top.Api.Response.JushitaJdpCommonQueryResponse>
    {
        /// <summary>
        /// 查询名称
        /// </summary>
        public string CmdName { get; set; }

        /// <summary>
        /// json参数
        /// </summary>
        public string Params { get; set; }

        #region ITopRequest Members

        public override string GetApiName()
        {
            return "taobao.jushita.jdp.common.query";
        }

        public override IDictionary<string, string> GetParameters()
        {
            TopDictionary parameters = new TopDictionary();
            parameters.Add("cmd_name", this.CmdName);
            parameters.Add("params", this.Params);
            if (this.otherParams != null)
            {
                parameters.AddAll(this.otherParams);
            }
            return parameters;
        }

        public override void Validate()
        {
            RequestValidator.ValidateRequired("cmd_name", this.CmdName);
            RequestValidator.ValidateRequired("params", this.Params);
        }

        #endregion
    }
}
