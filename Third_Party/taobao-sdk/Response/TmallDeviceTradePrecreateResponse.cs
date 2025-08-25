using System;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace Top.Api.Response
{
    /// <summary>
    /// TmallDeviceTradePrecreateResponse.
    /// </summary>
    public class TmallDeviceTradePrecreateResponse : TopResponse
    {
        /// <summary>
        /// 链接有效结束时间
        /// </summary>
        [XmlElement("life_end")]
        public string LifeEnd { get; set; }

        /// <summary>
        /// 链接有效起始时间
        /// </summary>
        [XmlElement("life_start")]
        public string LifeStart { get; set; }

        /// <summary>
        /// 链接二维码图片
        /// </summary>
        [XmlElement("qr_code")]
        public string QrCode { get; set; }

        /// <summary>
        /// 短链接
        /// </summary>
        [XmlElement("short_url")]
        public string ShortUrl { get; set; }

    }
}
