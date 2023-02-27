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
    public class GetPixTransactionResponse : GetTransactionResponse 
    {
        // These fields hold the values for the public properties.
        private string qrCode;
        private string qrCodeUrl;
        private DateTime expiresAt;
        private List<Models.PixAdditionalInformation> additionalInformation;
        private string endToEndId;
        private Models.GetPixPayerResponse payer;

        /// <summary>
        /// TODO: Write general description for this method
        /// </summary>
        [JsonProperty("qr_code")]
        public string QrCode 
        { 
            get 
            {
                return this.qrCode; 
            } 
            set 
            {
                this.qrCode = value;
                onPropertyChanged("QrCode");
            }
        }

        /// <summary>
        /// TODO: Write general description for this method
        /// </summary>
        [JsonProperty("qr_code_url")]
        public string QrCodeUrl 
        { 
            get 
            {
                return this.qrCodeUrl; 
            } 
            set 
            {
                this.qrCodeUrl = value;
                onPropertyChanged("QrCodeUrl");
            }
        }

        /// <summary>
        /// TODO: Write general description for this method
        /// </summary>
        [JsonConverter(typeof(IsoDateTimeConverter))]
        [JsonProperty("expires_at")]
        public DateTime ExpiresAt 
        { 
            get 
            {
                return this.expiresAt; 
            } 
            set 
            {
                this.expiresAt = value;
                onPropertyChanged("ExpiresAt");
            }
        }

        /// <summary>
        /// TODO: Write general description for this method
        /// </summary>
        [JsonProperty("additional_information")]
        public List<Models.PixAdditionalInformation> AdditionalInformation 
        { 
            get 
            {
                return this.additionalInformation; 
            } 
            set 
            {
                this.additionalInformation = value;
                onPropertyChanged("AdditionalInformation");
            }
        }

        /// <summary>
        /// TODO: Write general description for this method
        /// </summary>
        [JsonProperty("end_to_end_id")]
        public string EndToEndId 
        { 
            get 
            {
                return this.endToEndId; 
            } 
            set 
            {
                this.endToEndId = value;
                onPropertyChanged("EndToEndId");
            }
        }

        /// <summary>
        /// Pix payer data.
        /// </summary>
        [JsonProperty("payer")]
        public Models.GetPixPayerResponse Payer 
        { 
            get 
            {
                return this.payer; 
            } 
            set 
            {
                this.payer = value;
                onPropertyChanged("Payer");
            }
        }
    }
} 