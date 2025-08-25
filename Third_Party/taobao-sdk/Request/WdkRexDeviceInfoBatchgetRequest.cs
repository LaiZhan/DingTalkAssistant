using System;
using System.Collections.Generic;
using Top.Api.Util;

namespace Top.Api.Request
{
    /// <summary>
    /// TOP API: wdk.rex.device.info.batchget
    /// </summary>
    public class WdkRexDeviceInfoBatchgetRequest : BaseTopRequest<Top.Api.Response.WdkRexDeviceInfoBatchgetResponse>
    {
        /// <summary>
        /// 业务key
        /// </summary>
        public string AccessKey { get; set; }

        /// <summary>
        /// 业务签名
        /// </summary>
        public string AccessSign { get; set; }

        /// <summary>
        /// 页码
        /// </summary>
        public Nullable<long> PageNum { get; set; }

        /// <summary>
        /// 页大小
        /// </summary>
        public Nullable<long> PageSize { get; set; }

        /// <summary>
        /// 设备IDs
        /// </summary>
        public string Uuids { get; set; }

        #region ITopRequest Members

        public override string GetApiName()
        {
            return "wdk.rex.device.info.batchget";
        }

        public override IDictionary<string, string> GetParameters()
        {
            TopDictionary parameters = new TopDictionary();
            parameters.Add("access_key", this.AccessKey);
            parameters.Add("access_sign", this.AccessSign);
            parameters.Add("page_num", this.PageNum);
            parameters.Add("page_size", this.PageSize);
            parameters.Add("uuids", this.Uuids);
            if (this.otherParams != null)
            {
                parameters.AddAll(this.otherParams);
            }
            return parameters;
        }

        public override void Validate()
        {
            RequestValidator.ValidateRequired("access_key", this.AccessKey);
            RequestValidator.ValidateRequired("access_sign", this.AccessSign);
            RequestValidator.ValidateRequired("uuids", this.Uuids);
        }

        #endregion
    }
}
