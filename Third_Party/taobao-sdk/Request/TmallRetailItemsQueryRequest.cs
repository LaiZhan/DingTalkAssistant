using System;
using System.Xml.Serialization;
using System.Collections.Generic;
using Top.Api.Util;

namespace Top.Api.Request
{
    /// <summary>
    /// TOP API: tmall.retail.items.query
    /// </summary>
    public class TmallRetailItemsQueryRequest : BaseTopRequest<Top.Api.Response.TmallRetailItemsQueryResponse>
    {
        /// <summary>
        /// t
        /// </summary>
        public string Param0 { get; set; }

        public DeviceContextDomain Param0_ { set { this.Param0 = TopUtils.ObjectToJson(value); } } 

        #region ITopRequest Members

        public override string GetApiName()
        {
            return "tmall.retail.items.query";
        }

        public override IDictionary<string, string> GetParameters()
        {
            TopDictionary parameters = new TopDictionary();
            parameters.Add("param0", this.Param0);
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
/// DeviceContextDomain Data Structure.
/// </summary>
[Serializable]

public class DeviceContextDomain : TopObject
{
	        /// <summary>
	        /// t
	        /// </summary>
	        [XmlElement("address")]
	        public string Address { get; set; }
	
	        /// <summary>
	        /// t
	        /// </summary>
	        [XmlElement("appkey")]
	        public string Appkey { get; set; }
	
	        /// <summary>
	        /// t
	        /// </summary>
	        [XmlElement("brand_user_id")]
	        public Nullable<long> BrandUserId { get; set; }
	
	        /// <summary>
	        /// t
	        /// </summary>
	        [XmlElement("device_code")]
	        public string DeviceCode { get; set; }
	
	        /// <summary>
	        /// t
	        /// </summary>
	        [XmlElement("device_id")]
	        public string DeviceId { get; set; }
	
	        /// <summary>
	        /// t
	        /// </summary>
	        [XmlElement("device_ip")]
	        public string DeviceIp { get; set; }
	
	        /// <summary>
	        /// t
	        /// </summary>
	        [XmlElement("device_name")]
	        public string DeviceName { get; set; }
	
	        /// <summary>
	        /// t
	        /// </summary>
	        [XmlElement("device_sn")]
	        public string DeviceSn { get; set; }
	
	        /// <summary>
	        /// t
	        /// </summary>
	        [XmlElement("device_type")]
	        public Nullable<long> DeviceType { get; set; }
	
	        /// <summary>
	        /// t
	        /// </summary>
	        [XmlElement("id")]
	        public Nullable<long> Id { get; set; }
	
	        /// <summary>
	        /// t
	        /// </summary>
	        [XmlElement("item_props")]
	        public string ItemProps { get; set; }
	
	        /// <summary>
	        /// t
	        /// </summary>
	        [XmlElement("mac")]
	        public string Mac { get; set; }
	
	        /// <summary>
	        /// t
	        /// </summary>
	        [XmlElement("main_page")]
	        public string MainPage { get; set; }
	
	        /// <summary>
	        /// t
	        /// </summary>
	        [XmlElement("out_code")]
	        public string OutCode { get; set; }
	
	        /// <summary>
	        /// t
	        /// </summary>
	        [XmlElement("props")]
	        public string Props { get; set; }
	
	        /// <summary>
	        /// t
	        /// </summary>
	        [XmlElement("pwd")]
	        public string Pwd { get; set; }
	
	        /// <summary>
	        /// t
	        /// </summary>
	        [XmlElement("regist_status")]
	        public Nullable<long> RegistStatus { get; set; }
	
	        /// <summary>
	        /// t
	        /// </summary>
	        [XmlElement("seller_id")]
	        public Nullable<long> SellerId { get; set; }
	
	        /// <summary>
	        /// t
	        /// </summary>
	        [XmlElement("status")]
	        public Nullable<long> Status { get; set; }
	
	        /// <summary>
	        /// t
	        /// </summary>
	        [XmlElement("store_id")]
	        public Nullable<long> StoreId { get; set; }
	
	        /// <summary>
	        /// t
	        /// </summary>
	        [XmlElement("ts")]
	        public Nullable<long> Ts { get; set; }
	
	        /// <summary>
	        /// t
	        /// </summary>
	        [XmlElement("uni_crm_id")]
	        public string UniCrmId { get; set; }
	
	        /// <summary>
	        /// t
	        /// </summary>
	        [XmlElement("user_props")]
	        public string UserProps { get; set; }
	
	        /// <summary>
	        /// t
	        /// </summary>
	        [XmlElement("utdid")]
	        public string Utdid { get; set; }
}

        #endregion
    }
}
