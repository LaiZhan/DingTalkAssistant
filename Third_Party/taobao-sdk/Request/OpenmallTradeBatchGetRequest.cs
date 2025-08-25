using System;
using System.Collections.Generic;
using Top.Api.Util;

namespace Top.Api.Request
{
    /// <summary>
    /// TOP API: taobao.openmall.trade.batch.get
    /// </summary>
    public class OpenmallTradeBatchGetRequest : BaseTopRequest<Top.Api.Response.OpenmallTradeBatchGetResponse>
    {
        /// <summary>
        /// 渠道商Nick
        /// </summary>
        public string Distributor { get; set; }

        /// <summary>
        /// 查询范围结束时间，闭区间
        /// </summary>
        public Nullable<DateTime> EndCreated { get; set; }

        /// <summary>
        /// 查询页码，从1开始
        /// </summary>
        public Nullable<long> PageIndex { get; set; }

        /// <summary>
        /// 页面大小，不超过100
        /// </summary>
        public Nullable<long> PageSize { get; set; }

        /// <summary>
        /// 查询范围开始时间，闭区间
        /// </summary>
        public Nullable<DateTime> StartCreated { get; set; }

        #region ITopRequest Members

        public override string GetApiName()
        {
            return "taobao.openmall.trade.batch.get";
        }

        public override IDictionary<string, string> GetParameters()
        {
            TopDictionary parameters = new TopDictionary();
            parameters.Add("distributor", this.Distributor);
            parameters.Add("end_created", this.EndCreated);
            parameters.Add("page_index", this.PageIndex);
            parameters.Add("page_size", this.PageSize);
            parameters.Add("start_created", this.StartCreated);
            if (this.otherParams != null)
            {
                parameters.AddAll(this.otherParams);
            }
            return parameters;
        }

        public override void Validate()
        {
            RequestValidator.ValidateRequired("distributor", this.Distributor);
            RequestValidator.ValidateRequired("end_created", this.EndCreated);
            RequestValidator.ValidateRequired("page_index", this.PageIndex);
            RequestValidator.ValidateRequired("page_size", this.PageSize);
            RequestValidator.ValidateRequired("start_created", this.StartCreated);
        }

        #endregion
    }
}
