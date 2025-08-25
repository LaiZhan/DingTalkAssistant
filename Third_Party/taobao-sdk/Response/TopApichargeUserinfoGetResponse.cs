using System;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace Top.Api.Response
{
    /// <summary>
    /// TopApichargeUserinfoGetResponse.
    /// </summary>
    public class TopApichargeUserinfoGetResponse : TopResponse
    {
        /// <summary>
        /// 账户余额（单位：人民币元）
        /// </summary>
        [XmlElement("account_amout")]
        public string AccountAmout { get; set; }

        /// <summary>
        /// 本月消费金额（单位：人民币元）
        /// </summary>
        [XmlElement("curr_month_amout")]
        public string CurrMonthAmout { get; set; }

        /// <summary>
        /// 昨日消费金额（单位：人民币元）
        /// </summary>
        [XmlElement("yestoday_amout")]
        public string YestodayAmout { get; set; }

    }
}
