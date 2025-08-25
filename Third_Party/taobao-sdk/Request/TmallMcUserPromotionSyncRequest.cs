using System;
using System.Collections.Generic;
using Top.Api.Util;

namespace Top.Api.Request
{
    /// <summary>
    /// TOP API: tmall.mc.user.promotion.sync
    /// </summary>
    public class TmallMcUserPromotionSyncRequest : BaseTopRequest<Top.Api.Response.TmallMcUserPromotionSyncResponse>
    {
        /// <summary>
        /// 渠道
        /// </summary>
        public string ChannelId { get; set; }

        /// <summary>
        /// 设备类型
        /// </summary>
        public string DeviceType { get; set; }

        /// <summary>
        /// 权益截止时间
        /// </summary>
        public Nullable<DateTime> EndTime { get; set; }

        /// <summary>
        /// 权益金额上限
        /// </summary>
        public string MaxPrice { get; set; }

        /// <summary>
        /// 外部权益策略ID
        /// </summary>
        public string OptionStrategyId { get; set; }

        /// <summary>
        /// 权益名称
        /// </summary>
        public string OptionStrategyName { get; set; }

        /// <summary>
        /// 权益生效时间
        /// </summary>
        public Nullable<DateTime> StartTime { get; set; }

        /// <summary>
        /// 状态信息.VALId有效，INVALID无效
        /// </summary>
        public string Status { get; set; }

        #region ITopRequest Members

        public override string GetApiName()
        {
            return "tmall.mc.user.promotion.sync";
        }

        public override IDictionary<string, string> GetParameters()
        {
            TopDictionary parameters = new TopDictionary();
            parameters.Add("channel_id", this.ChannelId);
            parameters.Add("device_type", this.DeviceType);
            parameters.Add("end_time", this.EndTime);
            parameters.Add("max_price", this.MaxPrice);
            parameters.Add("option_strategy_id", this.OptionStrategyId);
            parameters.Add("option_strategy_name", this.OptionStrategyName);
            parameters.Add("start_time", this.StartTime);
            parameters.Add("status", this.Status);
            if (this.otherParams != null)
            {
                parameters.AddAll(this.otherParams);
            }
            return parameters;
        }

        public override void Validate()
        {
            RequestValidator.ValidateRequired("channel_id", this.ChannelId);
            RequestValidator.ValidateRequired("device_type", this.DeviceType);
            RequestValidator.ValidateRequired("end_time", this.EndTime);
            RequestValidator.ValidateRequired("max_price", this.MaxPrice);
            RequestValidator.ValidateRequired("option_strategy_id", this.OptionStrategyId);
            RequestValidator.ValidateRequired("option_strategy_name", this.OptionStrategyName);
            RequestValidator.ValidateRequired("start_time", this.StartTime);
            RequestValidator.ValidateRequired("status", this.Status);
        }

        #endregion
    }
}
