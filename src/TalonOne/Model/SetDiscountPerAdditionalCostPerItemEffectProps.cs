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
    /// The properties specific to the \&quot;setDiscountPerAdditionalCostPerItem\&quot; effect. This gets triggered whenever a validated rule contained a \&quot;set discount per additional cost per item\&quot; effect. This is a discount that should be applied on a specific additional cost in a specific item.
    /// </summary>
    [DataContract]
    public partial class SetDiscountPerAdditionalCostPerItemEffectProps :  IEquatable<SetDiscountPerAdditionalCostPerItemEffectProps>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="SetDiscountPerAdditionalCostPerItemEffectProps" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected SetDiscountPerAdditionalCostPerItemEffectProps() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="SetDiscountPerAdditionalCostPerItemEffectProps" /> class.
        /// </summary>
        /// <param name="name">The name / description of this discount (required).</param>
        /// <param name="additionalCostId">The ID of the additional cost. (required).</param>
        /// <param name="value">The total monetary value of the discount. (required).</param>
        /// <param name="position">The index of the item in the cart item list containing the additional cost to be discounted. (required).</param>
        /// <param name="subPosition">Only used when [cart item flattening](https://docs.talon.one/docs/product/campaigns/campaign-evaluation#flattening) is enabled. Indicates which item the discount applies to for cart items with &#x60;quantity&#x60; &gt; 1. .</param>
        /// <param name="additionalCost">The name of the additional cost. (required).</param>
        /// <param name="desiredValue">Only with [partial discounts enabled](https://docs.talon.one/docs/product/campaigns/campaign-evaluation/#partial-discounts). Represents the monetary value of the discount to be applied to additional discount without considering budget limitations. .</param>
        public SetDiscountPerAdditionalCostPerItemEffectProps(string name = default(string), int additionalCostId = default(int), decimal value = default(decimal), decimal position = default(decimal), decimal subPosition = default(decimal), string additionalCost = default(string), decimal desiredValue = default(decimal))
        {
            // to ensure "name" is required (not null)
            this.Name = name ?? throw new ArgumentNullException("name is a required property for SetDiscountPerAdditionalCostPerItemEffectProps and cannot be null");
            this.AdditionalCostId = additionalCostId;
            this.Value = value;
            this.Position = position;
            // to ensure "additionalCost" is required (not null)
            this.AdditionalCost = additionalCost ?? throw new ArgumentNullException("additionalCost is a required property for SetDiscountPerAdditionalCostPerItemEffectProps and cannot be null");
            this.SubPosition = subPosition;
            this.DesiredValue = desiredValue;
        }
        
        /// <summary>
        /// The name / description of this discount
        /// </summary>
        /// <value>The name / description of this discount</value>
        [DataMember(Name="name", EmitDefaultValue=false)]
        public string Name { get; set; }

        /// <summary>
        /// The ID of the additional cost.
        /// </summary>
        /// <value>The ID of the additional cost.</value>
        [DataMember(Name="additionalCostId", EmitDefaultValue=false)]
        public int AdditionalCostId { get; set; }

        /// <summary>
        /// The total monetary value of the discount.
        /// </summary>
        /// <value>The total monetary value of the discount.</value>
        [DataMember(Name="value", EmitDefaultValue=false)]
        public decimal Value { get; set; }

        /// <summary>
        /// The index of the item in the cart item list containing the additional cost to be discounted.
        /// </summary>
        /// <value>The index of the item in the cart item list containing the additional cost to be discounted.</value>
        [DataMember(Name="position", EmitDefaultValue=false)]
        public decimal Position { get; set; }

        /// <summary>
        /// Only used when [cart item flattening](https://docs.talon.one/docs/product/campaigns/campaign-evaluation#flattening) is enabled. Indicates which item the discount applies to for cart items with &#x60;quantity&#x60; &gt; 1. 
        /// </summary>
        /// <value>Only used when [cart item flattening](https://docs.talon.one/docs/product/campaigns/campaign-evaluation#flattening) is enabled. Indicates which item the discount applies to for cart items with &#x60;quantity&#x60; &gt; 1. </value>
        [DataMember(Name="subPosition", EmitDefaultValue=false)]
        public decimal SubPosition { get; set; }

        /// <summary>
        /// The name of the additional cost.
        /// </summary>
        /// <value>The name of the additional cost.</value>
        [DataMember(Name="additionalCost", EmitDefaultValue=false)]
        public string AdditionalCost { get; set; }

        /// <summary>
        /// Only with [partial discounts enabled](https://docs.talon.one/docs/product/campaigns/campaign-evaluation/#partial-discounts). Represents the monetary value of the discount to be applied to additional discount without considering budget limitations. 
        /// </summary>
        /// <value>Only with [partial discounts enabled](https://docs.talon.one/docs/product/campaigns/campaign-evaluation/#partial-discounts). Represents the monetary value of the discount to be applied to additional discount without considering budget limitations. </value>
        [DataMember(Name="desiredValue", EmitDefaultValue=false)]
        public decimal DesiredValue { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class SetDiscountPerAdditionalCostPerItemEffectProps {\n");
            sb.Append("  Name: ").Append(Name).Append("\n");
            sb.Append("  AdditionalCostId: ").Append(AdditionalCostId).Append("\n");
            sb.Append("  Value: ").Append(Value).Append("\n");
            sb.Append("  Position: ").Append(Position).Append("\n");
            sb.Append("  SubPosition: ").Append(SubPosition).Append("\n");
            sb.Append("  AdditionalCost: ").Append(AdditionalCost).Append("\n");
            sb.Append("  DesiredValue: ").Append(DesiredValue).Append("\n");
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
            return this.Equals(input as SetDiscountPerAdditionalCostPerItemEffectProps);
        }

        /// <summary>
        /// Returns true if SetDiscountPerAdditionalCostPerItemEffectProps instances are equal
        /// </summary>
        /// <param name="input">Instance of SetDiscountPerAdditionalCostPerItemEffectProps to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(SetDiscountPerAdditionalCostPerItemEffectProps input)
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
                    this.Value == input.Value ||
                    this.Value.Equals(input.Value)
                ) && 
                (
                    this.Position == input.Position ||
                    this.Position.Equals(input.Position)
                ) && 
                (
                    this.SubPosition == input.SubPosition ||
                    this.SubPosition.Equals(input.SubPosition)
                ) && 
                (
                    this.AdditionalCost == input.AdditionalCost ||
                    (this.AdditionalCost != null &&
                    this.AdditionalCost.Equals(input.AdditionalCost))
                ) && 
                (
                    this.DesiredValue == input.DesiredValue ||
                    this.DesiredValue.Equals(input.DesiredValue)
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
                hashCode = hashCode * 59 + this.Value.GetHashCode();
                hashCode = hashCode * 59 + this.Position.GetHashCode();
                hashCode = hashCode * 59 + this.SubPosition.GetHashCode();
                if (this.AdditionalCost != null)
                    hashCode = hashCode * 59 + this.AdditionalCost.GetHashCode();
                hashCode = hashCode * 59 + this.DesiredValue.GetHashCode();
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
