using System;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace Top.Api.Response
{
    /// <summary>
    /// TradeVoucherUploadResponse.
    /// </summary>
    public class TradeVoucherUploadResponse : TopResponse
    {
        /// <summary>
        /// 上传到多媒体平台的文件
        /// </summary>
        [XmlElement("file")]
        public Top.Api.Domain.File File { get; set; }

    }
}
