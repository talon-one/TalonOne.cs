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
    /// Contains information about hidden conditions and effects in the Application.
    /// </summary>
    [DataContract]
    public partial class HiddenConditionsEffects :  IEquatable<HiddenConditionsEffects>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="HiddenConditionsEffects" /> class.
        /// </summary>
        /// <param name="builtInEffects">List of hidden built-in effects..</param>
        /// <param name="conditions">List of hidden conditions..</param>
        /// <param name="customEffects">List of the IDs of hidden custom effects..</param>
        /// <param name="webhooks">List of the IDs of hidden webhooks..</param>
        public HiddenConditionsEffects(List<string> builtInEffects = default(List<string>), List<string> conditions = default(List<string>), List<int> customEffects = default(List<int>), List<int> webhooks = default(List<int>))
        {
            this.BuiltInEffects = builtInEffects;
            this.Conditions = conditions;
            this.CustomEffects = customEffects;
            this.Webhooks = webhooks;
        }
        
        /// <summary>
        /// List of hidden built-in effects.
        /// </summary>
        /// <value>List of hidden built-in effects.</value>
        [DataMember(Name="builtInEffects", EmitDefaultValue=false)]
        public List<string> BuiltInEffects { get; set; }

        /// <summary>
        /// List of hidden conditions.
        /// </summary>
        /// <value>List of hidden conditions.</value>
        [DataMember(Name="conditions", EmitDefaultValue=false)]
        public List<string> Conditions { get; set; }

        /// <summary>
        /// List of the IDs of hidden custom effects.
        /// </summary>
        /// <value>List of the IDs of hidden custom effects.</value>
        [DataMember(Name="customEffects", EmitDefaultValue=false)]
        public List<int> CustomEffects { get; set; }

        /// <summary>
        /// List of the IDs of hidden webhooks.
        /// </summary>
        /// <value>List of the IDs of hidden webhooks.</value>
        [DataMember(Name="webhooks", EmitDefaultValue=false)]
        public List<int> Webhooks { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class HiddenConditionsEffects {\n");
            sb.Append("  BuiltInEffects: ").Append(BuiltInEffects).Append("\n");
            sb.Append("  Conditions: ").Append(Conditions).Append("\n");
            sb.Append("  CustomEffects: ").Append(CustomEffects).Append("\n");
            sb.Append("  Webhooks: ").Append(Webhooks).Append("\n");
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
            return this.Equals(input as HiddenConditionsEffects);
        }

        /// <summary>
        /// Returns true if HiddenConditionsEffects instances are equal
        /// </summary>
        /// <param name="input">Instance of HiddenConditionsEffects to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(HiddenConditionsEffects input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.BuiltInEffects == input.BuiltInEffects ||
                    this.BuiltInEffects != null &&
                    input.BuiltInEffects != null &&
                    this.BuiltInEffects.SequenceEqual(input.BuiltInEffects)
                ) && 
                (
                    this.Conditions == input.Conditions ||
                    this.Conditions != null &&
                    input.Conditions != null &&
                    this.Conditions.SequenceEqual(input.Conditions)
                ) && 
                (
                    this.CustomEffects == input.CustomEffects ||
                    this.CustomEffects != null &&
                    input.CustomEffects != null &&
                    this.CustomEffects.SequenceEqual(input.CustomEffects)
                ) && 
                (
                    this.Webhooks == input.Webhooks ||
                    this.Webhooks != null &&
                    input.Webhooks != null &&
                    this.Webhooks.SequenceEqual(input.Webhooks)
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
                if (this.BuiltInEffects != null)
                    hashCode = hashCode * 59 + this.BuiltInEffects.GetHashCode();
                if (this.Conditions != null)
                    hashCode = hashCode * 59 + this.Conditions.GetHashCode();
                if (this.CustomEffects != null)
                    hashCode = hashCode * 59 + this.CustomEffects.GetHashCode();
                if (this.Webhooks != null)
                    hashCode = hashCode * 59 + this.Webhooks.GetHashCode();
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
