/*
 * PagarmeCoreApi.Standard
 *
 * This file was automatically generated by APIMATIC v2.0 ( https://apimatic.io ).
 */
using System;
using System.IO;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using PagarmeCoreApi.Standard;
using PagarmeCoreApi.Standard.Utilities;


namespace PagarmeCoreApi.Standard.Models
{
    public class CreateCancelSubscriptionRequest : BaseModel 
    {
        // These fields hold the values for the public properties.
        private bool cancelPendingInvoices;

        /// <summary>
        /// Indicates if the pending invoices must also be canceled.
        /// </summary>
        [JsonProperty("cancel_pending_invoices")]
        public bool CancelPendingInvoices 
        { 
            get 
            {
                return this.cancelPendingInvoices; 
            } 
            set 
            {
                this.cancelPendingInvoices = value;
                onPropertyChanged("CancelPendingInvoices");
            }
        }
    }
} 