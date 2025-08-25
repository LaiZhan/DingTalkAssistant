using System;
using System.Collections.Generic;
using Top.Api.Util;

namespace Top.Api.Request
{
    /// <summary>
    /// TOP API: taobao.jushita.jdp.user.add
    /// </summary>
    public class JushitaJdpUserAddRequest : BaseTopRequest<Top.Api.Response.JushitaJdpUserAddResponse>
    {
        /// <summary>
        /// 推送历史数据天数，只能为90天内，包含90天。当此参数不填时，表示以页面中应用配置的历史天数为准；如果为0表示这个用户不推送历史数据；其它表示推送的历史天数。
        /// </summary>
        public Nullable<long> HistoryDays { get; set; }

        /// <summary>
        /// 已废弃，新版订单同步服务不要使用。同步用户数据的机器IP,必须是界面配置的IP。
        /// </summary>
        public string HostIp { get; set; }

        /// <summary>
        /// 已废弃，新版订单同步服务不要使用。绑定类型，用户数据同步的机器名称。
        /// </summary>
        public string HostName { get; set; }

        /// <summary>
        /// RDS实例名称
        /// </summary>
        public string RdsName { get; set; }

        /// <summary>
        /// 已废弃，使用页面中应用的配置。用户同步的数据类型,多个用','号分割。可选值：trade,refund,item
        /// </summary>
        public string Topics { get; set; }

        #region ITopRequest Members

        public override string GetApiName()
        {
            return "taobao.jushita.jdp.user.add";
        }

        public override IDictionary<string, string> GetParameters()
        {
            TopDictionary parameters = new TopDictionary();
            parameters.Add("history_days", this.HistoryDays);
            parameters.Add("host_ip", this.HostIp);
            parameters.Add("host_name", this.HostName);
            parameters.Add("rds_name", this.RdsName);
            parameters.Add("topics", this.Topics);
            if (this.otherParams != null)
            {
                parameters.AddAll(this.otherParams);
            }
            return parameters;
        }

        public override void Validate()
        {
            RequestValidator.ValidateMaxValue("history_days", this.HistoryDays, 90);
            RequestValidator.ValidateMinValue("history_days", this.HistoryDays, 0);
            RequestValidator.ValidateMaxLength("host_name", this.HostName, 60);
            RequestValidator.ValidateRequired("rds_name", this.RdsName);
            RequestValidator.ValidateMaxListSize("topics", this.Topics, 16);
        }

        #endregion
    }
}
