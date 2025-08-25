using System;
using System.Xml.Serialization;
using System.Collections.Generic;
using Top.Api.Util;

namespace Top.Api.Request
{
    /// <summary>
    /// TOP API: alibaba.banma.track.task.add
    /// </summary>
    public class AlibabaBanmaTrackTaskAddRequest : BaseTopRequest<Top.Api.Response.AlibabaBanmaTrackTaskAddResponse>
    {
        /// <summary>
        /// task
        /// </summary>
        public string Task { get; set; }

        public TaskDODomain Task_ { set { this.Task = TopUtils.ObjectToJson(value); } } 

        #region ITopRequest Members

        public override string GetApiName()
        {
            return "alibaba.banma.track.task.add";
        }

        public override IDictionary<string, string> GetParameters()
        {
            TopDictionary parameters = new TopDictionary();
            parameters.Add("task", this.Task);
            if (this.otherParams != null)
            {
                parameters.AddAll(this.otherParams);
            }
            return parameters;
        }

        public override void Validate()
        {
            RequestValidator.ValidateRequired("task", this.Task);
        }

	/// <summary>
/// TaskDODomain Data Structure.
/// </summary>
[Serializable]

public class TaskDODomain : TopObject
{
	        /// <summary>
	        /// device_id
	        /// </summary>
	        [XmlElement("device_id")]
	        public string DeviceId { get; set; }
	
	        /// <summary>
	        /// os_type
	        /// </summary>
	        [XmlElement("os_type")]
	        public Nullable<long> OsType { get; set; }
	
	        /// <summary>
	        /// tenant_id
	        /// </summary>
	        [XmlElement("tenant_id")]
	        public string TenantId { get; set; }
	
	        /// <summary>
	        /// type
	        /// </summary>
	        [XmlElement("type")]
	        public Nullable<long> Type { get; set; }
}

        #endregion
    }
}
