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
    /// The effect produced for the catalog item.
    /// </summary>
    [DataContract]
    public partial class StrikethroughEffect :  IEquatable<StrikethroughEffect>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="StrikethroughEffect" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected StrikethroughEffect() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="StrikethroughEffect" /> class.
        /// </summary>
        /// <param name="campaignId">The ID of the campaign that effect belongs to. (required).</param>
        /// <param name="rulesetId">The ID of the ruleset containing the rule that triggered this effect. (required).</param>
        /// <param name="ruleIndex">The position of the rule that triggered this effect within the ruleset. (required).</param>
        /// <param name="ruleName">The name of the rule that triggered this effect. (required).</param>
        /// <param name="type">The type of this effect. (required).</param>
        /// <param name="props">props (required).</param>
        /// <param name="startTime">The start of the time frame where the effect is active in UTC..</param>
        /// <param name="endTime">The end of the time frame where the effect is active in UTC..</param>
        public StrikethroughEffect(int campaignId = default(int), int rulesetId = default(int), int ruleIndex = default(int), string ruleName = default(string), string type = default(string), Object props = default(Object), DateTime startTime = default(DateTime), DateTime endTime = default(DateTime))
        {
            this.CampaignId = campaignId;
            this.RulesetId = rulesetId;
            this.RuleIndex = ruleIndex;
            // to ensure "ruleName" is required (not null)
            this.RuleName = ruleName ?? throw new ArgumentNullException("ruleName is a required property for StrikethroughEffect and cannot be null");
            // to ensure "type" is required (not null)
            this.Type = type ?? throw new ArgumentNullException("type is a required property for StrikethroughEffect and cannot be null");
            // to ensure "props" is required (not null)
            this.Props = props ?? throw new ArgumentNullException("props is a required property for StrikethroughEffect and cannot be null");
            this.StartTime = startTime;
            this.EndTime = endTime;
        }
        
        /// <summary>
        /// The ID of the campaign that effect belongs to.
        /// </summary>
        /// <value>The ID of the campaign that effect belongs to.</value>
        [DataMember(Name="campaignId", EmitDefaultValue=false)]
        public int CampaignId { get; set; }

        /// <summary>
        /// The ID of the ruleset containing the rule that triggered this effect.
        /// </summary>
        /// <value>The ID of the ruleset containing the rule that triggered this effect.</value>
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
        /// The type of this effect.
        /// </summary>
        /// <value>The type of this effect.</value>
        [DataMember(Name="type", EmitDefaultValue=false)]
        public string Type { get; set; }

        /// <summary>
        /// Gets or Sets Props
        /// </summary>
        [DataMember(Name="props", EmitDefaultValue=false)]
        public Object Props { get; set; }

        /// <summary>
        /// The start of the time frame where the effect is active in UTC.
        /// </summary>
        /// <value>The start of the time frame where the effect is active in UTC.</value>
        [DataMember(Name="startTime", EmitDefaultValue=false)]
        public DateTime StartTime { get; set; }

        /// <summary>
        /// The end of the time frame where the effect is active in UTC.
        /// </summary>
        /// <value>The end of the time frame where the effect is active in UTC.</value>
        [DataMember(Name="endTime", EmitDefaultValue=false)]
        public DateTime EndTime { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class StrikethroughEffect {\n");
            sb.Append("  CampaignId: ").Append(CampaignId).Append("\n");
            sb.Append("  RulesetId: ").Append(RulesetId).Append("\n");
            sb.Append("  RuleIndex: ").Append(RuleIndex).Append("\n");
            sb.Append("  RuleName: ").Append(RuleName).Append("\n");
            sb.Append("  Type: ").Append(Type).Append("\n");
            sb.Append("  Props: ").Append(Props).Append("\n");
            sb.Append("  StartTime: ").Append(StartTime).Append("\n");
            sb.Append("  EndTime: ").Append(EndTime).Append("\n");
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
            return this.Equals(input as StrikethroughEffect);
        }

        /// <summary>
        /// Returns true if StrikethroughEffect instances are equal
        /// </summary>
        /// <param name="input">Instance of StrikethroughEffect to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(StrikethroughEffect input)
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
                    this.Type == input.Type ||
                    (this.Type != null &&
                    this.Type.Equals(input.Type))
                ) && 
                (
                    this.Props == input.Props ||
                    (this.Props != null &&
                    this.Props.Equals(input.Props))
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
                if (this.Type != null)
                    hashCode = hashCode * 59 + this.Type.GetHashCode();
                if (this.Props != null)
                    hashCode = hashCode * 59 + this.Props.GetHashCode();
                if (this.StartTime != null)
                    hashCode = hashCode * 59 + this.StartTime.GetHashCode();
                if (this.EndTime != null)
                    hashCode = hashCode * 59 + this.EndTime.GetHashCode();
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
