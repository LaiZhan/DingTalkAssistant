using System;
using System.Xml.Serialization;

namespace Top.Api.Domain
{
    /// <summary>
    /// JdpUser Data Structure.
    /// </summary>
    [Serializable]
    public class JdpUser : TopObject
    {
        /// <summary>
        /// 和数据回流绑定的appkey，用户的数据推到此appkey对应的rds后，会回传X_DOWNLOADED消息
        /// </summary>
        [XmlElement("hl_appkey")]
        public string HlAppkey { get; set; }

        /// <summary>
        /// 用户等级，用于区分大卖家，值越大则订单量越大
        /// </summary>
        [XmlElement("level")]
        public long Level { get; set; }

        /// <summary>
        /// rds的id，平台appkey会返回rds_id而不是rds_name
        /// </summary>
        [XmlElement("rds_id")]
        public long RdsId { get; set; }

        /// <summary>
        /// rds数据库的实例名
        /// </summary>
        [XmlElement("rds_name")]
        public string RdsName { get; set; }

        /// <summary>
        /// 卖家类型，B表示商城卖家，C表示淘宝卖家
        /// </summary>
        [XmlElement("seller_type")]
        public string SellerType { get; set; }

        /// <summary>
        /// 0:暂停1：正常2：sessoin失效，停止3：已删除
        /// </summary>
        [XmlElement("status")]
        public long Status { get; set; }

        /// <summary>
        /// 用户id
        /// </summary>
        [XmlElement("user_id")]
        public long UserId { get; set; }

        /// <summary>
        /// 用户昵称
        /// </summary>
        [XmlElement("user_nick")]
        public string UserNick { get; set; }
    }
}
