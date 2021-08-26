/*
 * PagarMe.Standard
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
using PagarMe.Standard;
using PagarMe.Standard.Utilities;


namespace PagarMe.Standard.Models
{
    public class GetOrderItemResponse : BaseModel 
    {
        // These fields hold the values for the public properties.
        private string id;
        private int amount;
        private string description;
        private int quantity;
        private Models.GetSellerResponse getSellerResponse;
        private string category;
        private string code;

        /// <summary>
        /// Id
        /// </summary>
        [JsonProperty("id")]
        public string Id 
        { 
            get 
            {
                return this.id; 
            } 
            set 
            {
                this.id = value;
                onPropertyChanged("Id");
            }
        }

        /// <summary>
        /// TODO: Write general description for this method
        /// </summary>
        [JsonProperty("amount")]
        public int Amount 
        { 
            get 
            {
                return this.amount; 
            } 
            set 
            {
                this.amount = value;
                onPropertyChanged("Amount");
            }
        }

        /// <summary>
        /// TODO: Write general description for this method
        /// </summary>
        [JsonProperty("description")]
        public string Description 
        { 
            get 
            {
                return this.description; 
            } 
            set 
            {
                this.description = value;
                onPropertyChanged("Description");
            }
        }

        /// <summary>
        /// TODO: Write general description for this method
        /// </summary>
        [JsonProperty("quantity")]
        public int Quantity 
        { 
            get 
            {
                return this.quantity; 
            } 
            set 
            {
                this.quantity = value;
                onPropertyChanged("Quantity");
            }
        }

        /// <summary>
        /// Seller data
        /// </summary>
        [JsonProperty("GetSellerResponse")]
        public Models.GetSellerResponse GetSellerResponse 
        { 
            get 
            {
                return this.getSellerResponse; 
            } 
            set 
            {
                this.getSellerResponse = value;
                onPropertyChanged("GetSellerResponse");
            }
        }

        /// <summary>
        /// Category
        /// </summary>
        [JsonProperty("category")]
        public string Category 
        { 
            get 
            {
                return this.category; 
            } 
            set 
            {
                this.category = value;
                onPropertyChanged("Category");
            }
        }

        /// <summary>
        /// Code
        /// </summary>
        [JsonProperty("code")]
        public string Code 
        { 
            get 
            {
                return this.code; 
            } 
            set 
            {
                this.code = value;
                onPropertyChanged("Code");
            }
        }
    }
} 