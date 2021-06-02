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
    /// CampaignTemplate
    /// </summary>
    [DataContract]
    public partial class CampaignTemplate :  IEquatable<CampaignTemplate>, IValidatableObject
    {
        /// <summary>
        /// Only Campaign Templates in &#39;available&#39; state may be used to create Campaigns.
        /// </summary>
        /// <value>Only Campaign Templates in &#39;available&#39; state may be used to create Campaigns.</value>
        [JsonConverter(typeof(StringEnumConverter))]
        public enum StateEnum
        {
            /// <summary>
            /// Enum Draft for value: draft
            /// </summary>
            [EnumMember(Value = "draft")]
            Draft = 1,

            /// <summary>
            /// Enum Enabled for value: enabled
            /// </summary>
            [EnumMember(Value = "enabled")]
            Enabled = 2,

            /// <summary>
            /// Enum Disabled for value: disabled
            /// </summary>
            [EnumMember(Value = "disabled")]
            Disabled = 3

        }

        /// <summary>
        /// Only Campaign Templates in &#39;available&#39; state may be used to create Campaigns.
        /// </summary>
        /// <value>Only Campaign Templates in &#39;available&#39; state may be used to create Campaigns.</value>
        [DataMember(Name="state", EmitDefaultValue=true)]
        public StateEnum State { get; set; }
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
            Giveaways = 4

        }


        /// <summary>
        /// A list of features for the campaign template.
        /// </summary>
        /// <value>A list of features for the campaign template.</value>
        [DataMember(Name="features", EmitDefaultValue=false)]
        public List<FeaturesEnum> Features { get; set; }
        /// <summary>
        /// Initializes a new instance of the <see cref="CampaignTemplate" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected CampaignTemplate() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="CampaignTemplate" /> class.
        /// </summary>
        /// <param name="id">Unique ID for this entity. (required).</param>
        /// <param name="created">The exact moment this entity was created. (required).</param>
        /// <param name="accountId">The ID of the account that owns this entity. (required).</param>
        /// <param name="userId">The ID of the account that owns this entity. (required).</param>
        /// <param name="name">The campaign template name. (required).</param>
        /// <param name="description">Customer-facing text that explains the objective of the template. (required).</param>
        /// <param name="instructions">Customer-facing text that explains how to use the template. For example, you can use this property to explain the available attributes of this template, and how they can be modified when a user uses this template to create a new campaign. (required).</param>
        /// <param name="campaignAttributes">The Campaign Attributes that Campaigns created from this template will have by default..</param>
        /// <param name="couponAttributes">The Campaign Attributes that Coupons created from this template will have by default..</param>
        /// <param name="state">Only Campaign Templates in &#39;available&#39; state may be used to create Campaigns. (required).</param>
        /// <param name="activeRulesetId">The ID of the Ruleset this Campaign Template will use..</param>
        /// <param name="tags">A list of tags for the campaign template..</param>
        /// <param name="features">A list of features for the campaign template..</param>
        /// <param name="couponSettings">couponSettings.</param>
        /// <param name="referralSettings">referralSettings.</param>
        /// <param name="limits">The set of limits that will operate for this campaign template.</param>
        /// <param name="templateParams">Template parameters are fields which can be used to replace values in a rule..</param>
        /// <param name="applicationsIds">A list of the IDs of the applications that are subscribed to this campaign template A list of the IDs of the applications that are subscribed to this campaign template (required).</param>
        /// <param name="updated">Timestamp of the most recent update to the campaign template or any of its elements..</param>
        /// <param name="updatedBy">Name of the user who last updated this campaign template if available..</param>
        /// <param name="validApplicationIds">The IDs of the applications that are related to this entity. (required).</param>
        public CampaignTemplate(int id = default(int), DateTime created = default(DateTime), int accountId = default(int), int userId = default(int), string name = default(string), string description = default(string), string instructions = default(string), Object campaignAttributes = default(Object), Object couponAttributes = default(Object), StateEnum state = default(StateEnum), int activeRulesetId = default(int), List<string> tags = default(List<string>), List<FeaturesEnum> features = default(List<FeaturesEnum>), CodeGeneratorSettings couponSettings = default(CodeGeneratorSettings), CodeGeneratorSettings referralSettings = default(CodeGeneratorSettings), List<TemplateLimitConfig> limits = default(List<TemplateLimitConfig>), List<CampaignTemplateParams> templateParams = default(List<CampaignTemplateParams>), List<int> applicationsIds = default(List<int>), DateTime updated = default(DateTime), string updatedBy = default(string), List<int> validApplicationIds = default(List<int>))
        {
            // to ensure "id" is required (not null)
            if (id == null)
            {
                throw new InvalidDataException("id is a required property for CampaignTemplate and cannot be null");
            }
            else
            {
                this.Id = id;
            }
            
            // to ensure "created" is required (not null)
            if (created == null)
            {
                throw new InvalidDataException("created is a required property for CampaignTemplate and cannot be null");
            }
            else
            {
                this.Created = created;
            }
            
            // to ensure "accountId" is required (not null)
            if (accountId == null)
            {
                throw new InvalidDataException("accountId is a required property for CampaignTemplate and cannot be null");
            }
            else
            {
                this.AccountId = accountId;
            }
            
            // to ensure "userId" is required (not null)
            if (userId == null)
            {
                throw new InvalidDataException("userId is a required property for CampaignTemplate and cannot be null");
            }
            else
            {
                this.UserId = userId;
            }
            
            // to ensure "name" is required (not null)
            if (name == null)
            {
                throw new InvalidDataException("name is a required property for CampaignTemplate and cannot be null");
            }
            else
            {
                this.Name = name;
            }
            
            // to ensure "description" is required (not null)
            if (description == null)
            {
                throw new InvalidDataException("description is a required property for CampaignTemplate and cannot be null");
            }
            else
            {
                this.Description = description;
            }
            
            // to ensure "instructions" is required (not null)
            if (instructions == null)
            {
                throw new InvalidDataException("instructions is a required property for CampaignTemplate and cannot be null");
            }
            else
            {
                this.Instructions = instructions;
            }
            
            // to ensure "state" is required (not null)
            if (state == null)
            {
                throw new InvalidDataException("state is a required property for CampaignTemplate and cannot be null");
            }
            else
            {
                this.State = state;
            }
            
            // to ensure "applicationsIds" is required (not null)
            if (applicationsIds == null)
            {
                throw new InvalidDataException("applicationsIds is a required property for CampaignTemplate and cannot be null");
            }
            else
            {
                this.ApplicationsIds = applicationsIds;
            }
            
            // to ensure "validApplicationIds" is required (not null)
            if (validApplicationIds == null)
            {
                throw new InvalidDataException("validApplicationIds is a required property for CampaignTemplate and cannot be null");
            }
            else
            {
                this.ValidApplicationIds = validApplicationIds;
            }
            
            this.CampaignAttributes = campaignAttributes;
            this.CouponAttributes = couponAttributes;
            this.ActiveRulesetId = activeRulesetId;
            this.Tags = tags;
            this.Features = features;
            this.CouponSettings = couponSettings;
            this.ReferralSettings = referralSettings;
            this.Limits = limits;
            this.TemplateParams = templateParams;
            this.Updated = updated;
            this.UpdatedBy = updatedBy;
        }
        
        /// <summary>
        /// Unique ID for this entity.
        /// </summary>
        /// <value>Unique ID for this entity.</value>
        [DataMember(Name="id", EmitDefaultValue=true)]
        public int Id { get; set; }

        /// <summary>
        /// The exact moment this entity was created.
        /// </summary>
        /// <value>The exact moment this entity was created.</value>
        [DataMember(Name="created", EmitDefaultValue=true)]
        public DateTime Created { get; set; }

        /// <summary>
        /// The ID of the account that owns this entity.
        /// </summary>
        /// <value>The ID of the account that owns this entity.</value>
        [DataMember(Name="accountId", EmitDefaultValue=true)]
        public int AccountId { get; set; }

        /// <summary>
        /// The ID of the account that owns this entity.
        /// </summary>
        /// <value>The ID of the account that owns this entity.</value>
        [DataMember(Name="userId", EmitDefaultValue=true)]
        public int UserId { get; set; }

        /// <summary>
        /// The campaign template name.
        /// </summary>
        /// <value>The campaign template name.</value>
        [DataMember(Name="name", EmitDefaultValue=true)]
        public string Name { get; set; }

        /// <summary>
        /// Customer-facing text that explains the objective of the template.
        /// </summary>
        /// <value>Customer-facing text that explains the objective of the template.</value>
        [DataMember(Name="description", EmitDefaultValue=true)]
        public string Description { get; set; }

        /// <summary>
        /// Customer-facing text that explains how to use the template. For example, you can use this property to explain the available attributes of this template, and how they can be modified when a user uses this template to create a new campaign.
        /// </summary>
        /// <value>Customer-facing text that explains how to use the template. For example, you can use this property to explain the available attributes of this template, and how they can be modified when a user uses this template to create a new campaign.</value>
        [DataMember(Name="instructions", EmitDefaultValue=true)]
        public string Instructions { get; set; }

        /// <summary>
        /// The Campaign Attributes that Campaigns created from this template will have by default.
        /// </summary>
        /// <value>The Campaign Attributes that Campaigns created from this template will have by default.</value>
        [DataMember(Name="campaignAttributes", EmitDefaultValue=false)]
        public Object CampaignAttributes { get; set; }

        /// <summary>
        /// The Campaign Attributes that Coupons created from this template will have by default.
        /// </summary>
        /// <value>The Campaign Attributes that Coupons created from this template will have by default.</value>
        [DataMember(Name="couponAttributes", EmitDefaultValue=false)]
        public Object CouponAttributes { get; set; }


        /// <summary>
        /// The ID of the Ruleset this Campaign Template will use.
        /// </summary>
        /// <value>The ID of the Ruleset this Campaign Template will use.</value>
        [DataMember(Name="activeRulesetId", EmitDefaultValue=false)]
        public int ActiveRulesetId { get; set; }

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
        /// The set of limits that will operate for this campaign template
        /// </summary>
        /// <value>The set of limits that will operate for this campaign template</value>
        [DataMember(Name="limits", EmitDefaultValue=false)]
        public List<TemplateLimitConfig> Limits { get; set; }

        /// <summary>
        /// Template parameters are fields which can be used to replace values in a rule.
        /// </summary>
        /// <value>Template parameters are fields which can be used to replace values in a rule.</value>
        [DataMember(Name="templateParams", EmitDefaultValue=false)]
        public List<CampaignTemplateParams> TemplateParams { get; set; }

        /// <summary>
        /// A list of the IDs of the applications that are subscribed to this campaign template A list of the IDs of the applications that are subscribed to this campaign template
        /// </summary>
        /// <value>A list of the IDs of the applications that are subscribed to this campaign template A list of the IDs of the applications that are subscribed to this campaign template</value>
        [DataMember(Name="applicationsIds", EmitDefaultValue=true)]
        public List<int> ApplicationsIds { get; set; }

        /// <summary>
        /// Timestamp of the most recent update to the campaign template or any of its elements.
        /// </summary>
        /// <value>Timestamp of the most recent update to the campaign template or any of its elements.</value>
        [DataMember(Name="updated", EmitDefaultValue=false)]
        public DateTime Updated { get; set; }

        /// <summary>
        /// Name of the user who last updated this campaign template if available.
        /// </summary>
        /// <value>Name of the user who last updated this campaign template if available.</value>
        [DataMember(Name="updatedBy", EmitDefaultValue=false)]
        public string UpdatedBy { get; set; }

        /// <summary>
        /// The IDs of the applications that are related to this entity.
        /// </summary>
        /// <value>The IDs of the applications that are related to this entity.</value>
        [DataMember(Name="validApplicationIds", EmitDefaultValue=true)]
        public List<int> ValidApplicationIds { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class CampaignTemplate {\n");
            sb.Append("  Id: ").Append(Id).Append("\n");
            sb.Append("  Created: ").Append(Created).Append("\n");
            sb.Append("  AccountId: ").Append(AccountId).Append("\n");
            sb.Append("  UserId: ").Append(UserId).Append("\n");
            sb.Append("  Name: ").Append(Name).Append("\n");
            sb.Append("  Description: ").Append(Description).Append("\n");
            sb.Append("  Instructions: ").Append(Instructions).Append("\n");
            sb.Append("  CampaignAttributes: ").Append(CampaignAttributes).Append("\n");
            sb.Append("  CouponAttributes: ").Append(CouponAttributes).Append("\n");
            sb.Append("  State: ").Append(State).Append("\n");
            sb.Append("  ActiveRulesetId: ").Append(ActiveRulesetId).Append("\n");
            sb.Append("  Tags: ").Append(Tags).Append("\n");
            sb.Append("  Features: ").Append(Features).Append("\n");
            sb.Append("  CouponSettings: ").Append(CouponSettings).Append("\n");
            sb.Append("  ReferralSettings: ").Append(ReferralSettings).Append("\n");
            sb.Append("  Limits: ").Append(Limits).Append("\n");
            sb.Append("  TemplateParams: ").Append(TemplateParams).Append("\n");
            sb.Append("  ApplicationsIds: ").Append(ApplicationsIds).Append("\n");
            sb.Append("  Updated: ").Append(Updated).Append("\n");
            sb.Append("  UpdatedBy: ").Append(UpdatedBy).Append("\n");
            sb.Append("  ValidApplicationIds: ").Append(ValidApplicationIds).Append("\n");
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
            return this.Equals(input as CampaignTemplate);
        }

        /// <summary>
        /// Returns true if CampaignTemplate instances are equal
        /// </summary>
        /// <param name="input">Instance of CampaignTemplate to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(CampaignTemplate input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.Id == input.Id ||
                    (this.Id != null &&
                    this.Id.Equals(input.Id))
                ) && 
                (
                    this.Created == input.Created ||
                    (this.Created != null &&
                    this.Created.Equals(input.Created))
                ) && 
                (
                    this.AccountId == input.AccountId ||
                    (this.AccountId != null &&
                    this.AccountId.Equals(input.AccountId))
                ) && 
                (
                    this.UserId == input.UserId ||
                    (this.UserId != null &&
                    this.UserId.Equals(input.UserId))
                ) && 
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
                    this.Instructions == input.Instructions ||
                    (this.Instructions != null &&
                    this.Instructions.Equals(input.Instructions))
                ) && 
                (
                    this.CampaignAttributes == input.CampaignAttributes ||
                    (this.CampaignAttributes != null &&
                    this.CampaignAttributes.Equals(input.CampaignAttributes))
                ) && 
                (
                    this.CouponAttributes == input.CouponAttributes ||
                    (this.CouponAttributes != null &&
                    this.CouponAttributes.Equals(input.CouponAttributes))
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
                    this.TemplateParams == input.TemplateParams ||
                    this.TemplateParams != null &&
                    input.TemplateParams != null &&
                    this.TemplateParams.SequenceEqual(input.TemplateParams)
                ) && 
                (
                    this.ApplicationsIds == input.ApplicationsIds ||
                    this.ApplicationsIds != null &&
                    input.ApplicationsIds != null &&
                    this.ApplicationsIds.SequenceEqual(input.ApplicationsIds)
                ) && 
                (
                    this.Updated == input.Updated ||
                    (this.Updated != null &&
                    this.Updated.Equals(input.Updated))
                ) && 
                (
                    this.UpdatedBy == input.UpdatedBy ||
                    (this.UpdatedBy != null &&
                    this.UpdatedBy.Equals(input.UpdatedBy))
                ) && 
                (
                    this.ValidApplicationIds == input.ValidApplicationIds ||
                    this.ValidApplicationIds != null &&
                    input.ValidApplicationIds != null &&
                    this.ValidApplicationIds.SequenceEqual(input.ValidApplicationIds)
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
                if (this.Id != null)
                    hashCode = hashCode * 59 + this.Id.GetHashCode();
                if (this.Created != null)
                    hashCode = hashCode * 59 + this.Created.GetHashCode();
                if (this.AccountId != null)
                    hashCode = hashCode * 59 + this.AccountId.GetHashCode();
                if (this.UserId != null)
                    hashCode = hashCode * 59 + this.UserId.GetHashCode();
                if (this.Name != null)
                    hashCode = hashCode * 59 + this.Name.GetHashCode();
                if (this.Description != null)
                    hashCode = hashCode * 59 + this.Description.GetHashCode();
                if (this.Instructions != null)
                    hashCode = hashCode * 59 + this.Instructions.GetHashCode();
                if (this.CampaignAttributes != null)
                    hashCode = hashCode * 59 + this.CampaignAttributes.GetHashCode();
                if (this.CouponAttributes != null)
                    hashCode = hashCode * 59 + this.CouponAttributes.GetHashCode();
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
                if (this.TemplateParams != null)
                    hashCode = hashCode * 59 + this.TemplateParams.GetHashCode();
                if (this.ApplicationsIds != null)
                    hashCode = hashCode * 59 + this.ApplicationsIds.GetHashCode();
                if (this.Updated != null)
                    hashCode = hashCode * 59 + this.Updated.GetHashCode();
                if (this.UpdatedBy != null)
                    hashCode = hashCode * 59 + this.UpdatedBy.GetHashCode();
                if (this.ValidApplicationIds != null)
                    hashCode = hashCode * 59 + this.ValidApplicationIds.GetHashCode();
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
