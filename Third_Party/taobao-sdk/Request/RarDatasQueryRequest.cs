using System;
using System.Collections.Generic;
using Top.Api.Util;

namespace Top.Api.Request
{
    /// <summary>
    /// TOP API: taobao.rar.datas.query
    /// </summary>
    public class RarDatasQueryRequest : BaseTopRequest<Top.Api.Response.RarDatasQueryResponse>
    {
        /// <summary>
        /// 分页页码
        /// </summary>
        public Nullable<long> PageIndex { get; set; }

        /// <summary>
        /// 每页最大值
        /// </summary>
        public Nullable<long> PageSize { get; set; }

        /// <summary>
        /// sql中的业务参数,JSOn格式
        /// </summary>
        public string Params { get; set; }

        /// <summary>
        /// RAR分配的sqlId
        /// </summary>
        public Nullable<long> SqlId { get; set; }

        /// <summary>
        /// 商家授权产生的token
        /// </summary>
        public string Token { get; set; }

        #region ITopRequest Members

        public override string GetApiName()
        {
            return "taobao.rar.datas.query";
        }

        public override IDictionary<string, string> GetParameters()
        {
            TopDictionary parameters = new TopDictionary();
            parameters.Add("page_index", this.PageIndex);
            parameters.Add("page_size", this.PageSize);
            parameters.Add("params", this.Params);
            parameters.Add("sql_id", this.SqlId);
            parameters.Add("token", this.Token);
            if (this.otherParams != null)
            {
                parameters.AddAll(this.otherParams);
            }
            return parameters;
        }

        public override void Validate()
        {
            RequestValidator.ValidateRequired("page_index", this.PageIndex);
            RequestValidator.ValidateRequired("params", this.Params);
            RequestValidator.ValidateRequired("sql_id", this.SqlId);
            RequestValidator.ValidateRequired("token", this.Token);
        }

        #endregion
    }
}
