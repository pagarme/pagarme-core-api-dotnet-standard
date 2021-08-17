/*
 * PagarmeAPI.Standard
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
using APIMATIC.SDK.Common;


namespace PagarmeAPI.Standard.Models
{
    public class CreateRecipient : BaseModel 
    {
        // These fields hold the values for the public properties.
        private int? anticipatableVolumePercentage;
        private bool? automaticAnticipationEnabled;
        private int? transferDay;
        private bool transferEnabled;
        private string transferInterval;
        private string postbackUrl;
        private Models.BankAccount bankAccount;
        private Models.RegisterInformation registerInformation;
        private DateTime? lastTransfer;
        private string automaticAnticipationType;
        private string automaticAnticipationDays;
        private int? automaticAnticipation1025Delay;
        private DateTime? dateCreated;
        private DateTime? dateUpdated;
        private string status;
        private string statusReason;
        private Dictionary<string, string> metadata;
        private string externalId;
        private string mdrConfigurationId;
        private string anticipationFee;
        private string apiKey;
        private bool pixRecipientAsSource = false;

        /// <summary>
        /// TODO: Write general description for this method
        /// </summary>
        [JsonProperty("anticipatable_volume_percentage")]
        public int? AnticipatableVolumePercentage 
        { 
            get 
            {
                return this.anticipatableVolumePercentage; 
            } 
            set 
            {
                this.anticipatableVolumePercentage = value;
                onPropertyChanged("AnticipatableVolumePercentage");
            }
        }

        /// <summary>
        /// TODO: Write general description for this method
        /// </summary>
        [JsonProperty("automatic_anticipation_enabled")]
        public bool? AutomaticAnticipationEnabled 
        { 
            get 
            {
                return this.automaticAnticipationEnabled; 
            } 
            set 
            {
                this.automaticAnticipationEnabled = value;
                onPropertyChanged("AutomaticAnticipationEnabled");
            }
        }

        /// <summary>
        /// TODO: Write general description for this method
        /// </summary>
        [JsonProperty("transfer_day")]
        public int? TransferDay 
        { 
            get 
            {
                return this.transferDay; 
            } 
            set 
            {
                this.transferDay = value;
                onPropertyChanged("TransferDay");
            }
        }

        /// <summary>
        /// TODO: Write general description for this method
        /// </summary>
        [JsonProperty("transfer_enabled")]
        public bool TransferEnabled 
        { 
            get 
            {
                return this.transferEnabled; 
            } 
            set 
            {
                this.transferEnabled = value;
                onPropertyChanged("TransferEnabled");
            }
        }

        /// <summary>
        /// TODO: Write general description for this method
        /// </summary>
        [JsonProperty("transfer_interval")]
        public string TransferInterval 
        { 
            get 
            {
                return this.transferInterval; 
            } 
            set 
            {
                this.transferInterval = value;
                onPropertyChanged("TransferInterval");
            }
        }

        /// <summary>
        /// TODO: Write general description for this method
        /// </summary>
        [JsonProperty("postback_url")]
        public string PostbackUrl 
        { 
            get 
            {
                return this.postbackUrl; 
            } 
            set 
            {
                this.postbackUrl = value;
                onPropertyChanged("PostbackUrl");
            }
        }

        /// <summary>
        /// TODO: Write general description for this method
        /// </summary>
        [JsonProperty("bank_account")]
        public Models.BankAccount BankAccount 
        { 
            get 
            {
                return this.bankAccount; 
            } 
            set 
            {
                this.bankAccount = value;
                onPropertyChanged("BankAccount");
            }
        }

        /// <summary>
        /// TODO: Write general description for this method
        /// </summary>
        [JsonProperty("register_information")]
        public Models.RegisterInformation RegisterInformation 
        { 
            get 
            {
                return this.registerInformation; 
            } 
            set 
            {
                this.registerInformation = value;
                onPropertyChanged("RegisterInformation");
            }
        }

        /// <summary>
        /// TODO: Write general description for this method
        /// </summary>
        [JsonConverter(typeof(IsoDateTimeConverter))]
        [JsonProperty("last_transfer")]
        public DateTime? LastTransfer 
        { 
            get 
            {
                return this.lastTransfer; 
            } 
            set 
            {
                this.lastTransfer = value;
                onPropertyChanged("LastTransfer");
            }
        }

        /// <summary>
        /// TODO: Write general description for this method
        /// </summary>
        [JsonProperty("automatic_anticipation_type")]
        public string AutomaticAnticipationType 
        { 
            get 
            {
                return this.automaticAnticipationType; 
            } 
            set 
            {
                this.automaticAnticipationType = value;
                onPropertyChanged("AutomaticAnticipationType");
            }
        }

        /// <summary>
        /// TODO: Write general description for this method
        /// </summary>
        [JsonProperty("automatic_anticipation_days")]
        public string AutomaticAnticipationDays 
        { 
            get 
            {
                return this.automaticAnticipationDays; 
            } 
            set 
            {
                this.automaticAnticipationDays = value;
                onPropertyChanged("AutomaticAnticipationDays");
            }
        }

        /// <summary>
        /// TODO: Write general description for this method
        /// </summary>
        [JsonProperty("automatic_anticipation_1025_delay")]
        public int? AutomaticAnticipation1025Delay 
        { 
            get 
            {
                return this.automaticAnticipation1025Delay; 
            } 
            set 
            {
                this.automaticAnticipation1025Delay = value;
                onPropertyChanged("AutomaticAnticipation1025Delay");
            }
        }

        /// <summary>
        /// TODO: Write general description for this method
        /// </summary>
        [JsonConverter(typeof(IsoDateTimeConverter))]
        [JsonProperty("date_created")]
        public DateTime? DateCreated 
        { 
            get 
            {
                return this.dateCreated; 
            } 
            set 
            {
                this.dateCreated = value;
                onPropertyChanged("DateCreated");
            }
        }

        /// <summary>
        /// TODO: Write general description for this method
        /// </summary>
        [JsonConverter(typeof(IsoDateTimeConverter))]
        [JsonProperty("date_updated")]
        public DateTime? DateUpdated 
        { 
            get 
            {
                return this.dateUpdated; 
            } 
            set 
            {
                this.dateUpdated = value;
                onPropertyChanged("DateUpdated");
            }
        }

        /// <summary>
        /// TODO: Write general description for this method
        /// </summary>
        [JsonProperty("status")]
        public string Status 
        { 
            get 
            {
                return this.status; 
            } 
            set 
            {
                this.status = value;
                onPropertyChanged("Status");
            }
        }

        /// <summary>
        /// TODO: Write general description for this method
        /// </summary>
        [JsonProperty("status_reason")]
        public string StatusReason 
        { 
            get 
            {
                return this.statusReason; 
            } 
            set 
            {
                this.statusReason = value;
                onPropertyChanged("StatusReason");
            }
        }

        /// <summary>
        /// TODO: Write general description for this method
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

        /// <summary>
        /// TODO: Write general description for this method
        /// </summary>
        [JsonProperty("external_id")]
        public string ExternalId 
        { 
            get 
            {
                return this.externalId; 
            } 
            set 
            {
                this.externalId = value;
                onPropertyChanged("ExternalId");
            }
        }

        /// <summary>
        /// TODO: Write general description for this method
        /// </summary>
        [JsonProperty("mdr_configuration_id")]
        public string MdrConfigurationId 
        { 
            get 
            {
                return this.mdrConfigurationId; 
            } 
            set 
            {
                this.mdrConfigurationId = value;
                onPropertyChanged("MdrConfigurationId");
            }
        }

        /// <summary>
        /// TODO: Write general description for this method
        /// </summary>
        [JsonProperty("anticipation_fee")]
        public string AnticipationFee 
        { 
            get 
            {
                return this.anticipationFee; 
            } 
            set 
            {
                this.anticipationFee = value;
                onPropertyChanged("AnticipationFee");
            }
        }

        /// <summary>
        /// TODO: Write general description for this method
        /// </summary>
        [JsonProperty("api_key")]
        public string ApiKey 
        { 
            get 
            {
                return this.apiKey; 
            } 
            set 
            {
                this.apiKey = value;
                onPropertyChanged("ApiKey");
            }
        }

        /// <summary>
        /// TODO: Write general description for this method
        /// </summary>
        [JsonProperty("pix_recipient_as_source")]
        public bool PixRecipientAsSource 
        { 
            get 
            {
                return this.pixRecipientAsSource; 
            } 
            set 
            {
                this.pixRecipientAsSource = value;
                onPropertyChanged("PixRecipientAsSource");
            }
        }
    }
} 