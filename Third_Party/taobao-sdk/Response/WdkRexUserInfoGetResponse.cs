using System;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace Top.Api.Response
{
    /// <summary>
    /// WdkRexUserInfoGetResponse.
    /// </summary>
    public class WdkRexUserInfoGetResponse : TopResponse
    {
        /// <summary>
        /// 数据
        /// </summary>
        [XmlElement("data")]
        public RexUserDTODomain Data { get; set; }

        /// <summary>
        /// 错误码
        /// </summary>
        [XmlElement("msg_code")]
        public string MsgCode { get; set; }

        /// <summary>
        /// 错误码
        /// </summary>
        [XmlElement("msg_info")]
        public string MsgInfo { get; set; }

        /// <summary>
        /// 成功结果
        /// </summary>
        [XmlElement("succeed")]
        public bool Succeed { get; set; }

	/// <summary>
/// RexUserDTODomain Data Structure.
/// </summary>
[Serializable]

public class RexUserDTODomain : TopObject
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
	        /// 工号
	        /// </summary>
	        [XmlElement("employee_number")]
	        public string EmployeeNumber { get; set; }
	
	        /// <summary>
	        /// 账号名称
	        /// </summary>
	        [XmlElement("name")]
	        public string Name { get; set; }
	
	        /// <summary>
	        /// 昵称
	        /// </summary>
	        [XmlElement("nick_name")]
	        public string NickName { get; set; }
	
	        /// <summary>
	        /// 组织架构信息
	        /// </summary>
	        [XmlElement("role_auths")]
	        public string RoleAuths { get; set; }
	
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

    }
}
