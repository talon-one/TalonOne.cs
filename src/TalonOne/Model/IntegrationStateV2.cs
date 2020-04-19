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
    /// Contains all entities that might interest Talon.One integrations. This is the response type returned by the V2 PUT customer_session endpoint 
    /// </summary>
    [DataContract]
    public partial class IntegrationStateV2 :  IEquatable<IntegrationStateV2>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="IntegrationStateV2" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected IntegrationStateV2() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="IntegrationStateV2" /> class.
        /// </summary>
        /// <param name="customerSession">customerSession.</param>
        /// <param name="customerProfile">customerProfile.</param>
        /// <param name="_event">_event.</param>
        /// <param name="loyalty">loyalty.</param>
        /// <param name="referral">referral.</param>
        /// <param name="coupons">coupons.</param>
        /// <param name="triggeredCampaigns">triggeredCampaigns.</param>
        /// <param name="effects">effects (required).</param>
        /// <param name="createdCoupons">createdCoupons (required).</param>
        /// <param name="createdReferrals">createdReferrals (required).</param>
        public IntegrationStateV2(CustomerSessionV2 customerSession = default(CustomerSessionV2), CustomerProfile customerProfile = default(CustomerProfile), Event _event = default(Event), Loyalty loyalty = default(Loyalty), Referral referral = default(Referral), List<Coupon> coupons = default(List<Coupon>), List<Campaign> triggeredCampaigns = default(List<Campaign>), List<Effect> effects = default(List<Effect>), List<Coupon> createdCoupons = default(List<Coupon>), List<Referral> createdReferrals = default(List<Referral>))
        {
            // to ensure "effects" is required (not null)
            if (effects == null)
            {
                throw new InvalidDataException("effects is a required property for IntegrationStateV2 and cannot be null");
            }
            else
            {
                this.Effects = effects;
            }
            
            // to ensure "createdCoupons" is required (not null)
            if (createdCoupons == null)
            {
                throw new InvalidDataException("createdCoupons is a required property for IntegrationStateV2 and cannot be null");
            }
            else
            {
                this.CreatedCoupons = createdCoupons;
            }
            
            // to ensure "createdReferrals" is required (not null)
            if (createdReferrals == null)
            {
                throw new InvalidDataException("createdReferrals is a required property for IntegrationStateV2 and cannot be null");
            }
            else
            {
                this.CreatedReferrals = createdReferrals;
            }
            
            this.CustomerSession = customerSession;
            this.CustomerProfile = customerProfile;
            this.Event = _event;
            this.Loyalty = loyalty;
            this.Referral = referral;
            this.Coupons = coupons;
            this.TriggeredCampaigns = triggeredCampaigns;
        }
        
        /// <summary>
        /// Gets or Sets CustomerSession
        /// </summary>
        [DataMember(Name="customerSession", EmitDefaultValue=false)]
        public CustomerSessionV2 CustomerSession { get; set; }

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
        /// Gets or Sets Referral
        /// </summary>
        [DataMember(Name="referral", EmitDefaultValue=false)]
        public Referral Referral { get; set; }

        /// <summary>
        /// Gets or Sets Coupons
        /// </summary>
        [DataMember(Name="coupons", EmitDefaultValue=false)]
        public List<Coupon> Coupons { get; set; }

        /// <summary>
        /// Gets or Sets TriggeredCampaigns
        /// </summary>
        [DataMember(Name="triggeredCampaigns", EmitDefaultValue=false)]
        public List<Campaign> TriggeredCampaigns { get; set; }

        /// <summary>
        /// Gets or Sets Effects
        /// </summary>
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
            sb.Append("class IntegrationStateV2 {\n");
            sb.Append("  CustomerSession: ").Append(CustomerSession).Append("\n");
            sb.Append("  CustomerProfile: ").Append(CustomerProfile).Append("\n");
            sb.Append("  Event: ").Append(Event).Append("\n");
            sb.Append("  Loyalty: ").Append(Loyalty).Append("\n");
            sb.Append("  Referral: ").Append(Referral).Append("\n");
            sb.Append("  Coupons: ").Append(Coupons).Append("\n");
            sb.Append("  TriggeredCampaigns: ").Append(TriggeredCampaigns).Append("\n");
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
            return this.Equals(input as IntegrationStateV2);
        }

        /// <summary>
        /// Returns true if IntegrationStateV2 instances are equal
        /// </summary>
        /// <param name="input">Instance of IntegrationStateV2 to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(IntegrationStateV2 input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.CustomerSession == input.CustomerSession ||
                    (this.CustomerSession != null &&
                    this.CustomerSession.Equals(input.CustomerSession))
                ) && 
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
                    this.Referral == input.Referral ||
                    (this.Referral != null &&
                    this.Referral.Equals(input.Referral))
                ) && 
                (
                    this.Coupons == input.Coupons ||
                    this.Coupons != null &&
                    input.Coupons != null &&
                    this.Coupons.SequenceEqual(input.Coupons)
                ) && 
                (
                    this.TriggeredCampaigns == input.TriggeredCampaigns ||
                    this.TriggeredCampaigns != null &&
                    input.TriggeredCampaigns != null &&
                    this.TriggeredCampaigns.SequenceEqual(input.TriggeredCampaigns)
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
                if (this.CustomerSession != null)
                    hashCode = hashCode * 59 + this.CustomerSession.GetHashCode();
                if (this.CustomerProfile != null)
                    hashCode = hashCode * 59 + this.CustomerProfile.GetHashCode();
                if (this.Event != null)
                    hashCode = hashCode * 59 + this.Event.GetHashCode();
                if (this.Loyalty != null)
                    hashCode = hashCode * 59 + this.Loyalty.GetHashCode();
                if (this.Referral != null)
                    hashCode = hashCode * 59 + this.Referral.GetHashCode();
                if (this.Coupons != null)
                    hashCode = hashCode * 59 + this.Coupons.GetHashCode();
                if (this.TriggeredCampaigns != null)
                    hashCode = hashCode * 59 + this.TriggeredCampaigns.GetHashCode();
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