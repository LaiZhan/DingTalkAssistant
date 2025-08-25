using System;
using System.Collections.Generic;
using Top.Api.Util;

namespace Top.Api.Request
{
    /// <summary>
    /// TOP API: taobao.osfbpm.robot.test
    /// </summary>
    public class OsfbpmRobotTestRequest : BaseTopRequest<Top.Api.Response.OsfbpmRobotTestResponse>
    {
        /// <summary>
        /// 水电费水电费
        /// </summary>
        public Nullable<long> PlatformId { get; set; }

        /// <summary>
        /// 水电费水电费
        /// </summary>
        public string QuestionBody { get; set; }

        /// <summary>
        /// 水电费水电费
        /// </summary>
        public string RobotCode { get; set; }

        /// <summary>
        /// 水电费水电费
        /// </summary>
        public Nullable<long> RobotId { get; set; }

        #region ITopRequest Members

        public override string GetApiName()
        {
            return "taobao.osfbpm.robot.test";
        }

        public override IDictionary<string, string> GetParameters()
        {
            TopDictionary parameters = new TopDictionary();
            parameters.Add("platform_id", this.PlatformId);
            parameters.Add("question_body", this.QuestionBody);
            parameters.Add("robot_code", this.RobotCode);
            parameters.Add("robot_id", this.RobotId);
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
