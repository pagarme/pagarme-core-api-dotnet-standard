/*
 * PagarmeCoreApi.Standard
 *
 * This file was automatically generated by APIMATIC v2.0 ( https://apimatic.io ).
 */
using System;
using System.Collections.Generic;
using System.Dynamic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PagarmeCoreApi.Standard;
using PagarmeCoreApi.Standard.Utilities;
using PagarmeCoreApi.Standard.Http.Request;
using PagarmeCoreApi.Standard.Http.Response;
using PagarmeCoreApi.Standard.Http.Client;

namespace PagarmeCoreApi.Standard.Controllers
{
    public partial interface ITokensController
    {
        /// <summary>
        /// TODO: type endpoint description here
        /// </summary>
        /// <param name="publicKey">Required parameter: Public key</param>
        /// <param name="request">Required parameter: Request for creating a token</param>
        /// <param name="idempotencyKey">Optional parameter: Example: </param>
        /// <return>Returns the Models.GetTokenResponse response from the API call</return>
        Models.GetTokenResponse CreateToken(string publicKey, Models.CreateTokenRequest request, string idempotencyKey = null);

        /// <summary>
        /// TODO: type endpoint description here
        /// </summary>
        /// <param name="publicKey">Required parameter: Public key</param>
        /// <param name="request">Required parameter: Request for creating a token</param>
        /// <param name="idempotencyKey">Optional parameter: Example: </param>
        /// <return>Returns the Models.GetTokenResponse response from the API call</return>
        Task<Models.GetTokenResponse> CreateTokenAsync(string publicKey, Models.CreateTokenRequest request, string idempotencyKey = null);

        /// <summary>
        /// Gets a token from its id
        /// </summary>
        /// <param name="id">Required parameter: Token id</param>
        /// <param name="publicKey">Required parameter: Public key</param>
        /// <return>Returns the Models.GetTokenResponse response from the API call</return>
        Models.GetTokenResponse GetToken(string id, string publicKey);

        /// <summary>
        /// Gets a token from its id
        /// </summary>
        /// <param name="id">Required parameter: Token id</param>
        /// <param name="publicKey">Required parameter: Public key</param>
        /// <return>Returns the Models.GetTokenResponse response from the API call</return>
        Task<Models.GetTokenResponse> GetTokenAsync(string id, string publicKey);

    }
} 