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
    /// LoyaltyDashboardPointsBreakdown
    /// </summary>
    [DataContract]
    public partial class LoyaltyDashboardPointsBreakdown :  IEquatable<LoyaltyDashboardPointsBreakdown>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="LoyaltyDashboardPointsBreakdown" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected LoyaltyDashboardPointsBreakdown() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="LoyaltyDashboardPointsBreakdown" /> class.
        /// </summary>
        /// <param name="createdManually">createdManually (required).</param>
        /// <param name="createdViaRuleEngine">createdViaRuleEngine (required).</param>
        public LoyaltyDashboardPointsBreakdown(decimal createdManually = default(decimal), decimal createdViaRuleEngine = default(decimal))
        {
            this.CreatedManually = createdManually;
            this.CreatedViaRuleEngine = createdViaRuleEngine;
        }
        
        /// <summary>
        /// Gets or Sets CreatedManually
        /// </summary>
        [DataMember(Name="createdManually", EmitDefaultValue=false)]
        public decimal CreatedManually { get; set; }

        /// <summary>
        /// Gets or Sets CreatedViaRuleEngine
        /// </summary>
        [DataMember(Name="createdViaRuleEngine", EmitDefaultValue=false)]
        public decimal CreatedViaRuleEngine { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class LoyaltyDashboardPointsBreakdown {\n");
            sb.Append("  CreatedManually: ").Append(CreatedManually).Append("\n");
            sb.Append("  CreatedViaRuleEngine: ").Append(CreatedViaRuleEngine).Append("\n");
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
            return this.Equals(input as LoyaltyDashboardPointsBreakdown);
        }

        /// <summary>
        /// Returns true if LoyaltyDashboardPointsBreakdown instances are equal
        /// </summary>
        /// <param name="input">Instance of LoyaltyDashboardPointsBreakdown to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(LoyaltyDashboardPointsBreakdown input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.CreatedManually == input.CreatedManually ||
                    this.CreatedManually.Equals(input.CreatedManually)
                ) && 
                (
                    this.CreatedViaRuleEngine == input.CreatedViaRuleEngine ||
                    this.CreatedViaRuleEngine.Equals(input.CreatedViaRuleEngine)
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
                hashCode = hashCode * 59 + this.CreatedManually.GetHashCode();
                hashCode = hashCode * 59 + this.CreatedViaRuleEngine.GetHashCode();
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
