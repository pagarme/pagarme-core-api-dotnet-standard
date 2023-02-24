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
    public class CreateVoucherPaymentRequest : BaseModel 
    {
        // These fields hold the values for the public properties.
        private string statementDescriptor;
        private string cardId;
        private string cardToken;
        private Models.CreateCardRequest card;
        private string recurrencyCycle;

        /// <summary>
        /// The text that will be shown on the voucher's statement
        /// </summary>
        [JsonProperty("statement_descriptor")]
        public string StatementDescriptor 
        { 
            get 
            {
                return this.statementDescriptor; 
            } 
            set 
            {
                this.statementDescriptor = value;
                onPropertyChanged("StatementDescriptor");
            }
        }

        /// <summary>
        /// Card id
        /// </summary>
        [JsonProperty("card_id")]
        public string CardId 
        { 
            get 
            {
                return this.cardId; 
            } 
            set 
            {
                this.cardId = value;
                onPropertyChanged("CardId");
            }
        }

        /// <summary>
        /// Card token
        /// </summary>
        [JsonProperty("card_token")]
        public string CardToken 
        { 
            get 
            {
                return this.cardToken; 
            } 
            set 
            {
                this.cardToken = value;
                onPropertyChanged("CardToken");
            }
        }

        /// <summary>
        /// Card data
        /// </summary>
        [JsonProperty("Card")]
        public Models.CreateCardRequest Card 
        { 
            get 
            {
                return this.card; 
            } 
            set 
            {
                this.card = value;
                onPropertyChanged("Card");
            }
        }

        /// <summary>
        /// Defines whether the card has been used one or more times.
        /// </summary>
        [JsonProperty("recurrency_cycle")]
        public string RecurrencyCycle 
        { 
            get 
            {
                return this.recurrencyCycle; 
            } 
            set 
            {
                this.recurrencyCycle = value;
                onPropertyChanged("RecurrencyCycle");
            }
        }
    }
} 