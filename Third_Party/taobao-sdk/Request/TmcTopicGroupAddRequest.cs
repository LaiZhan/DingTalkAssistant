using System;
using System.Collections.Generic;
using Top.Api.Util;

namespace Top.Api.Request
{
    /// <summary>
    /// TOP API: taobao.tmc.topic.group.add
    /// </summary>
    public class TmcTopicGroupAddRequest : BaseTopRequest<Top.Api.Response.TmcTopicGroupAddResponse>
    {
        /// <summary>
        /// 消息分组名，如果不存在，会自动创建
        /// </summary>
        public string GroupName { get; set; }

        /// <summary>
        /// 消息topic名称，多个以逗号(,)分割
        /// </summary>
        public string Topics { get; set; }

        #region ITopRequest Members

        public override string GetApiName()
        {
            return "taobao.tmc.topic.group.add";
        }

        public override IDictionary<string, string> GetParameters()
        {
            TopDictionary parameters = new TopDictionary();
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
