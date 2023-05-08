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
    /// UpdateCoupon
    /// </summary>
    [DataContract]
    public partial class UpdateCoupon :  IEquatable<UpdateCoupon>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="UpdateCoupon" /> class.
        /// </summary>
        /// <param name="usageLimit">The number of times the coupon code can be redeemed. &#x60;0&#x60; means unlimited redemptions but any campaign usage limits will still apply. .</param>
        /// <param name="discountLimit">The total discount value that the code can give. Typically used to represent a gift card value. .</param>
        /// <param name="reservationLimit">The number of reservations that can be made with this coupon code. .</param>
        /// <param name="startDate">Timestamp at which point the coupon becomes valid..</param>
        /// <param name="expiryDate">Expiration date of the coupon. Coupon never expires if this is omitted, zero, or negative..</param>
        /// <param name="limits">Limits configuration for a coupon. These limits will override the limits set from the campaign.  **Note:** Only usable when creating a single coupon which is not tied to a specific recipient. Only per-profile limits are allowed to be configured. .</param>
        /// <param name="recipientIntegrationId">The integration ID for this coupon&#39;s beneficiary&#39;s profile..</param>
        /// <param name="attributes">Arbitrary properties associated with this item..</param>
        /// <param name="isReservationMandatory">Whether the reservation effect actually created a new reservation. (default to true).</param>
        public UpdateCoupon(int usageLimit = default(int), decimal discountLimit = default(decimal), int reservationLimit = default(int), DateTime startDate = default(DateTime), DateTime expiryDate = default(DateTime), List<LimitConfig> limits = default(List<LimitConfig>), string recipientIntegrationId = default(string), Object attributes = default(Object), bool isReservationMandatory = true)
        {
            this.UsageLimit = usageLimit;
            this.DiscountLimit = discountLimit;
            this.ReservationLimit = reservationLimit;
            this.StartDate = startDate;
            this.ExpiryDate = expiryDate;
            this.Limits = limits;
            this.RecipientIntegrationId = recipientIntegrationId;
            this.Attributes = attributes;
            this.IsReservationMandatory = isReservationMandatory;
        }
        
        /// <summary>
        /// The number of times the coupon code can be redeemed. &#x60;0&#x60; means unlimited redemptions but any campaign usage limits will still apply. 
        /// </summary>
        /// <value>The number of times the coupon code can be redeemed. &#x60;0&#x60; means unlimited redemptions but any campaign usage limits will still apply. </value>
        [DataMember(Name="usageLimit", EmitDefaultValue=false)]
        public int UsageLimit { get; set; }

        /// <summary>
        /// The total discount value that the code can give. Typically used to represent a gift card value. 
        /// </summary>
        /// <value>The total discount value that the code can give. Typically used to represent a gift card value. </value>
        [DataMember(Name="discountLimit", EmitDefaultValue=false)]
        public decimal DiscountLimit { get; set; }

        /// <summary>
        /// The number of reservations that can be made with this coupon code. 
        /// </summary>
        /// <value>The number of reservations that can be made with this coupon code. </value>
        [DataMember(Name="reservationLimit", EmitDefaultValue=false)]
        public int ReservationLimit { get; set; }

        /// <summary>
        /// Timestamp at which point the coupon becomes valid.
        /// </summary>
        /// <value>Timestamp at which point the coupon becomes valid.</value>
        [DataMember(Name="startDate", EmitDefaultValue=false)]
        public DateTime StartDate { get; set; }

        /// <summary>
        /// Expiration date of the coupon. Coupon never expires if this is omitted, zero, or negative.
        /// </summary>
        /// <value>Expiration date of the coupon. Coupon never expires if this is omitted, zero, or negative.</value>
        [DataMember(Name="expiryDate", EmitDefaultValue=false)]
        public DateTime ExpiryDate { get; set; }

        /// <summary>
        /// Limits configuration for a coupon. These limits will override the limits set from the campaign.  **Note:** Only usable when creating a single coupon which is not tied to a specific recipient. Only per-profile limits are allowed to be configured. 
        /// </summary>
        /// <value>Limits configuration for a coupon. These limits will override the limits set from the campaign.  **Note:** Only usable when creating a single coupon which is not tied to a specific recipient. Only per-profile limits are allowed to be configured. </value>
        [DataMember(Name="limits", EmitDefaultValue=false)]
        public List<LimitConfig> Limits { get; set; }

        /// <summary>
        /// The integration ID for this coupon&#39;s beneficiary&#39;s profile.
        /// </summary>
        /// <value>The integration ID for this coupon&#39;s beneficiary&#39;s profile.</value>
        [DataMember(Name="recipientIntegrationId", EmitDefaultValue=false)]
        public string RecipientIntegrationId { get; set; }

        /// <summary>
        /// Arbitrary properties associated with this item.
        /// </summary>
        /// <value>Arbitrary properties associated with this item.</value>
        [DataMember(Name="attributes", EmitDefaultValue=false)]
        public Object Attributes { get; set; }

        /// <summary>
        /// Whether the reservation effect actually created a new reservation.
        /// </summary>
        /// <value>Whether the reservation effect actually created a new reservation.</value>
        [DataMember(Name="isReservationMandatory", EmitDefaultValue=false)]
        public bool IsReservationMandatory { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class UpdateCoupon {\n");
            sb.Append("  UsageLimit: ").Append(UsageLimit).Append("\n");
            sb.Append("  DiscountLimit: ").Append(DiscountLimit).Append("\n");
            sb.Append("  ReservationLimit: ").Append(ReservationLimit).Append("\n");
            sb.Append("  StartDate: ").Append(StartDate).Append("\n");
            sb.Append("  ExpiryDate: ").Append(ExpiryDate).Append("\n");
            sb.Append("  Limits: ").Append(Limits).Append("\n");
            sb.Append("  RecipientIntegrationId: ").Append(RecipientIntegrationId).Append("\n");
            sb.Append("  Attributes: ").Append(Attributes).Append("\n");
            sb.Append("  IsReservationMandatory: ").Append(IsReservationMandatory).Append("\n");
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
            return this.Equals(input as UpdateCoupon);
        }

        /// <summary>
        /// Returns true if UpdateCoupon instances are equal
        /// </summary>
        /// <param name="input">Instance of UpdateCoupon to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(UpdateCoupon input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.UsageLimit == input.UsageLimit ||
                    this.UsageLimit.Equals(input.UsageLimit)
                ) && 
                (
                    this.DiscountLimit == input.DiscountLimit ||
                    this.DiscountLimit.Equals(input.DiscountLimit)
                ) && 
                (
                    this.ReservationLimit == input.ReservationLimit ||
                    this.ReservationLimit.Equals(input.ReservationLimit)
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
                    this.Limits == input.Limits ||
                    this.Limits != null &&
                    input.Limits != null &&
                    this.Limits.SequenceEqual(input.Limits)
                ) && 
                (
                    this.RecipientIntegrationId == input.RecipientIntegrationId ||
                    (this.RecipientIntegrationId != null &&
                    this.RecipientIntegrationId.Equals(input.RecipientIntegrationId))
                ) && 
                (
                    this.Attributes == input.Attributes ||
                    (this.Attributes != null &&
                    this.Attributes.Equals(input.Attributes))
                ) && 
                (
                    this.IsReservationMandatory == input.IsReservationMandatory ||
                    this.IsReservationMandatory.Equals(input.IsReservationMandatory)
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
                hashCode = hashCode * 59 + this.UsageLimit.GetHashCode();
                hashCode = hashCode * 59 + this.DiscountLimit.GetHashCode();
                hashCode = hashCode * 59 + this.ReservationLimit.GetHashCode();
                if (this.StartDate != null)
                    hashCode = hashCode * 59 + this.StartDate.GetHashCode();
                if (this.ExpiryDate != null)
                    hashCode = hashCode * 59 + this.ExpiryDate.GetHashCode();
                if (this.Limits != null)
                    hashCode = hashCode * 59 + this.Limits.GetHashCode();
                if (this.RecipientIntegrationId != null)
                    hashCode = hashCode * 59 + this.RecipientIntegrationId.GetHashCode();
                if (this.Attributes != null)
                    hashCode = hashCode * 59 + this.Attributes.GetHashCode();
                hashCode = hashCode * 59 + this.IsReservationMandatory.GetHashCode();
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

            // DiscountLimit (decimal) maximum
            if(this.DiscountLimit > (decimal)999999)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for DiscountLimit, must be a value less than or equal to 999999.", new [] { "DiscountLimit" });
            }

            // DiscountLimit (decimal) minimum
            if(this.DiscountLimit < (decimal)0)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for DiscountLimit, must be a value greater than or equal to 0.", new [] { "DiscountLimit" });
            }

            // ReservationLimit (int) maximum
            if(this.ReservationLimit > (int)999999)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for ReservationLimit, must be a value less than or equal to 999999.", new [] { "ReservationLimit" });
            }

            // ReservationLimit (int) minimum
            if(this.ReservationLimit < (int)0)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for ReservationLimit, must be a value greater than or equal to 0.", new [] { "ReservationLimit" });
            }

            // RecipientIntegrationId (string) maxLength
            if(this.RecipientIntegrationId != null && this.RecipientIntegrationId.Length > 1000)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for RecipientIntegrationId, length must be less than 1000.", new [] { "RecipientIntegrationId" });
            }

            yield break;
        }
    }

}
