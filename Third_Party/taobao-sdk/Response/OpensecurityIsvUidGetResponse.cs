using System;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace Top.Api.Response
{
    /// <summary>
    /// OpensecurityIsvUidGetResponse.
    /// </summary>
    public class OpensecurityIsvUidGetResponse : TopResponse
    {
        /// <summary>
        /// open security tbUserId for ISV，淘宝账号对ISV级别的唯一open security ID，用于同一个ISV多个Appkey间数据共享。
        /// </summary>
        [XmlElement("open_uid_isv")]
        public string OpenUidIsv { get; set; }

    }
}
