/// This code was generated by
/// \ / _    _  _|   _  _
///  | (_)\/(_)(_|\/| |(/_  v1.0.0
///       /       /

using System;
using System.Collections.Generic;
using Twilio.Base;
using Twilio.Converters;

namespace Twilio.Rest.Api.V2010.Account.Sip 
{

    /// <summary>
    /// Retrieve a list of domains belonging to the account used to make the request
    /// </summary>
    public class ReadDomainOptions : ReadOptions<DomainResource> 
    {
        /// <summary>
        /// The SID of the Account that created the resources to read
        /// </summary>
        public string PathAccountSid { get; set; }

        /// <summary>
        /// Generate the necessary parameters
        /// </summary>
        public override List<KeyValuePair<string, string>> GetParams()
        {
            var p = new List<KeyValuePair<string, string>>();
            if (PageSize != null)
            {
                p.Add(new KeyValuePair<string, string>("PageSize", PageSize.ToString()));
            }

            return p;
        }
    }

    /// <summary>
    /// Create a new Domain
    /// </summary>
    public class CreateDomainOptions : IOptions<DomainResource> 
    {
        /// <summary>
        /// The SID of the Account that will create the resource
        /// </summary>
        public string PathAccountSid { get; set; }
        /// <summary>
        /// The unique address on Twilio to route SIP traffic
        /// </summary>
        public string DomainName { get; }
        /// <summary>
        /// A string to describe the resource
        /// </summary>
        public string FriendlyName { get; set; }
        /// <summary>
        /// The URL we should call when receiving a call
        /// </summary>
        public Uri VoiceUrl { get; set; }
        /// <summary>
        /// The HTTP method to use with voice_url
        /// </summary>
        public Twilio.Http.HttpMethod VoiceMethod { get; set; }
        /// <summary>
        /// The URL we should call when an error occurs in executing TwiML
        /// </summary>
        public Uri VoiceFallbackUrl { get; set; }
        /// <summary>
        /// The HTTP method to use with voice_fallback_url
        /// </summary>
        public Twilio.Http.HttpMethod VoiceFallbackMethod { get; set; }
        /// <summary>
        /// The URL that we should call to pass status updates
        /// </summary>
        public Uri VoiceStatusCallbackUrl { get; set; }
        /// <summary>
        /// The HTTP method we should use to call `voice_status_callback_url`
        /// </summary>
        public Twilio.Http.HttpMethod VoiceStatusCallbackMethod { get; set; }
        /// <summary>
        /// Whether SIP registration is allowed
        /// </summary>
        public bool? SipRegistration { get; set; }

        /// <summary>
        /// Construct a new CreateDomainOptions
        /// </summary>
        /// <param name="domainName"> The unique address on Twilio to route SIP traffic </param>
        public CreateDomainOptions(string domainName)
        {
            DomainName = domainName;
        }

        /// <summary>
        /// Generate the necessary parameters
        /// </summary>
        public List<KeyValuePair<string, string>> GetParams()
        {
            var p = new List<KeyValuePair<string, string>>();
            if (DomainName != null)
            {
                p.Add(new KeyValuePair<string, string>("DomainName", DomainName));
            }

            if (FriendlyName != null)
            {
                p.Add(new KeyValuePair<string, string>("FriendlyName", FriendlyName));
            }

            if (VoiceUrl != null)
            {
                p.Add(new KeyValuePair<string, string>("VoiceUrl", Serializers.Url(VoiceUrl)));
            }

            if (VoiceMethod != null)
            {
                p.Add(new KeyValuePair<string, string>("VoiceMethod", VoiceMethod.ToString()));
            }

            if (VoiceFallbackUrl != null)
            {
                p.Add(new KeyValuePair<string, string>("VoiceFallbackUrl", Serializers.Url(VoiceFallbackUrl)));
            }

            if (VoiceFallbackMethod != null)
            {
                p.Add(new KeyValuePair<string, string>("VoiceFallbackMethod", VoiceFallbackMethod.ToString()));
            }

            if (VoiceStatusCallbackUrl != null)
            {
                p.Add(new KeyValuePair<string, string>("VoiceStatusCallbackUrl", Serializers.Url(VoiceStatusCallbackUrl)));
            }

            if (VoiceStatusCallbackMethod != null)
            {
                p.Add(new KeyValuePair<string, string>("VoiceStatusCallbackMethod", VoiceStatusCallbackMethod.ToString()));
            }

            if (SipRegistration != null)
            {
                p.Add(new KeyValuePair<string, string>("SipRegistration", SipRegistration.Value.ToString().ToLower()));
            }

            return p;
        }
    }

    /// <summary>
    /// Fetch an instance of a Domain
    /// </summary>
    public class FetchDomainOptions : IOptions<DomainResource> 
    {
        /// <summary>
        /// The SID of the Account that created the resource to fetch
        /// </summary>
        public string PathAccountSid { get; set; }
        /// <summary>
        /// The unique string that identifies the resource
        /// </summary>
        public string PathSid { get; }

        /// <summary>
        /// Construct a new FetchDomainOptions
        /// </summary>
        /// <param name="pathSid"> The unique string that identifies the resource </param>
        public FetchDomainOptions(string pathSid)
        {
            PathSid = pathSid;
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

    /// <summary>
    /// Update the attributes of a domain
    /// </summary>
    public class UpdateDomainOptions : IOptions<DomainResource> 
    {
        /// <summary>
        /// The SID of the Account that created the resource to update
        /// </summary>
        public string PathAccountSid { get; set; }
        /// <summary>
        /// The unique string that identifies the resource
        /// </summary>
        public string PathSid { get; }
        /// <summary>
        /// A string to describe the resource
        /// </summary>
        public string FriendlyName { get; set; }
        /// <summary>
        /// The HTTP method used with voice_fallback_url
        /// </summary>
        public Twilio.Http.HttpMethod VoiceFallbackMethod { get; set; }
        /// <summary>
        /// The URL we should call when an error occurs in executing TwiML
        /// </summary>
        public Uri VoiceFallbackUrl { get; set; }
        /// <summary>
        /// The HTTP method we should use with voice_url
        /// </summary>
        public Twilio.Http.HttpMethod VoiceMethod { get; set; }
        /// <summary>
        /// The HTTP method we should use to call voice_status_callback_url
        /// </summary>
        public Twilio.Http.HttpMethod VoiceStatusCallbackMethod { get; set; }
        /// <summary>
        /// The URL that we should call to pass status updates
        /// </summary>
        public Uri VoiceStatusCallbackUrl { get; set; }
        /// <summary>
        /// The URL we should call when receiving a call
        /// </summary>
        public Uri VoiceUrl { get; set; }
        /// <summary>
        /// Whether SIP registration is allowed
        /// </summary>
        public bool? SipRegistration { get; set; }
        /// <summary>
        /// The unique address on Twilio to route SIP traffic
        /// </summary>
        public string DomainName { get; set; }

        /// <summary>
        /// Construct a new UpdateDomainOptions
        /// </summary>
        /// <param name="pathSid"> The unique string that identifies the resource </param>
        public UpdateDomainOptions(string pathSid)
        {
            PathSid = pathSid;
        }

        /// <summary>
        /// Generate the necessary parameters
        /// </summary>
        public List<KeyValuePair<string, string>> GetParams()
        {
            var p = new List<KeyValuePair<string, string>>();
            if (FriendlyName != null)
            {
                p.Add(new KeyValuePair<string, string>("FriendlyName", FriendlyName));
            }

            if (VoiceFallbackMethod != null)
            {
                p.Add(new KeyValuePair<string, string>("VoiceFallbackMethod", VoiceFallbackMethod.ToString()));
            }

            if (VoiceFallbackUrl != null)
            {
                p.Add(new KeyValuePair<string, string>("VoiceFallbackUrl", Serializers.Url(VoiceFallbackUrl)));
            }

            if (VoiceMethod != null)
            {
                p.Add(new KeyValuePair<string, string>("VoiceMethod", VoiceMethod.ToString()));
            }

            if (VoiceStatusCallbackMethod != null)
            {
                p.Add(new KeyValuePair<string, string>("VoiceStatusCallbackMethod", VoiceStatusCallbackMethod.ToString()));
            }

            if (VoiceStatusCallbackUrl != null)
            {
                p.Add(new KeyValuePair<string, string>("VoiceStatusCallbackUrl", Serializers.Url(VoiceStatusCallbackUrl)));
            }

            if (VoiceUrl != null)
            {
                p.Add(new KeyValuePair<string, string>("VoiceUrl", Serializers.Url(VoiceUrl)));
            }

            if (SipRegistration != null)
            {
                p.Add(new KeyValuePair<string, string>("SipRegistration", SipRegistration.Value.ToString().ToLower()));
            }

            if (DomainName != null)
            {
                p.Add(new KeyValuePair<string, string>("DomainName", DomainName));
            }

            return p;
        }
    }

    /// <summary>
    /// Delete an instance of a Domain
    /// </summary>
    public class DeleteDomainOptions : IOptions<DomainResource> 
    {
        /// <summary>
        /// The SID of the Account that created the resources to delete
        /// </summary>
        public string PathAccountSid { get; set; }
        /// <summary>
        /// The unique string that identifies the resource
        /// </summary>
        public string PathSid { get; }

        /// <summary>
        /// Construct a new DeleteDomainOptions
        /// </summary>
        /// <param name="pathSid"> The unique string that identifies the resource </param>
        public DeleteDomainOptions(string pathSid)
        {
            PathSid = pathSid;
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