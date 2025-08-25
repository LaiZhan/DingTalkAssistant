using System;
using System.Collections.Generic;
using Top.Api.Util;

namespace Top.Api.Request
{
    /// <summary>
    /// TOP API: taobao.smartapp.smartform.data.write
    /// </summary>
    public class SmartappSmartformDataWriteRequest : BaseTopRequest<Top.Api.Response.SmartappSmartformDataWriteResponse>
    {
        /// <summary>
        /// 需变更的表单数据
        /// </summary>
        public string FormData { get; set; }

        /// <summary>
        /// 智能表单唯一标识
        /// </summary>
        public string FormIdentifier { get; set; }

        /// <summary>
        /// 需变更的数据ID，不填表示插入
        /// </summary>
        public string RecordId { get; set; }

        #region ITopRequest Members

        public override string GetApiName()
        {
            return "taobao.smartapp.smartform.data.write";
        }

        public override IDictionary<string, string> GetParameters()
        {
            TopDictionary parameters = new TopDictionary();
            parameters.Add("form_data", this.FormData);
            parameters.Add("form_identifier", this.FormIdentifier);
            parameters.Add("record_id", this.RecordId);
            if (this.otherParams != null)
            {
                parameters.AddAll(this.otherParams);
            }
            return parameters;
        }

        public override void Validate()
        {
            RequestValidator.ValidateRequired("form_data", this.FormData);
            RequestValidator.ValidateRequired("form_identifier", this.FormIdentifier);
        }

        #endregion
    }
}
