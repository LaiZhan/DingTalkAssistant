using System;
using System.Collections.Generic;
using Top.Api.Util;

namespace Top.Api.Request
{
    /// <summary>
    /// TOP API: taobao.jds.trade.traces.get
    /// </summary>
    public class JdsTradeTracesGetRequest : BaseTopRequest<Top.Api.Response.JdsTradeTracesGetResponse>
    {
        /// <summary>
        /// 是否返回用户的状态(是否存在)
        /// </summary>
        public Nullable<bool> ReturnUserStatus { get; set; }

        /// <summary>
        /// 淘宝的订单tid
        /// </summary>
        public Nullable<long> Tid { get; set; }

        #region ITopRequest Members

        public override string GetApiName()
        {
            return "taobao.jds.trade.traces.get";
        }

        public override IDictionary<string, string> GetParameters()
        {
            TopDictionary parameters = new TopDictionary();
            parameters.Add("return_user_status", this.ReturnUserStatus);
            parameters.Add("tid", this.Tid);
            if (this.otherParams != null)
            {
                parameters.AddAll(this.otherParams);
            }
            return parameters;
        }

        public override void Validate()
        {
            RequestValidator.ValidateRequired("tid", this.Tid);
        }

        #endregion
    }
}
