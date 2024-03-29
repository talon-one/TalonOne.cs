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
    /// The properties specific to the \&quot;reserveCoupon\&quot; effect. This gets triggered whenever a validated rule contained a \&quot;reserve coupon\&quot; effect. This reserves the coupon currently on scope to the profile on scope.
    /// </summary>
    [DataContract]
    public partial class ReserveCouponEffectProps :  IEquatable<ReserveCouponEffectProps>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ReserveCouponEffectProps" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected ReserveCouponEffectProps() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="ReserveCouponEffectProps" /> class.
        /// </summary>
        /// <param name="couponValue">The value of the coupon currently on scope. (required).</param>
        /// <param name="profileIntegrationId">The ID of this customer profile in the third-party integration. (required).</param>
        /// <param name="isNewReservation">Indicates whether this is a new coupon reservation or not. (required).</param>
        public ReserveCouponEffectProps(string couponValue = default(string), string profileIntegrationId = default(string), bool isNewReservation = default(bool))
        {
            // to ensure "couponValue" is required (not null)
            this.CouponValue = couponValue ?? throw new ArgumentNullException("couponValue is a required property for ReserveCouponEffectProps and cannot be null");
            // to ensure "profileIntegrationId" is required (not null)
            this.ProfileIntegrationId = profileIntegrationId ?? throw new ArgumentNullException("profileIntegrationId is a required property for ReserveCouponEffectProps and cannot be null");
            this.IsNewReservation = isNewReservation;
        }
        
        /// <summary>
        /// The value of the coupon currently on scope.
        /// </summary>
        /// <value>The value of the coupon currently on scope.</value>
        [DataMember(Name="couponValue", EmitDefaultValue=false)]
        public string CouponValue { get; set; }

        /// <summary>
        /// The ID of this customer profile in the third-party integration.
        /// </summary>
        /// <value>The ID of this customer profile in the third-party integration.</value>
        [DataMember(Name="profileIntegrationId", EmitDefaultValue=false)]
        public string ProfileIntegrationId { get; set; }

        /// <summary>
        /// Indicates whether this is a new coupon reservation or not.
        /// </summary>
        /// <value>Indicates whether this is a new coupon reservation or not.</value>
        [DataMember(Name="isNewReservation", EmitDefaultValue=false)]
        public bool IsNewReservation { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ReserveCouponEffectProps {\n");
            sb.Append("  CouponValue: ").Append(CouponValue).Append("\n");
            sb.Append("  ProfileIntegrationId: ").Append(ProfileIntegrationId).Append("\n");
            sb.Append("  IsNewReservation: ").Append(IsNewReservation).Append("\n");
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
            return this.Equals(input as ReserveCouponEffectProps);
        }

        /// <summary>
        /// Returns true if ReserveCouponEffectProps instances are equal
        /// </summary>
        /// <param name="input">Instance of ReserveCouponEffectProps to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(ReserveCouponEffectProps input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.CouponValue == input.CouponValue ||
                    (this.CouponValue != null &&
                    this.CouponValue.Equals(input.CouponValue))
                ) && 
                (
                    this.ProfileIntegrationId == input.ProfileIntegrationId ||
                    (this.ProfileIntegrationId != null &&
                    this.ProfileIntegrationId.Equals(input.ProfileIntegrationId))
                ) && 
                (
                    this.IsNewReservation == input.IsNewReservation ||
                    this.IsNewReservation.Equals(input.IsNewReservation)
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
                if (this.CouponValue != null)
                    hashCode = hashCode * 59 + this.CouponValue.GetHashCode();
                if (this.ProfileIntegrationId != null)
                    hashCode = hashCode * 59 + this.ProfileIntegrationId.GetHashCode();
                hashCode = hashCode * 59 + this.IsNewReservation.GetHashCode();
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
