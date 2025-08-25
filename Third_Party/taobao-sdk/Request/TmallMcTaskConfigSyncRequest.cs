using System;
using System.Collections.Generic;
using Top.Api.Util;

namespace Top.Api.Request
{
    /// <summary>
    /// TOP API: tmall.mc.task.config.sync
    /// </summary>
    public class TmallMcTaskConfigSyncRequest : BaseTopRequest<Top.Api.Response.TmallMcTaskConfigSyncResponse>
    {
        /// <summary>
        /// 营销任务编码
        /// </summary>
        public string BizType { get; set; }

        /// <summary>
        /// 刊例价,单位分
        /// </summary>
        public Nullable<long> Cost { get; set; }

        /// <summary>
        /// 营销任务描叙
        /// </summary>
        public string Description { get; set; }

        /// <summary>
        /// 营销任务名称
        /// </summary>
        public string Name { get; set; }

        /// <summary>
        /// 作为chargeTag字段填充到投放计划中 保存唯一，quan'j
        /// </summary>
        public string OutterId { get; set; }

        /// <summary>
        /// 定价版本号
        /// </summary>
        public string Version { get; set; }

        #region ITopRequest Members

        public override string GetApiName()
        {
            return "tmall.mc.task.config.sync";
        }

        public override IDictionary<string, string> GetParameters()
        {
            TopDictionary parameters = new TopDictionary();
            parameters.Add("biz_type", this.BizType);
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
            RequestValidator.ValidateRequired("biz_type", this.BizType);
            RequestValidator.ValidateRequired("cost", this.Cost);
            RequestValidator.ValidateRequired("description", this.Description);
            RequestValidator.ValidateRequired("name", this.Name);
            RequestValidator.ValidateRequired("outter_id", this.OutterId);
            RequestValidator.ValidateRequired("version", this.Version);
        }

        #endregion
    }
}
