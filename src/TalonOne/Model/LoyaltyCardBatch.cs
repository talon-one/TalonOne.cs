/* 
 * Talon.One API
 *
 * Use the Talon.One API to integrate with your application and to manage applications and campaigns:  - Use the operations in the [Integration API section](#integration-api) are used to integrate with our platform - Use the operation in the [Management API section](#management-api) to manage applications and campaigns.  ## Determining the base URL of the endpoints  The API is available at the same hostname as your Campaign Manager deployment. For example, if you access the Campaign Manager at `https://yourbaseurl.talon.one/`, the URL for the [updateCustomerSessionV2](https://docs.talon.one/integration-api#operation/updateCustomerSessionV2) endpoint is `https://yourbaseurl.talon.one/v2/customer_sessions/{Id}` 
 *
 * 
 * Contact: devs@talon.one
 * Generated by: https://github.com/openapitools/openapi-generator.git
 */


using System;
using System.Linq;
using System.IO;
using System.Text;
using System.Text.RegularExpressions;
using System.Collections;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Runtime.Serialization;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using System.ComponentModel.DataAnnotations;
using OpenAPIDateConverter = TalonOne.Client.OpenAPIDateConverter;

namespace TalonOne.Model
{
    /// <summary>
    /// LoyaltyCardBatch
    /// </summary>
    [DataContract]
    public partial class LoyaltyCardBatch :  IEquatable<LoyaltyCardBatch>, IValidatableObject
    {
        /// <summary>
        /// Status of the loyalty cards in the batch.
        /// </summary>
        /// <value>Status of the loyalty cards in the batch.</value>
        [JsonConverter(typeof(StringEnumConverter))]
        public enum StatusEnum
        {
            /// <summary>
            /// Enum Active for value: active
            /// </summary>
            [EnumMember(Value = "active")]
            Active = 1,

            /// <summary>
            /// Enum Inactive for value: inactive
            /// </summary>
            [EnumMember(Value = "inactive")]
            Inactive = 2

        }

        /// <summary>
        /// Status of the loyalty cards in the batch.
        /// </summary>
        /// <value>Status of the loyalty cards in the batch.</value>
        [DataMember(Name="status", EmitDefaultValue=false)]
        public StatusEnum? Status { get; set; }
        /// <summary>
        /// Initializes a new instance of the <see cref="LoyaltyCardBatch" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected LoyaltyCardBatch() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="LoyaltyCardBatch" /> class.
        /// </summary>
        /// <param name="numberOfCards">Number of loyalty cards in the batch. (required).</param>
        /// <param name="batchId">ID of the loyalty card batch..</param>
        /// <param name="status">Status of the loyalty cards in the batch. (default to StatusEnum.Active).</param>
        public LoyaltyCardBatch(int numberOfCards = default(int), string batchId = default(string), StatusEnum? status = StatusEnum.Active)
        {
            this.NumberOfCards = numberOfCards;
            this.BatchId = batchId;
            this.Status = status;
        }
        
        /// <summary>
        /// Number of loyalty cards in the batch.
        /// </summary>
        /// <value>Number of loyalty cards in the batch.</value>
        [DataMember(Name="numberOfCards", EmitDefaultValue=false)]
        public int NumberOfCards { get; set; }

        /// <summary>
        /// ID of the loyalty card batch.
        /// </summary>
        /// <value>ID of the loyalty card batch.</value>
        [DataMember(Name="batchId", EmitDefaultValue=false)]
        public string BatchId { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class LoyaltyCardBatch {\n");
            sb.Append("  NumberOfCards: ").Append(NumberOfCards).Append("\n");
            sb.Append("  BatchId: ").Append(BatchId).Append("\n");
            sb.Append("  Status: ").Append(Status).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }
  
        /// <summary>
        /// Returns the JSON string presentation of the object
        /// </summary>
        /// <returns>JSON string presentation of the object</returns>
        public virtual string ToJson()
        {
            return JsonConvert.SerializeObject(this, Formatting.Indented);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        /// <param name="input">Object to be compared</param>
        /// <returns>Boolean</returns>
        public override bool Equals(object input)
        {
            return this.Equals(input as LoyaltyCardBatch);
        }

        /// <summary>
        /// Returns true if LoyaltyCardBatch instances are equal
        /// </summary>
        /// <param name="input">Instance of LoyaltyCardBatch to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(LoyaltyCardBatch input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.NumberOfCards == input.NumberOfCards ||
                    this.NumberOfCards.Equals(input.NumberOfCards)
                ) && 
                (
                    this.BatchId == input.BatchId ||
                    (this.BatchId != null &&
                    this.BatchId.Equals(input.BatchId))
                ) && 
                (
                    this.Status == input.Status ||
                    this.Status.Equals(input.Status)
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
                hashCode = hashCode * 59 + this.NumberOfCards.GetHashCode();
                if (this.BatchId != null)
                    hashCode = hashCode * 59 + this.BatchId.GetHashCode();
                hashCode = hashCode * 59 + this.Status.GetHashCode();
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
            // BatchId (string) maxLength
            if(this.BatchId != null && this.BatchId.Length > 20)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for BatchId, length must be less than 20.", new [] { "BatchId" });
            }

            // BatchId (string) minLength
            if(this.BatchId != null && this.BatchId.Length < 4)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for BatchId, length must be greater than 4.", new [] { "BatchId" });
            }

            // BatchId (string) pattern
            Regex regexBatchId = new Regex(@"^[A-Za-z0-9_-]*$", RegexOptions.CultureInvariant);
            if (false == regexBatchId.Match(this.BatchId).Success)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for BatchId, must match a pattern of " + regexBatchId, new [] { "BatchId" });
            }

            yield break;
        }
    }

}
