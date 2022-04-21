/*
 * Web3.Storage API
 *
 * This documentation describes the HTTP API for [**Web3.Storage**](https://web3.storage), which allows you to quickly and easily build applications using decentralized data storage persisted by [Filecoin](https://filecoin.io) and available over [IPFS](https://ipfs.io).  You can also interact with this API using client libraries. See [**docs.web3.storage**](https://docs.web3.storage) for more information on using a client library, as well as a variety of other guides and how-tos for Web3.Storage as a whole.  ## API endpoint URL  The main public API endpoint URL for Web3.Storage is `https://api.web3.storage`. All endpoints described in this document should be made relative to this root URL. For example, to post to the `/car` endpoint, send your request to `https://api.web3.storage/car`.  ### Rate limits  This API imposes rate limits to ensure quality of service. You may receive a 429 \"Too many requests\" error if you make more than 30 requests with the same API token within a ten second window. Upon receiving a response with a 429 status, clients should retry the failed request after a small delay. To avoid 429 responses, you may wish to implement client-side request throttling to stay within the limits. 
 *
 * The version of the OpenAPI document: 1.0
 * Generated by: https://github.com/openapitools/openapi-generator.git
 */


using System;
using System.Collections;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.IO;
using System.Runtime.Serialization;
using System.Text;
using System.Text.RegularExpressions;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using Newtonsoft.Json.Linq;
using System.ComponentModel.DataAnnotations;
using OpenAPIDateConverter = Web3.Storage.Client.OpenAPIDateConverter;

namespace Web3.Storage.Model
{
    /// <summary>
    /// Deal
    /// </summary>
    [DataContract(Name = "Deal")]
    public partial class Deal : IEquatable<Deal>, IValidatableObject
    {
        /// <summary>
        /// Current deal status.
        /// </summary>
        /// <value>Current deal status.</value>
        [JsonConverter(typeof(StringEnumConverter))]
        public enum StatusEnum
        {
            /// <summary>
            /// Enum Queued for value: Queued
            /// </summary>
            [EnumMember(Value = "Queued")]
            Queued = 1,

            /// <summary>
            /// Enum Published for value: Published
            /// </summary>
            [EnumMember(Value = "Published")]
            Published = 2,

            /// <summary>
            /// Enum Active for value: Active
            /// </summary>
            [EnumMember(Value = "Active")]
            Active = 3

        }


        /// <summary>
        /// Current deal status.
        /// </summary>
        /// <value>Current deal status.</value>
        [DataMember(Name = "status", IsRequired = true, EmitDefaultValue = false)]
        public StatusEnum Status { get; set; }
        /// <summary>
        /// Initializes a new instance of the <see cref="Deal" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected Deal() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="Deal" /> class.
        /// </summary>
        /// <param name="dealId">On-chain ID of the deal..</param>
        /// <param name="storageProvider">Address of the provider storing this data..</param>
        /// <param name="status">Current deal status. (required).</param>
        /// <param name="pieceCid">Filecoin [Piece CID](https://spec.filecoin.io/systems/filecoin_files/piece/) of the data in the deal..</param>
        /// <param name="dataCid">CID of the data aggregated in this deal..</param>
        /// <param name="dataModelSelector">Selector for extracting stored data from the aggregated data root..</param>
        /// <param name="activation">Date when the deal will become active in [ISO 8601](https://en.wikipedia.org/wiki/ISO_8601) format..</param>
        /// <param name="created">Creation date in [ISO 8601](https://en.wikipedia.org/wiki/ISO_8601) format. (required).</param>
        /// <param name="updated">Updated date in [ISO 8601](https://en.wikipedia.org/wiki/ISO_8601) format. (required).</param>
        public Deal(decimal dealId = default(decimal), string storageProvider = default(string), StatusEnum status = default(StatusEnum), string pieceCid = default(string), string dataCid = default(string), string dataModelSelector = default(string), string activation = default(string), string created = default(string), string updated = default(string))
        {
            this.Status = status;
            // to ensure "created" is required (not null)
            this.Created = created ?? throw new ArgumentNullException("created is a required property for Deal and cannot be null");
            // to ensure "updated" is required (not null)
            this.Updated = updated ?? throw new ArgumentNullException("updated is a required property for Deal and cannot be null");
            this.DealId = dealId;
            this.StorageProvider = storageProvider;
            this.PieceCid = pieceCid;
            this.DataCid = dataCid;
            this.DataModelSelector = dataModelSelector;
            this.Activation = activation;
        }

        /// <summary>
        /// On-chain ID of the deal.
        /// </summary>
        /// <value>On-chain ID of the deal.</value>
        [DataMember(Name = "dealId", EmitDefaultValue = false)]
        public decimal DealId { get; set; }

        /// <summary>
        /// Address of the provider storing this data.
        /// </summary>
        /// <value>Address of the provider storing this data.</value>
        [DataMember(Name = "storageProvider", EmitDefaultValue = false)]
        public string StorageProvider { get; set; }

        /// <summary>
        /// Filecoin [Piece CID](https://spec.filecoin.io/systems/filecoin_files/piece/) of the data in the deal.
        /// </summary>
        /// <value>Filecoin [Piece CID](https://spec.filecoin.io/systems/filecoin_files/piece/) of the data in the deal.</value>
        [DataMember(Name = "pieceCid", EmitDefaultValue = false)]
        public string PieceCid { get; set; }

        /// <summary>
        /// CID of the data aggregated in this deal.
        /// </summary>
        /// <value>CID of the data aggregated in this deal.</value>
        [DataMember(Name = "dataCid", EmitDefaultValue = false)]
        public string DataCid { get; set; }

        /// <summary>
        /// Selector for extracting stored data from the aggregated data root.
        /// </summary>
        /// <value>Selector for extracting stored data from the aggregated data root.</value>
        [DataMember(Name = "dataModelSelector", EmitDefaultValue = false)]
        public string DataModelSelector { get; set; }

        /// <summary>
        /// Date when the deal will become active in [ISO 8601](https://en.wikipedia.org/wiki/ISO_8601) format.
        /// </summary>
        /// <value>Date when the deal will become active in [ISO 8601](https://en.wikipedia.org/wiki/ISO_8601) format.</value>
        [DataMember(Name = "activation", EmitDefaultValue = false)]
        public string Activation { get; set; }

        /// <summary>
        /// Creation date in [ISO 8601](https://en.wikipedia.org/wiki/ISO_8601) format.
        /// </summary>
        /// <value>Creation date in [ISO 8601](https://en.wikipedia.org/wiki/ISO_8601) format.</value>
        [DataMember(Name = "created", IsRequired = true, EmitDefaultValue = false)]
        public string Created { get; set; }

        /// <summary>
        /// Updated date in [ISO 8601](https://en.wikipedia.org/wiki/ISO_8601) format.
        /// </summary>
        /// <value>Updated date in [ISO 8601](https://en.wikipedia.org/wiki/ISO_8601) format.</value>
        [DataMember(Name = "updated", IsRequired = true, EmitDefaultValue = false)]
        public string Updated { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class Deal {\n");
            sb.Append("  DealId: ").Append(DealId).Append("\n");
            sb.Append("  StorageProvider: ").Append(StorageProvider).Append("\n");
            sb.Append("  Status: ").Append(Status).Append("\n");
            sb.Append("  PieceCid: ").Append(PieceCid).Append("\n");
            sb.Append("  DataCid: ").Append(DataCid).Append("\n");
            sb.Append("  DataModelSelector: ").Append(DataModelSelector).Append("\n");
            sb.Append("  Activation: ").Append(Activation).Append("\n");
            sb.Append("  Created: ").Append(Created).Append("\n");
            sb.Append("  Updated: ").Append(Updated).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns the JSON string presentation of the object
        /// </summary>
        /// <returns>JSON string presentation of the object</returns>
        public virtual string ToJson()
        {
            return Newtonsoft.Json.JsonConvert.SerializeObject(this, Newtonsoft.Json.Formatting.Indented);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        /// <param name="input">Object to be compared</param>
        /// <returns>Boolean</returns>
        public override bool Equals(object input)
        {
            return this.Equals(input as Deal);
        }

        /// <summary>
        /// Returns true if Deal instances are equal
        /// </summary>
        /// <param name="input">Instance of Deal to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(Deal input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.DealId == input.DealId ||
                    this.DealId.Equals(input.DealId)
                ) && 
                (
                    this.StorageProvider == input.StorageProvider ||
                    (this.StorageProvider != null &&
                    this.StorageProvider.Equals(input.StorageProvider))
                ) && 
                (
                    this.Status == input.Status ||
                    this.Status.Equals(input.Status)
                ) && 
                (
                    this.PieceCid == input.PieceCid ||
                    (this.PieceCid != null &&
                    this.PieceCid.Equals(input.PieceCid))
                ) && 
                (
                    this.DataCid == input.DataCid ||
                    (this.DataCid != null &&
                    this.DataCid.Equals(input.DataCid))
                ) && 
                (
                    this.DataModelSelector == input.DataModelSelector ||
                    (this.DataModelSelector != null &&
                    this.DataModelSelector.Equals(input.DataModelSelector))
                ) && 
                (
                    this.Activation == input.Activation ||
                    (this.Activation != null &&
                    this.Activation.Equals(input.Activation))
                ) && 
                (
                    this.Created == input.Created ||
                    (this.Created != null &&
                    this.Created.Equals(input.Created))
                ) && 
                (
                    this.Updated == input.Updated ||
                    (this.Updated != null &&
                    this.Updated.Equals(input.Updated))
                );
        }

        /// <summary>
        /// Gets the hash code
        /// </summary>
        /// <returns>Hash code</returns>
        public override int GetHashCode()
        {
            unchecked // Overflow is fine, just wrap
            {
                int hashCode = 41;
                hashCode = hashCode * 59 + this.DealId.GetHashCode();
                if (this.StorageProvider != null)
                    hashCode = hashCode * 59 + this.StorageProvider.GetHashCode();
                hashCode = hashCode * 59 + this.Status.GetHashCode();
                if (this.PieceCid != null)
                    hashCode = hashCode * 59 + this.PieceCid.GetHashCode();
                if (this.DataCid != null)
                    hashCode = hashCode * 59 + this.DataCid.GetHashCode();
                if (this.DataModelSelector != null)
                    hashCode = hashCode * 59 + this.DataModelSelector.GetHashCode();
                if (this.Activation != null)
                    hashCode = hashCode * 59 + this.Activation.GetHashCode();
                if (this.Created != null)
                    hashCode = hashCode * 59 + this.Created.GetHashCode();
                if (this.Updated != null)
                    hashCode = hashCode * 59 + this.Updated.GetHashCode();
                return hashCode;
            }
        }

        /// <summary>
        /// To validate all properties of the instance
        /// </summary>
        /// <param name="validationContext">Validation context</param>
        /// <returns>Validation Result</returns>
        IEnumerable<System.ComponentModel.DataAnnotations.ValidationResult> IValidatableObject.Validate(ValidationContext validationContext)
        {
            yield break;
        }
    }

}