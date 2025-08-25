using System;
using System.Xml.Serialization;

namespace Top.Api.Domain
{
    /// <summary>
    /// Monitorstation Data Structure.
    /// </summary>
    [Serializable]
    public class Monitorstation : TopObject
    {
        /// <summary>
        /// 属于流域
        /// </summary>
        [XmlElement("belong")]
        public string Belong { get; set; }

        /// <summary>
        /// 日期
        /// </summary>
        [XmlElement("date")]
        public string Date { get; set; }

        /// <summary>
        /// 监视站点
        /// </summary>
        [XmlElement("name")]
        public string Name { get; set; }

        /// <summary>
        /// 氨氮
        /// </summary>
        [XmlElement("nitrogen")]
        public string Nitrogen { get; set; }

        /// <summary>
        /// 氨氮水质类别
        /// </summary>
        [XmlElement("nitrogenquality")]
        public string Nitrogenquality { get; set; }

        /// <summary>
        /// 总有机碳
        /// </summary>
        [XmlElement("orgacarbon")]
        public string Orgacarbon { get; set; }

        /// <summary>
        /// 溶解氧水质类别
        /// </summary>
        [XmlElement("orgacarbonquality")]
        public string Orgacarbonquality { get; set; }

        /// <summary>
        /// 溶解氧
        /// </summary>
        [XmlElement("oxygen")]
        public string Oxygen { get; set; }

        /// <summary>
        /// 溶解氧水质类别
        /// </summary>
        [XmlElement("oxygenquality")]
        public string Oxygenquality { get; set; }

        /// <summary>
        /// 高锰酸钾指数
        /// </summary>
        [XmlElement("permangan")]
        public string Permangan { get; set; }

        /// <summary>
        /// 高锰酸钾指数水质类别
        /// </summary>
        [XmlElement("permanganquality")]
        public string Permanganquality { get; set; }

        /// <summary>
        /// PH
        /// </summary>
        [XmlElement("ph")]
        public string Ph { get; set; }

        /// <summary>
        /// PH水质类别
        /// </summary>
        [XmlElement("phquality")]
        public string Phquality { get; set; }

        /// <summary>
        /// a
        /// </summary>
        [XmlElement("profile")]
        public string Profile { get; set; }

        /// <summary>
        /// 断面属性
        /// </summary>
        [XmlElement("section")]
        public string Section { get; set; }

        /// <summary>
        /// 更新时间
        /// </summary>
        [XmlElement("time")]
        public string Time { get; set; }
    }
}
