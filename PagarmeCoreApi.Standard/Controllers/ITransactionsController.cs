// <copyright file="ITransactionsController.cs" company="APIMatic">
// Copyright (c) APIMatic. All rights reserved.
// </copyright>
namespace PagarmeCoreApi.Standard.Controllers
{
    using System;
    using System.Collections.Generic;
    using System.Dynamic;
    using System.IO;
    using System.Linq;
    using System.Text;
    using System.Threading;
    using System.Threading.Tasks;
    using PagarmeCoreApi.Standard;
    using PagarmeCoreApi.Standard.Http.Client;
    using PagarmeCoreApi.Standard.Http.Request;
    using PagarmeCoreApi.Standard.Http.Response;
    using PagarmeCoreApi.Standard.Utilities;

    /// <summary>
    /// ITransactionsController.
    /// </summary>
    public interface ITransactionsController
    {
        /// <summary>
        /// GetTransaction EndPoint.
        /// </summary>
        /// <param name="transactionId">Required parameter: Example: .</param>
        /// <returns>Returns the Models.GetTransactionResponse response from the API call.</returns>
        Models.GetTransactionResponse GetTransaction(
                string transactionId);

        /// <summary>
        /// GetTransaction EndPoint.
        /// </summary>
        /// <param name="transactionId">Required parameter: Example: .</param>
        /// <param name="cancellationToken"> cancellationToken. </param>
        /// <returns>Returns the Models.GetTransactionResponse response from the API call.</returns>
        Task<Models.GetTransactionResponse> GetTransactionAsync(
                string transactionId,
                CancellationToken cancellationToken = default);
    }
}