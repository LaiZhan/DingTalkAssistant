using System;
using System.Collections.Generic;
using Top.Api.Util;

namespace Top.Api.Request
{
    /// <summary>
    /// TOP API: taobao.jushita.jdp.tasks.get
    /// </summary>
    public class JushitaJdpTasksGetRequest : BaseTopRequest<Top.Api.Response.JushitaJdpTasksGetResponse>
    {
        /// <summary>
        /// 最大可返回的任务数量
        /// </summary>
        public Nullable<long> FetchNum { get; set; }

        /// <summary>
        /// 普通isv不能传入此参数
        /// </summary>
        public string TargetAppkey { get; set; }

        /// <summary>
        /// 任务分组数量，表示把所有任务平均分成x组，在线订购应用此参数必传；非在线订购应用此参数忽略。
        /// </summary>
        public Nullable<long> TaskItemNum { get; set; }

        /// <summary>
        /// 指定获取哪些分组的任务，取多个分组有半角逗号分隔，在线订购应用此参数必传；非在线订购应用此参数忽略。其中task_items >= 0且task_items < task_item_num
        /// </summary>
        public string TaskItems { get; set; }

        /// <summary>
        /// 任务类型
        /// </summary>
        public Nullable<long> Type { get; set; }

        /// <summary>
        /// 需要查询哪些用户的任务，非在线订购应用此参数必传；在线订购应用此参数忽略。
        /// </summary>
        public string UserIds { get; set; }

        #region ITopRequest Members

        public override string GetApiName()
        {
            return "taobao.jushita.jdp.tasks.get";
        }

        public override IDictionary<string, string> GetParameters()
        {
            TopDictionary parameters = new TopDictionary();
            parameters.Add("fetch_num", this.FetchNum);
            parameters.Add("target_appkey", this.TargetAppkey);
            parameters.Add("task_item_num", this.TaskItemNum);
            parameters.Add("task_items", this.TaskItems);
            parameters.Add("type", this.Type);
            parameters.Add("user_ids", this.UserIds);
            if (this.otherParams != null)
            {
                parameters.AddAll(this.otherParams);
            }
            return parameters;
        }

        public override void Validate()
        {
            RequestValidator.ValidateMaxValue("fetch_num", this.FetchNum, 200);
            RequestValidator.ValidateMinValue("fetch_num", this.FetchNum, 1);
            RequestValidator.ValidateMinValue("task_item_num", this.TaskItemNum, 1);
            RequestValidator.ValidateMaxListSize("task_items", this.TaskItems, 500);
            RequestValidator.ValidateRequired("type", this.Type);
            RequestValidator.ValidateMinValue("type", this.Type, 0);
            RequestValidator.ValidateMaxListSize("user_ids", this.UserIds, 200);
        }

        #endregion
    }
}
