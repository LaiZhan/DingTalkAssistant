using System;
using System.Collections.Generic;
using Top.Api.Response;
using Top.Api.Util;

namespace Top.Api.Request
{
    /// <summary>
    /// TOP API: taobao.openmall.refund.image.upload
    /// </summary>
    public class OpenmallRefundImageUploadRequest : BaseTopRequest<OpenmallRefundImageUploadResponse>, ITopUploadRequest<OpenmallRefundImageUploadResponse>
    {
        /// <summary>
        /// 渠道商Nick
        /// </summary>
        public string Distributor { get; set; }

        /// <summary>
        /// 上传图片，必须为jpg或png格式，建议小于2M
        /// </summary>
        public FileItem Image { get; set; }

        /// <summary>
        /// 该图片归属的退款单ID
        /// </summary>
        public Nullable<long> RefundId { get; set; }

        #region BaseTopRequest Members

        public override string GetApiName()
        {
            return "taobao.openmall.refund.image.upload";
        }

        public override IDictionary<string, string> GetParameters()
        {
            TopDictionary parameters = new TopDictionary();
            parameters.Add("distributor", this.Distributor);
            parameters.Add("refund_id", this.RefundId);
            if (this.otherParams != null)
            {
                parameters.AddAll(this.otherParams);
            }
            return parameters;
        }

        public override void Validate()
        {
            RequestValidator.ValidateRequired("distributor", this.Distributor);
            RequestValidator.ValidateRequired("image", this.Image);
            RequestValidator.ValidateRequired("refund_id", this.RefundId);
        }

        #endregion

        #region ITopUploadRequest Members

        public IDictionary<string, FileItem> GetFileParameters()
        {
            IDictionary<string, FileItem> parameters = new Dictionary<string, FileItem>();
            parameters.Add("image", this.Image);
            return parameters;
        }

        #endregion
    }
}
