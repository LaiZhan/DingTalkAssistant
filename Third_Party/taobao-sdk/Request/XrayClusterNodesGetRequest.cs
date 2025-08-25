using System;
using System.Collections.Generic;
using Top.Api.Util;

namespace Top.Api.Request
{
    /// <summary>
    /// TOP API: taobao.xray.cluster.nodes.get
    /// </summary>
    public class XrayClusterNodesGetRequest : BaseTopRequest<Top.Api.Response.XrayClusterNodesGetResponse>
    {
        /// <summary>
        /// 集群名
        /// </summary>
        public string Cluster { get; set; }

        #region ITopRequest Members

        public override string GetApiName()
        {
            return "taobao.xray.cluster.nodes.get";
        }

        public override IDictionary<string, string> GetParameters()
        {
            TopDictionary parameters = new TopDictionary();
            parameters.Add("cluster", this.Cluster);
            if (this.otherParams != null)
            {
                parameters.AddAll(this.otherParams);
            }
            return parameters;
        }

        public override void Validate()
        {
            RequestValidator.ValidateRequired("cluster", this.Cluster);
        }

        #endregion
    }
}
