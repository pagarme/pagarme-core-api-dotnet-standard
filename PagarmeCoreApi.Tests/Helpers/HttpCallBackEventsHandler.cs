/*
 * PagarmeCoreApi.Tests
 *
 * This file was automatically generated by APIMATIC v2.0 ( https://apimatic.io ).
 */
using PagarmeCoreApi.Standard.Http.Client;
using PagarmeCoreApi.Standard.Http.Request;
using PagarmeCoreApi.Standard.Http.Response;

namespace PagarmeCoreApi.Tests.Helpers
{
    public class HttpCallBackEventsHandler
    {
        public HttpRequest Request { get; private set; }

        public HttpResponse Response { get; private set; }

        public void OnBeforeHttpRequestEventHandler(IHttpClient source, HttpRequest request)
        {
            this.Request = request;
        }

        public void OnAfterHttpResponseEventHandler(IHttpClient source, HttpResponse response)
        {
            this.Response = response;
        }
    }
}