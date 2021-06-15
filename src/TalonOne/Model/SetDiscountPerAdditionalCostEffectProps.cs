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
    /// The properties specific to the \&quot;setDiscountPerAdditionalCost\&quot; effect. This gets triggered whenever a validated rule contained a \&quot;set per additional cost discount\&quot; effect. This is a discount that should be applied on a specific additional cost.
    /// </summary>
    [DataContract]
    public partial class SetDiscountPerAdditionalCostEffectProps :  IEquatable<SetDiscountPerAdditionalCostEffectProps>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="SetDiscountPerAdditionalCostEffectProps" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected SetDiscountPerAdditionalCostEffectProps() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="SetDiscountPerAdditionalCostEffectProps" /> class.
        /// </summary>
        /// <param name="name">The name/description of this discount (required).</param>
        /// <param name="additionalCostId">The ID of the additional cost (required).</param>
        /// <param name="additionalCost">The name of the additional cost (required).</param>
        /// <param name="value">The total monetary value of the discount (required).</param>
        public SetDiscountPerAdditionalCostEffectProps(string name = default(string), int additionalCostId = default(int), string additionalCost = default(string), decimal value = default(decimal))
        {
            // to ensure "name" is required (not null)
            this.Name = name ?? throw new ArgumentNullException("name is a required property for SetDiscountPerAdditionalCostEffectProps and cannot be null");
            this.AdditionalCostId = additionalCostId;
            // to ensure "additionalCost" is required (not null)
            this.AdditionalCost = additionalCost ?? throw new ArgumentNullException("additionalCost is a required property for SetDiscountPerAdditionalCostEffectProps and cannot be null");
            this.Value = value;
        }
        
        /// <summary>
        /// The name/description of this discount
        /// </summary>
        /// <value>The name/description of this discount</value>
        [DataMember(Name="name", EmitDefaultValue=false)]
        public string Name { get; set; }

        /// <summary>
        /// The ID of the additional cost
        /// </summary>
        /// <value>The ID of the additional cost</value>
        [DataMember(Name="additionalCostId", EmitDefaultValue=false)]
        public int AdditionalCostId { get; set; }

        /// <summary>
        /// The name of the additional cost
        /// </summary>
        /// <value>The name of the additional cost</value>
        [DataMember(Name="additionalCost", EmitDefaultValue=false)]
        public string AdditionalCost { get; set; }

        /// <summary>
        /// The total monetary value of the discount
        /// </summary>
        /// <value>The total monetary value of the discount</value>
        [DataMember(Name="value", EmitDefaultValue=false)]
        public decimal Value { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class SetDiscountPerAdditionalCostEffectProps {\n");
            sb.Append("  Name: ").Append(Name).Append("\n");
            sb.Append("  AdditionalCostId: ").Append(AdditionalCostId).Append("\n");
            sb.Append("  AdditionalCost: ").Append(AdditionalCost).Append("\n");
            sb.Append("  Value: ").Append(Value).Append("\n");
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
            return this.Equals(input as SetDiscountPerAdditionalCostEffectProps);
        }

        /// <summary>
        /// Returns true if SetDiscountPerAdditionalCostEffectProps instances are equal
        /// </summary>
        /// <param name="input">Instance of SetDiscountPerAdditionalCostEffectProps to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(SetDiscountPerAdditionalCostEffectProps input)
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
                    this.AdditionalCostId == input.AdditionalCostId ||
                    this.AdditionalCostId.Equals(input.AdditionalCostId)
                ) && 
                (
                    this.AdditionalCost == input.AdditionalCost ||
                    (this.AdditionalCost != null &&
                    this.AdditionalCost.Equals(input.AdditionalCost))
                ) && 
                (
                    this.Value == input.Value ||
                    this.Value.Equals(input.Value)
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
                hashCode = hashCode * 59 + this.AdditionalCostId.GetHashCode();
                if (this.AdditionalCost != null)
                    hashCode = hashCode * 59 + this.AdditionalCost.GetHashCode();
                hashCode = hashCode * 59 + this.Value.GetHashCode();
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
