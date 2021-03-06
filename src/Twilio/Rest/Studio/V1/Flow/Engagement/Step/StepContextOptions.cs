/// This code was generated by
/// \ / _    _  _|   _  _
///  | (_)\/(_)(_|\/| |(/_  v1.0.0
///       /       /

using System;
using System.Collections.Generic;
using Twilio.Base;
using Twilio.Converters;

namespace Twilio.Rest.Studio.V1.Flow.Engagement.Step
{

    /// <summary>
    /// Retrieve the context for an Engagement Step.
    /// </summary>
    public class FetchStepContextOptions : IOptions<StepContextResource>
    {
        /// <summary>
        /// Flow Sid.
        /// </summary>
        public string PathFlowSid { get; }
        /// <summary>
        /// Engagement Sid.
        /// </summary>
        public string PathEngagementSid { get; }
        /// <summary>
        /// Step Sid.
        /// </summary>
        public string PathStepSid { get; }

        /// <summary>
        /// Construct a new FetchStepContextOptions
        /// </summary>
        /// <param name="pathFlowSid"> Flow Sid. </param>
        /// <param name="pathEngagementSid"> Engagement Sid. </param>
        /// <param name="pathStepSid"> Step Sid. </param>
        public FetchStepContextOptions(string pathFlowSid, string pathEngagementSid, string pathStepSid)
        {
            PathFlowSid = pathFlowSid;
            PathEngagementSid = pathEngagementSid;
            PathStepSid = pathStepSid;
        }

        /// <summary>
        /// Generate the necessary parameters
        /// </summary>
        public List<KeyValuePair<string, string>> GetParams()
        {
            var p = new List<KeyValuePair<string, string>>();
            return p;
        }
    }

}