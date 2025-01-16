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
    /// UpdateCampaignTemplate
    /// </summary>
    [DataContract]
    public partial class UpdateCampaignTemplate :  IEquatable<UpdateCampaignTemplate>, IValidatableObject
    {
        /// <summary>
        /// Only campaign templates in &#39;available&#39; state may be used to create campaigns.
        /// </summary>
        /// <value>Only campaign templates in &#39;available&#39; state may be used to create campaigns.</value>
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
        /// Only campaign templates in &#39;available&#39; state may be used to create campaigns.
        /// </summary>
        /// <value>Only campaign templates in &#39;available&#39; state may be used to create campaigns.</value>
        [DataMember(Name="state", EmitDefaultValue=false)]
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
        /// The campaign type. Possible type values:   - &#x60;cartItem&#x60;: Type of campaign that can apply effects only to cart items.   - &#x60;advanced&#x60;: Type of campaign that can apply effects to customer sessions and cart items. 
        /// </summary>
        /// <value>The campaign type. Possible type values:   - &#x60;cartItem&#x60;: Type of campaign that can apply effects only to cart items.   - &#x60;advanced&#x60;: Type of campaign that can apply effects to customer sessions and cart items. </value>
        [JsonConverter(typeof(StringEnumConverter))]
        public enum CampaignTypeEnum
        {
            /// <summary>
            /// Enum CartItem for value: cartItem
            /// </summary>
            [EnumMember(Value = "cartItem")]
            CartItem = 1,

            /// <summary>
            /// Enum Advanced for value: advanced
            /// </summary>
            [EnumMember(Value = "advanced")]
            Advanced = 2

        }

        /// <summary>
        /// The campaign type. Possible type values:   - &#x60;cartItem&#x60;: Type of campaign that can apply effects only to cart items.   - &#x60;advanced&#x60;: Type of campaign that can apply effects to customer sessions and cart items. 
        /// </summary>
        /// <value>The campaign type. Possible type values:   - &#x60;cartItem&#x60;: Type of campaign that can apply effects only to cart items.   - &#x60;advanced&#x60;: Type of campaign that can apply effects to customer sessions and cart items. </value>
        [DataMember(Name="campaignType", EmitDefaultValue=false)]
        public CampaignTypeEnum? CampaignType { get; set; }
        /// <summary>
        /// Initializes a new instance of the <see cref="UpdateCampaignTemplate" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected UpdateCampaignTemplate() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="UpdateCampaignTemplate" /> class.
        /// </summary>
        /// <param name="name">The campaign template name. (required).</param>
        /// <param name="description">Customer-facing text that explains the objective of the template. (required).</param>
        /// <param name="instructions">Customer-facing text that explains how to use the template. For example, you can use this property to explain the available attributes of this template, and how they can be modified when a user uses this template to create a new campaign. (required).</param>
        /// <param name="campaignAttributes">The campaign attributes that campaigns created from this template will have by default..</param>
        /// <param name="couponAttributes">The campaign attributes that coupons created from this template will have by default..</param>
        /// <param name="state">Only campaign templates in &#39;available&#39; state may be used to create campaigns. (required).</param>
        /// <param name="activeRulesetId">The ID of the ruleset this campaign template will use..</param>
        /// <param name="tags">A list of tags for the campaign template..</param>
        /// <param name="features">A list of features for the campaign template..</param>
        /// <param name="couponSettings">couponSettings.</param>
        /// <param name="couponReservationSettings">couponReservationSettings.</param>
        /// <param name="referralSettings">referralSettings.</param>
        /// <param name="limits">The set of limits that operate for this campaign template..</param>
        /// <param name="templateParams">Fields which can be used to replace values in a rule..</param>
        /// <param name="applicationsIds">A list of IDs of the Applications that are subscribed to this campaign template. (required).</param>
        /// <param name="campaignCollections">The campaign collections from the blueprint campaign for the template..</param>
        /// <param name="defaultCampaignGroupId">The default campaign group ID..</param>
        /// <param name="campaignType">The campaign type. Possible type values:   - &#x60;cartItem&#x60;: Type of campaign that can apply effects only to cart items.   - &#x60;advanced&#x60;: Type of campaign that can apply effects to customer sessions and cart items.  (default to CampaignTypeEnum.Advanced).</param>
        public UpdateCampaignTemplate(string name = default(string), string description = default(string), string instructions = default(string), Object campaignAttributes = default(Object), Object couponAttributes = default(Object), StateEnum state = default(StateEnum), int activeRulesetId = default(int), List<string> tags = default(List<string>), List<FeaturesEnum> features = default(List<FeaturesEnum>), CodeGeneratorSettings couponSettings = default(CodeGeneratorSettings), CampaignTemplateCouponReservationSettings couponReservationSettings = default(CampaignTemplateCouponReservationSettings), CodeGeneratorSettings referralSettings = default(CodeGeneratorSettings), List<TemplateLimitConfig> limits = default(List<TemplateLimitConfig>), List<CampaignTemplateParams> templateParams = default(List<CampaignTemplateParams>), List<int> applicationsIds = default(List<int>), List<CampaignTemplateCollection> campaignCollections = default(List<CampaignTemplateCollection>), int defaultCampaignGroupId = default(int), CampaignTypeEnum? campaignType = CampaignTypeEnum.Advanced)
        {
            // to ensure "name" is required (not null)
            this.Name = name ?? throw new ArgumentNullException("name is a required property for UpdateCampaignTemplate and cannot be null");
            // to ensure "description" is required (not null)
            this.Description = description ?? throw new ArgumentNullException("description is a required property for UpdateCampaignTemplate and cannot be null");
            // to ensure "instructions" is required (not null)
            this.Instructions = instructions ?? throw new ArgumentNullException("instructions is a required property for UpdateCampaignTemplate and cannot be null");
            this.State = state;
            // to ensure "applicationsIds" is required (not null)
            this.ApplicationsIds = applicationsIds ?? throw new ArgumentNullException("applicationsIds is a required property for UpdateCampaignTemplate and cannot be null");
            this.CampaignAttributes = campaignAttributes;
            this.CouponAttributes = couponAttributes;
            this.ActiveRulesetId = activeRulesetId;
            this.Tags = tags;
            this.Features = features;
            this.CouponSettings = couponSettings;
            this.CouponReservationSettings = couponReservationSettings;
            this.ReferralSettings = referralSettings;
            this.Limits = limits;
            this.TemplateParams = templateParams;
            this.CampaignCollections = campaignCollections;
            this.DefaultCampaignGroupId = defaultCampaignGroupId;
            this.CampaignType = campaignType;
        }
        
        /// <summary>
        /// The campaign template name.
        /// </summary>
        /// <value>The campaign template name.</value>
        [DataMember(Name="name", EmitDefaultValue=false)]
        public string Name { get; set; }

        /// <summary>
        /// Customer-facing text that explains the objective of the template.
        /// </summary>
        /// <value>Customer-facing text that explains the objective of the template.</value>
        [DataMember(Name="description", EmitDefaultValue=false)]
        public string Description { get; set; }

        /// <summary>
        /// Customer-facing text that explains how to use the template. For example, you can use this property to explain the available attributes of this template, and how they can be modified when a user uses this template to create a new campaign.
        /// </summary>
        /// <value>Customer-facing text that explains how to use the template. For example, you can use this property to explain the available attributes of this template, and how they can be modified when a user uses this template to create a new campaign.</value>
        [DataMember(Name="instructions", EmitDefaultValue=false)]
        public string Instructions { get; set; }

        /// <summary>
        /// The campaign attributes that campaigns created from this template will have by default.
        /// </summary>
        /// <value>The campaign attributes that campaigns created from this template will have by default.</value>
        [DataMember(Name="campaignAttributes", EmitDefaultValue=false)]
        public Object CampaignAttributes { get; set; }

        /// <summary>
        /// The campaign attributes that coupons created from this template will have by default.
        /// </summary>
        /// <value>The campaign attributes that coupons created from this template will have by default.</value>
        [DataMember(Name="couponAttributes", EmitDefaultValue=false)]
        public Object CouponAttributes { get; set; }

        /// <summary>
        /// The ID of the ruleset this campaign template will use.
        /// </summary>
        /// <value>The ID of the ruleset this campaign template will use.</value>
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
        /// Gets or Sets CouponReservationSettings
        /// </summary>
        [DataMember(Name="couponReservationSettings", EmitDefaultValue=false)]
        public CampaignTemplateCouponReservationSettings CouponReservationSettings { get; set; }

        /// <summary>
        /// Gets or Sets ReferralSettings
        /// </summary>
        [DataMember(Name="referralSettings", EmitDefaultValue=false)]
        public CodeGeneratorSettings ReferralSettings { get; set; }

        /// <summary>
        /// The set of limits that operate for this campaign template.
        /// </summary>
        /// <value>The set of limits that operate for this campaign template.</value>
        [DataMember(Name="limits", EmitDefaultValue=false)]
        public List<TemplateLimitConfig> Limits { get; set; }

        /// <summary>
        /// Fields which can be used to replace values in a rule.
        /// </summary>
        /// <value>Fields which can be used to replace values in a rule.</value>
        [DataMember(Name="templateParams", EmitDefaultValue=false)]
        public List<CampaignTemplateParams> TemplateParams { get; set; }

        /// <summary>
        /// A list of IDs of the Applications that are subscribed to this campaign template.
        /// </summary>
        /// <value>A list of IDs of the Applications that are subscribed to this campaign template.</value>
        [DataMember(Name="applicationsIds", EmitDefaultValue=false)]
        public List<int> ApplicationsIds { get; set; }

        /// <summary>
        /// The campaign collections from the blueprint campaign for the template.
        /// </summary>
        /// <value>The campaign collections from the blueprint campaign for the template.</value>
        [DataMember(Name="campaignCollections", EmitDefaultValue=false)]
        public List<CampaignTemplateCollection> CampaignCollections { get; set; }

        /// <summary>
        /// The default campaign group ID.
        /// </summary>
        /// <value>The default campaign group ID.</value>
        [DataMember(Name="defaultCampaignGroupId", EmitDefaultValue=false)]
        public int DefaultCampaignGroupId { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class UpdateCampaignTemplate {\n");
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
            sb.Append("  CouponReservationSettings: ").Append(CouponReservationSettings).Append("\n");
            sb.Append("  ReferralSettings: ").Append(ReferralSettings).Append("\n");
            sb.Append("  Limits: ").Append(Limits).Append("\n");
            sb.Append("  TemplateParams: ").Append(TemplateParams).Append("\n");
            sb.Append("  ApplicationsIds: ").Append(ApplicationsIds).Append("\n");
            sb.Append("  CampaignCollections: ").Append(CampaignCollections).Append("\n");
            sb.Append("  DefaultCampaignGroupId: ").Append(DefaultCampaignGroupId).Append("\n");
            sb.Append("  CampaignType: ").Append(CampaignType).Append("\n");
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
            return this.Equals(input as UpdateCampaignTemplate);
        }

        /// <summary>
        /// Returns true if UpdateCampaignTemplate instances are equal
        /// </summary>
        /// <param name="input">Instance of UpdateCampaignTemplate to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(UpdateCampaignTemplate input)
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
                    this.State.Equals(input.State)
                ) && 
                (
                    this.ActiveRulesetId == input.ActiveRulesetId ||
                    this.ActiveRulesetId.Equals(input.ActiveRulesetId)
                ) && 
                (
                    this.Tags == input.Tags ||
                    this.Tags != null &&
                    input.Tags != null &&
                    this.Tags.SequenceEqual(input.Tags)
                ) && 
                (
                    this.Features == input.Features ||
                    this.Features.SequenceEqual(input.Features)
                ) && 
                (
                    this.CouponSettings == input.CouponSettings ||
                    (this.CouponSettings != null &&
                    this.CouponSettings.Equals(input.CouponSettings))
                ) && 
                (
                    this.CouponReservationSettings == input.CouponReservationSettings ||
                    (this.CouponReservationSettings != null &&
                    this.CouponReservationSettings.Equals(input.CouponReservationSettings))
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
                    this.CampaignCollections == input.CampaignCollections ||
                    this.CampaignCollections != null &&
                    input.CampaignCollections != null &&
                    this.CampaignCollections.SequenceEqual(input.CampaignCollections)
                ) && 
                (
                    this.DefaultCampaignGroupId == input.DefaultCampaignGroupId ||
                    this.DefaultCampaignGroupId.Equals(input.DefaultCampaignGroupId)
                ) && 
                (
                    this.CampaignType == input.CampaignType ||
                    this.CampaignType.Equals(input.CampaignType)
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
                if (this.Instructions != null)
                    hashCode = hashCode * 59 + this.Instructions.GetHashCode();
                if (this.CampaignAttributes != null)
                    hashCode = hashCode * 59 + this.CampaignAttributes.GetHashCode();
                if (this.CouponAttributes != null)
                    hashCode = hashCode * 59 + this.CouponAttributes.GetHashCode();
                hashCode = hashCode * 59 + this.State.GetHashCode();
                hashCode = hashCode * 59 + this.ActiveRulesetId.GetHashCode();
                if (this.Tags != null)
                    hashCode = hashCode * 59 + this.Tags.GetHashCode();
                hashCode = hashCode * 59 + this.Features.GetHashCode();
                if (this.CouponSettings != null)
                    hashCode = hashCode * 59 + this.CouponSettings.GetHashCode();
                if (this.CouponReservationSettings != null)
                    hashCode = hashCode * 59 + this.CouponReservationSettings.GetHashCode();
                if (this.ReferralSettings != null)
                    hashCode = hashCode * 59 + this.ReferralSettings.GetHashCode();
                if (this.Limits != null)
                    hashCode = hashCode * 59 + this.Limits.GetHashCode();
                if (this.TemplateParams != null)
                    hashCode = hashCode * 59 + this.TemplateParams.GetHashCode();
                if (this.ApplicationsIds != null)
                    hashCode = hashCode * 59 + this.ApplicationsIds.GetHashCode();
                if (this.CampaignCollections != null)
                    hashCode = hashCode * 59 + this.CampaignCollections.GetHashCode();
                hashCode = hashCode * 59 + this.DefaultCampaignGroupId.GetHashCode();
                hashCode = hashCode * 59 + this.CampaignType.GetHashCode();
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
