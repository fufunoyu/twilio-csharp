/// This code was generated by
/// \ / _    _  _|   _  _
///  | (_)\/(_)(_|\/| |(/_  v1.0.0
///       /       /

using System;
using System.Collections.Generic;
using Twilio.Base;
using Twilio.Converters;

namespace Twilio.Rest.Taskrouter.V1.Workspace.Worker
{

    /// <summary>
    /// FetchWorkersRealTimeStatisticsOptions
    /// </summary>
    public class FetchWorkersRealTimeStatisticsOptions : IOptions<WorkersRealTimeStatisticsResource>
    {
        /// <summary>
        /// The workspace_sid
        /// </summary>
        public string PathWorkspaceSid { get; }
        /// <summary>
        /// Filter cumulative statistics by TaskChannel.
        /// </summary>
        public string TaskChannel { get; set; }

        /// <summary>
        /// Construct a new FetchWorkersRealTimeStatisticsOptions
        /// </summary>
        /// <param name="pathWorkspaceSid"> The workspace_sid </param>
        public FetchWorkersRealTimeStatisticsOptions(string pathWorkspaceSid)
        {
            PathWorkspaceSid = pathWorkspaceSid;
        }

        /// <summary>
        /// Generate the necessary parameters
        /// </summary>
        public List<KeyValuePair<string, string>> GetParams()
        {
            var p = new List<KeyValuePair<string, string>>();
            if (TaskChannel != null)
            {
                p.Add(new KeyValuePair<string, string>("TaskChannel", TaskChannel));
            }

            return p;
        }
    }

}