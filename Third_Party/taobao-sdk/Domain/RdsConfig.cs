using System;
using System.Xml.Serialization;

namespace Top.Api.Domain
{
    /// <summary>
    /// RdsConfig Data Structure.
    /// </summary>
    [Serializable]
    public class RdsConfig : TopObject
    {
        /// <summary>
        /// appkey
        /// </summary>
        [XmlElement("appkey")]
        public string Appkey { get; set; }

        /// <summary>
        /// 数据库tdp密码
        /// </summary>
        [XmlElement("db_tdp_ps")]
        public string DbTdpPs { get; set; }

        /// <summary>
        /// 数据库tdp用户名
        /// </summary>
        [XmlElement("db_tdp_user")]
        public string DbTdpUser { get; set; }

        /// <summary>
        /// 数据库类型，mysql/sqlserver
        /// </summary>
        [XmlElement("db_type")]
        public string DbType { get; set; }

        /// <summary>
        /// 数据库用户名
        /// </summary>
        [XmlElement("db_user")]
        public string DbUser { get; set; }

        /// <summary>
        /// 主机地址
        /// </summary>
        [XmlElement("host")]
        public string Host { get; set; }

        /// <summary>
        /// 数据推送rds表里的id
        /// </summary>
        [XmlElement("id")]
        public long Id { get; set; }

        /// <summary>
        /// rds数据库实例名
        /// </summary>
        [XmlElement("name")]
        public string Name { get; set; }

        /// <summary>
        /// rds数据库端口
        /// </summary>
        [XmlElement("port")]
        public string Port { get; set; }

        /// <summary>
        /// 数据库状态
        /// </summary>
        [XmlElement("status")]
        public string Status { get; set; }
    }
}
