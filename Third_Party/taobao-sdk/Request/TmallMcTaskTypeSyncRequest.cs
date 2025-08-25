using System;
using System.Collections.Generic;
using Top.Api.Util;

namespace Top.Api.Request
{
    /// <summary>
    /// TOP API: tmall.mc.task.type.sync
    /// </summary>
    public class TmallMcTaskTypeSyncRequest : BaseTopRequest<Top.Api.Response.TmallMcTaskTypeSyncResponse>
    {
        /// <summary>
        /// 渠道是否需要结算。0, 不需要，1：需要
        /// </summary>
        public Nullable<long> ChannelPay { get; set; }

        /// <summary>
        /// 投放类型编码
        /// </summary>
        public string Code { get; set; }

        /// <summary>
        /// 投放计划任务类型的描述
        /// </summary>
        public string Comment { get; set; }

        /// <summary>
        /// 投放时间限制，0为不限
        /// </summary>
        public Nullable<long> DayLimit { get; set; }

        /// <summary>
        /// 名称
        /// </summary>
        public string Name { get; set; }

        /// <summary>
        /// 不可用场景，可不填
        /// </summary>
        public string NotScene { get; set; }

        /// <summary>
        /// 每日投放限额，0为不限
        /// </summary>
        public Nullable<long> QuotaDayLimit { get; set; }

        /// <summary>
        /// 投放限额，0为不限
        /// </summary>
        public Nullable<long> QuotaLimit { get; set; }

        /// <summary>
        /// 可用场景，可不填
        /// </summary>
        public string Scene { get; set; }

        /// <summary>
        /// 商家是否需要结算。0, 不需要，1：需要
        /// </summary>
        public Nullable<long> SellerPay { get; set; }

        #region ITopRequest Members

        public override string GetApiName()
        {
            return "tmall.mc.task.type.sync";
        }

        public override IDictionary<string, string> GetParameters()
        {
            TopDictionary parameters = new TopDictionary();
            parameters.Add("channel_pay", this.ChannelPay);
            parameters.Add("code", this.Code);
            parameters.Add("comment", this.Comment);
            parameters.Add("day_limit", this.DayLimit);
            parameters.Add("name", this.Name);
            parameters.Add("not_scene", this.NotScene);
            parameters.Add("quota_day_limit", this.QuotaDayLimit);
            parameters.Add("quota_limit", this.QuotaLimit);
            parameters.Add("scene", this.Scene);
            parameters.Add("seller_pay", this.SellerPay);
            if (this.otherParams != null)
            {
                parameters.AddAll(this.otherParams);
            }
            return parameters;
        }

        public override void Validate()
        {
            RequestValidator.ValidateRequired("channel_pay", this.ChannelPay);
            RequestValidator.ValidateRequired("code", this.Code);
            RequestValidator.ValidateRequired("day_limit", this.DayLimit);
            RequestValidator.ValidateRequired("name", this.Name);
            RequestValidator.ValidateRequired("quota_day_limit", this.QuotaDayLimit);
            RequestValidator.ValidateRequired("quota_limit", this.QuotaLimit);
            RequestValidator.ValidateRequired("seller_pay", this.SellerPay);
        }

        #endregion
    }
}
