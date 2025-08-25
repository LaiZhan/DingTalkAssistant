using System;
using System.Collections.Generic;
using Top.Api.Util;

namespace Top.Api.Request
{
    /// <summary>
    /// TOP API: taobao.openmall.trade.shipaddress.update
    /// </summary>
    public class OpenmallTradeShipaddressUpdateRequest : BaseTopRequest<Top.Api.Response.OpenmallTradeShipaddressUpdateResponse>
    {
        /// <summary>
        /// 媒体渠道，代表分销者的身份，签约支付宝代扣的渠道商淘宝账号nick
        /// </summary>
        public string Distributor { get; set; }

        /// <summary>
        /// 收货地址。最大长度为228个字节。
        /// </summary>
        public string ReceiverAddress { get; set; }

        /// <summary>
        /// 城市。最大长度为32个字节。如：杭州
        /// </summary>
        public string ReceiverCity { get; set; }

        /// <summary>
        /// 区/县。最大长度为32个字节。如：西湖区
        /// </summary>
        public string ReceiverDistrict { get; set; }

        /// <summary>
        /// 移动电话。最大长度为11个字节。
        /// </summary>
        public string ReceiverMobile { get; set; }

        /// <summary>
        /// 收货人全名。最大长度为50个字节。
        /// </summary>
        public string ReceiverName { get; set; }

        /// <summary>
        /// 固定电话。最大长度为30个字节。
        /// </summary>
        public string ReceiverPhone { get; set; }

        /// <summary>
        /// 省份。最大长度为32个字节。如：浙江
        /// </summary>
        public string ReceiverState { get; set; }

        /// <summary>
        /// 6位数字的邮编
        /// </summary>
        public string ReceiverZip { get; set; }

        /// <summary>
        /// 淘宝订单号
        /// </summary>
        public Nullable<long> Tid { get; set; }

        #region ITopRequest Members

        public override string GetApiName()
        {
            return "taobao.openmall.trade.shipaddress.update";
        }

        public override IDictionary<string, string> GetParameters()
        {
            TopDictionary parameters = new TopDictionary();
            parameters.Add("distributor", this.Distributor);
            parameters.Add("receiver_address", this.ReceiverAddress);
            parameters.Add("receiver_city", this.ReceiverCity);
            parameters.Add("receiver_district", this.ReceiverDistrict);
            parameters.Add("receiver_mobile", this.ReceiverMobile);
            parameters.Add("receiver_name", this.ReceiverName);
            parameters.Add("receiver_phone", this.ReceiverPhone);
            parameters.Add("receiver_state", this.ReceiverState);
            parameters.Add("receiver_zip", this.ReceiverZip);
            parameters.Add("tid", this.Tid);
            if (this.otherParams != null)
            {
                parameters.AddAll(this.otherParams);
            }
            return parameters;
        }

        public override void Validate()
        {
            RequestValidator.ValidateRequired("distributor", this.Distributor);
            RequestValidator.ValidateRequired("receiver_address", this.ReceiverAddress);
            RequestValidator.ValidateMaxLength("receiver_address", this.ReceiverAddress, 228);
            RequestValidator.ValidateRequired("receiver_city", this.ReceiverCity);
            RequestValidator.ValidateMaxLength("receiver_city", this.ReceiverCity, 32);
            RequestValidator.ValidateRequired("receiver_district", this.ReceiverDistrict);
            RequestValidator.ValidateMaxLength("receiver_district", this.ReceiverDistrict, 32);
            RequestValidator.ValidateRequired("receiver_mobile", this.ReceiverMobile);
            RequestValidator.ValidateMaxLength("receiver_mobile", this.ReceiverMobile, 11);
            RequestValidator.ValidateRequired("receiver_name", this.ReceiverName);
            RequestValidator.ValidateMaxLength("receiver_name", this.ReceiverName, 50);
            RequestValidator.ValidateMaxLength("receiver_phone", this.ReceiverPhone, 30);
            RequestValidator.ValidateRequired("receiver_state", this.ReceiverState);
            RequestValidator.ValidateMaxLength("receiver_state", this.ReceiverState, 32);
            RequestValidator.ValidateRequired("tid", this.Tid);
        }

        #endregion
    }
}
