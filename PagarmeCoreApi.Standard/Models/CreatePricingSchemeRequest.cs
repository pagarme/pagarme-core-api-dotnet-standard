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
    public class CreatePricingSchemeRequest : BaseModel 
    {
        // These fields hold the values for the public properties.
        private string schemeType;
        private List<Models.CreatePriceBracketRequest> priceBrackets;
        private int? price;
        private int? minimumPrice;
        private double? percentage;

        /// <summary>
        /// Scheme type
        /// </summary>
        [JsonProperty("scheme_type")]
        public string SchemeType 
        { 
            get 
            {
                return this.schemeType; 
            } 
            set 
            {
                this.schemeType = value;
                onPropertyChanged("SchemeType");
            }
        }

        /// <summary>
        /// Price brackets
        /// </summary>
        [JsonProperty("price_brackets")]
        public List<Models.CreatePriceBracketRequest> PriceBrackets 
        { 
            get 
            {
                return this.priceBrackets; 
            } 
            set 
            {
                this.priceBrackets = value;
                onPropertyChanged("PriceBrackets");
            }
        }

        /// <summary>
        /// Price
        /// </summary>
        [JsonProperty("price")]
        public int? Price 
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
        /// Minimum price
        /// </summary>
        [JsonProperty("minimum_price")]
        public int? MinimumPrice 
        { 
            get 
            {
                return this.minimumPrice; 
            } 
            set 
            {
                this.minimumPrice = value;
                onPropertyChanged("MinimumPrice");
            }
        }

        /// <summary>
        /// percentual value used in pricing_scheme Percent
        /// </summary>
        [JsonProperty("percentage")]
        public double? Percentage 
        { 
            get 
            {
                return this.percentage; 
            } 
            set 
            {
                this.percentage = value;
                onPropertyChanged("Percentage");
            }
        }
    }
} 