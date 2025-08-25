using System;
using System.Xml.Serialization;
using System.Collections.Generic;
using Top.Api.Util;

namespace Top.Api.Request
{
    /// <summary>
    /// TOP API: wdk.rex.device.info.latest
    /// </summary>
    public class WdkRexDeviceInfoLatestRequest : BaseTopRequest<Top.Api.Response.WdkRexDeviceInfoLatestResponse>
    {
        /// <summary>
        /// 请求封装
        /// </summary>
        public string Req { get; set; }

        public AiotManagerDeviceLatestRequestDomain Req_ { set { this.Req = TopUtils.ObjectToJson(value); } } 

        #region ITopRequest Members

        public override string GetApiName()
        {
            return "wdk.rex.device.info.latest";
        }

        public override IDictionary<string, string> GetParameters()
        {
            TopDictionary parameters = new TopDictionary();
            parameters.Add("req", this.Req);
            if (this.otherParams != null)
            {
                parameters.AddAll(this.otherParams);
            }
            return parameters;
        }

        public override void Validate()
        {
        }

	/// <summary>
/// AiotManagerDeviceLatestRequestDomain Data Structure.
/// </summary>
[Serializable]

public class AiotManagerDeviceLatestRequestDomain : TopObject
{
	        /// <summary>
	        /// 应用ID
	        /// </summary>
	        [XmlElement("app_id")]
	        public Nullable<long> AppId { get; set; }
	
	        /// <summary>
	        /// 包签名
	        /// </summary>
	        [XmlElement("app_sign_md5")]
	        public string AppSignMd5 { get; set; }
	
	        /// <summary>
	        /// 设备类型
	        /// </summary>
	        [XmlElement("device_type")]
	        public string DeviceType { get; set; }
	
	        /// <summary>
	        /// 商家code
	        /// </summary>
	        [XmlElement("merchant_code")]
	        public string MerchantCode { get; set; }
	
	        /// <summary>
	        /// 是否需要AK
	        /// </summary>
	        [XmlElement("need_ak")]
	        public Nullable<bool> NeedAk { get; set; }
	
	        /// <summary>
	        /// 包名
	        /// </summary>
	        [XmlElement("package_name")]
	        public string PackageName { get; set; }
	
	        /// <summary>
	        /// 阿里云pk
	        /// </summary>
	        [XmlElement("product_key")]
	        public string ProductKey { get; set; }
	
	        /// <summary>
	        /// 唯一标识
	        /// </summary>
	        [XmlElement("utdid")]
	        public string Utdid { get; set; }
	
	        /// <summary>
	        /// uuid
	        /// </summary>
	        [XmlElement("uuid")]
	        public string Uuid { get; set; }
}

        #endregion
    }
}
