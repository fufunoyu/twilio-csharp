using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using Twilio.Base;
using Twilio.Clients;
using Twilio.Converters;
using Twilio.Exceptions;
using Twilio.Http;

namespace Twilio.Rest.Api.V2010.Account.Call 
{

    /// <summary>
    /// RecordingResource
    /// </summary>
    public class RecordingResource : Resource 
    {
        private static Request BuildFetchRequest(FetchRecordingOptions options, ITwilioRestClient client)
        {
            return new Request(
                HttpMethod.Get,
                Rest.Domain.Api,
                "/2010-04-01/Accounts/" + (options.PathAccountSid ?? client.AccountSid) + "/Calls/" + options.PathCallSid + "/Recordings/" + options.PathSid + ".json",
                client.Region,
                queryParams: options.GetParams()
            );
        }

        /// <summary>
        /// fetch
        /// </summary>
        ///
        /// <param name="options"> Fetch Recording parameters </param>
        /// <param name="client"> Client to make requests to Twilio </param>
        /// <returns> A single instance of Recording </returns> 
        public static RecordingResource Fetch(FetchRecordingOptions options, ITwilioRestClient client = null)
        {
            client = client ?? TwilioClient.GetRestClient();
            var response = client.Request(BuildFetchRequest(options, client));
            return FromJson(response.Content);
        }

        #if !NET35
        /// <summary>
        /// fetch
        /// </summary>
        ///
        /// <param name="options"> Fetch Recording parameters </param>
        /// <param name="client"> Client to make requests to Twilio </param>
        /// <returns> Task that resolves to A single instance of Recording </returns> 
        public static async System.Threading.Tasks.Task<RecordingResource> FetchAsync(FetchRecordingOptions options, ITwilioRestClient client = null)
        {
            client = client ?? TwilioClient.GetRestClient();
            var response = await client.RequestAsync(BuildFetchRequest(options, client));
            return FromJson(response.Content);
        }
        #endif

        /// <summary>
        /// fetch
        /// </summary>
        ///
        /// <param name="pathCallSid"> The call_sid </param>
        /// <param name="pathSid"> The sid </param>
        /// <param name="pathAccountSid"> The account_sid </param>
        /// <param name="client"> Client to make requests to Twilio </param>
        /// <returns> A single instance of Recording </returns> 
        public static RecordingResource Fetch(string pathCallSid, string pathSid, string pathAccountSid = null, ITwilioRestClient client = null)
        {
            var options = new FetchRecordingOptions(pathCallSid, pathSid){PathAccountSid = pathAccountSid};
            return Fetch(options, client);
        }

        #if !NET35
        /// <summary>
        /// fetch
        /// </summary>
        ///
        /// <param name="pathCallSid"> The call_sid </param>
        /// <param name="pathSid"> The sid </param>
        /// <param name="pathAccountSid"> The account_sid </param>
        /// <param name="client"> Client to make requests to Twilio </param>
        /// <returns> Task that resolves to A single instance of Recording </returns> 
        public static async System.Threading.Tasks.Task<RecordingResource> FetchAsync(string pathCallSid, string pathSid, string pathAccountSid = null, ITwilioRestClient client = null)
        {
            var options = new FetchRecordingOptions(pathCallSid, pathSid){PathAccountSid = pathAccountSid};
            return await FetchAsync(options, client);
        }
        #endif

        private static Request BuildDeleteRequest(DeleteRecordingOptions options, ITwilioRestClient client)
        {
            return new Request(
                HttpMethod.Delete,
                Rest.Domain.Api,
                "/2010-04-01/Accounts/" + (options.PathAccountSid ?? client.AccountSid) + "/Calls/" + options.PathCallSid + "/Recordings/" + options.PathSid + ".json",
                client.Region,
                queryParams: options.GetParams()
            );
        }

        /// <summary>
        /// delete
        /// </summary>
        ///
        /// <param name="options"> Delete Recording parameters </param>
        /// <param name="client"> Client to make requests to Twilio </param>
        /// <returns> A single instance of Recording </returns> 
        public static bool Delete(DeleteRecordingOptions options, ITwilioRestClient client = null)
        {
            client = client ?? TwilioClient.GetRestClient();
            var response = client.Request(BuildDeleteRequest(options, client));
            return response.StatusCode == System.Net.HttpStatusCode.NoContent;
        }

        #if !NET35
        /// <summary>
        /// delete
        /// </summary>
        ///
        /// <param name="options"> Delete Recording parameters </param>
        /// <param name="client"> Client to make requests to Twilio </param>
        /// <returns> Task that resolves to A single instance of Recording </returns> 
        public static async System.Threading.Tasks.Task<bool> DeleteAsync(DeleteRecordingOptions options, ITwilioRestClient client = null)
        {
            client = client ?? TwilioClient.GetRestClient();
            var response = await client.RequestAsync(BuildDeleteRequest(options, client));
            return response.StatusCode == System.Net.HttpStatusCode.NoContent;
        }
        #endif

        /// <summary>
        /// delete
        /// </summary>
        ///
        /// <param name="pathCallSid"> The call_sid </param>
        /// <param name="pathSid"> The sid </param>
        /// <param name="pathAccountSid"> The account_sid </param>
        /// <param name="client"> Client to make requests to Twilio </param>
        /// <returns> A single instance of Recording </returns> 
        public static bool Delete(string pathCallSid, string pathSid, string pathAccountSid = null, ITwilioRestClient client = null)
        {
            var options = new DeleteRecordingOptions(pathCallSid, pathSid){PathAccountSid = pathAccountSid};
            return Delete(options, client);
        }

        #if !NET35
        /// <summary>
        /// delete
        /// </summary>
        ///
        /// <param name="pathCallSid"> The call_sid </param>
        /// <param name="pathSid"> The sid </param>
        /// <param name="pathAccountSid"> The account_sid </param>
        /// <param name="client"> Client to make requests to Twilio </param>
        /// <returns> Task that resolves to A single instance of Recording </returns> 
        public static async System.Threading.Tasks.Task<bool> DeleteAsync(string pathCallSid, string pathSid, string pathAccountSid = null, ITwilioRestClient client = null)
        {
            var options = new DeleteRecordingOptions(pathCallSid, pathSid){PathAccountSid = pathAccountSid};
            return await DeleteAsync(options, client);
        }
        #endif

        private static Request BuildReadRequest(ReadRecordingOptions options, ITwilioRestClient client)
        {
            return new Request(
                HttpMethod.Get,
                Rest.Domain.Api,
                "/2010-04-01/Accounts/" + (options.PathAccountSid ?? client.AccountSid) + "/Calls/" + options.PathCallSid + "/Recordings.json",
                client.Region,
                queryParams: options.GetParams()
            );
        }

        /// <summary>
        /// read
        /// </summary>
        ///
        /// <param name="options"> Read Recording parameters </param>
        /// <param name="client"> Client to make requests to Twilio </param>
        /// <returns> A single instance of Recording </returns> 
        public static ResourceSet<RecordingResource> Read(ReadRecordingOptions options, ITwilioRestClient client = null)
        {
            client = client ?? TwilioClient.GetRestClient();
            var response = client.Request(BuildReadRequest(options, client));

            var page = Page<RecordingResource>.FromJson("recordings", response.Content);
            return new ResourceSet<RecordingResource>(page, options, client);
        }

        #if !NET35
        /// <summary>
        /// read
        /// </summary>
        ///
        /// <param name="options"> Read Recording parameters </param>
        /// <param name="client"> Client to make requests to Twilio </param>
        /// <returns> Task that resolves to A single instance of Recording </returns> 
        public static async System.Threading.Tasks.Task<ResourceSet<RecordingResource>> ReadAsync(ReadRecordingOptions options, ITwilioRestClient client = null)
        {
            client = client ?? TwilioClient.GetRestClient();
            var response = await client.RequestAsync(BuildReadRequest(options, client));

            var page = Page<RecordingResource>.FromJson("recordings", response.Content);
            return new ResourceSet<RecordingResource>(page, options, client);
        }
        #endif

        /// <summary>
        /// read
        /// </summary>
        ///
        /// <param name="pathCallSid"> The call_sid </param>
        /// <param name="pathAccountSid"> The account_sid </param>
        /// <param name="dateCreatedBefore"> The date_created </param>
        /// <param name="dateCreated"> The date_created </param>
        /// <param name="dateCreatedAfter"> The date_created </param>
        /// <param name="pageSize"> Page size </param>
        /// <param name="limit"> Record limit </param>
        /// <param name="client"> Client to make requests to Twilio </param>
        /// <returns> A single instance of Recording </returns> 
        public static ResourceSet<RecordingResource> Read(string pathCallSid, string pathAccountSid = null, DateTime? dateCreatedBefore = null, DateTime? dateCreated = null, DateTime? dateCreatedAfter = null, int? pageSize = null, long? limit = null, ITwilioRestClient client = null)
        {
            var options = new ReadRecordingOptions(pathCallSid){PathAccountSid = pathAccountSid, DateCreatedBefore = dateCreatedBefore, DateCreated = dateCreated, DateCreatedAfter = dateCreatedAfter, PageSize = pageSize, Limit = limit};
            return Read(options, client);
        }

        #if !NET35
        /// <summary>
        /// read
        /// </summary>
        ///
        /// <param name="pathCallSid"> The call_sid </param>
        /// <param name="pathAccountSid"> The account_sid </param>
        /// <param name="dateCreatedBefore"> The date_created </param>
        /// <param name="dateCreated"> The date_created </param>
        /// <param name="dateCreatedAfter"> The date_created </param>
        /// <param name="pageSize"> Page size </param>
        /// <param name="limit"> Record limit </param>
        /// <param name="client"> Client to make requests to Twilio </param>
        /// <returns> Task that resolves to A single instance of Recording </returns> 
        public static async System.Threading.Tasks.Task<ResourceSet<RecordingResource>> ReadAsync(string pathCallSid, string pathAccountSid = null, DateTime? dateCreatedBefore = null, DateTime? dateCreated = null, DateTime? dateCreatedAfter = null, int? pageSize = null, long? limit = null, ITwilioRestClient client = null)
        {
            var options = new ReadRecordingOptions(pathCallSid){PathAccountSid = pathAccountSid, DateCreatedBefore = dateCreatedBefore, DateCreated = dateCreated, DateCreatedAfter = dateCreatedAfter, PageSize = pageSize, Limit = limit};
            return await ReadAsync(options, client);
        }
        #endif

        /// <summary>
        /// Fetch the target page of records
        /// </summary>
        ///
        /// <param name="targetUrl"> API-generated URL for the requested results page </param>
        /// <param name="client"> Client to make requests to Twilio </param>
        /// <returns> The target page of records </returns> 
        public static Page<RecordingResource> GetPage(string targetUrl, ITwilioRestClient client)
        {
            client = client ?? TwilioClient.GetRestClient();

            var request = new Request(
                HttpMethod.Get,
                targetUrl
            );

            var response = client.Request(request);
            return Page<RecordingResource>.FromJson("recordings", response.Content);
        }

        /// <summary>
        /// Fetch the next page of records
        /// </summary>
        ///
        /// <param name="page"> current page of records </param>
        /// <param name="client"> Client to make requests to Twilio </param>
        /// <returns> The next page of records </returns> 
        public static Page<RecordingResource> NextPage(Page<RecordingResource> page, ITwilioRestClient client)
        {
            var request = new Request(
                HttpMethod.Get,
                page.GetNextPageUrl(
                    Rest.Domain.Api,
                    client.Region
                )
            );

            var response = client.Request(request);
            return Page<RecordingResource>.FromJson("recordings", response.Content);
        }

        /// <summary>
        /// Fetch the previous page of records
        /// </summary>
        ///
        /// <param name="page"> current page of records </param>
        /// <param name="client"> Client to make requests to Twilio </param>
        /// <returns> The previous page of records </returns> 
        public static Page<RecordingResource> PreviousPage(Page<RecordingResource> page, ITwilioRestClient client)
        {
            var request = new Request(
                HttpMethod.Get,
                page.GetPreviousPageUrl(
                    Rest.Domain.Api,
                    client.Region
                )
            );

            var response = client.Request(request);
            return Page<RecordingResource>.FromJson("recordings", response.Content);
        }

        /// <summary>
        /// Converts a JSON string into a RecordingResource object
        /// </summary>
        ///
        /// <param name="json"> Raw JSON string </param>
        /// <returns> RecordingResource object represented by the provided JSON </returns> 
        public static RecordingResource FromJson(string json)
        {
            // Convert all checked exceptions to Runtime
            try
            {
                return JsonConvert.DeserializeObject<RecordingResource>(json);
            }
            catch (JsonException e)
            {
                throw new ApiException(e.Message, e);
            }
        }

        /// <summary>
        /// The account_sid
        /// </summary>
        [JsonProperty("account_sid")]
        public string AccountSid { get; private set; }
        /// <summary>
        /// The api_version
        /// </summary>
        [JsonProperty("api_version")]
        public string ApiVersion { get; private set; }
        /// <summary>
        /// The call_sid
        /// </summary>
        [JsonProperty("call_sid")]
        public string CallSid { get; private set; }
        /// <summary>
        /// The date_created
        /// </summary>
        [JsonProperty("date_created")]
        public DateTime? DateCreated { get; private set; }
        /// <summary>
        /// The date_updated
        /// </summary>
        [JsonProperty("date_updated")]
        public DateTime? DateUpdated { get; private set; }
        /// <summary>
        /// The duration
        /// </summary>
        [JsonProperty("duration")]
        public string Duration { get; private set; }
        /// <summary>
        /// The sid
        /// </summary>
        [JsonProperty("sid")]
        public string Sid { get; private set; }
        /// <summary>
        /// The price
        /// </summary>
        [JsonProperty("price")]
        public decimal? Price { get; private set; }
        /// <summary>
        /// The uri
        /// </summary>
        [JsonProperty("uri")]
        public string Uri { get; private set; }
        /// <summary>
        /// The encryption_type
        /// </summary>
        [JsonProperty("encryption_type")]
        public string EncryptionType { get; private set; }
        /// <summary>
        /// The encryption_details
        /// </summary>
        [JsonProperty("encryption_details")]
        public object EncryptionDetails { get; private set; }

        private RecordingResource()
        {

        }
    }

}