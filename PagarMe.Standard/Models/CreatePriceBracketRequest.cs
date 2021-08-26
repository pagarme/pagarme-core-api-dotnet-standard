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
    public class CreatePriceBracketRequest : BaseModel 
    {
        // These fields hold the values for the public properties.
        private int startQuantity;
        private int price;
        private int? endQuantity;
        private int? overagePrice;

        /// <summary>
        /// Start quantity
        /// </summary>
        [JsonProperty("start_quantity")]
        public int StartQuantity 
        { 
            get 
            {
                return this.startQuantity; 
            } 
            set 
            {
                this.startQuantity = value;
                onPropertyChanged("StartQuantity");
            }
        }

        /// <summary>
        /// Price
        /// </summary>
        [JsonProperty("price")]
        public int Price 
        { 
            get 
            {
                return this.price; 
            } 
            set 
            {
                this.price = value;
                onPropertyChanged("Price");
            }
        }

        /// <summary>
        /// End quantity
        /// </summary>
        [JsonProperty("end_quantity")]
        public int? EndQuantity 
        { 
            get 
            {
                return this.endQuantity; 
            } 
            set 
            {
                this.endQuantity = value;
                onPropertyChanged("EndQuantity");
            }
        }

        /// <summary>
        /// Overage price
        /// </summary>
        [JsonProperty("overage_price")]
        public int? OveragePrice 
        { 
            get 
            {
                return this.overagePrice; 
            } 
            set 
            {
                this.overagePrice = value;
                onPropertyChanged("OveragePrice");
            }
        }
    }
} 