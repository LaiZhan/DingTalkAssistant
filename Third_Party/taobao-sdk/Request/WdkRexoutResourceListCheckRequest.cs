using System;
using System.Collections.Generic;
using Top.Api.Util;

namespace Top.Api.Request
{
    /// <summary>
    /// TOP API: wdk.rexout.resource.list.check
    /// </summary>
    public class WdkRexoutResourceListCheckRequest : BaseTopRequest<Top.Api.Response.WdkRexoutResourceListCheckResponse>
    {
        /// <summary>
        /// 自定义参数
        /// </summary>
        public string Attributes { get; set; }

        /// <summary>
        /// 设备ID
        /// </summary>
        public string DeviceId { get; set; }

        /// <summary>
        /// 设备类型
        /// </summary>
        public string DeviceType { get; set; }

        /// <summary>
        /// 旧版本资源信息
        /// </summary>
        public string OldVersions { get; set; }

        /// <summary>
        /// 所属商家结构
        /// </summary>
        public string OrgInfo { get; set; }

        /// <summary>
        /// 主包名
        /// </summary>
        public string PackageName { get; set; }

        /// <summary>
        /// 租户ID
        /// </summary>
        public Nullable<long> TenantId { get; set; }

        /// <summary>
        /// 主包版本
        /// </summary>
        public Nullable<long> VersionCode { get; set; }

        #region ITopRequest Members

        public override string GetApiName()
        {
            return "wdk.rexout.resource.list.check";
        }

        public override IDictionary<string, string> GetParameters()
        {
            TopDictionary parameters = new TopDictionary();
            parameters.Add("attributes", this.Attributes);
            parameters.Add("device_id", this.DeviceId);
            parameters.Add("device_type", this.DeviceType);
            parameters.Add("old_versions", this.OldVersions);
            parameters.Add("org_info", this.OrgInfo);
            parameters.Add("package_name", this.PackageName);
            parameters.Add("tenant_id", this.TenantId);
            parameters.Add("version_code", this.VersionCode);
            if (this.otherParams != null)
            {
                parameters.AddAll(this.otherParams);
            }
            return parameters;
        }

        public override void Validate()
        {
            RequestValidator.ValidateRequired("device_id", this.DeviceId);
            RequestValidator.ValidateRequired("package_name", this.PackageName);
            RequestValidator.ValidateRequired("tenant_id", this.TenantId);
            RequestValidator.ValidateRequired("version_code", this.VersionCode);
        }

        #endregion
    }
}
