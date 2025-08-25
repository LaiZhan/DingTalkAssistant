using System;
using System.Collections.Generic;
using Top.Api.Util;

namespace Top.Api.Request
{
    /// <summary>
    /// TOP API: wdk.rex.user.auth.query
    /// </summary>
    public class WdkRexUserAuthQueryRequest : BaseTopRequest<Top.Api.Response.WdkRexUserAuthQueryResponse>
    {
        /// <summary>
        /// 业务key
        /// </summary>
        public string AccessKey { get; set; }

        /// <summary>
        /// 业务签名
        /// </summary>
        public string AccessSign { get; set; }

        /// <summary>
        /// 是否合并搜索上级组织架构
        /// </summary>
        public Nullable<bool> NeedMerge { get; set; }

        /// <summary>
        /// 组织架构code
        /// </summary>
        public string OuCode { get; set; }

        /// <summary>
        /// 页码
        /// </summary>
        public Nullable<long> PageNum { get; set; }

        /// <summary>
        /// 页大小
        /// </summary>
        public Nullable<long> PageSize { get; set; }

        /// <summary>
        /// 角色code的列表
        /// </summary>
        public string RoleCodes { get; set; }

        #region ITopRequest Members

        public override string GetApiName()
        {
            return "wdk.rex.user.auth.query";
        }

        public override IDictionary<string, string> GetParameters()
        {
            TopDictionary parameters = new TopDictionary();
            parameters.Add("access_key", this.AccessKey);
            parameters.Add("access_sign", this.AccessSign);
            parameters.Add("need_merge", this.NeedMerge);
            parameters.Add("ou_code", this.OuCode);
            parameters.Add("page_num", this.PageNum);
            parameters.Add("page_size", this.PageSize);
            parameters.Add("role_codes", this.RoleCodes);
            if (this.otherParams != null)
            {
                parameters.AddAll(this.otherParams);
            }
            return parameters;
        }

        public override void Validate()
        {
            RequestValidator.ValidateRequired("access_key", this.AccessKey);
            RequestValidator.ValidateRequired("access_sign", this.AccessSign);
            RequestValidator.ValidateRequired("ou_code", this.OuCode);
        }

        #endregion
    }
}
