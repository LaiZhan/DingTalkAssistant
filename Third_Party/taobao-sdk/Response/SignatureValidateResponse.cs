using System;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace Top.Api.Response
{
    /// <summary>
    /// SignatureValidateResponse.
    /// </summary>
    public class SignatureValidateResponse : TopResponse
    {
        /// <summary>
        /// appkey拥有者ID
        /// </summary>
        [XmlElement("isv_id")]
        public long IsvId { get; set; }

        /// <summary>
        /// 验证成功后返回加密的secret信息，秘钥为signature的前8位
        /// </summary>
        [XmlElement("secret")]
        public string Secret { get; set; }

        /// <summary>
        /// 签名是否有效
        /// </summary>
        [XmlElement("valid")]
        public bool Valid { get; set; }

    }
}
