using System;
using System.Collections.Generic;
using Top.Api.Util;

namespace Top.Api.Request
{
    /// <summary>
    /// TOP API: taobao.jushita.jdp.users.get
    /// </summary>
    public class JushitaJdpUsersGetRequest : BaseTopRequest<Top.Api.Response.JushitaJdpUsersGetResponse>
    {
        /// <summary>
        /// 此参数一般不用传，用于查询最后更改时间在某个时间段内的用户
        /// </summary>
        public Nullable<DateTime> EndModified { get; set; }

        /// <summary>
        /// 当前页数
        /// </summary>
        public Nullable<long> PageNo { get; set; }

        /// <summary>
        /// 每页记录数，默认200
        /// </summary>
        public Nullable<long> PageSize { get; set; }

        /// <summary>
        /// 此参数一般不用传，用于查询最后更改时间在某个时间段内的用户
        /// </summary>
        public Nullable<DateTime> StartModified { get; set; }

        /// <summary>
        /// 普通isv不能传入此参数
        /// </summary>
        public string TargetAppkey { get; set; }

        /// <summary>
        /// 如果传了user_id表示单条查询
        /// </summary>
        public Nullable<long> UserId { get; set; }

        #region ITopRequest Members

        public override string GetApiName()
        {
            return "taobao.jushita.jdp.users.get";
        }

        public override IDictionary<string, string> GetParameters()
        {
            TopDictionary parameters = new TopDictionary();
            parameters.Add("end_modified", this.EndModified);
            parameters.Add("page_no", this.PageNo);
            parameters.Add("page_size", this.PageSize);
            parameters.Add("start_modified", this.StartModified);
            parameters.Add("target_appkey", this.TargetAppkey);
            parameters.Add("user_id", this.UserId);
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
