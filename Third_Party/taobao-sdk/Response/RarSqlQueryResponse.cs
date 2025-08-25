using System;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace Top.Api.Response
{
    /// <summary>
    /// RarSqlQueryResponse.
    /// </summary>
    public class RarSqlQueryResponse : TopResponse
    {
        /// <summary>
        /// result
        /// </summary>
        [XmlArray("results")]
        [XmlArrayItem("rar_sql_dto")]
        public List<RarSqlDtoDomain> Results { get; set; }

	/// <summary>
/// RarSqlDtoDomain Data Structure.
/// </summary>
[Serializable]

public class RarSqlDtoDomain : TopObject
{
	        /// <summary>
	        /// SQL修改时间
	        /// </summary>
	        [XmlElement("gmt_modified")]
	        public string GmtModified { get; set; }
	
	        /// <summary>
	        /// 具体查询语句
	        /// </summary>
	        [XmlElement("sql")]
	        public string Sql { get; set; }
	
	        /// <summary>
	        /// sqlId,用于查询接口
	        /// </summary>
	        [XmlElement("sql_id")]
	        public long SqlId { get; set; }
	
	        /// <summary>
	        /// SQL状态。0：无效，1：有效
	        /// </summary>
	        [XmlElement("status")]
	        public long Status { get; set; }
	
	        /// <summary>
	        /// 数据类型 1:会员，2：订单，3：门店，4：商品
	        /// </summary>
	        [XmlElement("type")]
	        public long Type { get; set; }
}

    }
}
