using System;
using System.Collections.Generic;
using Top.Api.Util;

namespace Top.Api.Request
{
    /// <summary>
    /// TOP API: taobao.topapi.performance.test
    /// </summary>
    public class TopapiPerformanceTestRequest : BaseTopRequest<Top.Api.Response.TopapiPerformanceTestResponse>
    {
        /// <summary>
        /// 123
        /// </summary>
        public string Commond { get; set; }

        /// <summary>
        /// 123
        /// </summary>
        public string Factor { get; set; }

        /// <summary>
        /// 123
        /// </summary>
        public Nullable<long> Rt { get; set; }

        #region ITopRequest Members

        public override string GetApiName()
        {
            return "taobao.topapi.performance.test";
        }

        public override IDictionary<string, string> GetParameters()
        {
            TopDictionary parameters = new TopDictionary();
            parameters.Add("commond", this.Commond);
            parameters.Add("factor", this.Factor);
            parameters.Add("rt", this.Rt);
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
