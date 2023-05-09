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
    /// A notification regarding a campaign whose ruleset was changed.
    /// </summary>
    [DataContract]
    public partial class CampaignRulesetChangedNotification :  IEquatable<CampaignRulesetChangedNotification>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="CampaignRulesetChangedNotification" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected CampaignRulesetChangedNotification() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="CampaignRulesetChangedNotification" /> class.
        /// </summary>
        /// <param name="campaign">campaign (required).</param>
        /// <param name="oldRuleset">oldRuleset.</param>
        /// <param name="ruleset">ruleset.</param>
        public CampaignRulesetChangedNotification(Campaign campaign = default(Campaign), Ruleset oldRuleset = default(Ruleset), Ruleset ruleset = default(Ruleset))
        {
            // to ensure "campaign" is required (not null)
            this.Campaign = campaign ?? throw new ArgumentNullException("campaign is a required property for CampaignRulesetChangedNotification and cannot be null");
            this.OldRuleset = oldRuleset;
            this.Ruleset = ruleset;
        }
        
        /// <summary>
        /// Gets or Sets Campaign
        /// </summary>
        [DataMember(Name="campaign", EmitDefaultValue=false)]
        public Campaign Campaign { get; set; }

        /// <summary>
        /// Gets or Sets OldRuleset
        /// </summary>
        [DataMember(Name="oldRuleset", EmitDefaultValue=false)]
        public Ruleset OldRuleset { get; set; }

        /// <summary>
        /// Gets or Sets Ruleset
        /// </summary>
        [DataMember(Name="ruleset", EmitDefaultValue=false)]
        public Ruleset Ruleset { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class CampaignRulesetChangedNotification {\n");
            sb.Append("  Campaign: ").Append(Campaign).Append("\n");
            sb.Append("  OldRuleset: ").Append(OldRuleset).Append("\n");
            sb.Append("  Ruleset: ").Append(Ruleset).Append("\n");
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
            return this.Equals(input as CampaignRulesetChangedNotification);
        }

        /// <summary>
        /// Returns true if CampaignRulesetChangedNotification instances are equal
        /// </summary>
        /// <param name="input">Instance of CampaignRulesetChangedNotification to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(CampaignRulesetChangedNotification input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.Campaign == input.Campaign ||
                    (this.Campaign != null &&
                    this.Campaign.Equals(input.Campaign))
                ) && 
                (
                    this.OldRuleset == input.OldRuleset ||
                    (this.OldRuleset != null &&
                    this.OldRuleset.Equals(input.OldRuleset))
                ) && 
                (
                    this.Ruleset == input.Ruleset ||
                    (this.Ruleset != null &&
                    this.Ruleset.Equals(input.Ruleset))
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
                if (this.Campaign != null)
                    hashCode = hashCode * 59 + this.Campaign.GetHashCode();
                if (this.OldRuleset != null)
                    hashCode = hashCode * 59 + this.OldRuleset.GetHashCode();
                if (this.Ruleset != null)
                    hashCode = hashCode * 59 + this.Ruleset.GetHashCode();
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
