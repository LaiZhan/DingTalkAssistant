using System;
using System.Collections.Generic;
using Top.Api.Util;

namespace Top.Api.Request
{
    /// <summary>
    /// TOP API: wdk.aiot.firmware.version.check
    /// </summary>
    public class WdkAiotFirmwareVersionCheckRequest : BaseTopRequest<Top.Api.Response.WdkAiotFirmwareVersionCheckResponse>
    {
        /// <summary>
        /// 自定义参数
        /// </summary>
        public string AttributesJson { get; set; }

        /// <summary>
        /// 厂商
        /// </summary>
        public string Brand { get; set; }

        /// <summary>
        /// 设备唯一标识
        /// </summary>
        public string DeviceId { get; set; }

        /// <summary>
        /// 硬件类型
        /// </summary>
        public string Hardtype { get; set; }

        /// <summary>
        /// 当前版本号
        /// </summary>
        public string OldVersionCode { get; set; }

        #region ITopRequest Members

        public override string GetApiName()
        {
            return "wdk.aiot.firmware.version.check";
        }

        public override IDictionary<string, string> GetParameters()
        {
            TopDictionary parameters = new TopDictionary();
            parameters.Add("attributes_json", this.AttributesJson);
            parameters.Add("brand", this.Brand);
            parameters.Add("device_id", this.DeviceId);
            parameters.Add("hardtype", this.Hardtype);
            parameters.Add("old_version_code", this.OldVersionCode);
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
