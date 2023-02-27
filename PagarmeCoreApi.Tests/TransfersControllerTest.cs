/*
 * PagarmeCoreApi.Tests
 *
 * This file was automatically generated by APIMATIC v2.0 ( https://apimatic.io ).
 */
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Threading.Tasks;
using Newtonsoft.Json.Converters;
using PagarmeCoreApi.Standard;
using PagarmeCoreApi.Standard.Utilities; 
using PagarmeCoreApi.Standard.Http.Client;
using PagarmeCoreApi.Standard.Http.Response;
using PagarmeCoreApi.Tests.Helpers;
using NUnit.Framework;
using PagarmeCoreApi.Standard;
using PagarmeCoreApi.Standard.Controllers;
using PagarmeCoreApi.Standard.Exceptions;

namespace PagarmeCoreApi.Tests
{
    [TestFixture]
    public class TransfersControllerTest : ControllerTestBase
    {
        /// <summary>
        /// Controller instance (for all tests)
        /// </summary>
        private static ITransfersController controller;

        /// <summary>
        /// Setup test class
        /// </summary>
        [SetUp]
        public static void SetUpClass()
        {
            controller = GetClient().Transfers;
        }

        /// <summary>
        /// Gets all transfers 
        /// </summary>
        [Test]
        public async Task TestTestGetTransfers1() 
        {

            // Perform API call
            Standard.Models.ListTransfers result = null;

            try
            {
                result = await controller.GetTransfers1Async();
            }
            catch(APIException) {};

            // Test response code
            Assert.AreEqual(200, httpCallBackHandler.Response.StatusCode,
                    "Status should be 200");

            // Test headers
            Dictionary<string, string> headers = new Dictionary<string, string>();
            headers.Add("Content-Type", "application/json");

            Assert.IsTrue(TestHelper.AreHeadersProperSubsetOf (
                    headers, httpCallBackHandler.Response.Headers),
                    "Headers should match");

        }

    }
}