/* 
 * Talon.One API
 *
 * Use the Talon.One API to integrate with your application and to manage applications and campaigns:  - Use the operations in the [Integration API section](#integration-api) are used to integrate with our platform - Use the operation in the [Management API section](#management-api) to manage applications and campaigns.  ## Determining the base URL of the endpoints  The API is available at the same hostname as your Campaign Manager deployment. For example, if you are reading this page at `https://mycompany.talon.one/docs/api/`, the URL for the [updateCustomerSession](https://docs.talon.one/integration-api/#operation/updateCustomerSessionV2) endpoint is `https://mycompany.talon.one/v2/customer_sessions/{Id}` 
 *
 * The version of the OpenAPI document: 1.0.0
 * 
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
    /// The properties specific to the \&quot;rejectCoupon\&quot; effect. This gets triggered whenever the coupon was rejected. See rejectionReason for more info on why.
    /// </summary>
    [DataContract]
    public partial class RejectCouponEffectProps :  IEquatable<RejectCouponEffectProps>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="RejectCouponEffectProps" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected RejectCouponEffectProps() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="RejectCouponEffectProps" /> class.
        /// </summary>
        /// <param name="value">The coupon code that was rejected (required).</param>
        /// <param name="rejectionReason">The reason why this coupon was rejected (required).</param>
        /// <param name="conditionIndex">The index of the condition that caused the rejection of the coupon.</param>
        /// <param name="effectIndex">The index of the effect that caused the rejection of the coupon.</param>
        /// <param name="details">More details about the failure.</param>
        public RejectCouponEffectProps(string value = default(string), string rejectionReason = default(string), int conditionIndex = default(int), int effectIndex = default(int), string details = default(string))
        {
            // to ensure "value" is required (not null)
            this.Value = value ?? throw new ArgumentNullException("value is a required property for RejectCouponEffectProps and cannot be null");
            // to ensure "rejectionReason" is required (not null)
            this.RejectionReason = rejectionReason ?? throw new ArgumentNullException("rejectionReason is a required property for RejectCouponEffectProps and cannot be null");
            this.ConditionIndex = conditionIndex;
            this.EffectIndex = effectIndex;
            this.Details = details;
        }
        
        /// <summary>
        /// The coupon code that was rejected
        /// </summary>
        /// <value>The coupon code that was rejected</value>
        [DataMember(Name="value", EmitDefaultValue=false)]
        public string Value { get; set; }

        /// <summary>
        /// The reason why this coupon was rejected
        /// </summary>
        /// <value>The reason why this coupon was rejected</value>
        [DataMember(Name="rejectionReason", EmitDefaultValue=false)]
        public string RejectionReason { get; set; }

        /// <summary>
        /// The index of the condition that caused the rejection of the coupon
        /// </summary>
        /// <value>The index of the condition that caused the rejection of the coupon</value>
        [DataMember(Name="conditionIndex", EmitDefaultValue=false)]
        public int ConditionIndex { get; set; }

        /// <summary>
        /// The index of the effect that caused the rejection of the coupon
        /// </summary>
        /// <value>The index of the effect that caused the rejection of the coupon</value>
        [DataMember(Name="effectIndex", EmitDefaultValue=false)]
        public int EffectIndex { get; set; }

        /// <summary>
        /// More details about the failure
        /// </summary>
        /// <value>More details about the failure</value>
        [DataMember(Name="details", EmitDefaultValue=false)]
        public string Details { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class RejectCouponEffectProps {\n");
            sb.Append("  Value: ").Append(Value).Append("\n");
            sb.Append("  RejectionReason: ").Append(RejectionReason).Append("\n");
            sb.Append("  ConditionIndex: ").Append(ConditionIndex).Append("\n");
            sb.Append("  EffectIndex: ").Append(EffectIndex).Append("\n");
            sb.Append("  Details: ").Append(Details).Append("\n");
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
            return this.Equals(input as RejectCouponEffectProps);
        }

        /// <summary>
        /// Returns true if RejectCouponEffectProps instances are equal
        /// </summary>
        /// <param name="input">Instance of RejectCouponEffectProps to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(RejectCouponEffectProps input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.Value == input.Value ||
                    (this.Value != null &&
                    this.Value.Equals(input.Value))
                ) && 
                (
                    this.RejectionReason == input.RejectionReason ||
                    (this.RejectionReason != null &&
                    this.RejectionReason.Equals(input.RejectionReason))
                ) && 
                (
                    this.ConditionIndex == input.ConditionIndex ||
                    this.ConditionIndex.Equals(input.ConditionIndex)
                ) && 
                (
                    this.EffectIndex == input.EffectIndex ||
                    this.EffectIndex.Equals(input.EffectIndex)
                ) && 
                (
                    this.Details == input.Details ||
                    (this.Details != null &&
                    this.Details.Equals(input.Details))
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
                if (this.Value != null)
                    hashCode = hashCode * 59 + this.Value.GetHashCode();
                if (this.RejectionReason != null)
                    hashCode = hashCode * 59 + this.RejectionReason.GetHashCode();
                hashCode = hashCode * 59 + this.ConditionIndex.GetHashCode();
                hashCode = hashCode * 59 + this.EffectIndex.GetHashCode();
                if (this.Details != null)
                    hashCode = hashCode * 59 + this.Details.GetHashCode();
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
