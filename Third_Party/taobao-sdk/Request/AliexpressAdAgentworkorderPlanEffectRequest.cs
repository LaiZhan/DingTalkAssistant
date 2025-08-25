using System;
using System.Collections.Generic;
using Top.Api.Util;

namespace Top.Api.Request
{
    /// <summary>
    /// TOP API: aliexpress.ad.agentworkorder.plan.effect
    /// </summary>
    public class AliexpressAdAgentworkorderPlanEffectRequest : BaseTopRequest<Top.Api.Response.AliexpressAdAgentworkorderPlanEffectResponse>
    {
        /// <summary>
        /// AE工单单号
        /// </summary>
        public string BizNo { get; set; }

        /// <summary>
        /// 操作备注
        /// </summary>
        public string OperateDesc { get; set; }

        /// <summary>
        /// 操作结果，CONFIRM-确认,REJECT-拒绝
        /// </summary>
        public string OperateType { get; set; }

        /// <summary>
        /// 外部服务商代投工单业务单号
        /// </summary>
        public string OuterBizNo { get; set; }

        /// <summary>
        /// 投放方案推送接口有返回planId
        /// </summary>
        public Nullable<long> PlanId { get; set; }

        /// <summary>
        /// 商户id
        /// </summary>
        public Nullable<long> SellerId { get; set; }

        #region ITopRequest Members

        public override string GetApiName()
        {
            return "aliexpress.ad.agentworkorder.plan.effect";
        }

        public override IDictionary<string, string> GetParameters()
        {
            TopDictionary parameters = new TopDictionary();
            parameters.Add("biz_no", this.BizNo);
            parameters.Add("operate_desc", this.OperateDesc);
            parameters.Add("operate_type", this.OperateType);
            parameters.Add("outer_biz_no", this.OuterBizNo);
            parameters.Add("plan_id", this.PlanId);
            parameters.Add("seller_id", this.SellerId);
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
