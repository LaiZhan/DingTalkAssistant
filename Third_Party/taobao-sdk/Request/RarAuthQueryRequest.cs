using System;
using System.Collections.Generic;
using Top.Api.Util;

namespace Top.Api.Request
{
    /// <summary>
    /// TOP API: taobao.rar.auth.query
    /// </summary>
    public class RarAuthQueryRequest : BaseTopRequest<Top.Api.Response.RarAuthQueryResponse>
    {
        /// <summary>
        /// 需要查询的用户
        /// </summary>
        public string Nick { get; set; }

        /// <summary>
        /// 分页索引
        /// </summary>
        public Nullable<long> PageIndex { get; set; }

        /// <summary>
        /// 每页的行数
        /// </summary>
        public Nullable<long> PageSize { get; set; }

        /// <summary>
        /// 授权状态。0：无效，1：有效
        /// </summary>
        public Nullable<long> Status { get; set; }

        #region ITopRequest Members

        public override string GetApiName()
        {
            return "taobao.rar.auth.query";
        }

        public override IDictionary<string, string> GetParameters()
        {
            TopDictionary parameters = new TopDictionary();
            parameters.Add("nick", this.Nick);
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
