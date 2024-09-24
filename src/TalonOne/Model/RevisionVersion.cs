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
    /// RevisionVersion
    /// </summary>
    [DataContract]
    public partial class RevisionVersion :  IEquatable<RevisionVersion>, IValidatableObject
    {
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
            Loyalty = 3,

            /// <summary>
            /// Enum Giveaways for value: giveaways
            /// </summary>
            [EnumMember(Value = "giveaways")]
            Giveaways = 4,

            /// <summary>
            /// Enum Strikethrough for value: strikethrough
            /// </summary>
            [EnumMember(Value = "strikethrough")]
            Strikethrough = 5,

            /// <summary>
            /// Enum Achievements for value: achievements
            /// </summary>
            [EnumMember(Value = "achievements")]
            Achievements = 6

        }


        /// <summary>
        /// A list of features for the campaign template.
        /// </summary>
        /// <value>A list of features for the campaign template.</value>
        [DataMember(Name="features", EmitDefaultValue=false)]
        public List<FeaturesEnum> Features { get; set; }
        /// <summary>
        /// Initializes a new instance of the <see cref="RevisionVersion" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected RevisionVersion() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="RevisionVersion" /> class.
        /// </summary>
        /// <param name="id">Unique ID for this entity. Not to be confused with the Integration ID, which is set by your integration layer and used in most endpoints. (required).</param>
        /// <param name="accountId">accountId (required).</param>
        /// <param name="applicationId">applicationId (required).</param>
        /// <param name="campaignId">campaignId (required).</param>
        /// <param name="created">created (required).</param>
        /// <param name="createdBy">createdBy (required).</param>
        /// <param name="revisionId">revisionId (required).</param>
        /// <param name="version">version (required).</param>
        /// <param name="name">A user-facing name for this campaign..</param>
        /// <param name="startTime">Timestamp when the campaign will become active..</param>
        /// <param name="endTime">Timestamp when the campaign will become inactive..</param>
        /// <param name="attributes">Arbitrary properties associated with this campaign..</param>
        /// <param name="description">A detailed description of the campaign..</param>
        /// <param name="activeRulesetId">The ID of the ruleset this campaign template will use..</param>
        /// <param name="tags">A list of tags for the campaign template..</param>
        /// <param name="couponSettings">couponSettings.</param>
        /// <param name="referralSettings">referralSettings.</param>
        /// <param name="limits">The set of limits that will operate for this campaign version..</param>
        /// <param name="features">A list of features for the campaign template..</param>
        public RevisionVersion(int id = default(int), int accountId = default(int), int applicationId = default(int), int campaignId = default(int), DateTime created = default(DateTime), int createdBy = default(int), int revisionId = default(int), int version = default(int), string name = default(string), DateTime? startTime = default(DateTime?), DateTime? endTime = default(DateTime?), Object attributes = default(Object), string description = default(string), int? activeRulesetId = default(int?), List<string> tags = default(List<string>), CodeGeneratorSettings couponSettings = default(CodeGeneratorSettings), CodeGeneratorSettings referralSettings = default(CodeGeneratorSettings), List<LimitConfig> limits = default(List<LimitConfig>), List<FeaturesEnum> features = default(List<FeaturesEnum>))
        {
            this.Id = id;
            this.AccountId = accountId;
            this.ApplicationId = applicationId;
            this.CampaignId = campaignId;
            this.Created = created;
            this.CreatedBy = createdBy;
            this.RevisionId = revisionId;
            this.Version = version;
            this.Name = name;
            this.StartTime = startTime;
            this.EndTime = endTime;
            this.Attributes = attributes;
            this.Description = description;
            this.ActiveRulesetId = activeRulesetId;
            this.Tags = tags;
            this.CouponSettings = couponSettings;
            this.ReferralSettings = referralSettings;
            this.Limits = limits;
            this.Features = features;
        }
        
        /// <summary>
        /// Unique ID for this entity. Not to be confused with the Integration ID, which is set by your integration layer and used in most endpoints.
        /// </summary>
        /// <value>Unique ID for this entity. Not to be confused with the Integration ID, which is set by your integration layer and used in most endpoints.</value>
        [DataMember(Name="id", EmitDefaultValue=false)]
        public int Id { get; set; }

        /// <summary>
        /// Gets or Sets AccountId
        /// </summary>
        [DataMember(Name="accountId", EmitDefaultValue=false)]
        public int AccountId { get; set; }

        /// <summary>
        /// Gets or Sets ApplicationId
        /// </summary>
        [DataMember(Name="applicationId", EmitDefaultValue=false)]
        public int ApplicationId { get; set; }

        /// <summary>
        /// Gets or Sets CampaignId
        /// </summary>
        [DataMember(Name="campaignId", EmitDefaultValue=false)]
        public int CampaignId { get; set; }

        /// <summary>
        /// Gets or Sets Created
        /// </summary>
        [DataMember(Name="created", EmitDefaultValue=false)]
        public DateTime Created { get; set; }

        /// <summary>
        /// Gets or Sets CreatedBy
        /// </summary>
        [DataMember(Name="createdBy", EmitDefaultValue=false)]
        public int CreatedBy { get; set; }

        /// <summary>
        /// Gets or Sets RevisionId
        /// </summary>
        [DataMember(Name="revisionId", EmitDefaultValue=false)]
        public int RevisionId { get; set; }

        /// <summary>
        /// Gets or Sets Version
        /// </summary>
        [DataMember(Name="version", EmitDefaultValue=false)]
        public int Version { get; set; }

        /// <summary>
        /// A user-facing name for this campaign.
        /// </summary>
        /// <value>A user-facing name for this campaign.</value>
        [DataMember(Name="name", EmitDefaultValue=false)]
        public string Name { get; set; }

        /// <summary>
        /// Timestamp when the campaign will become active.
        /// </summary>
        /// <value>Timestamp when the campaign will become active.</value>
        [DataMember(Name="startTime", EmitDefaultValue=true)]
        public DateTime? StartTime { get; set; }

        /// <summary>
        /// Timestamp when the campaign will become inactive.
        /// </summary>
        /// <value>Timestamp when the campaign will become inactive.</value>
        [DataMember(Name="endTime", EmitDefaultValue=true)]
        public DateTime? EndTime { get; set; }

        /// <summary>
        /// Arbitrary properties associated with this campaign.
        /// </summary>
        /// <value>Arbitrary properties associated with this campaign.</value>
        [DataMember(Name="attributes", EmitDefaultValue=false)]
        public Object Attributes { get; set; }

        /// <summary>
        /// A detailed description of the campaign.
        /// </summary>
        /// <value>A detailed description of the campaign.</value>
        [DataMember(Name="description", EmitDefaultValue=true)]
        public string Description { get; set; }

        /// <summary>
        /// The ID of the ruleset this campaign template will use.
        /// </summary>
        /// <value>The ID of the ruleset this campaign template will use.</value>
        [DataMember(Name="activeRulesetId", EmitDefaultValue=true)]
        public int? ActiveRulesetId { get; set; }

        /// <summary>
        /// A list of tags for the campaign template.
        /// </summary>
        /// <value>A list of tags for the campaign template.</value>
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
        /// The set of limits that will operate for this campaign version.
        /// </summary>
        /// <value>The set of limits that will operate for this campaign version.</value>
        [DataMember(Name="limits", EmitDefaultValue=false)]
        public List<LimitConfig> Limits { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class RevisionVersion {\n");
            sb.Append("  Id: ").Append(Id).Append("\n");
            sb.Append("  AccountId: ").Append(AccountId).Append("\n");
            sb.Append("  ApplicationId: ").Append(ApplicationId).Append("\n");
            sb.Append("  CampaignId: ").Append(CampaignId).Append("\n");
            sb.Append("  Created: ").Append(Created).Append("\n");
            sb.Append("  CreatedBy: ").Append(CreatedBy).Append("\n");
            sb.Append("  RevisionId: ").Append(RevisionId).Append("\n");
            sb.Append("  Version: ").Append(Version).Append("\n");
            sb.Append("  Name: ").Append(Name).Append("\n");
            sb.Append("  StartTime: ").Append(StartTime).Append("\n");
            sb.Append("  EndTime: ").Append(EndTime).Append("\n");
            sb.Append("  Attributes: ").Append(Attributes).Append("\n");
            sb.Append("  Description: ").Append(Description).Append("\n");
            sb.Append("  ActiveRulesetId: ").Append(ActiveRulesetId).Append("\n");
            sb.Append("  Tags: ").Append(Tags).Append("\n");
            sb.Append("  CouponSettings: ").Append(CouponSettings).Append("\n");
            sb.Append("  ReferralSettings: ").Append(ReferralSettings).Append("\n");
            sb.Append("  Limits: ").Append(Limits).Append("\n");
            sb.Append("  Features: ").Append(Features).Append("\n");
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
            return this.Equals(input as RevisionVersion);
        }

        /// <summary>
        /// Returns true if RevisionVersion instances are equal
        /// </summary>
        /// <param name="input">Instance of RevisionVersion to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(RevisionVersion input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.Id == input.Id ||
                    this.Id.Equals(input.Id)
                ) && 
                (
                    this.AccountId == input.AccountId ||
                    this.AccountId.Equals(input.AccountId)
                ) && 
                (
                    this.ApplicationId == input.ApplicationId ||
                    this.ApplicationId.Equals(input.ApplicationId)
                ) && 
                (
                    this.CampaignId == input.CampaignId ||
                    this.CampaignId.Equals(input.CampaignId)
                ) && 
                (
                    this.Created == input.Created ||
                    (this.Created != null &&
                    this.Created.Equals(input.Created))
                ) && 
                (
                    this.CreatedBy == input.CreatedBy ||
                    this.CreatedBy.Equals(input.CreatedBy)
                ) && 
                (
                    this.RevisionId == input.RevisionId ||
                    this.RevisionId.Equals(input.RevisionId)
                ) && 
                (
                    this.Version == input.Version ||
                    this.Version.Equals(input.Version)
                ) && 
                (
                    this.Name == input.Name ||
                    (this.Name != null &&
                    this.Name.Equals(input.Name))
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
                    this.Description == input.Description ||
                    (this.Description != null &&
                    this.Description.Equals(input.Description))
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
                    this.Features == input.Features ||
                    this.Features.SequenceEqual(input.Features)
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
                hashCode = hashCode * 59 + this.Id.GetHashCode();
                hashCode = hashCode * 59 + this.AccountId.GetHashCode();
                hashCode = hashCode * 59 + this.ApplicationId.GetHashCode();
                hashCode = hashCode * 59 + this.CampaignId.GetHashCode();
                if (this.Created != null)
                    hashCode = hashCode * 59 + this.Created.GetHashCode();
                hashCode = hashCode * 59 + this.CreatedBy.GetHashCode();
                hashCode = hashCode * 59 + this.RevisionId.GetHashCode();
                hashCode = hashCode * 59 + this.Version.GetHashCode();
                if (this.Name != null)
                    hashCode = hashCode * 59 + this.Name.GetHashCode();
                if (this.StartTime != null)
                    hashCode = hashCode * 59 + this.StartTime.GetHashCode();
                if (this.EndTime != null)
                    hashCode = hashCode * 59 + this.EndTime.GetHashCode();
                if (this.Attributes != null)
                    hashCode = hashCode * 59 + this.Attributes.GetHashCode();
                if (this.Description != null)
                    hashCode = hashCode * 59 + this.Description.GetHashCode();
                if (this.ActiveRulesetId != null)
                    hashCode = hashCode * 59 + this.ActiveRulesetId.GetHashCode();
                if (this.Tags != null)
                    hashCode = hashCode * 59 + this.Tags.GetHashCode();
                if (this.CouponSettings != null)
                    hashCode = hashCode * 59 + this.CouponSettings.GetHashCode();
                if (this.ReferralSettings != null)
                    hashCode = hashCode * 59 + this.ReferralSettings.GetHashCode();
                if (this.Limits != null)
                    hashCode = hashCode * 59 + this.Limits.GetHashCode();
                hashCode = hashCode * 59 + this.Features.GetHashCode();
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
