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
    /// GenerateRuleTitleRule
    /// </summary>
    [DataContract]
    public partial class GenerateRuleTitleRule :  IEquatable<GenerateRuleTitleRule>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="GenerateRuleTitleRule" /> class.
        /// </summary>
        /// <param name="effects">An array of effectful Talang expressions in arrays that will be evaluated when a rule matches..</param>
        /// <param name="condition">A Talang expression that will be evaluated in the context of the given event..</param>
        public GenerateRuleTitleRule(List<Object> effects = default(List<Object>), List<Object> condition = default(List<Object>))
        {
            this.Effects = effects;
            this.Condition = condition;
        }
        
        /// <summary>
        /// An array of effectful Talang expressions in arrays that will be evaluated when a rule matches.
        /// </summary>
        /// <value>An array of effectful Talang expressions in arrays that will be evaluated when a rule matches.</value>
        [DataMember(Name="effects", EmitDefaultValue=false)]
        public List<Object> Effects { get; set; }

        /// <summary>
        /// A Talang expression that will be evaluated in the context of the given event.
        /// </summary>
        /// <value>A Talang expression that will be evaluated in the context of the given event.</value>
        [DataMember(Name="condition", EmitDefaultValue=false)]
        public List<Object> Condition { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class GenerateRuleTitleRule {\n");
            sb.Append("  Effects: ").Append(Effects).Append("\n");
            sb.Append("  Condition: ").Append(Condition).Append("\n");
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
            return this.Equals(input as GenerateRuleTitleRule);
        }

        /// <summary>
        /// Returns true if GenerateRuleTitleRule instances are equal
        /// </summary>
        /// <param name="input">Instance of GenerateRuleTitleRule to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(GenerateRuleTitleRule input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.Effects == input.Effects ||
                    this.Effects != null &&
                    input.Effects != null &&
                    this.Effects.SequenceEqual(input.Effects)
                ) && 
                (
                    this.Condition == input.Condition ||
                    this.Condition != null &&
                    input.Condition != null &&
                    this.Condition.SequenceEqual(input.Condition)
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
                if (this.Effects != null)
                    hashCode = hashCode * 59 + this.Effects.GetHashCode();
                if (this.Condition != null)
                    hashCode = hashCode * 59 + this.Condition.GetHashCode();
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
