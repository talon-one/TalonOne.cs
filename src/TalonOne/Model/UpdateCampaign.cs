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
    /// UpdateCampaign
    /// </summary>
    [DataContract]
    public partial class UpdateCampaign :  IEquatable<UpdateCampaign>, IValidatableObject
    {
        /// <summary>
        /// A disabled or archived campaign is not evaluated for rules or coupons. 
        /// </summary>
        /// <value>A disabled or archived campaign is not evaluated for rules or coupons. </value>
        [JsonConverter(typeof(StringEnumConverter))]
        public enum StateEnum
        {
            /// <summary>
            /// Enum Enabled for value: enabled
            /// </summary>
            [EnumMember(Value = "enabled")]
            Enabled = 1,

            /// <summary>
            /// Enum Disabled for value: disabled
            /// </summary>
            [EnumMember(Value = "disabled")]
            Disabled = 2,

            /// <summary>
            /// Enum Archived for value: archived
            /// </summary>
            [EnumMember(Value = "archived")]
            Archived = 3

        }

        /// <summary>
        /// A disabled or archived campaign is not evaluated for rules or coupons. 
        /// </summary>
        /// <value>A disabled or archived campaign is not evaluated for rules or coupons. </value>
        [DataMember(Name="state", EmitDefaultValue=false)]
        public StateEnum? State { get; set; }
        /// <summary>
        /// Defines Features
        /// </summary>
        [JsonConverter(typeof(StringEnumConverter))]
        public enum FeaturesEnum
        {
            /// <summary>
            /// Enum Coupons for value: coupons
            /// </summary>
            [EnumMember(Value = "coupons")]
            Coupons = 1,

            /// <summary>
            /// Enum Referrals for value: referrals
            /// </summary>
            [EnumMember(Value = "referrals")]
            Referrals = 2,

            /// <summary>
            /// Enum Loyalty for value: loyalty
            /// </summary>
            [EnumMember(Value = "loyalty")]
            Loyalty = 3

        }


        /// <summary>
        /// A list of features for the campaign.
        /// </summary>
        /// <value>A list of features for the campaign.</value>
        [DataMember(Name="features", EmitDefaultValue=false)]
        public List<FeaturesEnum> Features { get; set; }
        /// <summary>
        /// Initializes a new instance of the <see cref="UpdateCampaign" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected UpdateCampaign() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="UpdateCampaign" /> class.
        /// </summary>
        /// <param name="name">A friendly name for this campaign. (required).</param>
        /// <param name="description">A detailed description of the campaign..</param>
        /// <param name="startTime">Datetime when the campaign will become active..</param>
        /// <param name="endTime">Datetime when the campaign will become in-active..</param>
        /// <param name="attributes">Arbitrary properties associated with this campaign.</param>
        /// <param name="state">A disabled or archived campaign is not evaluated for rules or coupons.  (default to StateEnum.Enabled).</param>
        /// <param name="activeRulesetId">ID of Ruleset this campaign applies on customer session evaluation..</param>
        /// <param name="tags">A list of tags for the campaign. (required).</param>
        /// <param name="features">A list of features for the campaign. (required).</param>
        /// <param name="couponSettings">couponSettings.</param>
        /// <param name="referralSettings">referralSettings.</param>
        /// <param name="limits">The set of limits that will operate for this campaign (required).</param>
        /// <param name="campaignGroups">The IDs of the campaign groups that own this entity..</param>
        public UpdateCampaign(string name = default(string), string description = default(string), DateTime startTime = default(DateTime), DateTime endTime = default(DateTime), Object attributes = default(Object), StateEnum? state = StateEnum.Enabled, int activeRulesetId = default(int), List<string> tags = default(List<string>), List<FeaturesEnum> features = default(List<FeaturesEnum>), CodeGeneratorSettings couponSettings = default(CodeGeneratorSettings), CodeGeneratorSettings referralSettings = default(CodeGeneratorSettings), List<LimitConfig> limits = default(List<LimitConfig>), List<int> campaignGroups = default(List<int>))
        {
            // to ensure "name" is required (not null)
            if (name == null)
            {
                throw new InvalidDataException("name is a required property for UpdateCampaign and cannot be null");
            }
            else
            {
                this.Name = name;
            }
            
            // to ensure "tags" is required (not null)
            if (tags == null)
            {
                throw new InvalidDataException("tags is a required property for UpdateCampaign and cannot be null");
            }
            else
            {
                this.Tags = tags;
            }
            
            // to ensure "features" is required (not null)
            if (features == null)
            {
                throw new InvalidDataException("features is a required property for UpdateCampaign and cannot be null");
            }
            else
            {
                this.Features = features;
            }
            
            // to ensure "limits" is required (not null)
            if (limits == null)
            {
                throw new InvalidDataException("limits is a required property for UpdateCampaign and cannot be null");
            }
            else
            {
                this.Limits = limits;
            }
            
            this.Description = description;
            this.StartTime = startTime;
            this.EndTime = endTime;
            this.Attributes = attributes;
            // use default value if no "state" provided
            if (state == null)
            {
                this.State = StateEnum.Enabled;
            }
            else
            {
                this.State = state;
            }
            this.ActiveRulesetId = activeRulesetId;
            this.CouponSettings = couponSettings;
            this.ReferralSettings = referralSettings;
            this.CampaignGroups = campaignGroups;
        }
        
        /// <summary>
        /// A friendly name for this campaign.
        /// </summary>
        /// <value>A friendly name for this campaign.</value>
        [DataMember(Name="name", EmitDefaultValue=false)]
        public string Name { get; set; }

        /// <summary>
        /// A detailed description of the campaign.
        /// </summary>
        /// <value>A detailed description of the campaign.</value>
        [DataMember(Name="description", EmitDefaultValue=false)]
        public string Description { get; set; }

        /// <summary>
        /// Datetime when the campaign will become active.
        /// </summary>
        /// <value>Datetime when the campaign will become active.</value>
        [DataMember(Name="startTime", EmitDefaultValue=false)]
        public DateTime StartTime { get; set; }

        /// <summary>
        /// Datetime when the campaign will become in-active.
        /// </summary>
        /// <value>Datetime when the campaign will become in-active.</value>
        [DataMember(Name="endTime", EmitDefaultValue=false)]
        public DateTime EndTime { get; set; }

        /// <summary>
        /// Arbitrary properties associated with this campaign
        /// </summary>
        /// <value>Arbitrary properties associated with this campaign</value>
        [DataMember(Name="attributes", EmitDefaultValue=false)]
        public Object Attributes { get; set; }


        /// <summary>
        /// ID of Ruleset this campaign applies on customer session evaluation.
        /// </summary>
        /// <value>ID of Ruleset this campaign applies on customer session evaluation.</value>
        [DataMember(Name="activeRulesetId", EmitDefaultValue=false)]
        public int ActiveRulesetId { get; set; }

        /// <summary>
        /// A list of tags for the campaign.
        /// </summary>
        /// <value>A list of tags for the campaign.</value>
        [DataMember(Name="tags", EmitDefaultValue=false)]
        public List<string> Tags { get; set; }


        /// <summary>
        /// Gets or Sets CouponSettings
        /// </summary>
        [DataMember(Name="couponSettings", EmitDefaultValue=false)]
        public CodeGeneratorSettings CouponSettings { get; set; }

        /// <summary>
        /// Gets or Sets ReferralSettings
        /// </summary>
        [DataMember(Name="referralSettings", EmitDefaultValue=false)]
        public CodeGeneratorSettings ReferralSettings { get; set; }

        /// <summary>
        /// The set of limits that will operate for this campaign
        /// </summary>
        /// <value>The set of limits that will operate for this campaign</value>
        [DataMember(Name="limits", EmitDefaultValue=false)]
        public List<LimitConfig> Limits { get; set; }

        /// <summary>
        /// The IDs of the campaign groups that own this entity.
        /// </summary>
        /// <value>The IDs of the campaign groups that own this entity.</value>
        [DataMember(Name="campaignGroups", EmitDefaultValue=false)]
        public List<int> CampaignGroups { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class UpdateCampaign {\n");
            sb.Append("  Name: ").Append(Name).Append("\n");
            sb.Append("  Description: ").Append(Description).Append("\n");
            sb.Append("  StartTime: ").Append(StartTime).Append("\n");
            sb.Append("  EndTime: ").Append(EndTime).Append("\n");
            sb.Append("  Attributes: ").Append(Attributes).Append("\n");
            sb.Append("  State: ").Append(State).Append("\n");
            sb.Append("  ActiveRulesetId: ").Append(ActiveRulesetId).Append("\n");
            sb.Append("  Tags: ").Append(Tags).Append("\n");
            sb.Append("  Features: ").Append(Features).Append("\n");
            sb.Append("  CouponSettings: ").Append(CouponSettings).Append("\n");
            sb.Append("  ReferralSettings: ").Append(ReferralSettings).Append("\n");
            sb.Append("  Limits: ").Append(Limits).Append("\n");
            sb.Append("  CampaignGroups: ").Append(CampaignGroups).Append("\n");
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
            return this.Equals(input as UpdateCampaign);
        }

        /// <summary>
        /// Returns true if UpdateCampaign instances are equal
        /// </summary>
        /// <param name="input">Instance of UpdateCampaign to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(UpdateCampaign input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.Name == input.Name ||
                    (this.Name != null &&
                    this.Name.Equals(input.Name))
                ) && 
                (
                    this.Description == input.Description ||
                    (this.Description != null &&
                    this.Description.Equals(input.Description))
                ) && 
                (
                    this.StartTime == input.StartTime ||
                    (this.StartTime != null &&
                    this.StartTime.Equals(input.StartTime))
                ) && 
                (
                    this.EndTime == input.EndTime ||
                    (this.EndTime != null &&
                    this.EndTime.Equals(input.EndTime))
                ) && 
                (
                    this.Attributes == input.Attributes ||
                    (this.Attributes != null &&
                    this.Attributes.Equals(input.Attributes))
                ) && 
                (
                    this.State == input.State ||
                    (this.State != null &&
                    this.State.Equals(input.State))
                ) && 
                (
                    this.ActiveRulesetId == input.ActiveRulesetId ||
                    (this.ActiveRulesetId != null &&
                    this.ActiveRulesetId.Equals(input.ActiveRulesetId))
                ) && 
                (
                    this.Tags == input.Tags ||
                    this.Tags != null &&
                    input.Tags != null &&
                    this.Tags.SequenceEqual(input.Tags)
                ) && 
                (
                    this.Features == input.Features ||
                    this.Features != null &&
                    input.Features != null &&
                    this.Features.SequenceEqual(input.Features)
                ) && 
                (
                    this.CouponSettings == input.CouponSettings ||
                    (this.CouponSettings != null &&
                    this.CouponSettings.Equals(input.CouponSettings))
                ) && 
                (
                    this.ReferralSettings == input.ReferralSettings ||
                    (this.ReferralSettings != null &&
                    this.ReferralSettings.Equals(input.ReferralSettings))
                ) && 
                (
                    this.Limits == input.Limits ||
                    this.Limits != null &&
                    input.Limits != null &&
                    this.Limits.SequenceEqual(input.Limits)
                ) && 
                (
                    this.CampaignGroups == input.CampaignGroups ||
                    this.CampaignGroups != null &&
                    input.CampaignGroups != null &&
                    this.CampaignGroups.SequenceEqual(input.CampaignGroups)
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
                if (this.Name != null)
                    hashCode = hashCode * 59 + this.Name.GetHashCode();
                if (this.Description != null)
                    hashCode = hashCode * 59 + this.Description.GetHashCode();
                if (this.StartTime != null)
                    hashCode = hashCode * 59 + this.StartTime.GetHashCode();
                if (this.EndTime != null)
                    hashCode = hashCode * 59 + this.EndTime.GetHashCode();
                if (this.Attributes != null)
                    hashCode = hashCode * 59 + this.Attributes.GetHashCode();
                if (this.State != null)
                    hashCode = hashCode * 59 + this.State.GetHashCode();
                if (this.ActiveRulesetId != null)
                    hashCode = hashCode * 59 + this.ActiveRulesetId.GetHashCode();
                if (this.Tags != null)
                    hashCode = hashCode * 59 + this.Tags.GetHashCode();
                if (this.Features != null)
                    hashCode = hashCode * 59 + this.Features.GetHashCode();
                if (this.CouponSettings != null)
                    hashCode = hashCode * 59 + this.CouponSettings.GetHashCode();
                if (this.ReferralSettings != null)
                    hashCode = hashCode * 59 + this.ReferralSettings.GetHashCode();
                if (this.Limits != null)
                    hashCode = hashCode * 59 + this.Limits.GetHashCode();
                if (this.CampaignGroups != null)
                    hashCode = hashCode * 59 + this.CampaignGroups.GetHashCode();
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
            // Name (string) minLength
            if(this.Name != null && this.Name.Length < 1)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for Name, length must be greater than 1.", new [] { "Name" });
            }

            yield break;
        }
    }

}
