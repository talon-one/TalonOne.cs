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
    /// Definition of all properties that are present on all effects, independent of their type.
    /// </summary>
    [DataContract]
    public partial class EffectEntity :  IEquatable<EffectEntity>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="EffectEntity" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected EffectEntity() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="EffectEntity" /> class.
        /// </summary>
        /// <param name="campaignId">The ID of the campaign that triggered this effect. (required).</param>
        /// <param name="rulesetId">The ID of the ruleset that was active in the campaign when this effect was triggered. (required).</param>
        /// <param name="ruleIndex">The position of the rule that triggered this effect within the ruleset. (required).</param>
        /// <param name="ruleName">The name of the rule that triggered this effect. (required).</param>
        /// <param name="effectType">The type of effect that was triggered. See [API effects](https://docs.talon.one/docs/dev/integration-api/api-effects). (required).</param>
        /// <param name="triggeredByCoupon">The ID of the coupon that was being evaluated when this effect was triggered..</param>
        /// <param name="triggeredForCatalogItem">The ID of the catalog item that was being evaluated when this effect was triggered..</param>
        /// <param name="conditionIndex">The index of the condition that was triggered..</param>
        /// <param name="evaluationGroupID">The ID of the evaluation group. For more information, see [Managing campaign evaluation](https://docs.talon.one/docs/product/applications/managing-campaign-evaluation)..</param>
        /// <param name="evaluationGroupMode">The evaluation mode of the evaluation group. For more information, see [Managing campaign evaluation](https://docs.talon.one/docs/product/applications/managing-campaign-evaluation)..</param>
        public EffectEntity(int campaignId = default(int), int rulesetId = default(int), int ruleIndex = default(int), string ruleName = default(string), string effectType = default(string), int triggeredByCoupon = default(int), int triggeredForCatalogItem = default(int), int conditionIndex = default(int), int evaluationGroupID = default(int), string evaluationGroupMode = default(string))
        {
            this.CampaignId = campaignId;
            this.RulesetId = rulesetId;
            this.RuleIndex = ruleIndex;
            // to ensure "ruleName" is required (not null)
            this.RuleName = ruleName ?? throw new ArgumentNullException("ruleName is a required property for EffectEntity and cannot be null");
            // to ensure "effectType" is required (not null)
            this.EffectType = effectType ?? throw new ArgumentNullException("effectType is a required property for EffectEntity and cannot be null");
            this.TriggeredByCoupon = triggeredByCoupon;
            this.TriggeredForCatalogItem = triggeredForCatalogItem;
            this.ConditionIndex = conditionIndex;
            this.EvaluationGroupID = evaluationGroupID;
            this.EvaluationGroupMode = evaluationGroupMode;
        }
        
        /// <summary>
        /// The ID of the campaign that triggered this effect.
        /// </summary>
        /// <value>The ID of the campaign that triggered this effect.</value>
        [DataMember(Name="campaignId", EmitDefaultValue=false)]
        public int CampaignId { get; set; }

        /// <summary>
        /// The ID of the ruleset that was active in the campaign when this effect was triggered.
        /// </summary>
        /// <value>The ID of the ruleset that was active in the campaign when this effect was triggered.</value>
        [DataMember(Name="rulesetId", EmitDefaultValue=false)]
        public int RulesetId { get; set; }

        /// <summary>
        /// The position of the rule that triggered this effect within the ruleset.
        /// </summary>
        /// <value>The position of the rule that triggered this effect within the ruleset.</value>
        [DataMember(Name="ruleIndex", EmitDefaultValue=false)]
        public int RuleIndex { get; set; }

        /// <summary>
        /// The name of the rule that triggered this effect.
        /// </summary>
        /// <value>The name of the rule that triggered this effect.</value>
        [DataMember(Name="ruleName", EmitDefaultValue=false)]
        public string RuleName { get; set; }

        /// <summary>
        /// The type of effect that was triggered. See [API effects](https://docs.talon.one/docs/dev/integration-api/api-effects).
        /// </summary>
        /// <value>The type of effect that was triggered. See [API effects](https://docs.talon.one/docs/dev/integration-api/api-effects).</value>
        [DataMember(Name="effectType", EmitDefaultValue=false)]
        public string EffectType { get; set; }

        /// <summary>
        /// The ID of the coupon that was being evaluated when this effect was triggered.
        /// </summary>
        /// <value>The ID of the coupon that was being evaluated when this effect was triggered.</value>
        [DataMember(Name="triggeredByCoupon", EmitDefaultValue=false)]
        public int TriggeredByCoupon { get; set; }

        /// <summary>
        /// The ID of the catalog item that was being evaluated when this effect was triggered.
        /// </summary>
        /// <value>The ID of the catalog item that was being evaluated when this effect was triggered.</value>
        [DataMember(Name="triggeredForCatalogItem", EmitDefaultValue=false)]
        public int TriggeredForCatalogItem { get; set; }

        /// <summary>
        /// The index of the condition that was triggered.
        /// </summary>
        /// <value>The index of the condition that was triggered.</value>
        [DataMember(Name="conditionIndex", EmitDefaultValue=false)]
        public int ConditionIndex { get; set; }

        /// <summary>
        /// The ID of the evaluation group. For more information, see [Managing campaign evaluation](https://docs.talon.one/docs/product/applications/managing-campaign-evaluation).
        /// </summary>
        /// <value>The ID of the evaluation group. For more information, see [Managing campaign evaluation](https://docs.talon.one/docs/product/applications/managing-campaign-evaluation).</value>
        [DataMember(Name="evaluationGroupID", EmitDefaultValue=false)]
        public int EvaluationGroupID { get; set; }

        /// <summary>
        /// The evaluation mode of the evaluation group. For more information, see [Managing campaign evaluation](https://docs.talon.one/docs/product/applications/managing-campaign-evaluation).
        /// </summary>
        /// <value>The evaluation mode of the evaluation group. For more information, see [Managing campaign evaluation](https://docs.talon.one/docs/product/applications/managing-campaign-evaluation).</value>
        [DataMember(Name="evaluationGroupMode", EmitDefaultValue=false)]
        public string EvaluationGroupMode { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class EffectEntity {\n");
            sb.Append("  CampaignId: ").Append(CampaignId).Append("\n");
            sb.Append("  RulesetId: ").Append(RulesetId).Append("\n");
            sb.Append("  RuleIndex: ").Append(RuleIndex).Append("\n");
            sb.Append("  RuleName: ").Append(RuleName).Append("\n");
            sb.Append("  EffectType: ").Append(EffectType).Append("\n");
            sb.Append("  TriggeredByCoupon: ").Append(TriggeredByCoupon).Append("\n");
            sb.Append("  TriggeredForCatalogItem: ").Append(TriggeredForCatalogItem).Append("\n");
            sb.Append("  ConditionIndex: ").Append(ConditionIndex).Append("\n");
            sb.Append("  EvaluationGroupID: ").Append(EvaluationGroupID).Append("\n");
            sb.Append("  EvaluationGroupMode: ").Append(EvaluationGroupMode).Append("\n");
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
            return this.Equals(input as EffectEntity);
        }

        /// <summary>
        /// Returns true if EffectEntity instances are equal
        /// </summary>
        /// <param name="input">Instance of EffectEntity to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(EffectEntity input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.CampaignId == input.CampaignId ||
                    this.CampaignId.Equals(input.CampaignId)
                ) && 
                (
                    this.RulesetId == input.RulesetId ||
                    this.RulesetId.Equals(input.RulesetId)
                ) && 
                (
                    this.RuleIndex == input.RuleIndex ||
                    this.RuleIndex.Equals(input.RuleIndex)
                ) && 
                (
                    this.RuleName == input.RuleName ||
                    (this.RuleName != null &&
                    this.RuleName.Equals(input.RuleName))
                ) && 
                (
                    this.EffectType == input.EffectType ||
                    (this.EffectType != null &&
                    this.EffectType.Equals(input.EffectType))
                ) && 
                (
                    this.TriggeredByCoupon == input.TriggeredByCoupon ||
                    this.TriggeredByCoupon.Equals(input.TriggeredByCoupon)
                ) && 
                (
                    this.TriggeredForCatalogItem == input.TriggeredForCatalogItem ||
                    this.TriggeredForCatalogItem.Equals(input.TriggeredForCatalogItem)
                ) && 
                (
                    this.ConditionIndex == input.ConditionIndex ||
                    this.ConditionIndex.Equals(input.ConditionIndex)
                ) && 
                (
                    this.EvaluationGroupID == input.EvaluationGroupID ||
                    this.EvaluationGroupID.Equals(input.EvaluationGroupID)
                ) && 
                (
                    this.EvaluationGroupMode == input.EvaluationGroupMode ||
                    (this.EvaluationGroupMode != null &&
                    this.EvaluationGroupMode.Equals(input.EvaluationGroupMode))
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
                hashCode = hashCode * 59 + this.RulesetId.GetHashCode();
                hashCode = hashCode * 59 + this.RuleIndex.GetHashCode();
                if (this.RuleName != null)
                    hashCode = hashCode * 59 + this.RuleName.GetHashCode();
                if (this.EffectType != null)
                    hashCode = hashCode * 59 + this.EffectType.GetHashCode();
                hashCode = hashCode * 59 + this.TriggeredByCoupon.GetHashCode();
                hashCode = hashCode * 59 + this.TriggeredForCatalogItem.GetHashCode();
                hashCode = hashCode * 59 + this.ConditionIndex.GetHashCode();
                hashCode = hashCode * 59 + this.EvaluationGroupID.GetHashCode();
                if (this.EvaluationGroupMode != null)
                    hashCode = hashCode * 59 + this.EvaluationGroupMode.GetHashCode();
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
