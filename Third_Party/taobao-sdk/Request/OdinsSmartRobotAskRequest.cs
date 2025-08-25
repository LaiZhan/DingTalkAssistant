using System;
using System.Collections.Generic;
using Top.Api.Util;

namespace Top.Api.Request
{
    /// <summary>
    /// TOP API: taobao.odins.smart.robot.ask
    /// </summary>
    public class OdinsSmartRobotAskRequest : BaseTopRequest<Top.Api.Response.OdinsSmartRobotAskResponse>
    {
        /// <summary>
        /// 问题内容
        /// </summary>
        public string Quesion { get; set; }

        #region ITopRequest Members

        public override string GetApiName()
        {
            return "taobao.odins.smart.robot.ask";
        }

        public override IDictionary<string, string> GetParameters()
        {
            TopDictionary parameters = new TopDictionary();
            parameters.Add("quesion", this.Quesion);
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
