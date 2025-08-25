using System;
using System.Collections.Generic;
using Top.Api.Util;

namespace Top.Api.Request
{
    /// <summary>
    /// TOP API: taobao.qimen.event.produce
    /// </summary>
    public class QimenEventProduceRequest : BaseTopRequest<Top.Api.Response.QimenEventProduceResponse>
    {
        /// <summary>
        /// 订单创建时间,数字
        /// </summary>
        public Nullable<long> Create { get; set; }

        /// <summary>
        /// JSON格式扩展字段
        /// </summary>
        public string Ext { get; set; }

        /// <summary>
        /// 外部商家名称。必须同时填写platform
        /// </summary>
        public string Nick { get; set; }

        /// <summary>
        /// 商家平台编码.MAIN:官方渠道,JD:京东,DD:当当,PP:拍拍,YX:易讯,EBAY:ebay,AMAZON:亚马逊,SN:苏宁,GM:国美,WPH:唯品会,JM:聚美,MGJ:蘑菇街,YT:银泰,YHD:1号店,1688:1688,POS:POS门店,OTHER:其他
        /// </summary>
        public string Platform { get; set; }

        /// <summary>
        /// 事件状态，如QIMEN_ERP_TRANSFER，QIMEN_ERP_CHECK
        /// </summary>
        public string Status { get; set; }

        /// <summary>
        /// 淘宝订单号
        /// </summary>
        public string Tid { get; set; }

        #region ITopRequest Members

        public override string GetApiName()
        {
            return "taobao.qimen.event.produce";
        }

        public override IDictionary<string, string> GetParameters()
        {
            TopDictionary parameters = new TopDictionary();
            parameters.Add("create", this.Create);
            parameters.Add("ext", this.Ext);
            parameters.Add("nick", this.Nick);
            parameters.Add("platform", this.Platform);
            parameters.Add("status", this.Status);
            parameters.Add("tid", this.Tid);
            if (this.otherParams != null)
            {
                parameters.AddAll(this.otherParams);
            }
            return parameters;
        }

        public override void Validate()
        {
            RequestValidator.ValidateRequired("status", this.Status);
            RequestValidator.ValidateRequired("tid", this.Tid);
        }

        #endregion
    }
}
