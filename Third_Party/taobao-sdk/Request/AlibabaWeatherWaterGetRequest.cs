using System;
using System.Collections.Generic;
using Top.Api.Util;

namespace Top.Api.Request
{
    /// <summary>
    /// TOP API: alibaba.weather.water.get
    /// </summary>
    public class AlibabaWeatherWaterGetRequest : BaseTopRequest<Top.Api.Response.AlibabaWeatherWaterGetResponse>
    {
        /// <summary>
        /// 流域名称，查询流域为“长江流域”，则输入“长江流域”
        /// </summary>
        public string River { get; set; }

        #region ITopRequest Members

        public override string GetApiName()
        {
            return "alibaba.weather.water.get";
        }

        public override IDictionary<string, string> GetParameters()
        {
            TopDictionary parameters = new TopDictionary();
            parameters.Add("river", this.River);
            if (this.otherParams != null)
            {
                parameters.AddAll(this.otherParams);
            }
            return parameters;
        }

        public override void Validate()
        {
            RequestValidator.ValidateRequired("river", this.River);
        }

        #endregion
    }
}
