using System;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace Top.Api.Response
{
    /// <summary>
    /// TmallMcDeviceCircleCheckResponse.
    /// </summary>
    public class TmallMcDeviceCircleCheckResponse : TopResponse
    {
        /// <summary>
        /// 设备相关投放计划
        /// </summary>
        [XmlArray("results")]
        [XmlArrayItem("task_dto")]
        public List<TaskDtoDomain> Results { get; set; }

	/// <summary>
/// TaskDtoDomain Data Structure.
/// </summary>
[Serializable]

public class TaskDtoDomain : TopObject
{
	        /// <summary>
	        /// 结束时间
	        /// </summary>
	        [XmlElement("end_time")]
	        public string EndTime { get; set; }
	
	        /// <summary>
	        /// 投放计划id
	        /// </summary>
	        [XmlElement("id")]
	        public long Id { get; set; }
	
	        /// <summary>
	        /// 投放计划名称
	        /// </summary>
	        [XmlElement("name")]
	        public string Name { get; set; }
	
	        /// <summary>
	        /// 开始时间
	        /// </summary>
	        [XmlElement("start_time")]
	        public string StartTime { get; set; }
}

    }
}
