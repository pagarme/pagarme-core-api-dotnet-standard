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
    public partial interface IOrdersController
    {
        /// <summary>
        /// Gets all orders
        /// </summary>
        /// <param name="page">Optional parameter: Page number</param>
        /// <param name="size">Optional parameter: Page size</param>
        /// <param name="code">Optional parameter: Filter for order's code</param>
        /// <param name="status">Optional parameter: Filter for order's status</param>
        /// <param name="createdSince">Optional parameter: Filter for order's creation date start range</param>
        /// <param name="createdUntil">Optional parameter: Filter for order's creation date end range</param>
        /// <param name="customerId">Optional parameter: Filter for order's customer id</param>
        /// <return>Returns the Models.ListOrderResponse response from the API call</return>
        Models.ListOrderResponse GetOrders(
                int? page = null,
                int? size = null,
                string code = null,
                string status = null,
                DateTime? createdSince = null,
                DateTime? createdUntil = null,
                string customerId = null);

        /// <summary>
        /// Gets all orders
        /// </summary>
        /// <param name="page">Optional parameter: Page number</param>
        /// <param name="size">Optional parameter: Page size</param>
        /// <param name="code">Optional parameter: Filter for order's code</param>
        /// <param name="status">Optional parameter: Filter for order's status</param>
        /// <param name="createdSince">Optional parameter: Filter for order's creation date start range</param>
        /// <param name="createdUntil">Optional parameter: Filter for order's creation date end range</param>
        /// <param name="customerId">Optional parameter: Filter for order's customer id</param>
        /// <return>Returns the Models.ListOrderResponse response from the API call</return>
        Task<Models.ListOrderResponse> GetOrdersAsync(
                int? page = null,
                int? size = null,
                string code = null,
                string status = null,
                DateTime? createdSince = null,
                DateTime? createdUntil = null,
                string customerId = null);

        /// <summary>
        /// Creates a new Order
        /// </summary>
        /// <param name="body">Required parameter: Request for creating an order</param>
        /// <param name="idempotencyKey">Optional parameter: Example: </param>
        /// <return>Returns the Models.GetOrderResponse response from the API call</return>
        Models.GetOrderResponse CreateOrder(Models.CreateOrderRequest body, string idempotencyKey = null);

        /// <summary>
        /// Creates a new Order
        /// </summary>
        /// <param name="body">Required parameter: Request for creating an order</param>
        /// <param name="idempotencyKey">Optional parameter: Example: </param>
        /// <return>Returns the Models.GetOrderResponse response from the API call</return>
        Task<Models.GetOrderResponse> CreateOrderAsync(Models.CreateOrderRequest body, string idempotencyKey = null);

        /// <summary>
        /// DeleteAllOrderItems
        /// </summary>
        /// <param name="orderId">Required parameter: Order Id</param>
        /// <param name="idempotencyKey">Optional parameter: Example: </param>
        /// <return>Returns the Models.GetOrderResponse response from the API call</return>
        Models.GetOrderResponse DeleteAllOrderItems(string orderId, string idempotencyKey = null);

        /// <summary>
        /// DeleteAllOrderItems
        /// </summary>
        /// <param name="orderId">Required parameter: Order Id</param>
        /// <param name="idempotencyKey">Optional parameter: Example: </param>
        /// <return>Returns the Models.GetOrderResponse response from the API call</return>
        Task<Models.GetOrderResponse> DeleteAllOrderItemsAsync(string orderId, string idempotencyKey = null);

        /// <summary>
        /// CreateOrderItem
        /// </summary>
        /// <param name="orderId">Required parameter: Order Id</param>
        /// <param name="body">Required parameter: Order Item Model</param>
        /// <param name="idempotencyKey">Optional parameter: Example: </param>
        /// <return>Returns the Models.GetOrderItemResponse response from the API call</return>
        Models.GetOrderItemResponse CreateOrderItem(string orderId, Models.CreateOrderItemRequest body, string idempotencyKey = null);

        /// <summary>
        /// CreateOrderItem
        /// </summary>
        /// <param name="orderId">Required parameter: Order Id</param>
        /// <param name="body">Required parameter: Order Item Model</param>
        /// <param name="idempotencyKey">Optional parameter: Example: </param>
        /// <return>Returns the Models.GetOrderItemResponse response from the API call</return>
        Task<Models.GetOrderItemResponse> CreateOrderItemAsync(string orderId, Models.CreateOrderItemRequest body, string idempotencyKey = null);

        /// <summary>
        /// UpdateOrderItem
        /// </summary>
        /// <param name="orderId">Required parameter: Order Id</param>
        /// <param name="itemId">Required parameter: Item Id</param>
        /// <param name="body">Required parameter: Item Model</param>
        /// <param name="idempotencyKey">Optional parameter: Example: </param>
        /// <return>Returns the Models.GetOrderItemResponse response from the API call</return>
        Models.GetOrderItemResponse UpdateOrderItem(
                string orderId,
                string itemId,
                Models.UpdateOrderItemRequest body,
                string idempotencyKey = null);

        /// <summary>
        /// UpdateOrderItem
        /// </summary>
        /// <param name="orderId">Required parameter: Order Id</param>
        /// <param name="itemId">Required parameter: Item Id</param>
        /// <param name="body">Required parameter: Item Model</param>
        /// <param name="idempotencyKey">Optional parameter: Example: </param>
        /// <return>Returns the Models.GetOrderItemResponse response from the API call</return>
        Task<Models.GetOrderItemResponse> UpdateOrderItemAsync(
                string orderId,
                string itemId,
                Models.UpdateOrderItemRequest body,
                string idempotencyKey = null);

        /// <summary>
        /// DeleteOrderItem
        /// </summary>
        /// <param name="orderId">Required parameter: Order Id</param>
        /// <param name="itemId">Required parameter: Item Id</param>
        /// <param name="idempotencyKey">Optional parameter: Example: </param>
        /// <return>Returns the Models.GetOrderItemResponse response from the API call</return>
        Models.GetOrderItemResponse DeleteOrderItem(string orderId, string itemId, string idempotencyKey = null);

        /// <summary>
        /// DeleteOrderItem
        /// </summary>
        /// <param name="orderId">Required parameter: Order Id</param>
        /// <param name="itemId">Required parameter: Item Id</param>
        /// <param name="idempotencyKey">Optional parameter: Example: </param>
        /// <return>Returns the Models.GetOrderItemResponse response from the API call</return>
        Task<Models.GetOrderItemResponse> DeleteOrderItemAsync(string orderId, string itemId, string idempotencyKey = null);

        /// <summary>
        /// GetOrderItem
        /// </summary>
        /// <param name="orderId">Required parameter: Order Id</param>
        /// <param name="itemId">Required parameter: Item Id</param>
        /// <return>Returns the Models.GetOrderItemResponse response from the API call</return>
        Models.GetOrderItemResponse GetOrderItem(string orderId, string itemId);

        /// <summary>
        /// GetOrderItem
        /// </summary>
        /// <param name="orderId">Required parameter: Order Id</param>
        /// <param name="itemId">Required parameter: Item Id</param>
        /// <return>Returns the Models.GetOrderItemResponse response from the API call</return>
        Task<Models.GetOrderItemResponse> GetOrderItemAsync(string orderId, string itemId);

        /// <summary>
        /// CloseOrder
        /// </summary>
        /// <param name="id">Required parameter: Order Id</param>
        /// <param name="body">Required parameter: Update Order Model</param>
        /// <param name="idempotencyKey">Optional parameter: Example: </param>
        /// <return>Returns the Models.GetOrderResponse response from the API call</return>
        Models.GetOrderResponse CloseOrder(string id, Models.UpdateOrderStatusRequest body, string idempotencyKey = null);

        /// <summary>
        /// CloseOrder
        /// </summary>
        /// <param name="id">Required parameter: Order Id</param>
        /// <param name="body">Required parameter: Update Order Model</param>
        /// <param name="idempotencyKey">Optional parameter: Example: </param>
        /// <return>Returns the Models.GetOrderResponse response from the API call</return>
        Task<Models.GetOrderResponse> CloseOrderAsync(string id, Models.UpdateOrderStatusRequest body, string idempotencyKey = null);

        /// <summary>
        /// Updates the metadata from an order
        /// </summary>
        /// <param name="orderId">Required parameter: The order id</param>
        /// <param name="body">Required parameter: Request for updating the order metadata</param>
        /// <param name="idempotencyKey">Optional parameter: Example: </param>
        /// <return>Returns the Models.GetOrderResponse response from the API call</return>
        Models.GetOrderResponse UpdateOrderMetadata(string orderId, Models.UpdateMetadataRequest body, string idempotencyKey = null);

        /// <summary>
        /// Updates the metadata from an order
        /// </summary>
        /// <param name="orderId">Required parameter: The order id</param>
        /// <param name="body">Required parameter: Request for updating the order metadata</param>
        /// <param name="idempotencyKey">Optional parameter: Example: </param>
        /// <return>Returns the Models.GetOrderResponse response from the API call</return>
        Task<Models.GetOrderResponse> UpdateOrderMetadataAsync(string orderId, Models.UpdateMetadataRequest body, string idempotencyKey = null);

        /// <summary>
        /// Gets an order
        /// </summary>
        /// <param name="orderId">Required parameter: Order id</param>
        /// <return>Returns the Models.GetOrderResponse response from the API call</return>
        Models.GetOrderResponse GetOrder(string orderId);

        /// <summary>
        /// Gets an order
        /// </summary>
        /// <param name="orderId">Required parameter: Order id</param>
        /// <return>Returns the Models.GetOrderResponse response from the API call</return>
        Task<Models.GetOrderResponse> GetOrderAsync(string orderId);

    }
} 