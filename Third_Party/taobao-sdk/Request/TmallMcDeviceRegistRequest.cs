using System;
using System.Collections.Generic;
using Top.Api.Util;

namespace Top.Api.Request
{
    /// <summary>
    /// TOP API: tmall.mc.device.regist
    /// </summary>
    public class TmallMcDeviceRegistRequest : BaseTopRequest<Top.Api.Response.TmallMcDeviceRegistResponse>
    {
        /// <summary>
        /// 设备所在位置详细地址
        /// </summary>
        public string Address { get; set; }

        /// <summary>
        /// 设备服务商渠道
        /// </summary>
        public string Channel { get; set; }

        /// <summary>
        /// 设备所在城市
        /// </summary>
        public string City { get; set; }

        /// <summary>
        /// 设备所在位置城市编码
        /// </summary>
        public Nullable<long> CityCode { get; set; }

        /// <summary>
        /// 设备类型。
        /// </summary>
        public string DeviceType { get; set; }

        /// <summary>
        /// 设备所在区
        /// </summary>
        public string District { get; set; }

        /// <summary>
        /// 设备所在位置地区编码
        /// </summary>
        public Nullable<long> DistrictCode { get; set; }

        /// <summary>
        /// 设备外部编码,deivceSn
        /// </summary>
        public string OutCode { get; set; }

        /// <summary>
        /// 设备所在位置经度。高德数据
        /// </summary>
        public string PositionX { get; set; }

        /// <summary>
        /// 设备所在位置纬度。高德数据
        /// </summary>
        public string PositionY { get; set; }

        /// <summary>
        /// 设备所在省份
        /// </summary>
        public string Provice { get; set; }

        /// <summary>
        /// 设备所在位置省编码
        /// </summary>
        public Nullable<long> ProviceCode { get; set; }

        /// <summary>
        /// 设备所属场景类型。
        /// </summary>
        public string Scene { get; set; }

        /// <summary>
        /// 设备所在城镇编码
        /// </summary>
        public Nullable<long> TownCode { get; set; }

        #region ITopRequest Members

        public override string GetApiName()
        {
            return "tmall.mc.device.regist";
        }

        public override IDictionary<string, string> GetParameters()
        {
            TopDictionary parameters = new TopDictionary();
            parameters.Add("address", this.Address);
            parameters.Add("channel", this.Channel);
            parameters.Add("city", this.City);
            parameters.Add("city_code", this.CityCode);
            parameters.Add("device_type", this.DeviceType);
            parameters.Add("district", this.District);
            parameters.Add("district_code", this.DistrictCode);
            parameters.Add("out_code", this.OutCode);
            parameters.Add("position_x", this.PositionX);
            parameters.Add("position_y", this.PositionY);
            parameters.Add("provice", this.Provice);
            parameters.Add("provice_code", this.ProviceCode);
            parameters.Add("scene", this.Scene);
            parameters.Add("town_code", this.TownCode);
            if (this.otherParams != null)
            {
                parameters.AddAll(this.otherParams);
            }
            return parameters;
        }

        public override void Validate()
        {
            RequestValidator.ValidateRequired("address", this.Address);
            RequestValidator.ValidateRequired("channel", this.Channel);
            RequestValidator.ValidateRequired("city_code", this.CityCode);
            RequestValidator.ValidateRequired("device_type", this.DeviceType);
            RequestValidator.ValidateRequired("district_code", this.DistrictCode);
            RequestValidator.ValidateRequired("out_code", this.OutCode);
            RequestValidator.ValidateRequired("position_x", this.PositionX);
            RequestValidator.ValidateRequired("position_y", this.PositionY);
            RequestValidator.ValidateRequired("provice_code", this.ProviceCode);
            RequestValidator.ValidateRequired("scene", this.Scene);
        }

        #endregion
    }
}
