using System;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace Top.Api.Response
{
    /// <summary>
    /// TmallDeviceStoreFollowurlGetResponse.
    /// </summary>
    public class TmallDeviceStoreFollowurlGetResponse : TopResponse
    {
        /// <summary>
        /// 二维码图片URL
        /// </summary>
        [XmlElement("short_img_url")]
        public string ShortImgUrl { get; set; }

        /// <summary>
        /// 二维码短链接地址
        /// </summary>
        [XmlElement("short_url")]
        public string ShortUrl { get; set; }

    }
}
