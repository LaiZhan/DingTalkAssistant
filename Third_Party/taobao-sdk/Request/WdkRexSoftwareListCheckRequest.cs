using System;
using System.Collections.Generic;
using Top.Api.Util;

namespace Top.Api.Request
{
    /// <summary>
    /// TOP API: wdk.rex.software.list.check
    /// </summary>
    public class WdkRexSoftwareListCheckRequest : BaseTopRequest<Top.Api.Response.WdkRexSoftwareListCheckResponse>
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
        /// 旧版本信息
        /// </summary>
        public string OldVersions { get; set; }

        /// <summary>
        /// 组织机构信息
        /// </summary>
        public string OrgInfos { get; set; }

        /// <summary>
        /// 租户ID
        /// </summary>
        public Nullable<long> TenantId { get; set; }

        #region ITopRequest Members

        public override string GetApiName()
        {
            return "wdk.rex.software.list.check";
        }

        public override IDictionary<string, string> GetParameters()
        {
            TopDictionary parameters = new TopDictionary();
            parameters.Add("attributes", this.Attributes);
            parameters.Add("device_id", this.DeviceId);
            parameters.Add("device_type", this.DeviceType);
            parameters.Add("old_versions", this.OldVersions);
            parameters.Add("org_infos", this.OrgInfos);
            parameters.Add("tenant_id", this.TenantId);
            if (this.otherParams != null)
            {
                parameters.AddAll(this.otherParams);
            }
            return parameters;
        }

        public override void Validate()
        {
            RequestValidator.ValidateRequired("device_id", this.DeviceId);
            RequestValidator.ValidateRequired("tenant_id", this.TenantId);
        }

        #endregion
    }
}
