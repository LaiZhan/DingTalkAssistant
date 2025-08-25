using System;
using System.Collections.Generic;
using Top.Api.Util;

namespace Top.Api.Request
{
    /// <summary>
    /// TOP API: tmall.device.member.identity.get
    /// </summary>
    public class TmallDeviceMemberIdentityGetRequest : BaseTopRequest<Top.Api.Response.TmallDeviceMemberIdentityGetResponse>
    {
        /// <summary>
        /// 扩展参数为JSON字符串，用于埋点统计，source为来源字段固定值 paiyangji代表来源派样机类型设备，deviceId 为设备id，itemId 相关商品id
        /// </summary>
        public string ExtraInfo { get; set; }

        /// <summary>
        /// 混淆昵称，
        /// </summary>
        public string MixNick { get; set; }

        /// <summary>
        /// 明文nick，可不填，直接填混淆昵称
        /// </summary>
        public string Nick { get; set; }

        #region ITopRequest Members

        public override string GetApiName()
        {
            return "tmall.device.member.identity.get";
        }

        public override IDictionary<string, string> GetParameters()
        {
            TopDictionary parameters = new TopDictionary();
            parameters.Add("extra_info", this.ExtraInfo);
            parameters.Add("mix_nick", this.MixNick);
            parameters.Add("nick", this.Nick);
            if (this.otherParams != null)
            {
                parameters.AddAll(this.otherParams);
            }
            return parameters;
        }

        public override void Validate()
        {
        }

        #endregion
    }
}
