using System;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace Top.Api.Response
{
    /// <summary>
    /// TmallMcUserGetResponse.
    /// </summary>
    public class TmallMcUserGetResponse : TopResponse
    {
        /// <summary>
        /// 账户信息
        /// </summary>
        [XmlElement("account_no")]
        public string AccountNo { get; set; }

        /// <summary>
        /// 累计虚拟金额
        /// </summary>
        [XmlElement("accu_amount")]
        public string AccuAmount { get; set; }

        /// <summary>
        /// 实际累计充值金额
        /// </summary>
        [XmlElement("actual_amount")]
        public string ActualAmount { get; set; }

        /// <summary>
        /// 账户余额
        /// </summary>
        [XmlElement("balance")]
        public string Balance { get; set; }

        /// <summary>
        /// 品牌商用户ID
        /// </summary>
        [XmlElement("brand_user_id")]
        public string BrandUserId { get; set; }

        /// <summary>
        /// 品牌名称
        /// </summary>
        [XmlElement("brand_user_nick")]
        public string BrandUserNick { get; set; }

        /// <summary>
        /// 公司名称
        /// </summary>
        [XmlElement("company")]
        public string Company { get; set; }

        /// <summary>
        /// 联系人信息
        /// </summary>
        [XmlElement("contact_name")]
        public string ContactName { get; set; }

        /// <summary>
        /// 联系人手机号码
        /// </summary>
        [XmlElement("contact_phone")]
        public string ContactPhone { get; set; }

        /// <summary>
        /// 行业信息
        /// </summary>
        [XmlElement("industry")]
        public string Industry { get; set; }

        /// <summary>
        /// 代理商用户ID
        /// </summary>
        [XmlElement("proxy_user_id")]
        public string ProxyUserId { get; set; }

        /// <summary>
        /// 代理nick
        /// </summary>
        [XmlElement("proxy_user_nick")]
        public string ProxyUserNick { get; set; }

        /// <summary>
        /// 用户ID
        /// </summary>
        [XmlElement("user_id")]
        public string UserId { get; set; }

    }
}
