using System;
using System.Collections.Generic;
using Top.Api.Util;

namespace Top.Api.Request
{
    /// <summary>
    /// TOP API: wdk.aiot.devicetype.applist.get
    /// </summary>
    public class WdkAiotDevicetypeApplistGetRequest : BaseTopRequest<Top.Api.Response.WdkAiotDevicetypeApplistGetResponse>
    {
        /// <summary>
        /// 数据
        /// </summary>
        public string AttributesJson { get; set; }

        /// <summary>
        /// 设备ID
        /// </summary>
        public string DeviceId { get; set; }

        /// <summary>
        /// 设备类型
        /// </summary>
        public string DeviceType { get; set; }

        /// <summary>
        /// 数据
        /// </summary>
        public string OldVersionJson { get; set; }

        /// <summary>
        /// 机构code
        /// </summary>
        public string OuCode { get; set; }

        /// <summary>
        /// 租户
        /// </summary>
        public Nullable<long> TenantId { get; set; }

        #region ITopRequest Members

        public override string GetApiName()
        {
            return "wdk.aiot.devicetype.applist.get";
        }

        public override IDictionary<string, string> GetParameters()
        {
            TopDictionary parameters = new TopDictionary();
            parameters.Add("attributes_json", this.AttributesJson);
            parameters.Add("device_id", this.DeviceId);
            parameters.Add("device_type", this.DeviceType);
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
            RequestValidator.ValidateRequired("device_id", this.DeviceId);
            RequestValidator.ValidateRequired("device_type", this.DeviceType);
        }

        #endregion
    }
}
