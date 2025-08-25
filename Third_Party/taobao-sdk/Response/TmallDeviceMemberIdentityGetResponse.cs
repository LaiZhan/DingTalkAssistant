using System;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace Top.Api.Response
{
    /// <summary>
    /// TmallDeviceMemberIdentityGetResponse.
    /// </summary>
    public class TmallDeviceMemberIdentityGetResponse : TopResponse
    {
        /// <summary>
        /// result
        /// </summary>
        [XmlElement("result")]
        public ResultDtoDomain Result { get; set; }

	/// <summary>
/// MemberAccountDtoDomain Data Structure.
/// </summary>
[Serializable]

public class MemberAccountDtoDomain : TopObject
{
	        /// <summary>
	        /// bindStatus 1：绑卡（已经是线下会员线上未绑定，或者解绑后再绑定），2：注册
	        /// </summary>
	        [XmlElement("bind_status")]
	        public long BindStatus { get; set; }
	
	        /// <summary>
	        /// gmtCreate
	        /// </summary>
	        [XmlElement("gmt_create")]
	        public string GmtCreate { get; set; }
	
	        /// <summary>
	        /// 等级编号
	        /// </summary>
	        [XmlElement("grade")]
	        public long Grade { get; set; }
	
	        /// <summary>
	        /// 等级名称
	        /// </summary>
	        [XmlElement("grade_name")]
	        public string GradeName { get; set; }
}

	/// <summary>
/// ResultDtoDomain Data Structure.
/// </summary>
[Serializable]

public class ResultDtoDomain : TopObject
{
	        /// <summary>
	        /// code
	        /// </summary>
	        [XmlElement("code")]
	        public string Code { get; set; }
	
	        /// <summary>
	        /// result
	        /// </summary>
	        [XmlElement("member_info")]
	        public MemberAccountDtoDomain MemberInfo { get; set; }
	
	        /// <summary>
	        /// msg
	        /// </summary>
	        [XmlElement("msg")]
	        public string Msg { get; set; }
	
	        /// <summary>
	        /// total
	        /// </summary>
	        [XmlElement("total")]
	        public long Total { get; set; }
}

    }
}
