using System;
using System.Xml.Serialization;

namespace Top.Api.Domain
{
    /// <summary>
    /// AppBaseInfo Data Structure.
    /// </summary>
    [Serializable]
    public class AppBaseInfo : TopObject
    {
        /// <summary>
        /// app状态，1.线上运行, 2. 正式环境测试中, 6.开发中
        /// </summary>
        [XmlElement("app_status")]
        public long AppStatus { get; set; }

        /// <summary>
        /// app的唯一标识：app key
        /// </summary>
        [XmlElement("appkey")]
        public string Appkey { get; set; }

        /// <summary>
        /// app描述
        /// </summary>
        [XmlElement("description")]
        public string Description { get; set; }

        /// <summary>
        /// isv的数字id
        /// </summary>
        [XmlElement("isv_id")]
        public long IsvId { get; set; }

        /// <summary>
        /// Null
        /// </summary>
        [XmlElement("support_email")]
        public string SupportEmail { get; set; }

        /// <summary>
        /// app名称
        /// </summary>
        [XmlElement("title")]
        public string Title { get; set; }

        /// <summary>
        /// 开发者旺旺
        /// </summary>
        [XmlElement("wangwang")]
        public string Wangwang { get; set; }
    }
}
