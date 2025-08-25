using System;
using System.Collections.Generic;
using Top.Api.Util;

namespace Top.Api.Request
{
    /// <summary>
    /// TOP API: taobao.huanlang.test.service.combine
    /// </summary>
    public class HuanlangTestServiceCombineRequest : BaseTopRequest<Top.Api.Response.HuanlangTestServiceCombineResponse>
    {
        /// <summary>
        /// 12312
        /// </summary>
        public string Appkey { get; set; }

        #region ITopRequest Members

        public override string GetApiName()
        {
            return "taobao.huanlang.test.service.combine";
        }

        public override IDictionary<string, string> GetParameters()
        {
            TopDictionary parameters = new TopDictionary();
            parameters.Add("appkey", this.Appkey);
            if (this.otherParams != null)
            {
                parameters.AddAll(this.otherParams);
            }
            return parameters;
        }

        public override void Validate()
        {
            RequestValidator.ValidateRequired("appkey", this.Appkey);
        }

        #endregion
    }
}
