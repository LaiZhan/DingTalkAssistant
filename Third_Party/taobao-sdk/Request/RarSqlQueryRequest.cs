using System;
using System.Collections.Generic;
using Top.Api.Util;

namespace Top.Api.Request
{
    /// <summary>
    /// TOP API: taobao.rar.sql.query
    /// </summary>
    public class RarSqlQueryRequest : BaseTopRequest<Top.Api.Response.RarSqlQueryResponse>
    {
        /// <summary>
        /// 分页索引
        /// </summary>
        public Nullable<long> PageIndex { get; set; }

        /// <summary>
        /// 每页的行数
        /// </summary>
        public Nullable<long> PageSize { get; set; }

        /// <summary>
        /// SQL状态。0：无效，1：有效
        /// </summary>
        public Nullable<long> Status { get; set; }

        #region ITopRequest Members

        public override string GetApiName()
        {
            return "taobao.rar.sql.query";
        }

        public override IDictionary<string, string> GetParameters()
        {
            TopDictionary parameters = new TopDictionary();
            parameters.Add("page_index", this.PageIndex);
            parameters.Add("page_size", this.PageSize);
            parameters.Add("status", this.Status);
            if (this.otherParams != null)
            {
                parameters.AddAll(this.otherParams);
            }
            return parameters;
        }

        public override void Validate()
        {
            RequestValidator.ValidateRequired("page_index", this.PageIndex);
            RequestValidator.ValidateRequired("page_size", this.PageSize);
        }

        #endregion
    }
}
