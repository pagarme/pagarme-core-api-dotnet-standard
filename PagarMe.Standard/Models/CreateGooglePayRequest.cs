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
    public class CreateGooglePayRequest : BaseModel 
    {
        // These fields hold the values for the public properties.
        private string version;
        private string data;
        private Models.CreateGooglePayHeaderRequest header;
        private string signature;
        private string merchantIdentifier;

        /// <summary>
        /// The token version
        /// </summary>
        [JsonProperty("version")]
        public string Version 
        { 
            get 
            {
                return this.version; 
            } 
            set 
            {
                this.version = value;
                onPropertyChanged("Version");
            }
        }

        /// <summary>
        /// The cryptography data
        /// </summary>
        [JsonProperty("data")]
        public string Data 
        { 
            get 
            {
                return this.data; 
            } 
            set 
            {
                this.data = value;
                onPropertyChanged("Data");
            }
        }

        /// <summary>
        /// The GooglePay header request
        /// </summary>
        [JsonProperty("header")]
        public Models.CreateGooglePayHeaderRequest Header 
        { 
            get 
            {
                return this.header; 
            } 
            set 
            {
                this.header = value;
                onPropertyChanged("Header");
            }
        }

        /// <summary>
        /// Detached PKCS #7 signature, Base64 encoded as string
        /// </summary>
        [JsonProperty("signature")]
        public string Signature 
        { 
            get 
            {
                return this.signature; 
            } 
            set 
            {
                this.signature = value;
                onPropertyChanged("Signature");
            }
        }

        /// <summary>
        /// GooglePay Merchant identifier
        /// </summary>
        [JsonProperty("merchant_identifier")]
        public string MerchantIdentifier 
        { 
            get 
            {
                return this.merchantIdentifier; 
            } 
            set 
            {
                this.merchantIdentifier = value;
                onPropertyChanged("MerchantIdentifier");
            }
        }
    }
} 