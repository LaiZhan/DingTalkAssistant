using System;
using System.Collections.Generic;
using Top.Api.Util;

namespace Top.Api.Request
{
    /// <summary>
    /// TOP API: wdk.rex.firmware.update.check
    /// </summary>
    public class WdkRexFirmwareUpdateCheckRequest : BaseTopRequest<Top.Api.Response.WdkRexFirmwareUpdateCheckResponse>
    {
        /// <summary>
        /// 自定义更新参数
        /// </summary>
        public string Attributes { get; set; }

        /// <summary>
        /// 设备ID
        /// </summary>
        public string DeviceId { get; set; }

        /// <summary>
        /// 硬件型号
        /// </summary>
        public string HardwareCode { get; set; }

        /// <summary>
        /// 厂商Code
        /// </summary>
        public string ManufacturerCode { get; set; }

        /// <summary>
        /// 旧版本固件号（正整数）
        /// </summary>
        public string OldVersionCode { get; set; }

        /// <summary>
        /// 组织架构信息
        /// </summary>
        public string OrgInfo { get; set; }

        /// <summary>
        /// 租户ID
        /// </summary>
        public Nullable<long> TenantId { get; set; }

        #region ITopRequest Members

        public override string GetApiName()
        {
            return "wdk.rex.firmware.update.check";
        }

        public override IDictionary<string, string> GetParameters()
        {
            TopDictionary parameters = new TopDictionary();
            parameters.Add("attributes", this.Attributes);
            parameters.Add("device_id", this.DeviceId);
            parameters.Add("hardware_code", this.HardwareCode);
            parameters.Add("manufacturer_code", this.ManufacturerCode);
            parameters.Add("old_version_code", this.OldVersionCode);
            parameters.Add("org_info", this.OrgInfo);
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
            RequestValidator.ValidateRequired("hardware_code", this.HardwareCode);
            RequestValidator.ValidateRequired("manufacturer_code", this.ManufacturerCode);
            RequestValidator.ValidateRequired("old_version_code", this.OldVersionCode);
            RequestValidator.ValidateRequired("tenant_id", this.TenantId);
        }

        #endregion
    }
}
