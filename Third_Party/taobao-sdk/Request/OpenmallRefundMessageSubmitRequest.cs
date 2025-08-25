using System;
using System.Xml.Serialization;
using System.Collections.Generic;
using Top.Api.Util;

namespace Top.Api.Request
{
    /// <summary>
    /// TOP API: taobao.openmall.refund.message.submit
    /// </summary>
    public class OpenmallRefundMessageSubmitRequest : BaseTopRequest<Top.Api.Response.OpenmallRefundMessageSubmitResponse>
    {
        /// <summary>
        /// 分销者身份
        /// </summary>
        public string Distributor { get; set; }

        /// <summary>
        /// 退款单ID
        /// </summary>
        public Nullable<long> RefundId { get; set; }

        /// <summary>
        /// 提交留言结构
        /// </summary>
        public string RefundMessage { get; set; }

        public RefundMessageDomain RefundMessage_ { set { this.RefundMessage = TopUtils.ObjectToJson(value); } } 

        #region ITopRequest Members

        public override string GetApiName()
        {
            return "taobao.openmall.refund.message.submit";
        }

        public override IDictionary<string, string> GetParameters()
        {
            TopDictionary parameters = new TopDictionary();
            parameters.Add("distributor", this.Distributor);
            parameters.Add("refund_id", this.RefundId);
            parameters.Add("refund_message", this.RefundMessage);
            if (this.otherParams != null)
            {
                parameters.AddAll(this.otherParams);
            }
            return parameters;
        }

        public override void Validate()
        {
            RequestValidator.ValidateRequired("distributor", this.Distributor);
            RequestValidator.ValidateRequired("refund_id", this.RefundId);
            RequestValidator.ValidateRequired("refund_message", this.RefundMessage);
        }

	/// <summary>
/// RefundMessagePicDomain Data Structure.
/// </summary>
[Serializable]

public class RefundMessagePicDomain : TopObject
{
	        /// <summary>
	        /// 图片描述
	        /// </summary>
	        [XmlElement("desc")]
	        public string Desc { get; set; }
	
	        /// <summary>
	        /// 已废弃
	        /// </summary>
	        [XmlElement("pic")]
	        public string Pic { get; set; }
	
	        /// <summary>
	        /// 使用taobao.openmall.refund.image.upload得到的上传token
	        /// </summary>
	        [XmlElement("pic_token")]
	        public string PicToken { get; set; }
}

	/// <summary>
/// RefundMessageDomain Data Structure.
/// </summary>
[Serializable]

public class RefundMessageDomain : TopObject
{
	        /// <summary>
	        /// 退款留言详情，不超过180个字符
	        /// </summary>
	        [XmlElement("refund_message")]
	        public string RefundMessage_ { get; set; }
	
	        /// <summary>
	        /// 上传凭证图片，不超过3张
	        /// </summary>
	        [XmlArray("refund_message_pics")]
	        [XmlArrayItem("refund_message_pic")]
	        public List<RefundMessagePicDomain> RefundMessagePics { get; set; }
}

        #endregion
    }
}
