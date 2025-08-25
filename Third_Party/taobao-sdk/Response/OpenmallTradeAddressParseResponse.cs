using System;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace Top.Api.Response
{
    /// <summary>
    /// OpenmallTradeAddressParseResponse.
    /// </summary>
    public class OpenmallTradeAddressParseResponse : TopResponse
    {
        /// <summary>
        /// 一组地址解析结构，解析正确率与地址完整度相关
        /// </summary>
        [XmlElement("result")]
        public TopParseAddressVODomain Result { get; set; }

	/// <summary>
/// TopParseAddressEntryVODomain Data Structure.
/// </summary>
[Serializable]

public class TopParseAddressEntryVODomain : TopObject
{
	        /// <summary>
	        /// 地区编码
	        /// </summary>
	        [XmlElement("code")]
	        public string Code { get; set; }
	
	        /// <summary>
	        /// 地域名称
	        /// </summary>
	        [XmlElement("name")]
	        public string Name { get; set; }
	
	        /// <summary>
	        /// 地区级别，2代表省、自治区、直辖市、特别行政区；3代表地级市、 地区、盟、自治州；4代表县、区、自治县、旗；5代表乡、镇、街道，openmall中请取第三或者第四级别地域编码传入即可
	        /// </summary>
	        [XmlElement("scope")]
	        public long Scope { get; set; }
}

	/// <summary>
/// TopParseAddressVODomain Data Structure.
/// </summary>
[Serializable]

public class TopParseAddressVODomain : TopObject
{
	        /// <summary>
	        /// 地址解析结构
	        /// </summary>
	        [XmlArray("entries")]
	        [XmlArrayItem("top_parse_address_entry_v_o")]
	        public List<TopParseAddressEntryVODomain> Entries { get; set; }
}

    }
}
