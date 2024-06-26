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
    /// This is the response type returned by the trackEventV2 endpoint. 
    /// </summary>
    [DataContract]
    public partial class TrackEventV2Response :  IEquatable<TrackEventV2Response>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="TrackEventV2Response" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected TrackEventV2Response() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="TrackEventV2Response" /> class.
        /// </summary>
        /// <param name="customerProfile">customerProfile.</param>
        /// <param name="_event">_event.</param>
        /// <param name="loyalty">loyalty.</param>
        /// <param name="triggeredCampaigns">triggeredCampaigns.</param>
        /// <param name="ruleFailureReasons">ruleFailureReasons.</param>
        /// <param name="awardedGiveaways">awardedGiveaways.</param>
        /// <param name="effects">The effects generated by the rules in your running campaigns. See [API effects](https://docs.talon.one/docs/dev/integration-api/api-effects). (required).</param>
        /// <param name="createdCoupons">createdCoupons (required).</param>
        /// <param name="createdReferrals">createdReferrals (required).</param>
        public TrackEventV2Response(CustomerProfile customerProfile = default(CustomerProfile), Event _event = default(Event), Loyalty loyalty = default(Loyalty), List<Campaign> triggeredCampaigns = default(List<Campaign>), List<RuleFailureReason> ruleFailureReasons = default(List<RuleFailureReason>), List<Giveaway> awardedGiveaways = default(List<Giveaway>), List<Effect> effects = default(List<Effect>), List<Coupon> createdCoupons = default(List<Coupon>), List<Referral> createdReferrals = default(List<Referral>))
        {
            // to ensure "effects" is required (not null)
            this.Effects = effects ?? throw new ArgumentNullException("effects is a required property for TrackEventV2Response and cannot be null");
            // to ensure "createdCoupons" is required (not null)
            this.CreatedCoupons = createdCoupons ?? throw new ArgumentNullException("createdCoupons is a required property for TrackEventV2Response and cannot be null");
            // to ensure "createdReferrals" is required (not null)
            this.CreatedReferrals = createdReferrals ?? throw new ArgumentNullException("createdReferrals is a required property for TrackEventV2Response and cannot be null");
            this.CustomerProfile = customerProfile;
            this.Event = _event;
            this.Loyalty = loyalty;
            this.TriggeredCampaigns = triggeredCampaigns;
            this.RuleFailureReasons = ruleFailureReasons;
            this.AwardedGiveaways = awardedGiveaways;
        }
        
        /// <summary>
        /// Gets or Sets CustomerProfile
        /// </summary>
        [DataMember(Name="customerProfile", EmitDefaultValue=false)]
        public CustomerProfile CustomerProfile { get; set; }

        /// <summary>
        /// Gets or Sets Event
        /// </summary>
        [DataMember(Name="event", EmitDefaultValue=false)]
        public Event Event { get; set; }

        /// <summary>
        /// Gets or Sets Loyalty
        /// </summary>
        [DataMember(Name="loyalty", EmitDefaultValue=false)]
        public Loyalty Loyalty { get; set; }

        /// <summary>
        /// Gets or Sets TriggeredCampaigns
        /// </summary>
        [DataMember(Name="triggeredCampaigns", EmitDefaultValue=false)]
        public List<Campaign> TriggeredCampaigns { get; set; }

        /// <summary>
        /// Gets or Sets RuleFailureReasons
        /// </summary>
        [DataMember(Name="ruleFailureReasons", EmitDefaultValue=false)]
        public List<RuleFailureReason> RuleFailureReasons { get; set; }

        /// <summary>
        /// Gets or Sets AwardedGiveaways
        /// </summary>
        [DataMember(Name="awardedGiveaways", EmitDefaultValue=false)]
        public List<Giveaway> AwardedGiveaways { get; set; }

        /// <summary>
        /// The effects generated by the rules in your running campaigns. See [API effects](https://docs.talon.one/docs/dev/integration-api/api-effects).
        /// </summary>
        /// <value>The effects generated by the rules in your running campaigns. See [API effects](https://docs.talon.one/docs/dev/integration-api/api-effects).</value>
        [DataMember(Name="effects", EmitDefaultValue=false)]
        public List<Effect> Effects { get; set; }

        /// <summary>
        /// Gets or Sets CreatedCoupons
        /// </summary>
        [DataMember(Name="createdCoupons", EmitDefaultValue=false)]
        public List<Coupon> CreatedCoupons { get; set; }

        /// <summary>
        /// Gets or Sets CreatedReferrals
        /// </summary>
        [DataMember(Name="createdReferrals", EmitDefaultValue=false)]
        public List<Referral> CreatedReferrals { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class TrackEventV2Response {\n");
            sb.Append("  CustomerProfile: ").Append(CustomerProfile).Append("\n");
            sb.Append("  Event: ").Append(Event).Append("\n");
            sb.Append("  Loyalty: ").Append(Loyalty).Append("\n");
            sb.Append("  TriggeredCampaigns: ").Append(TriggeredCampaigns).Append("\n");
            sb.Append("  RuleFailureReasons: ").Append(RuleFailureReasons).Append("\n");
            sb.Append("  AwardedGiveaways: ").Append(AwardedGiveaways).Append("\n");
            sb.Append("  Effects: ").Append(Effects).Append("\n");
            sb.Append("  CreatedCoupons: ").Append(CreatedCoupons).Append("\n");
            sb.Append("  CreatedReferrals: ").Append(CreatedReferrals).Append("\n");
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
            return this.Equals(input as TrackEventV2Response);
        }

        /// <summary>
        /// Returns true if TrackEventV2Response instances are equal
        /// </summary>
        /// <param name="input">Instance of TrackEventV2Response to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(TrackEventV2Response input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.CustomerProfile == input.CustomerProfile ||
                    (this.CustomerProfile != null &&
                    this.CustomerProfile.Equals(input.CustomerProfile))
                ) && 
                (
                    this.Event == input.Event ||
                    (this.Event != null &&
                    this.Event.Equals(input.Event))
                ) && 
                (
                    this.Loyalty == input.Loyalty ||
                    (this.Loyalty != null &&
                    this.Loyalty.Equals(input.Loyalty))
                ) && 
                (
                    this.TriggeredCampaigns == input.TriggeredCampaigns ||
                    this.TriggeredCampaigns != null &&
                    input.TriggeredCampaigns != null &&
                    this.TriggeredCampaigns.SequenceEqual(input.TriggeredCampaigns)
                ) && 
                (
                    this.RuleFailureReasons == input.RuleFailureReasons ||
                    this.RuleFailureReasons != null &&
                    input.RuleFailureReasons != null &&
                    this.RuleFailureReasons.SequenceEqual(input.RuleFailureReasons)
                ) && 
                (
                    this.AwardedGiveaways == input.AwardedGiveaways ||
                    this.AwardedGiveaways != null &&
                    input.AwardedGiveaways != null &&
                    this.AwardedGiveaways.SequenceEqual(input.AwardedGiveaways)
                ) && 
                (
                    this.Effects == input.Effects ||
                    this.Effects != null &&
                    input.Effects != null &&
                    this.Effects.SequenceEqual(input.Effects)
                ) && 
                (
                    this.CreatedCoupons == input.CreatedCoupons ||
                    this.CreatedCoupons != null &&
                    input.CreatedCoupons != null &&
                    this.CreatedCoupons.SequenceEqual(input.CreatedCoupons)
                ) && 
                (
                    this.CreatedReferrals == input.CreatedReferrals ||
                    this.CreatedReferrals != null &&
                    input.CreatedReferrals != null &&
                    this.CreatedReferrals.SequenceEqual(input.CreatedReferrals)
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
                if (this.CustomerProfile != null)
                    hashCode = hashCode * 59 + this.CustomerProfile.GetHashCode();
                if (this.Event != null)
                    hashCode = hashCode * 59 + this.Event.GetHashCode();
                if (this.Loyalty != null)
                    hashCode = hashCode * 59 + this.Loyalty.GetHashCode();
                if (this.TriggeredCampaigns != null)
                    hashCode = hashCode * 59 + this.TriggeredCampaigns.GetHashCode();
                if (this.RuleFailureReasons != null)
                    hashCode = hashCode * 59 + this.RuleFailureReasons.GetHashCode();
                if (this.AwardedGiveaways != null)
                    hashCode = hashCode * 59 + this.AwardedGiveaways.GetHashCode();
                if (this.Effects != null)
                    hashCode = hashCode * 59 + this.Effects.GetHashCode();
                if (this.CreatedCoupons != null)
                    hashCode = hashCode * 59 + this.CreatedCoupons.GetHashCode();
                if (this.CreatedReferrals != null)
                    hashCode = hashCode * 59 + this.CreatedReferrals.GetHashCode();
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
