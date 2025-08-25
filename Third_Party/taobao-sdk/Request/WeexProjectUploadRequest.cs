using System;
using System.Collections.Generic;
using Top.Api.Response;
using Top.Api.Util;

namespace Top.Api.Request
{
    /// <summary>
    /// TOP API: taobao.weex.project.upload
    /// </summary>
    public class WeexProjectUploadRequest : BaseTopRequest<WeexProjectUploadResponse>, ITopUploadRequest<WeexProjectUploadResponse>
    {
        /// <summary>
        /// appkey
        /// </summary>
        public string Appkey { get; set; }

        /// <summary>
        /// 项目描述
        /// </summary>
        public string Desc { get; set; }

        /// <summary>
        /// 项目名称
        /// </summary>
        public string Name { get; set; }

        /// <summary>
        /// weex工程,最大5M
        /// </summary>
        public FileItem ProjectFile { get; set; }

        /// <summary>
        /// 版本相关描述
        /// </summary>
        public string Summary { get; set; }

        /// <summary>
        /// 版本号
        /// </summary>
        public string Version { get; set; }

        #region BaseTopRequest Members

        public override string GetApiName()
        {
            return "taobao.weex.project.upload";
        }

        public override IDictionary<string, string> GetParameters()
        {
            TopDictionary parameters = new TopDictionary();
            parameters.Add("appkey", this.Appkey);
            parameters.Add("desc", this.Desc);
            parameters.Add("name", this.Name);
            parameters.Add("summary", this.Summary);
            parameters.Add("version", this.Version);
            if (this.otherParams != null)
            {
                parameters.AddAll(this.otherParams);
            }
            return parameters;
        }

        public override void Validate()
        {
            RequestValidator.ValidateRequired("appkey", this.Appkey);
            RequestValidator.ValidateRequired("desc", this.Desc);
            RequestValidator.ValidateRequired("name", this.Name);
            RequestValidator.ValidateRequired("project_file", this.ProjectFile);
            RequestValidator.ValidateMaxLength("project_file", this.ProjectFile, 5242880);
            RequestValidator.ValidateRequired("summary", this.Summary);
            RequestValidator.ValidateRequired("version", this.Version);
        }

        #endregion

        #region ITopUploadRequest Members

        public IDictionary<string, FileItem> GetFileParameters()
        {
            IDictionary<string, FileItem> parameters = new Dictionary<string, FileItem>();
            parameters.Add("project_file", this.ProjectFile);
            return parameters;
        }

        #endregion
    }
}
