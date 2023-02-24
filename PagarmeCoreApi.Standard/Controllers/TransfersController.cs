/*
 * PagarmeCoreApi.Standard
 *
 * This file was automatically generated by APIMATIC v2.0 ( https://apimatic.io ).
 */
using System;
using System.Collections.Generic;
using System.Dynamic;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json.Converters;
using PagarmeCoreApi.Standard;
using PagarmeCoreApi.Standard.Utilities;
using PagarmeCoreApi.Standard.Http.Request;
using PagarmeCoreApi.Standard.Http.Response;
using PagarmeCoreApi.Standard.Http.Client;
using PagarmeCoreApi.Standard.Exceptions;

namespace PagarmeCoreApi.Standard.Controllers
{
    public partial class TransfersController: BaseController, ITransfersController
    {
        #region Singleton Pattern

        //private static variables for the singleton pattern
        private static object syncObject = new object();
        private static TransfersController instance = null;

        /// <summary>
        /// Singleton pattern implementation
        /// </summary>
        internal static TransfersController Instance
        {
            get
            {
                lock (syncObject)
                {
                    if (null == instance)
                    {
                        instance = new TransfersController();
                    }
                }
                return instance;
            }
        }

        #endregion Singleton Pattern

        /// <summary>
        /// GetTransferById
        /// </summary>
        /// <param name="transferId">Required parameter: Example: </param>
        /// <return>Returns the Models.GetTransfer response from the API call</return>
        public Models.GetTransfer GetTransferById(string transferId)
        {
            Task<Models.GetTransfer> t = GetTransferByIdAsync(transferId);
            APIHelper.RunTaskSynchronously(t);
            return t.Result;
        }

        /// <summary>
        /// GetTransferById
        /// </summary>
        /// <param name="transferId">Required parameter: Example: </param>
        /// <return>Returns the Models.GetTransfer response from the API call</return>
        public async Task<Models.GetTransfer> GetTransferByIdAsync(string transferId)
        {
            //the base uri for api requests
            string _baseUri = Configuration.BaseUri;

            //prepare query string for API call
            StringBuilder _queryBuilder = new StringBuilder(_baseUri);
            _queryBuilder.Append("/transfers/{transfer_id}");

            //process optional template parameters
            APIHelper.AppendUrlWithTemplateParameters(_queryBuilder, new Dictionary<string, object>()
            {
                { "transfer_id", transferId }
            });


            //validate and preprocess url
            string _queryUrl = APIHelper.CleanUrl(_queryBuilder);

            //append request with appropriate headers and parameters
            var _headers = new Dictionary<string,string>()
            {
                { "user-agent", "PagarmeCoreApi - DotNet 5.7.0" },
                { "accept", "application/json" }
            };

            //prepare the API call request to fetch the response
            HttpRequest _request = ClientInstance.Get(_queryUrl,_headers, Configuration.BasicAuthUserName, Configuration.BasicAuthPassword);

            //invoke request and get response
            HttpStringResponse _response = (HttpStringResponse) await ClientInstance.ExecuteAsStringAsync(_request).ConfigureAwait(false);
            HttpContext _context = new HttpContext(_request,_response);

            //Error handling using HTTP status codes
            if (_response.StatusCode == 400)
                throw new ErrorException("Invalid request", _context);

            if (_response.StatusCode == 401)
                throw new ErrorException("Invalid API key", _context);

            if (_response.StatusCode == 404)
                throw new ErrorException("An informed resource was not found", _context);

            if (_response.StatusCode == 412)
                throw new ErrorException("Business validation error", _context);

            if (_response.StatusCode == 422)
                throw new ErrorException("Contract validation error", _context);

            if (_response.StatusCode == 500)
                throw new ErrorException("Internal server error", _context);

            //handle errors defined at the API level
            base.ValidateResponse(_response, _context);

            try
            {
                return APIHelper.JsonDeserialize<Models.GetTransfer>(_response.Body);
            }
            catch (Exception _ex)
            {
                throw new APIException("Failed to parse the response: " + _ex.Message, _context);
            }
        }

        /// <summary>
        /// CreateTransfer
        /// </summary>
        /// <param name="body">Required parameter: Example: </param>
        /// <return>Returns the Models.GetTransfer response from the API call</return>
        public Models.GetTransfer PostCreateTransfer(Models.CreateTransfer body)
        {
            Task<Models.GetTransfer> t = PostCreateTransferAsync(body);
            APIHelper.RunTaskSynchronously(t);
            return t.Result;
        }

        /// <summary>
        /// CreateTransfer
        /// </summary>
        /// <param name="body">Required parameter: Example: </param>
        /// <return>Returns the Models.GetTransfer response from the API call</return>
        public async Task<Models.GetTransfer> PostCreateTransferAsync(Models.CreateTransfer body)
        {
            //the base uri for api requests
            string _baseUri = Configuration.BaseUri;

            //prepare query string for API call
            StringBuilder _queryBuilder = new StringBuilder(_baseUri);
            _queryBuilder.Append("/transfers/recipients");


            //validate and preprocess url
            string _queryUrl = APIHelper.CleanUrl(_queryBuilder);

            //append request with appropriate headers and parameters
            var _headers = new Dictionary<string,string>()
            {
                { "user-agent", "PagarmeCoreApi - DotNet 5.7.0" },
                { "accept", "application/json" },
                { "Content-Type", "application/json" }
            };

            //append body params
            var _body = APIHelper.JsonSerialize(body);

            //prepare the API call request to fetch the response
            HttpRequest _request = ClientInstance.PostBody(_queryUrl, _headers, _body, Configuration.BasicAuthUserName, Configuration.BasicAuthPassword);

            //invoke request and get response
            HttpStringResponse _response = (HttpStringResponse) await ClientInstance.ExecuteAsStringAsync(_request).ConfigureAwait(false);
            HttpContext _context = new HttpContext(_request,_response);

            //Error handling using HTTP status codes
            if (_response.StatusCode == 400)
                throw new ErrorException("Invalid request", _context);

            if (_response.StatusCode == 401)
                throw new ErrorException("Invalid API key", _context);

            if (_response.StatusCode == 404)
                throw new ErrorException("An informed resource was not found", _context);

            if (_response.StatusCode == 412)
                throw new ErrorException("Business validation error", _context);

            if (_response.StatusCode == 422)
                throw new ErrorException("Contract validation error", _context);

            if (_response.StatusCode == 500)
                throw new ErrorException("Internal server error", _context);

            //handle errors defined at the API level
            base.ValidateResponse(_response, _context);

            try
            {
                return APIHelper.JsonDeserialize<Models.GetTransfer>(_response.Body);
            }
            catch (Exception _ex)
            {
                throw new APIException("Failed to parse the response: " + _ex.Message, _context);
            }
        }

        /// <summary>
        /// Gets all transfers
        /// </summary>
        /// <return>Returns the Models.ListTransfers response from the API call</return>
        public Models.ListTransfers GetTransfers1()
        {
            Task<Models.ListTransfers> t = GetTransfers1Async();
            APIHelper.RunTaskSynchronously(t);
            return t.Result;
        }

        /// <summary>
        /// Gets all transfers
        /// </summary>
        /// <return>Returns the Models.ListTransfers response from the API call</return>
        public async Task<Models.ListTransfers> GetTransfers1Async()
        {
            //the base uri for api requests
            string _baseUri = Configuration.BaseUri;

            //prepare query string for API call
            StringBuilder _queryBuilder = new StringBuilder(_baseUri);
            _queryBuilder.Append("/transfers");


            //validate and preprocess url
            string _queryUrl = APIHelper.CleanUrl(_queryBuilder);

            //append request with appropriate headers and parameters
            var _headers = new Dictionary<string,string>()
            {
                { "user-agent", "PagarmeCoreApi - DotNet 5.7.0" },
                { "accept", "application/json" }
            };

            //prepare the API call request to fetch the response
            HttpRequest _request = ClientInstance.Get(_queryUrl,_headers, Configuration.BasicAuthUserName, Configuration.BasicAuthPassword);

            //invoke request and get response
            HttpStringResponse _response = (HttpStringResponse) await ClientInstance.ExecuteAsStringAsync(_request).ConfigureAwait(false);
            HttpContext _context = new HttpContext(_request,_response);

            //Error handling using HTTP status codes
            if (_response.StatusCode == 400)
                throw new ErrorException("Invalid request", _context);

            if (_response.StatusCode == 401)
                throw new ErrorException("Invalid API key", _context);

            if (_response.StatusCode == 404)
                throw new ErrorException("An informed resource was not found", _context);

            if (_response.StatusCode == 412)
                throw new ErrorException("Business validation error", _context);

            if (_response.StatusCode == 422)
                throw new ErrorException("Contract validation error", _context);

            if (_response.StatusCode == 500)
                throw new ErrorException("Internal server error", _context);

            //handle errors defined at the API level
            base.ValidateResponse(_response, _context);

            try
            {
                return APIHelper.JsonDeserialize<Models.ListTransfers>(_response.Body);
            }
            catch (Exception _ex)
            {
                throw new APIException("Failed to parse the response: " + _ex.Message, _context);
            }
        }

    }
} 