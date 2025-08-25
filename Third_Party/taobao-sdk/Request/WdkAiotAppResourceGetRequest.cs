using System;
using System.Collections.Generic;
using Top.Api.Util;

namespace Top.Api.Request
{
    /// <summary>
    /// TOP API: wdk.aiot.app.resource.get
    /// </summary>
    public class WdkAiotAppResourceGetRequest : BaseTopRequest<Top.Api.Response.WdkAiotAppResourceGetResponse>
    {
        /// <summary>
        /// 应用ID
        /// </summary>
        public Nullable<long> AppId { get; set; }

        /// <summary>
        /// 自定义数据
        /// </summary>
        public string AttributesJson { get; set; }

        /// <summary>
        /// 设备ID
        /// </summary>
        public string DeviceId { get; set; }

        /// <summary>
        /// 主版本号
        /// </summary>
        public string MainVersion { get; set; }

        /// <summary>
        /// 自定义数据
        /// </summary>
        public string OldVersionJson { get; set; }

        /// <summary>
        /// 机构Code
        /// </summary>
        public string OuCode { get; set; }

        /// <summary>
        /// 租户ID
        /// </summary>
        public Nullable<long> TenantId { get; set; }

        #region ITopRequest Members

        public override string GetApiName()
        {
            return "wdk.aiot.app.resource.get";
        }

        public override IDictionary<string, string> GetParameters()
        {
            TopDictionary parameters = new TopDictionary();
            parameters.Add("app_id", this.AppId);
            parameters.Add("attributes_json", this.AttributesJson);
            parameters.Add("device_id", this.DeviceId);
            parameters.Add("main_version", this.MainVersion);
            parameters.Add("old_version_json", this.OldVersionJson);
            parameters.Add("ou_code", this.OuCode);
            parameters.Add("tenant_id", this.TenantId);
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
