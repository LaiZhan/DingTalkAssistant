using System;
using System.Collections.Generic;
using Top.Api.Util;

namespace Top.Api.Request
{
    /// <summary>
    /// TOP API: wdk.rex.device.info.getchildren
    /// </summary>
    public class WdkRexDeviceInfoGetchildrenRequest : BaseTopRequest<Top.Api.Response.WdkRexDeviceInfoGetchildrenResponse>
    {
        /// <summary>
        /// key
        /// </summary>
        public string AccessKey { get; set; }

        /// <summary>
        /// 签名
        /// </summary>
        public string AccessSign { get; set; }

        /// <summary>
        /// 页号
        /// </summary>
        public Nullable<long> PageNum { get; set; }

        /// <summary>
        /// 页大小
        /// </summary>
        public Nullable<long> PageSize { get; set; }

        /// <summary>
        /// 设备ID
        /// </summary>
        public string Uuid { get; set; }

        #region ITopRequest Members

        public override string GetApiName()
        {
            return "wdk.rex.device.info.getchildren";
        }

        public override IDictionary<string, string> GetParameters()
        {
            TopDictionary parameters = new TopDictionary();
            parameters.Add("access_key", this.AccessKey);
            parameters.Add("access_sign", this.AccessSign);
            parameters.Add("page_num", this.PageNum);
            parameters.Add("page_size", this.PageSize);
            parameters.Add("uuid", this.Uuid);
            if (this.otherParams != null)
            {
                parameters.AddAll(this.otherParams);
            }
            return parameters;
        }

        public override void Validate()
        {
        }

        #endregion
    }
}
