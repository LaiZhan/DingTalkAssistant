using System;
using System.Collections.Generic;
using Top.Api.Util;

namespace Top.Api.Request
{
    /// <summary>
    /// TOP API: taobao.tmc.topic.group.delete
    /// </summary>
    public class TmcTopicGroupDeleteRequest : BaseTopRequest<Top.Api.Response.TmcTopicGroupDeleteResponse>
    {
        /// <summary>
        /// 消息分组Id，一般不用填写，如果分组已经被删除，则根据问题排查工具返回的ID删除路由关系
        /// </summary>
        public Nullable<long> GroupId { get; set; }

        /// <summary>
        /// 消息分组名
        /// </summary>
        public string GroupName { get; set; }

        /// <summary>
        /// 消息topic名称，多个以逗号(,)分割
        /// </summary>
        public string Topics { get; set; }

        #region ITopRequest Members

        public override string GetApiName()
        {
            return "taobao.tmc.topic.group.delete";
        }

        public override IDictionary<string, string> GetParameters()
        {
            TopDictionary parameters = new TopDictionary();
            parameters.Add("group_id", this.GroupId);
            parameters.Add("group_name", this.GroupName);
            parameters.Add("topics", this.Topics);
            if (this.otherParams != null)
            {
                parameters.AddAll(this.otherParams);
            }
            return parameters;
        }

        public override void Validate()
        {
            RequestValidator.ValidateRequired("group_name", this.GroupName);
            RequestValidator.ValidateRequired("topics", this.Topics);
            RequestValidator.ValidateMaxListSize("topics", this.Topics, 20);
        }

        #endregion
    }
}
