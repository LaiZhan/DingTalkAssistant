using System;
using System.Collections.Generic;
using Top.Api.Response;
using Top.Api.Util;

namespace Top.Api.Request
{
    /// <summary>
    /// TOP API: taobao.trade.voucher.upload
    /// </summary>
    public class TradeVoucherUploadRequest : BaseTopRequest<TradeVoucherUploadResponse>, ITopUploadRequest<TradeVoucherUploadResponse>
    {
        /// <summary>
        /// 该笔订单的买家Nick（混淆nick）
        /// </summary>
        public string BuyerNick { get; set; }

        /// <summary>
        /// 文件
        /// </summary>
        public FileItem FileData { get; set; }

        /// <summary>
        /// 上传文件的名称
        /// </summary>
        public string FileName { get; set; }

        /// <summary>
        /// 该笔订单的卖家Nick
        /// </summary>
        public string SellerNick { get; set; }

        #region BaseTopRequest Members

        public override string GetApiName()
        {
            return "taobao.trade.voucher.upload";
        }

        public override IDictionary<string, string> GetParameters()
        {
            TopDictionary parameters = new TopDictionary();
            parameters.Add("buyer_nick", this.BuyerNick);
            parameters.Add("file_name", this.FileName);
            parameters.Add("seller_nick", this.SellerNick);
            if (this.otherParams != null)
            {
                parameters.AddAll(this.otherParams);
            }
            return parameters;
        }

        public override void Validate()
        {
            RequestValidator.ValidateRequired("file_data", this.FileData);
            RequestValidator.ValidateRequired("file_name", this.FileName);
            RequestValidator.ValidateMaxLength("file_name", this.FileName, 50);
        }

        #endregion

        #region ITopUploadRequest Members

        public IDictionary<string, FileItem> GetFileParameters()
        {
            IDictionary<string, FileItem> parameters = new Dictionary<string, FileItem>();
            parameters.Add("file_data", this.FileData);
            return parameters;
        }

        #endregion
    }
}
