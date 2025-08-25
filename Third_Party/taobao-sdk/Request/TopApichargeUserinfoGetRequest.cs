using System;
using System.Collections.Generic;
using Top.Api.Util;

namespace Top.Api.Request
{
    /// <summary>
    /// TOP API: taobao.top.apicharge.userinfo.get
    /// </summary>
    public class TopApichargeUserinfoGetRequest : BaseTopRequest<Top.Api.Response.TopApichargeUserinfoGetResponse>
    {
        /// <summary>
        /// 设置需要的返回字段，可供选择的有curr_month_amout,yestoday_amout,account_amout
        /// </summary>
        public string Fields { get; set; }

        #region ITopRequest Members

        public override string GetApiName()
        {
            return "taobao.top.apicharge.userinfo.get";
        }

        public override IDictionary<string, string> GetParameters()
        {
            TopDictionary parameters = new TopDictionary();
            parameters.Add("fields", this.Fields);
            if (this.otherParams != null)
            {
                parameters.AddAll(this.otherParams);
            }
            return parameters;
        }

        public override void Validate()
        {
            RequestValidator.ValidateRequired("fields", this.Fields);
        }

        #endregion
    }
}
