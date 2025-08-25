using System;
using System.Collections.Generic;
using Top.Api.Util;

namespace Top.Api.Request
{
    /// <summary>
    /// TOP API: aliexpress.ad.agentworkorder.plan.create
    /// </summary>
    public class AliexpressAdAgentworkorderPlanCreateRequest : BaseTopRequest<Top.Api.Response.AliexpressAdAgentworkorderPlanCreateResponse>
    {
        /// <summary>
        /// 广告类型信息
        /// </summary>
        public string AdTypes { get; set; }

        /// <summary>
        /// AE工单单号
        /// </summary>
        public string BizNo { get; set; }

        /// <summary>
        /// 金额币种单位，默认美元
        /// </summary>
        public string BudgetCurrency { get; set; }

        /// <summary>
        /// 预算投放计划
        /// </summary>
        public string BudgetPlans { get; set; }

        /// <summary>
        /// 预计点击人数
        /// </summary>
        public Nullable<long> ClickCnt { get; set; }

        /// <summary>
        /// 预计cpc，单位为分，整数
        /// </summary>
        public Nullable<long> Cpc { get; set; }

        /// <summary>
        /// 人群策略，json字符串
        /// </summary>
        public string CrowdStrategy { get; set; }

        /// <summary>
        /// 预计曝光人群数量
        /// </summary>
        public Nullable<long> ImpressCnt { get; set; }

        /// <summary>
        /// 素材策略
        /// </summary>
        public string MaterialStrategies { get; set; }

        /// <summary>
        /// 优化策略
        /// </summary>
        public string OptimizeStrategies { get; set; }

        /// <summary>
        /// 部服务商代投工单业务单号
        /// </summary>
        public string OuterBizNo { get; set; }

        /// <summary>
        /// 商家ID
        /// </summary>
        public Nullable<long> SellerId { get; set; }

        /// <summary>
        /// 预计uv
        /// </summary>
        public Nullable<long> Uv { get; set; }

        #region ITopRequest Members

        public override string GetApiName()
        {
            return "aliexpress.ad.agentworkorder.plan.create";
        }

        public override IDictionary<string, string> GetParameters()
        {
            TopDictionary parameters = new TopDictionary();
            parameters.Add("ad_types", this.AdTypes);
            parameters.Add("biz_no", this.BizNo);
            parameters.Add("budget_currency", this.BudgetCurrency);
            parameters.Add("budget_plans", this.BudgetPlans);
            parameters.Add("click_cnt", this.ClickCnt);
            parameters.Add("cpc", this.Cpc);
            parameters.Add("crowd_strategy", this.CrowdStrategy);
            parameters.Add("impress_cnt", this.ImpressCnt);
            parameters.Add("material_strategies", this.MaterialStrategies);
            parameters.Add("optimize_strategies", this.OptimizeStrategies);
            parameters.Add("outer_biz_no", this.OuterBizNo);
            parameters.Add("seller_id", this.SellerId);
            parameters.Add("uv", this.Uv);
            if (this.otherParams != null)
            {
                parameters.AddAll(this.otherParams);
            }
            return parameters;
        }

        public override void Validate()
        {
            RequestValidator.ValidateRequired("biz_no", this.BizNo);
            RequestValidator.ValidateRequired("click_cnt", this.ClickCnt);
            RequestValidator.ValidateRequired("impress_cnt", this.ImpressCnt);
            RequestValidator.ValidateRequired("outer_biz_no", this.OuterBizNo);
            RequestValidator.ValidateRequired("seller_id", this.SellerId);
            RequestValidator.ValidateRequired("uv", this.Uv);
        }

        #endregion
    }
}
