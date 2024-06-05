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
    /// The average customer session value, calculated by dividing the revenue value by the number of sessions. The &#x60;influenced&#x60; value includes only sessions with at least one applied effect.
    /// </summary>
    [DataContract]
    public partial class ApplicationCampaignAnalyticsAvgSessionValue :  IEquatable<ApplicationCampaignAnalyticsAvgSessionValue>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ApplicationCampaignAnalyticsAvgSessionValue" /> class.
        /// </summary>
        /// <param name="value">value.</param>
        /// <param name="uplift">uplift.</param>
        /// <param name="trend">trend.</param>
        public ApplicationCampaignAnalyticsAvgSessionValue(decimal value = default(decimal), decimal uplift = default(decimal), decimal trend = default(decimal))
        {
            this.Value = value;
            this.Uplift = uplift;
            this.Trend = trend;
        }
        
        /// <summary>
        /// Gets or Sets Value
        /// </summary>
        [DataMember(Name="value", EmitDefaultValue=false)]
        public decimal Value { get; set; }

        /// <summary>
        /// Gets or Sets Uplift
        /// </summary>
        [DataMember(Name="uplift", EmitDefaultValue=false)]
        public decimal Uplift { get; set; }

        /// <summary>
        /// Gets or Sets Trend
        /// </summary>
        [DataMember(Name="trend", EmitDefaultValue=false)]
        public decimal Trend { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ApplicationCampaignAnalyticsAvgSessionValue {\n");
            sb.Append("  Value: ").Append(Value).Append("\n");
            sb.Append("  Uplift: ").Append(Uplift).Append("\n");
            sb.Append("  Trend: ").Append(Trend).Append("\n");
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
            return this.Equals(input as ApplicationCampaignAnalyticsAvgSessionValue);
        }

        /// <summary>
        /// Returns true if ApplicationCampaignAnalyticsAvgSessionValue instances are equal
        /// </summary>
        /// <param name="input">Instance of ApplicationCampaignAnalyticsAvgSessionValue to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(ApplicationCampaignAnalyticsAvgSessionValue input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.Value == input.Value ||
                    this.Value.Equals(input.Value)
                ) && 
                (
                    this.Uplift == input.Uplift ||
                    this.Uplift.Equals(input.Uplift)
                ) && 
                (
                    this.Trend == input.Trend ||
                    this.Trend.Equals(input.Trend)
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
                hashCode = hashCode * 59 + this.Value.GetHashCode();
                hashCode = hashCode * 59 + this.Uplift.GetHashCode();
                hashCode = hashCode * 59 + this.Trend.GetHashCode();
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
