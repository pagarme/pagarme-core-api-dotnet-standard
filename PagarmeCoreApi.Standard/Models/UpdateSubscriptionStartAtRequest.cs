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
    public class UpdateSubscriptionStartAtRequest : BaseModel 
    {
        // These fields hold the values for the public properties.
        private DateTime startAt;

        /// <summary>
        /// The date when the subscription periods will start
        /// </summary>
        [JsonConverter(typeof(IsoDateTimeConverter))]
        [JsonProperty("start_at")]
        public DateTime StartAt 
        { 
            get 
            {
                return this.startAt; 
            } 
            set 
            {
                this.startAt = value;
                onPropertyChanged("StartAt");
            }
        }
    }
} 