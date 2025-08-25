using System;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace Top.Api.Response
{
    /// <summary>
    /// TmallMcTaskInfoGetResponse.
    /// </summary>
    public class TmallMcTaskInfoGetResponse : TopResponse
    {
        /// <summary>
        /// 系统自动生成
        /// </summary>
        [XmlElement("data")]
        public TaskInfoDtoDomain Data { get; set; }

	/// <summary>
/// TaskInfoDtoDomain Data Structure.
/// </summary>
[Serializable]

public class TaskInfoDtoDomain : TopObject
{
	        /// <summary>
	        /// 账号ID
	        /// </summary>
	        [XmlElement("account_no")]
	        public string AccountNo { get; set; }
	
	        /// <summary>
	        /// 任务当前余额
	        /// </summary>
	        [XmlElement("balance")]
	        public long Balance { get; set; }
	
	        /// <summary>
	        /// 任务每日消费余额
	        /// </summary>
	        [XmlElement("balance_day")]
	        public long BalanceDay { get; set; }
	
	        /// <summary>
	        /// 业务类型
	        /// </summary>
	        [XmlElement("biz_type")]
	        public string BizType { get; set; }
	
	        /// <summary>
	        /// 品牌ID
	        /// </summary>
	        [XmlElement("brand_user_id")]
	        public long BrandUserId { get; set; }
	
	        /// <summary>
	        /// 品牌昵称
	        /// </summary>
	        [XmlElement("brand_user_nick")]
	        public string BrandUserNick { get; set; }
	
	        /// <summary>
	        /// 业务域
	        /// </summary>
	        [XmlElement("domain")]
	        public string Domain { get; set; }
	
	        /// <summary>
	        /// 任务开始时间
	        /// </summary>
	        [XmlElement("end_time")]
	        public string EndTime { get; set; }
	
	        /// <summary>
	        /// 投放计划名称
	        /// </summary>
	        [XmlElement("name")]
	        public string Name { get; set; }
	
	        /// <summary>
	        /// 支付类型
	        /// </summary>
	        [XmlElement("pay_type")]
	        public long PayType { get; set; }
	
	        /// <summary>
	        /// 代理商ID
	        /// </summary>
	        [XmlElement("proxy_user_id")]
	        public long ProxyUserId { get; set; }
	
	        /// <summary>
	        /// 任务总限额
	        /// </summary>
	        [XmlElement("quota")]
	        public long Quota { get; set; }
	
	        /// <summary>
	        /// 任务每日限额
	        /// </summary>
	        [XmlElement("quota_day")]
	        public long QuotaDay { get; set; }
	
	        /// <summary>
	        /// 关联设备数
	        /// </summary>
	        [XmlElement("ref_device_num")]
	        public long RefDeviceNum { get; set; }
	
	        /// <summary>
	        /// 投放计划规则（JSON）
	        /// </summary>
	        [XmlElement("rule")]
	        public string Rule { get; set; }
	
	        /// <summary>
	        /// 任务开始时间
	        /// </summary>
	        [XmlElement("start_time")]
	        public string StartTime { get; set; }
	
	        /// <summary>
	        /// 任务状态
	        /// </summary>
	        [XmlElement("status")]
	        public long Status { get; set; }
	
	        /// <summary>
	        /// 投放计划ID
	        /// </summary>
	        [XmlElement("task_id")]
	        public long TaskId { get; set; }
}

    }
}
