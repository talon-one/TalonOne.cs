/* 
 * Talon.One API
 *
 * The Talon.One API is used to manage applications and campaigns, as well as to integrate with your application. The operations in the _Integration API_ section are used to integrate with our platform, while the other operations are used to manage applications and campaigns.  ### Where is the API?  The API is available at the same hostname as these docs. For example, if you are reading this page at `https://mycompany.talon.one/docs/api/`, the URL for the [updateCustomerProfile][] operation is `https://mycompany.talon.one/v1/customer_profiles/id`  [updateCustomerProfile]: #operation- -v1-customer_profiles- -integrationId- -put 
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
    /// Holds a reference to the campaign, the coupon and the reason for which that coupon was rejected. Should only be present when there is a &#39;rejectCoupon&#39; effect.
    /// </summary>
    [DataContract]
    public partial class CouponRejectionReason :  IEquatable<CouponRejectionReason>, IValidatableObject
    {
        /// <summary>
        /// Defines Reason
        /// </summary>
        [JsonConverter(typeof(StringEnumConverter))]
        public enum ReasonEnum
        {
            /// <summary>
            /// Enum CouponNotFound for value: CouponNotFound
            /// </summary>
            [EnumMember(Value = "CouponNotFound")]
            CouponNotFound = 1,

            /// <summary>
            /// Enum CouponPartOfNotRunningCampaign for value: CouponPartOfNotRunningCampaign
            /// </summary>
            [EnumMember(Value = "CouponPartOfNotRunningCampaign")]
            CouponPartOfNotRunningCampaign = 2,

            /// <summary>
            /// Enum CouponLimitReached for value: CouponLimitReached
            /// </summary>
            [EnumMember(Value = "CouponLimitReached")]
            CouponLimitReached = 3,

            /// <summary>
            /// Enum CampaignLimitReached for value: CampaignLimitReached
            /// </summary>
            [EnumMember(Value = "CampaignLimitReached")]
            CampaignLimitReached = 4,

            /// <summary>
            /// Enum ProfileLimitReached for value: ProfileLimitReached
            /// </summary>
            [EnumMember(Value = "ProfileLimitReached")]
            ProfileLimitReached = 5,

            /// <summary>
            /// Enum CouponRecipientDoesNotMatch for value: CouponRecipientDoesNotMatch
            /// </summary>
            [EnumMember(Value = "CouponRecipientDoesNotMatch")]
            CouponRecipientDoesNotMatch = 6,

            /// <summary>
            /// Enum CouponExpired for value: CouponExpired
            /// </summary>
            [EnumMember(Value = "CouponExpired")]
            CouponExpired = 7,

            /// <summary>
            /// Enum CouponStartDateInFuture for value: CouponStartDateInFuture
            /// </summary>
            [EnumMember(Value = "CouponStartDateInFuture")]
            CouponStartDateInFuture = 8,

            /// <summary>
            /// Enum CouponRejectedByCondition for value: CouponRejectedByCondition
            /// </summary>
            [EnumMember(Value = "CouponRejectedByCondition")]
            CouponRejectedByCondition = 9,

            /// <summary>
            /// Enum EffectCouldNotBeApplied for value: EffectCouldNotBeApplied
            /// </summary>
            [EnumMember(Value = "EffectCouldNotBeApplied")]
            EffectCouldNotBeApplied = 10

        }

        /// <summary>
        /// Gets or Sets Reason
        /// </summary>
        [DataMember(Name="reason", EmitDefaultValue=false)]
        public ReasonEnum Reason { get; set; }
        /// <summary>
        /// Initializes a new instance of the <see cref="CouponRejectionReason" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected CouponRejectionReason() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="CouponRejectionReason" /> class.
        /// </summary>
        /// <param name="campaignId">campaignId (required).</param>
        /// <param name="couponId">couponId (required).</param>
        /// <param name="reason">reason (required).</param>
        public CouponRejectionReason(int campaignId = default(int), int couponId = default(int), ReasonEnum reason = default(ReasonEnum))
        {
            this.CampaignId = campaignId;
            this.CouponId = couponId;
            this.Reason = reason;
        }
        
        /// <summary>
        /// Gets or Sets CampaignId
        /// </summary>
        [DataMember(Name="campaignId", EmitDefaultValue=false)]
        public int CampaignId { get; set; }

        /// <summary>
        /// Gets or Sets CouponId
        /// </summary>
        [DataMember(Name="couponId", EmitDefaultValue=false)]
        public int CouponId { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class CouponRejectionReason {\n");
            sb.Append("  CampaignId: ").Append(CampaignId).Append("\n");
            sb.Append("  CouponId: ").Append(CouponId).Append("\n");
            sb.Append("  Reason: ").Append(Reason).Append("\n");
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
            return this.Equals(input as CouponRejectionReason);
        }

        /// <summary>
        /// Returns true if CouponRejectionReason instances are equal
        /// </summary>
        /// <param name="input">Instance of CouponRejectionReason to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(CouponRejectionReason input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.CampaignId == input.CampaignId ||
                    this.CampaignId.Equals(input.CampaignId)
                ) && 
                (
                    this.CouponId == input.CouponId ||
                    this.CouponId.Equals(input.CouponId)
                ) && 
                (
                    this.Reason == input.Reason ||
                    this.Reason.Equals(input.Reason)
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
                hashCode = hashCode * 59 + this.CampaignId.GetHashCode();
                hashCode = hashCode * 59 + this.CouponId.GetHashCode();
                hashCode = hashCode * 59 + this.Reason.GetHashCode();
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
