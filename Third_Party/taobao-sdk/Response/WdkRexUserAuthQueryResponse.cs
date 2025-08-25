using System;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace Top.Api.Response
{
    /// <summary>
    /// WdkRexUserAuthQueryResponse.
    /// </summary>
    public class WdkRexUserAuthQueryResponse : TopResponse
    {
        /// <summary>
        /// 返回数据
        /// </summary>
        [XmlElement("data")]
        public IotPageDODomain Data { get; set; }

        /// <summary>
        /// 错误码
        /// </summary>
        [XmlElement("msg_code")]
        public string MsgCode { get; set; }

        /// <summary>
        /// 错误信息
        /// </summary>
        [XmlElement("msg_info")]
        public string MsgInfo { get; set; }

        /// <summary>
        /// 成功结果
        /// </summary>
        [XmlElement("succeed")]
        public bool Succeed { get; set; }

	/// <summary>
/// ItemListDomain Data Structure.
/// </summary>
[Serializable]

public class ItemListDomain : TopObject
{
	        /// <summary>
	        /// 账号ID
	        /// </summary>
	        [XmlElement("account_id")]
	        public long AccountId { get; set; }
	
	        /// <summary>
	        /// 账号类型
	        /// </summary>
	        [XmlElement("account_type")]
	        public long AccountType { get; set; }
	
	        /// <summary>
	        /// 头像
	        /// </summary>
	        [XmlElement("avatar")]
	        public string Avatar { get; set; }
	
	        /// <summary>
	        /// 创建时间
	        /// </summary>
	        [XmlElement("create_time")]
	        public string CreateTime { get; set; }
	
	        /// <summary>
	        /// 工号code
	        /// </summary>
	        [XmlElement("employee_code")]
	        public string EmployeeCode { get; set; }
	
	        /// <summary>
	        /// 工号
	        /// </summary>
	        [XmlElement("employee_number")]
	        public string EmployeeNumber { get; set; }
	
	        /// <summary>
	        /// 姓名
	        /// </summary>
	        [XmlElement("name")]
	        public string Name { get; set; }
	
	        /// <summary>
	        /// 昵称
	        /// </summary>
	        [XmlElement("nick_name")]
	        public string NickName { get; set; }
	
	        /// <summary>
	        /// 账号状态
	        /// </summary>
	        [XmlElement("status")]
	        public long Status { get; set; }
	
	        /// <summary>
	        /// 租户ID
	        /// </summary>
	        [XmlElement("tenant_id")]
	        public long TenantId { get; set; }
}

	/// <summary>
/// IotPageDODomain Data Structure.
/// </summary>
[Serializable]

public class IotPageDODomain : TopObject
{
	        /// <summary>
	        /// 数据列表
	        /// </summary>
	        [XmlArray("item_list")]
	        [XmlArrayItem("item_list")]
	        public List<ItemListDomain> ItemList { get; set; }
	
	        /// <summary>
	        /// 页码
	        /// </summary>
	        [XmlElement("page_num")]
	        public long PageNum { get; set; }
	
	        /// <summary>
	        /// 页大小
	        /// </summary>
	        [XmlElement("page_size")]
	        public long PageSize { get; set; }
	
	        /// <summary>
	        /// 总数
	        /// </summary>
	        [XmlElement("total_num")]
	        public long TotalNum { get; set; }
}

    }
}
