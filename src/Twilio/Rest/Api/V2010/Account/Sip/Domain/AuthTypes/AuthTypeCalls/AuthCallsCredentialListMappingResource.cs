/// This code was generated by
/// \ / _    _  _|   _  _
///  | (_)\/(_)(_|\/| |(/_  v1.0.0
///       /       /
/// <summary>
/// AuthCallsCredentialListMappingResource
/// </summary>

using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using Twilio.Base;
using Twilio.Clients;
using Twilio.Converters;
using Twilio.Exceptions;
using Twilio.Http;

namespace Twilio.Rest.Api.V2010.Account.Sip.Domain.AuthTypes.AuthTypeCalls 
{

    public class AuthCallsCredentialListMappingResource : Resource 
    {
        private static Request BuildCreateRequest(CreateAuthCallsCredentialListMappingOptions options, 
                                                  ITwilioRestClient client)
        {
            return new Request(
                HttpMethod.Post,
                Rest.Domain.Api,
                "/2010-04-01/Accounts/" + (options.PathAccountSid ?? client.AccountSid) + "/SIP/Domains/" + options.PathDomainSid + "/Auth/Calls/CredentialListMappings.json",
                client.Region,
                postParams: options.GetParams()
            );
        }

        /// <summary>
        /// Create a new credential list mapping resource
        /// </summary>
        /// <param name="options"> Create AuthCallsCredentialListMapping parameters </param>
        /// <param name="client"> Client to make requests to Twilio </param>
        /// <returns> A single instance of AuthCallsCredentialListMapping </returns> 
        public static AuthCallsCredentialListMappingResource Create(CreateAuthCallsCredentialListMappingOptions options, 
                                                                    ITwilioRestClient client = null)
        {
            client = client ?? TwilioClient.GetRestClient();
            var response = client.Request(BuildCreateRequest(options, client));
            return FromJson(response.Content);
        }

        #if !NET35
        /// <summary>
        /// Create a new credential list mapping resource
        /// </summary>
        /// <param name="options"> Create AuthCallsCredentialListMapping parameters </param>
        /// <param name="client"> Client to make requests to Twilio </param>
        /// <returns> Task that resolves to A single instance of AuthCallsCredentialListMapping </returns> 
        public static async System.Threading.Tasks.Task<AuthCallsCredentialListMappingResource> CreateAsync(CreateAuthCallsCredentialListMappingOptions options, 
                                                                                                            ITwilioRestClient client = null)
        {
            client = client ?? TwilioClient.GetRestClient();
            var response = await client.RequestAsync(BuildCreateRequest(options, client));
            return FromJson(response.Content);
        }
        #endif

        /// <summary>
        /// Create a new credential list mapping resource
        /// </summary>
        /// <param name="pathDomainSid"> The SID of the SIP domain that will contain the new resource </param>
        /// <param name="credentialListSid"> The SID of the CredentialList resource to map to the SIP domain </param>
        /// <param name="pathAccountSid"> The SID of the Account that will create the resource </param>
        /// <param name="client"> Client to make requests to Twilio </param>
        /// <returns> A single instance of AuthCallsCredentialListMapping </returns> 
        public static AuthCallsCredentialListMappingResource Create(string pathDomainSid, 
                                                                    string credentialListSid, 
                                                                    string pathAccountSid = null, 
                                                                    ITwilioRestClient client = null)
        {
            var options = new CreateAuthCallsCredentialListMappingOptions(pathDomainSid, credentialListSid){PathAccountSid = pathAccountSid};
            return Create(options, client);
        }

        #if !NET35
        /// <summary>
        /// Create a new credential list mapping resource
        /// </summary>
        /// <param name="pathDomainSid"> The SID of the SIP domain that will contain the new resource </param>
        /// <param name="credentialListSid"> The SID of the CredentialList resource to map to the SIP domain </param>
        /// <param name="pathAccountSid"> The SID of the Account that will create the resource </param>
        /// <param name="client"> Client to make requests to Twilio </param>
        /// <returns> Task that resolves to A single instance of AuthCallsCredentialListMapping </returns> 
        public static async System.Threading.Tasks.Task<AuthCallsCredentialListMappingResource> CreateAsync(string pathDomainSid, 
                                                                                                            string credentialListSid, 
                                                                                                            string pathAccountSid = null, 
                                                                                                            ITwilioRestClient client = null)
        {
            var options = new CreateAuthCallsCredentialListMappingOptions(pathDomainSid, credentialListSid){PathAccountSid = pathAccountSid};
            return await CreateAsync(options, client);
        }
        #endif

        private static Request BuildReadRequest(ReadAuthCallsCredentialListMappingOptions options, ITwilioRestClient client)
        {
            return new Request(
                HttpMethod.Get,
                Rest.Domain.Api,
                "/2010-04-01/Accounts/" + (options.PathAccountSid ?? client.AccountSid) + "/SIP/Domains/" + options.PathDomainSid + "/Auth/Calls/CredentialListMappings.json",
                client.Region,
                queryParams: options.GetParams()
            );
        }

        /// <summary>
        /// Retrieve a list of credential list mappings belonging to the domain used in the request
        /// </summary>
        /// <param name="options"> Read AuthCallsCredentialListMapping parameters </param>
        /// <param name="client"> Client to make requests to Twilio </param>
        /// <returns> A single instance of AuthCallsCredentialListMapping </returns> 
        public static ResourceSet<AuthCallsCredentialListMappingResource> Read(ReadAuthCallsCredentialListMappingOptions options, 
                                                                               ITwilioRestClient client = null)
        {
            client = client ?? TwilioClient.GetRestClient();
            var response = client.Request(BuildReadRequest(options, client));

            var page = Page<AuthCallsCredentialListMappingResource>.FromJson("contents", response.Content);
            return new ResourceSet<AuthCallsCredentialListMappingResource>(page, options, client);
        }

        #if !NET35
        /// <summary>
        /// Retrieve a list of credential list mappings belonging to the domain used in the request
        /// </summary>
        /// <param name="options"> Read AuthCallsCredentialListMapping parameters </param>
        /// <param name="client"> Client to make requests to Twilio </param>
        /// <returns> Task that resolves to A single instance of AuthCallsCredentialListMapping </returns> 
        public static async System.Threading.Tasks.Task<ResourceSet<AuthCallsCredentialListMappingResource>> ReadAsync(ReadAuthCallsCredentialListMappingOptions options, 
                                                                                                                       ITwilioRestClient client = null)
        {
            client = client ?? TwilioClient.GetRestClient();
            var response = await client.RequestAsync(BuildReadRequest(options, client));

            var page = Page<AuthCallsCredentialListMappingResource>.FromJson("contents", response.Content);
            return new ResourceSet<AuthCallsCredentialListMappingResource>(page, options, client);
        }
        #endif

        /// <summary>
        /// Retrieve a list of credential list mappings belonging to the domain used in the request
        /// </summary>
        /// <param name="pathDomainSid"> The SID of the SIP domain that contains the resources to read </param>
        /// <param name="pathAccountSid"> The SID of the Account that created the resources to read </param>
        /// <param name="pageSize"> Page size </param>
        /// <param name="limit"> Record limit </param>
        /// <param name="client"> Client to make requests to Twilio </param>
        /// <returns> A single instance of AuthCallsCredentialListMapping </returns> 
        public static ResourceSet<AuthCallsCredentialListMappingResource> Read(string pathDomainSid, 
                                                                               string pathAccountSid = null, 
                                                                               int? pageSize = null, 
                                                                               long? limit = null, 
                                                                               ITwilioRestClient client = null)
        {
            var options = new ReadAuthCallsCredentialListMappingOptions(pathDomainSid){PathAccountSid = pathAccountSid, PageSize = pageSize, Limit = limit};
            return Read(options, client);
        }

        #if !NET35
        /// <summary>
        /// Retrieve a list of credential list mappings belonging to the domain used in the request
        /// </summary>
        /// <param name="pathDomainSid"> The SID of the SIP domain that contains the resources to read </param>
        /// <param name="pathAccountSid"> The SID of the Account that created the resources to read </param>
        /// <param name="pageSize"> Page size </param>
        /// <param name="limit"> Record limit </param>
        /// <param name="client"> Client to make requests to Twilio </param>
        /// <returns> Task that resolves to A single instance of AuthCallsCredentialListMapping </returns> 
        public static async System.Threading.Tasks.Task<ResourceSet<AuthCallsCredentialListMappingResource>> ReadAsync(string pathDomainSid, 
                                                                                                                       string pathAccountSid = null, 
                                                                                                                       int? pageSize = null, 
                                                                                                                       long? limit = null, 
                                                                                                                       ITwilioRestClient client = null)
        {
            var options = new ReadAuthCallsCredentialListMappingOptions(pathDomainSid){PathAccountSid = pathAccountSid, PageSize = pageSize, Limit = limit};
            return await ReadAsync(options, client);
        }
        #endif

        /// <summary>
        /// Fetch the target page of records
        /// </summary>
        /// <param name="targetUrl"> API-generated URL for the requested results page </param>
        /// <param name="client"> Client to make requests to Twilio </param>
        /// <returns> The target page of records </returns> 
        public static Page<AuthCallsCredentialListMappingResource> GetPage(string targetUrl, ITwilioRestClient client)
        {
            client = client ?? TwilioClient.GetRestClient();

            var request = new Request(
                HttpMethod.Get,
                targetUrl
            );

            var response = client.Request(request);
            return Page<AuthCallsCredentialListMappingResource>.FromJson("contents", response.Content);
        }

        /// <summary>
        /// Fetch the next page of records
        /// </summary>
        /// <param name="page"> current page of records </param>
        /// <param name="client"> Client to make requests to Twilio </param>
        /// <returns> The next page of records </returns> 
        public static Page<AuthCallsCredentialListMappingResource> NextPage(Page<AuthCallsCredentialListMappingResource> page, 
                                                                            ITwilioRestClient client)
        {
            var request = new Request(
                HttpMethod.Get,
                page.GetNextPageUrl(
                    Rest.Domain.Api,
                    client.Region
                )
            );

            var response = client.Request(request);
            return Page<AuthCallsCredentialListMappingResource>.FromJson("contents", response.Content);
        }

        /// <summary>
        /// Fetch the previous page of records
        /// </summary>
        /// <param name="page"> current page of records </param>
        /// <param name="client"> Client to make requests to Twilio </param>
        /// <returns> The previous page of records </returns> 
        public static Page<AuthCallsCredentialListMappingResource> PreviousPage(Page<AuthCallsCredentialListMappingResource> page, 
                                                                                ITwilioRestClient client)
        {
            var request = new Request(
                HttpMethod.Get,
                page.GetPreviousPageUrl(
                    Rest.Domain.Api,
                    client.Region
                )
            );

            var response = client.Request(request);
            return Page<AuthCallsCredentialListMappingResource>.FromJson("contents", response.Content);
        }

        private static Request BuildFetchRequest(FetchAuthCallsCredentialListMappingOptions options, 
                                                 ITwilioRestClient client)
        {
            return new Request(
                HttpMethod.Get,
                Rest.Domain.Api,
                "/2010-04-01/Accounts/" + (options.PathAccountSid ?? client.AccountSid) + "/SIP/Domains/" + options.PathDomainSid + "/Auth/Calls/CredentialListMappings/" + options.PathSid + ".json",
                client.Region,
                queryParams: options.GetParams()
            );
        }

        /// <summary>
        /// Fetch a specific instance of a credential list mapping
        /// </summary>
        /// <param name="options"> Fetch AuthCallsCredentialListMapping parameters </param>
        /// <param name="client"> Client to make requests to Twilio </param>
        /// <returns> A single instance of AuthCallsCredentialListMapping </returns> 
        public static AuthCallsCredentialListMappingResource Fetch(FetchAuthCallsCredentialListMappingOptions options, 
                                                                   ITwilioRestClient client = null)
        {
            client = client ?? TwilioClient.GetRestClient();
            var response = client.Request(BuildFetchRequest(options, client));
            return FromJson(response.Content);
        }

        #if !NET35
        /// <summary>
        /// Fetch a specific instance of a credential list mapping
        /// </summary>
        /// <param name="options"> Fetch AuthCallsCredentialListMapping parameters </param>
        /// <param name="client"> Client to make requests to Twilio </param>
        /// <returns> Task that resolves to A single instance of AuthCallsCredentialListMapping </returns> 
        public static async System.Threading.Tasks.Task<AuthCallsCredentialListMappingResource> FetchAsync(FetchAuthCallsCredentialListMappingOptions options, 
                                                                                                           ITwilioRestClient client = null)
        {
            client = client ?? TwilioClient.GetRestClient();
            var response = await client.RequestAsync(BuildFetchRequest(options, client));
            return FromJson(response.Content);
        }
        #endif

        /// <summary>
        /// Fetch a specific instance of a credential list mapping
        /// </summary>
        /// <param name="pathDomainSid"> The SID of the SIP domain that contains the resource to fetch </param>
        /// <param name="pathSid"> The unique string that identifies the resource </param>
        /// <param name="pathAccountSid"> The SID of the Account that created the resource to fetch </param>
        /// <param name="client"> Client to make requests to Twilio </param>
        /// <returns> A single instance of AuthCallsCredentialListMapping </returns> 
        public static AuthCallsCredentialListMappingResource Fetch(string pathDomainSid, 
                                                                   string pathSid, 
                                                                   string pathAccountSid = null, 
                                                                   ITwilioRestClient client = null)
        {
            var options = new FetchAuthCallsCredentialListMappingOptions(pathDomainSid, pathSid){PathAccountSid = pathAccountSid};
            return Fetch(options, client);
        }

        #if !NET35
        /// <summary>
        /// Fetch a specific instance of a credential list mapping
        /// </summary>
        /// <param name="pathDomainSid"> The SID of the SIP domain that contains the resource to fetch </param>
        /// <param name="pathSid"> The unique string that identifies the resource </param>
        /// <param name="pathAccountSid"> The SID of the Account that created the resource to fetch </param>
        /// <param name="client"> Client to make requests to Twilio </param>
        /// <returns> Task that resolves to A single instance of AuthCallsCredentialListMapping </returns> 
        public static async System.Threading.Tasks.Task<AuthCallsCredentialListMappingResource> FetchAsync(string pathDomainSid, 
                                                                                                           string pathSid, 
                                                                                                           string pathAccountSid = null, 
                                                                                                           ITwilioRestClient client = null)
        {
            var options = new FetchAuthCallsCredentialListMappingOptions(pathDomainSid, pathSid){PathAccountSid = pathAccountSid};
            return await FetchAsync(options, client);
        }
        #endif

        private static Request BuildDeleteRequest(DeleteAuthCallsCredentialListMappingOptions options, 
                                                  ITwilioRestClient client)
        {
            return new Request(
                HttpMethod.Delete,
                Rest.Domain.Api,
                "/2010-04-01/Accounts/" + (options.PathAccountSid ?? client.AccountSid) + "/SIP/Domains/" + options.PathDomainSid + "/Auth/Calls/CredentialListMappings/" + options.PathSid + ".json",
                client.Region,
                queryParams: options.GetParams()
            );
        }

        /// <summary>
        /// Delete a credential list mapping from the requested domain
        /// </summary>
        /// <param name="options"> Delete AuthCallsCredentialListMapping parameters </param>
        /// <param name="client"> Client to make requests to Twilio </param>
        /// <returns> A single instance of AuthCallsCredentialListMapping </returns> 
        public static bool Delete(DeleteAuthCallsCredentialListMappingOptions options, ITwilioRestClient client = null)
        {
            client = client ?? TwilioClient.GetRestClient();
            var response = client.Request(BuildDeleteRequest(options, client));
            return response.StatusCode == System.Net.HttpStatusCode.NoContent;
        }

        #if !NET35
        /// <summary>
        /// Delete a credential list mapping from the requested domain
        /// </summary>
        /// <param name="options"> Delete AuthCallsCredentialListMapping parameters </param>
        /// <param name="client"> Client to make requests to Twilio </param>
        /// <returns> Task that resolves to A single instance of AuthCallsCredentialListMapping </returns> 
        public static async System.Threading.Tasks.Task<bool> DeleteAsync(DeleteAuthCallsCredentialListMappingOptions options, 
                                                                          ITwilioRestClient client = null)
        {
            client = client ?? TwilioClient.GetRestClient();
            var response = await client.RequestAsync(BuildDeleteRequest(options, client));
            return response.StatusCode == System.Net.HttpStatusCode.NoContent;
        }
        #endif

        /// <summary>
        /// Delete a credential list mapping from the requested domain
        /// </summary>
        /// <param name="pathDomainSid"> The SID of the SIP domain that contains the resource to delete </param>
        /// <param name="pathSid"> The unique string that identifies the resource </param>
        /// <param name="pathAccountSid"> The SID of the Account that created the resources to delete </param>
        /// <param name="client"> Client to make requests to Twilio </param>
        /// <returns> A single instance of AuthCallsCredentialListMapping </returns> 
        public static bool Delete(string pathDomainSid, 
                                  string pathSid, 
                                  string pathAccountSid = null, 
                                  ITwilioRestClient client = null)
        {
            var options = new DeleteAuthCallsCredentialListMappingOptions(pathDomainSid, pathSid){PathAccountSid = pathAccountSid};
            return Delete(options, client);
        }

        #if !NET35
        /// <summary>
        /// Delete a credential list mapping from the requested domain
        /// </summary>
        /// <param name="pathDomainSid"> The SID of the SIP domain that contains the resource to delete </param>
        /// <param name="pathSid"> The unique string that identifies the resource </param>
        /// <param name="pathAccountSid"> The SID of the Account that created the resources to delete </param>
        /// <param name="client"> Client to make requests to Twilio </param>
        /// <returns> Task that resolves to A single instance of AuthCallsCredentialListMapping </returns> 
        public static async System.Threading.Tasks.Task<bool> DeleteAsync(string pathDomainSid, 
                                                                          string pathSid, 
                                                                          string pathAccountSid = null, 
                                                                          ITwilioRestClient client = null)
        {
            var options = new DeleteAuthCallsCredentialListMappingOptions(pathDomainSid, pathSid){PathAccountSid = pathAccountSid};
            return await DeleteAsync(options, client);
        }
        #endif

        /// <summary>
        /// Converts a JSON string into a AuthCallsCredentialListMappingResource object
        /// </summary>
        /// <param name="json"> Raw JSON string </param>
        /// <returns> AuthCallsCredentialListMappingResource object represented by the provided JSON </returns> 
        public static AuthCallsCredentialListMappingResource FromJson(string json)
        {
            // Convert all checked exceptions to Runtime
            try
            {
                return JsonConvert.DeserializeObject<AuthCallsCredentialListMappingResource>(json);
            }
            catch (JsonException e)
            {
                throw new ApiException(e.Message, e);
            }
        }

        /// <summary>
        /// The SID of the Account that created the resource
        /// </summary>
        [JsonProperty("account_sid")]
        public string AccountSid { get; private set; }
        /// <summary>
        /// The RFC 2822 date and time in GMT that the resource was created
        /// </summary>
        [JsonProperty("date_created")]
        public DateTime? DateCreated { get; private set; }
        /// <summary>
        /// The RFC 2822 date and time in GMT that the resource was last updated
        /// </summary>
        [JsonProperty("date_updated")]
        public DateTime? DateUpdated { get; private set; }
        /// <summary>
        /// The string that you assigned to describe the resource
        /// </summary>
        [JsonProperty("friendly_name")]
        public string FriendlyName { get; private set; }
        /// <summary>
        /// The unique string that identifies the resource
        /// </summary>
        [JsonProperty("sid")]
        public string Sid { get; private set; }

        private AuthCallsCredentialListMappingResource()
        {

        }
    }

}