using System;
using System.Collections.Generic;
using Top.Api.Util;

namespace Top.Api.Request
{
    /// <summary>
    /// TOP API: dingtalk.open.msg.callback
    /// </summary>
    public class DingtalkOpenMsgCallbackRequest : BaseTopRequest<Top.Api.Response.DingtalkOpenMsgCallbackResponse>
    {
        /// <summary>
        /// fdsfa
        /// </summary>
        public string MsgEncrypt { get; set; }

        /// <summary>
        /// dfs
        /// </summary>
        public string MsgNonce { get; set; }

        /// <summary>
        /// dasfas
        /// </summary>
        public string MsgSignature { get; set; }

        /// <summary>
        /// dsfds
        /// </summary>
        public string MsgTimestamp { get; set; }

        #region ITopRequest Members

        public override string GetApiName()
        {
            return "dingtalk.open.msg.callback";
        }

        public override IDictionary<string, string> GetParameters()
        {
            TopDictionary parameters = new TopDictionary();
            parameters.Add("msg_encrypt", this.MsgEncrypt);
            parameters.Add("msg_nonce", this.MsgNonce);
            parameters.Add("msg_signature", this.MsgSignature);
            parameters.Add("msg_timestamp", this.MsgTimestamp);
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
