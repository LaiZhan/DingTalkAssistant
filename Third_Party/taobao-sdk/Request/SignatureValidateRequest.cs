using System;
using System.Collections.Generic;
using Top.Api.Response;
using Top.Api.Util;

namespace Top.Api.Request
{
    /// <summary>
    /// TOP API: taobao.signature.validate
    /// </summary>
    public class SignatureValidateRequest : BaseTopRequest<SignatureValidateResponse>, ITopUploadRequest<SignatureValidateResponse>
    {
        /// <summary>
        /// 签名算法，可选值：HmacMD5, HmacSHA1
        /// </summary>
        public string Algorithm { get; set; }

        /// <summary>
        /// 待签名的请求体，最大5M
        /// </summary>
        public FileItem Body { get; set; }

        /// <summary>
        /// 字节流编码方式，可选值：utf-8, gbk
        /// </summary>
        public string Charset { get; set; }

        /// <summary>
        /// ISV的AppKey
        /// </summary>
        public string ProxyAppKey { get; set; }

        /// <summary>
        /// 待验证的签名
        /// </summary>
        public string Signature { get; set; }

        #region BaseTopRequest Members

        public override string GetApiName()
        {
            return "taobao.signature.validate";
        }

        public override IDictionary<string, string> GetParameters()
        {
            TopDictionary parameters = new TopDictionary();
            parameters.Add("algorithm", this.Algorithm);
            parameters.Add("charset", this.Charset);
            parameters.Add("proxy_app_key", this.ProxyAppKey);
            parameters.Add("signature", this.Signature);
            if (this.otherParams != null)
            {
                parameters.AddAll(this.otherParams);
            }
            return parameters;
        }

        public override void Validate()
        {
            RequestValidator.ValidateRequired("body", this.Body);
            RequestValidator.ValidateMaxLength("body", this.Body, 5242880);
            RequestValidator.ValidateRequired("proxy_app_key", this.ProxyAppKey);
            RequestValidator.ValidateRequired("signature", this.Signature);
        }

        #endregion

        #region ITopUploadRequest Members

        public IDictionary<string, FileItem> GetFileParameters()
        {
            IDictionary<string, FileItem> parameters = new Dictionary<string, FileItem>();
            parameters.Add("body", this.Body);
            return parameters;
        }

        #endregion
    }
}
