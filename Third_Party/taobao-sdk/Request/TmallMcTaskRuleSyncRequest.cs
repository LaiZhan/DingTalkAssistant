using System;
using System.Collections.Generic;
using Top.Api.Util;

namespace Top.Api.Request
{
    /// <summary>
    /// TOP API: tmall.mc.task.rule.sync
    /// </summary>
    public class TmallMcTaskRuleSyncRequest : BaseTopRequest<Top.Api.Response.TmallMcTaskRuleSyncResponse>
    {
        /// <summary>
        /// 刊例价，单位分
        /// </summary>
        public Nullable<long> Cost { get; set; }

        /// <summary>
        /// 投放服务描述
        /// </summary>
        public string Description { get; set; }

        /// <summary>
        /// 投放服务名称
        /// </summary>
        public string Name { get; set; }

        /// <summary>
        /// 作为chargeTag字段填充到投放计划中 全局唯一
        /// </summary>
        public string OutterId { get; set; }

        /// <summary>
        /// 定价版本号
        /// </summary>
        public string Version { get; set; }

        #region ITopRequest Members

        public override string GetApiName()
        {
            return "tmall.mc.task.rule.sync";
        }

        public override IDictionary<string, string> GetParameters()
        {
            TopDictionary parameters = new TopDictionary();
            parameters.Add("cost", this.Cost);
            parameters.Add("description", this.Description);
            parameters.Add("name", this.Name);
            parameters.Add("outter_id", this.OutterId);
            parameters.Add("version", this.Version);
            if (this.otherParams != null)
            {
                parameters.AddAll(this.otherParams);
            }
            return parameters;
        }

        public override void Validate()
        {
            RequestValidator.ValidateRequired("cost", this.Cost);
            RequestValidator.ValidateRequired("description", this.Description);
            RequestValidator.ValidateRequired("name", this.Name);
            RequestValidator.ValidateRequired("outter_id", this.OutterId);
            RequestValidator.ValidateRequired("version", this.Version);
        }

        #endregion
    }
}
