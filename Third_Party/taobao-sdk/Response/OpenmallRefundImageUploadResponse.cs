using System;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace Top.Api.Response
{
    /// <summary>
    /// OpenmallRefundImageUploadResponse.
    /// </summary>
    public class OpenmallRefundImageUploadResponse : TopResponse
    {
        /// <summary>
        /// 图片上传对应Token，用于提交留言接口
        /// </summary>
        [XmlElement("result")]
        public string Result { get; set; }

    }
}
