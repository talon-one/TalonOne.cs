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
    /// UpdateReferralBatch
    /// </summary>
    [DataContract]
    public partial class UpdateReferralBatch :  IEquatable<UpdateReferralBatch>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="UpdateReferralBatch" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected UpdateReferralBatch() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="UpdateReferralBatch" /> class.
        /// </summary>
        /// <param name="attributes">Arbitrary properties associated with this item..</param>
        /// <param name="batchID">The id of the batch the referral belongs to. (required).</param>
        /// <param name="startDate">Timestamp at which point the referral code becomes valid..</param>
        /// <param name="expiryDate">Expiration date of the referral code. Referral never expires if this is omitted..</param>
        /// <param name="usageLimit">The number of times a referral code can be used. This can be set to 0 for no limit, but any campaign usage limits will still apply. .</param>
        public UpdateReferralBatch(Object attributes = default(Object), string batchID = default(string), DateTime startDate = default(DateTime), DateTime expiryDate = default(DateTime), int usageLimit = default(int))
        {
            // to ensure "batchID" is required (not null)
            this.BatchID = batchID ?? throw new ArgumentNullException("batchID is a required property for UpdateReferralBatch and cannot be null");
            this.Attributes = attributes;
            this.StartDate = startDate;
            this.ExpiryDate = expiryDate;
            this.UsageLimit = usageLimit;
        }
        
        /// <summary>
        /// Arbitrary properties associated with this item.
        /// </summary>
        /// <value>Arbitrary properties associated with this item.</value>
        [DataMember(Name="attributes", EmitDefaultValue=false)]
        public Object Attributes { get; set; }

        /// <summary>
        /// The id of the batch the referral belongs to.
        /// </summary>
        /// <value>The id of the batch the referral belongs to.</value>
        [DataMember(Name="batchID", EmitDefaultValue=false)]
        public string BatchID { get; set; }

        /// <summary>
        /// Timestamp at which point the referral code becomes valid.
        /// </summary>
        /// <value>Timestamp at which point the referral code becomes valid.</value>
        [DataMember(Name="startDate", EmitDefaultValue=false)]
        public DateTime StartDate { get; set; }

        /// <summary>
        /// Expiration date of the referral code. Referral never expires if this is omitted.
        /// </summary>
        /// <value>Expiration date of the referral code. Referral never expires if this is omitted.</value>
        [DataMember(Name="expiryDate", EmitDefaultValue=false)]
        public DateTime ExpiryDate { get; set; }

        /// <summary>
        /// The number of times a referral code can be used. This can be set to 0 for no limit, but any campaign usage limits will still apply. 
        /// </summary>
        /// <value>The number of times a referral code can be used. This can be set to 0 for no limit, but any campaign usage limits will still apply. </value>
        [DataMember(Name="usageLimit", EmitDefaultValue=false)]
        public int UsageLimit { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class UpdateReferralBatch {\n");
            sb.Append("  Attributes: ").Append(Attributes).Append("\n");
            sb.Append("  BatchID: ").Append(BatchID).Append("\n");
            sb.Append("  StartDate: ").Append(StartDate).Append("\n");
            sb.Append("  ExpiryDate: ").Append(ExpiryDate).Append("\n");
            sb.Append("  UsageLimit: ").Append(UsageLimit).Append("\n");
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
            return this.Equals(input as UpdateReferralBatch);
        }

        /// <summary>
        /// Returns true if UpdateReferralBatch instances are equal
        /// </summary>
        /// <param name="input">Instance of UpdateReferralBatch to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(UpdateReferralBatch input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.Attributes == input.Attributes ||
                    (this.Attributes != null &&
                    this.Attributes.Equals(input.Attributes))
                ) && 
                (
                    this.BatchID == input.BatchID ||
                    (this.BatchID != null &&
                    this.BatchID.Equals(input.BatchID))
                ) && 
                (
                    this.StartDate == input.StartDate ||
                    (this.StartDate != null &&
                    this.StartDate.Equals(input.StartDate))
                ) && 
                (
                    this.ExpiryDate == input.ExpiryDate ||
                    (this.ExpiryDate != null &&
                    this.ExpiryDate.Equals(input.ExpiryDate))
                ) && 
                (
                    this.UsageLimit == input.UsageLimit ||
                    this.UsageLimit.Equals(input.UsageLimit)
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
                if (this.Attributes != null)
                    hashCode = hashCode * 59 + this.Attributes.GetHashCode();
                if (this.BatchID != null)
                    hashCode = hashCode * 59 + this.BatchID.GetHashCode();
                if (this.StartDate != null)
                    hashCode = hashCode * 59 + this.StartDate.GetHashCode();
                if (this.ExpiryDate != null)
                    hashCode = hashCode * 59 + this.ExpiryDate.GetHashCode();
                hashCode = hashCode * 59 + this.UsageLimit.GetHashCode();
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
            // UsageLimit (int) maximum
            if(this.UsageLimit > (int)999999)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for UsageLimit, must be a value less than or equal to 999999.", new [] { "UsageLimit" });
            }

            // UsageLimit (int) minimum
            if(this.UsageLimit < (int)0)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for UsageLimit, must be a value greater than or equal to 0.", new [] { "UsageLimit" });
            }

            yield break;
        }
    }

}
