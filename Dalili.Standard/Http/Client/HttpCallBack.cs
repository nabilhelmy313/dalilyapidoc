// <copyright file="HttpCallBack.cs" company="APIMatic">
// Copyright (c) APIMatic. All rights reserved.
// </copyright>
namespace Dalili.Standard.Http.Client
{
    using Dalili.Standard.Http.Request;
    using Dalili.Standard.Http.Response;

    /// <summary>
    /// HttpCallBack.
    /// </summary>
    internal sealed class HttpCallBack
    {
        /// <summary>
        /// Gets http request.
        /// </summary>
        public HttpRequest Request { get; private set; }

        /// <summary>
        /// Gets http response.
        /// </summary>
        public HttpResponse Response { get; private set; }

        /// <summary>
        /// BeforeHttpRequestEventHandler.
        /// </summary>
        /// <param name="source">Http Client.</param>
        /// <param name="request">Http Request.</param>
        public void OnBeforeHttpRequestEventHandler(IHttpClient source, HttpRequest request)
        {
            this.Request = request;
        }

        /// <summary>
        /// AfterHttpResponseEventHandler.
        /// </summary>
        /// <param name="source">Http Client.</param>
        /// <param name="response">Http Response.</param>
        public void OnAfterHttpResponseEventHandler(IHttpClient source, HttpResponse response)
        {
            this.Response = response;
        }
    }
}