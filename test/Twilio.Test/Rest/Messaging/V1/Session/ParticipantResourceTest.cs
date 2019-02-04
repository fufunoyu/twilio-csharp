/// This code was generated by
/// \ / _    _  _|   _  _
///  | (_)\/(_)(_|\/| |(/_  v1.0.0
///       /       /

using NSubstitute;
using NSubstitute.ExceptionExtensions;
using NUnit.Framework;
using System;
using System.Collections.Generic;
using Twilio.Clients;
using Twilio.Converters;
using Twilio.Exceptions;
using Twilio.Http;
using Twilio.Rest.Messaging.V1.Session;

namespace Twilio.Tests.Rest.Messaging.V1.Session 
{

    [TestFixture]
    public class ParticipantTest : TwilioTest 
    {
        [Test]
        public void TestCreateRequest()
        {
            var twilioRestClient = Substitute.For<ITwilioRestClient>();
            var request = new Request(
                HttpMethod.Post,
                Twilio.Rest.Domain.Messaging,
                "/v1/Sessions/CHXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXX/Participants",
                ""
            );
            twilioRestClient.Request(request).Throws(new ApiException("Server Error, no content"));

            try
            {
                ParticipantResource.Create("CHXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXX", client: twilioRestClient);
                Assert.Fail("Expected TwilioException to be thrown for 500");
            }
            catch (ApiException) {}
            twilioRestClient.Received().Request(request);
        }

        [Test]
        public void TestCreateIdentityResponse()
        {
            var twilioRestClient = Substitute.For<ITwilioRestClient>();
            twilioRestClient.AccountSid.Returns("ACXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXX");
            twilioRestClient.Request(Arg.Any<Request>())
                            .Returns(new Response(
                                         System.Net.HttpStatusCode.Created,
                                         "{\"account_sid\": \"ACaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaa\",\"service_sid\": \"ISaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaa\",\"messaging_service_sid\": \"MGaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaa\",\"session_sid\": \"CHaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaa\",\"sid\": \"MBaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaa\",\"identity\": \"Twilio\",\"attributes\": \"{ \\\"foo\\\": \\\"bar\\\" }\",\"date_created\": \"2015-12-16T22:18:37Z\",\"date_updated\": \"2015-12-16T22:18:38Z\",\"type\": \"chat\",\"twilio_address\": \"+111111\",\"user_address\": \"+999999\",\"url\": \"https://messaging.twilio.com/v1/Sessions/CHaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaa/Participants/MBaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaa\"}"
                                     ));

            var response = ParticipantResource.Create("CHXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXX", client: twilioRestClient);
            Assert.NotNull(response);
        }

        [Test]
        public void TestCreateAddressResponse()
        {
            var twilioRestClient = Substitute.For<ITwilioRestClient>();
            twilioRestClient.AccountSid.Returns("ACXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXX");
            twilioRestClient.Request(Arg.Any<Request>())
                            .Returns(new Response(
                                         System.Net.HttpStatusCode.Created,
                                         "{\"account_sid\": \"ACaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaa\",\"service_sid\": \"ISaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaa\",\"messaging_service_sid\": \"MGaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaa\",\"session_sid\": \"CHaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaa\",\"sid\": \"MBaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaa\",\"identity\": null,\"attributes\": \"{}\",\"date_created\": \"2016-03-24T21:05:50Z\",\"date_updated\": \"2016-03-24T21:05:50Z\",\"type\": \"chat\",\"twilio_address\": \"+111111\",\"user_address\": \"+999999\",\"url\": \"https://messaging.twilio.com/v1/Sessions/CHaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaa/Participants/MBaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaa\"}"
                                     ));

            var response = ParticipantResource.Create("CHXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXX", client: twilioRestClient);
            Assert.NotNull(response);
        }

        [Test]
        public void TestUpdateRequest()
        {
            var twilioRestClient = Substitute.For<ITwilioRestClient>();
            var request = new Request(
                HttpMethod.Post,
                Twilio.Rest.Domain.Messaging,
                "/v1/Sessions/CHXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXX/Participants/MBXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXX",
                ""
            );
            twilioRestClient.Request(request).Throws(new ApiException("Server Error, no content"));

            try
            {
                ParticipantResource.Update("CHXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXX", "MBXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXX", client: twilioRestClient);
                Assert.Fail("Expected TwilioException to be thrown for 500");
            }
            catch (ApiException) {}
            twilioRestClient.Received().Request(request);
        }

        [Test]
        public void TestUpdateResponse()
        {
            var twilioRestClient = Substitute.For<ITwilioRestClient>();
            twilioRestClient.AccountSid.Returns("ACXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXX");
            twilioRestClient.Request(Arg.Any<Request>())
                            .Returns(new Response(
                                         System.Net.HttpStatusCode.OK,
                                         "{\"account_sid\": \"ACaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaa\",\"service_sid\": \"ISaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaa\",\"messaging_service_sid\": \"MGaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaa\",\"session_sid\": \"CHaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaa\",\"sid\": \"MBaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaa\",\"identity\": \"Twilio\",\"attributes\": \"{ \\\"foo\\\": \\\"bar\\\" }\",\"date_created\": \"2015-12-16T22:18:37Z\",\"date_updated\": \"2015-12-16T22:18:38Z\",\"type\": \"chat\",\"twilio_address\": \"+111111\",\"user_address\": \"+999999\",\"url\": \"https://messaging.twilio.com/v1/Sessions/CHaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaa/Participants/MBaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaa\"}"
                                     ));

            var response = ParticipantResource.Update("CHXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXX", "MBXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXX", client: twilioRestClient);
            Assert.NotNull(response);
        }

        [Test]
        public void TestFetchRequest()
        {
            var twilioRestClient = Substitute.For<ITwilioRestClient>();
            var request = new Request(
                HttpMethod.Get,
                Twilio.Rest.Domain.Messaging,
                "/v1/Sessions/CHXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXX/Participants/MBXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXX",
                ""
            );
            twilioRestClient.Request(request).Throws(new ApiException("Server Error, no content"));

            try
            {
                ParticipantResource.Fetch("CHXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXX", "MBXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXX", client: twilioRestClient);
                Assert.Fail("Expected TwilioException to be thrown for 500");
            }
            catch (ApiException) {}
            twilioRestClient.Received().Request(request);
        }

        [Test]
        public void TestFetchResponse()
        {
            var twilioRestClient = Substitute.For<ITwilioRestClient>();
            twilioRestClient.AccountSid.Returns("ACXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXX");
            twilioRestClient.Request(Arg.Any<Request>())
                            .Returns(new Response(
                                         System.Net.HttpStatusCode.OK,
                                         "{\"account_sid\": \"ACaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaa\",\"service_sid\": \"ISaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaa\",\"messaging_service_sid\": \"MGaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaa\",\"session_sid\": \"CHaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaa\",\"sid\": \"MBaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaa\",\"identity\": \"Twilio\",\"attributes\": \"{}\",\"date_created\": \"2016-03-24T21:05:50Z\",\"date_updated\": \"2016-03-24T21:05:50Z\",\"type\": \"chat\",\"twilio_address\": \"+111111\",\"user_address\": \"+999999\",\"url\": \"https://messaging.twilio.com/v1/Sessions/CHaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaa/Participants/MBaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaa\"}"
                                     ));

            var response = ParticipantResource.Fetch("CHXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXX", "MBXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXX", client: twilioRestClient);
            Assert.NotNull(response);
        }

        [Test]
        public void TestReadRequest()
        {
            var twilioRestClient = Substitute.For<ITwilioRestClient>();
            var request = new Request(
                HttpMethod.Get,
                Twilio.Rest.Domain.Messaging,
                "/v1/Sessions/CHXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXX/Participants",
                ""
            );
            twilioRestClient.Request(request).Throws(new ApiException("Server Error, no content"));

            try
            {
                ParticipantResource.Read("CHXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXX", client: twilioRestClient);
                Assert.Fail("Expected TwilioException to be thrown for 500");
            }
            catch (ApiException) {}
            twilioRestClient.Received().Request(request);
        }

        [Test]
        public void TestReadResponse()
        {
            var twilioRestClient = Substitute.For<ITwilioRestClient>();
            twilioRestClient.AccountSid.Returns("ACXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXX");
            twilioRestClient.Request(Arg.Any<Request>())
                            .Returns(new Response(
                                         System.Net.HttpStatusCode.OK,
                                         "{\"meta\": {\"page\": 0,\"page_size\": 50,\"first_page_url\": \"https://messaging.twilio.com/v1/Sessions/CHaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaa/Participants?PageSize=50&Page=0\",\"previous_page_url\": null,\"url\": \"https://messaging.twilio.com/v1/Sessions/CHaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaa/Participants?PageSize=50&Page=0\",\"next_page_url\": null,\"key\": \"participants\"},\"participants\": [{\"account_sid\": \"ACaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaa\",\"service_sid\": \"ISaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaa\",\"messaging_service_sid\": \"MGaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaa\",\"session_sid\": \"CHaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaa\",\"sid\": \"MBaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaa\",\"identity\": \"Twilio\",\"attributes\": \"{}\",\"date_created\": \"2016-03-24T21:05:50Z\",\"date_updated\": \"2016-03-24T21:05:50Z\",\"type\": \"chat\",\"twilio_address\": \"+111111\",\"user_address\": \"+999999\",\"url\": \"https://messaging.twilio.com/v1/Sessions/CHaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaa/Participants/MBaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaa\"}]}"
                                     ));

            var response = ParticipantResource.Read("CHXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXX", client: twilioRestClient);
            Assert.NotNull(response);
        }

        [Test]
        public void TestDeleteRequest()
        {
            var twilioRestClient = Substitute.For<ITwilioRestClient>();
            var request = new Request(
                HttpMethod.Delete,
                Twilio.Rest.Domain.Messaging,
                "/v1/Sessions/CHXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXX/Participants/MBXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXX",
                ""
            );
            twilioRestClient.Request(request).Throws(new ApiException("Server Error, no content"));

            try
            {
                ParticipantResource.Delete("CHXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXX", "MBXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXX", client: twilioRestClient);
                Assert.Fail("Expected TwilioException to be thrown for 500");
            }
            catch (ApiException) {}
            twilioRestClient.Received().Request(request);
        }

        [Test]
        public void TestDeleteResponse()
        {
            var twilioRestClient = Substitute.For<ITwilioRestClient>();
            twilioRestClient.AccountSid.Returns("ACXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXX");
            twilioRestClient.Request(Arg.Any<Request>())
                            .Returns(new Response(
                                         System.Net.HttpStatusCode.NoContent,
                                         "null"
                                     ));

            var response = ParticipantResource.Delete("CHXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXX", "MBXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXX", client: twilioRestClient);
            Assert.NotNull(response);
        }
    }

}