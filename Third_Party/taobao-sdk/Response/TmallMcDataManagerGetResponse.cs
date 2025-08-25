using System;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace Top.Api.Response
{
    /// <summary>
    /// TmallMcDataManagerGetResponse.
    /// </summary>
    public class TmallMcDataManagerGetResponse : TopResponse
    {
        /// <summary>
        /// 返回对象
        /// </summary>
        [XmlElement("result")]
        public ResultDtoDomain Result { get; set; }

	/// <summary>
/// DataManagerListDomain Data Structure.
/// </summary>
[Serializable]

public class DataManagerListDomain : TopObject
{
	        /// <summary>
	        /// 扣费曝光数
	        /// </summary>
	        [XmlElement("deduction_exposure_device_num")]
	        public long DeductionExposureDeviceNum { get; set; }
	
	        /// <summary>
	        /// 曝光数
	        /// </summary>
	        [XmlElement("deduction_exposure_num")]
	        public long DeductionExposureNum { get; set; }
	
	        /// <summary>
	        /// 扣费曝光率
	        /// </summary>
	        [XmlElement("deduction_exposure_rate")]
	        public string DeductionExposureRate { get; set; }
	
	        /// <summary>
	        /// 设备数
	        /// </summary>
	        [XmlElement("device_num")]
	        public long DeviceNum { get; set; }
	
	        /// <summary>
	        /// 曝光数
	        /// </summary>
	        [XmlElement("exposure_num")]
	        public long ExposureNum { get; set; }
	
	        /// <summary>
	        /// 曝光率
	        /// </summary>
	        [XmlElement("exposure_rate")]
	        public string ExposureRate { get; set; }
	
	        /// <summary>
	        /// 互动设备数
	        /// </summary>
	        [XmlElement("interact_device_num")]
	        public long InteractDeviceNum { get; set; }
	
	        /// <summary>
	        /// 入会数
	        /// </summary>
	        [XmlElement("member_num")]
	        public long MemberNum { get; set; }
	
	        /// <summary>
	        /// 入会率
	        /// </summary>
	        [XmlElement("member_rate")]
	        public string MemberRate { get; set; }
	
	        /// <summary>
	        /// 日期
	        /// </summary>
	        [XmlElement("pt")]
	        public string Pt { get; set; }
	
	        /// <summary>
	        /// 请求数
	        /// </summary>
	        [XmlElement("request_num")]
	        public long RequestNum { get; set; }
	
	        /// <summary>
	        /// 发放权益设备数
	        /// </summary>
	        [XmlElement("rights_device_num")]
	        public long RightsDeviceNum { get; set; }
	
	        /// <summary>
	        /// 命中数
	        /// </summary>
	        [XmlElement("score_num")]
	        public long ScoreNum { get; set; }
	
	        /// <summary>
	        /// 命中率
	        /// </summary>
	        [XmlElement("score_rate")]
	        public string ScoreRate { get; set; }
}

	/// <summary>
/// PageResultDomain Data Structure.
/// </summary>
[Serializable]

public class PageResultDomain : TopObject
{
	        /// <summary>
	        /// 条数
	        /// </summary>
	        [XmlElement("count")]
	        public long Count { get; set; }
	
	        /// <summary>
	        /// 每日分页返回list
	        /// </summary>
	        [XmlArray("list")]
	        [XmlArrayItem("data_manager_list")]
	        public List<DataManagerListDomain> List { get; set; }
}

	/// <summary>
/// DataManagerSumDomain Data Structure.
/// </summary>
[Serializable]

public class DataManagerSumDomain : TopObject
{
	        /// <summary>
	        /// 渠道id
	        /// </summary>
	        [XmlElement("channel_id")]
	        public string ChannelId { get; set; }
	
	        /// <summary>
	        /// 累计扣减曝光数
	        /// </summary>
	        [XmlElement("deduction_exposure")]
	        public long DeductionExposure { get; set; }
	
	        /// <summary>
	        /// 累计扣减曝光率
	        /// </summary>
	        [XmlElement("deduction_exposure_rate")]
	        public string DeductionExposureRate { get; set; }
	
	        /// <summary>
	        /// 曝光数
	        /// </summary>
	        [XmlElement("exposure")]
	        public long Exposure { get; set; }
	
	        /// <summary>
	        /// 曝光率
	        /// </summary>
	        [XmlElement("exposure_rate")]
	        public string ExposureRate { get; set; }
	
	        /// <summary>
	        /// 入会数
	        /// </summary>
	        [XmlElement("member")]
	        public long Member { get; set; }
	
	        /// <summary>
	        /// 入会率
	        /// </summary>
	        [XmlElement("member_rate")]
	        public string MemberRate { get; set; }
	
	        /// <summary>
	        /// 日期
	        /// </summary>
	        [XmlElement("pt")]
	        public string Pt { get; set; }
	
	        /// <summary>
	        /// 累积请求数
	        /// </summary>
	        [XmlElement("request_sum")]
	        public long RequestSum { get; set; }
	
	        /// <summary>
	        /// 命中数
	        /// </summary>
	        [XmlElement("score")]
	        public long Score { get; set; }
	
	        /// <summary>
	        /// 命中率
	        /// </summary>
	        [XmlElement("score_rate")]
	        public string ScoreRate { get; set; }
}

	/// <summary>
/// DataManagerResponseDomain Data Structure.
/// </summary>
[Serializable]

public class DataManagerResponseDomain : TopObject
{
	        /// <summary>
	        /// 每日分页返回对象
	        /// </summary>
	        [XmlElement("data_manager_detail")]
	        public PageResultDomain DataManagerDetail { get; set; }
	
	        /// <summary>
	        /// 返回累计对象
	        /// </summary>
	        [XmlElement("data_manager_sum")]
	        public DataManagerSumDomain DataManagerSum { get; set; }
}

	/// <summary>
/// ResultDtoDomain Data Structure.
/// </summary>
[Serializable]

public class ResultDtoDomain : TopObject
{
	        /// <summary>
	        /// 返回code
	        /// </summary>
	        [XmlElement("code")]
	        public long Code { get; set; }
	
	        /// <summary>
	        /// resp
	        /// </summary>
	        [XmlElement("data")]
	        public DataManagerResponseDomain Data { get; set; }
	
	        /// <summary>
	        /// 错误信息
	        /// </summary>
	        [XmlElement("error_msg")]
	        public string ErrorMsg { get; set; }
	
	        /// <summary>
	        /// 执行结果
	        /// </summary>
	        [XmlElement("success")]
	        public bool Success { get; set; }
}

    }
}
