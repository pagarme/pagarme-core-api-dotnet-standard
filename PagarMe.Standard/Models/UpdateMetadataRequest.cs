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
    public class UpdateMetadataRequest : BaseModel 
    {
        // These fields hold the values for the public properties.
        private Dictionary<string, string> metadata;

        /// <summary>
        /// Metadata
        /// </summary>
        [JsonProperty("metadata")]
        public Dictionary<string, string> Metadata 
        { 
            get 
            {
                return this.metadata; 
            } 
            set 
            {
                this.metadata = value;
                onPropertyChanged("Metadata");
            }
        }
    }
} 