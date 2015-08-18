﻿using FullContactDotNet.Entities;
using RestSharp;
using System;

namespace FullContactDotNet
{
    public class FullContactPersonApi : FullContactApi, IFullContactPersonApi
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="FullContactPersonApi"/> class.
        /// </summary>
        public FullContactPersonApi() : base(FullContactConfiguration.ApiKey) { }

        /// <summary>
        /// Initializes a new instance of the <see cref="FullContactPersonApi"/> class.
        /// </summary>
        /// <param name="apiKey">The API key.</param>
        public FullContactPersonApi(string apiKey) : base(apiKey) { }

        /// <summary>
        /// Lookup Person by email address.
        /// </summary>
        /// <param name="emailAddress">The email address.</param>
        /// <param name="queue">The queue.</param>
        /// <param name="webhookUrl">The webhook url.</param>
        /// <returns></returns>
        /// <exception cref="System.ArgumentNullException">A email address is required to lookup a person by email.</exception>
        public Person LookupPersonByEmail(string emailAddress, int? queue = null, string webhookUrl = null)
        {
            if (string.IsNullOrEmpty(emailAddress)) throw new ArgumentNullException("A email address is required to lookup a person by email.");

            var request = GetPersonRequest(queue, webhookUrl);
            request.AddParameter("email", emailAddress);
            return Execute<Person>(request);
        }

        /// <summary>
        /// Lookup Person by phone number.
        /// </summary>
        /// <param name="phoneNumber">The phone number.</param>
        /// <param name="countryCode">The country code.</param>
        /// <param name="queue">The queue.</param>
        /// <param name="webhookUrl">The webhook url.</param>
        /// <returns></returns>
        /// <exception cref="System.ArgumentNullException">A phone number is required to lookup a person by twitter.</exception>
        public Person LookupPersonByPhone(string phoneNumber, string countryCode = null, int? queue = null, string webhookUrl = null)
        {
            if (string.IsNullOrEmpty(phoneNumber)) throw new ArgumentNullException("A phone number is required to lookup a person by twitter.");

            //TODO: investigate if the phone number needs to be formatted in a particular way

            var request = GetPersonRequest(queue, webhookUrl);
            request.AddParameter("phone", phoneNumber);

            if (!string.IsNullOrWhiteSpace(countryCode))
            {
                request.AddParameter("countryCode", countryCode);
            }

            return Execute<Person>(request);
        }

        /// <summary>
        /// Lookup Person by twitter username.
        /// </summary>
        /// <param name="twitterUsername">The twitter username.</param>
        /// <param name="queue">The queue.</param>
        /// <param name="webhookUrl">The webhook url.</param>
        /// <returns></returns>
        /// <exception cref="System.ArgumentNullException">A twitter username is required to lookup a person by twitter.</exception>
        public Person LookupPersonByTwitter(string twitterUsername, int? queue = null, string webhookUrl = null)
        {
            if (string.IsNullOrEmpty(twitterUsername)) throw new ArgumentNullException("A twitter username is required to lookup a person by twitter.");

            var request = GetPersonRequest(queue, webhookUrl);
            request.AddParameter("twitter", twitterUsername);
            return Execute<Person>(request);
        }

        /// <summary>
        /// Lookup Person by facebook username.
        /// </summary>
        /// <param name="facebookUsername">The facebook username.</param>
        /// <param name="queue">The queue.</param>
        /// <param name="webhookUrl">The webhook url.</param>
        /// <returns></returns>
        /// <exception cref="System.ArgumentNullException">A facebook username is required to lookup a person by facebook.</exception>
        public Person LookupPersonByFacebook(string facebookUsername, int? queue = null, string webhookUrl = null)
        {
            if (string.IsNullOrEmpty(facebookUsername)) throw new ArgumentNullException("A facebook username is required to lookup a person by facebook.");

            var request = GetPersonRequest(queue, webhookUrl);
            request.AddParameter("facebookUsername", facebookUsername);
            return Execute<Person>(request);
        }

        /// <summary>
        /// Gets the person request.
        /// </summary>
        /// <param name="queue">The queue.</param>
        /// <param name="webhookUrl">The webhook url.</param>
        /// <returns></returns>
        private RestRequest GetPersonRequest(int? queue = null, string webhookUrl = null)
        {
            var request = new RestRequest("/person.json", Method.GET);

            if (queue.HasValue)
            {
                request.AddParameter("queue", queue.Value);
            }

            if (!string.IsNullOrWhiteSpace(webhookUrl))
            {
                request.AddParameter("webhookUrl", webhookUrl);
            }

            return request;
        }
    }
}