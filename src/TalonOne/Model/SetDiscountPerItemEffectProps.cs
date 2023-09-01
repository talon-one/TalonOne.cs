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
    /// The properties specific to the &#x60;setDiscountPerItem&#x60; effect, triggered whenever a validated rule contained a \&quot;set per item discount\&quot; effect. This is a discount that will be applied either on a specific item, on a specific item + additional cost or on all additional costs per item. This depends on the chosen scope. 
    /// </summary>
    [DataContract]
    public partial class SetDiscountPerItemEffectProps :  IEquatable<SetDiscountPerItemEffectProps>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="SetDiscountPerItemEffectProps" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected SetDiscountPerItemEffectProps() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="SetDiscountPerItemEffectProps" /> class.
        /// </summary>
        /// <param name="name">The name of the discount. Contains a hashtag character indicating the index of the position of the item the discount applies to. It is identical to the value of the &#x60;position&#x60; property.  (required).</param>
        /// <param name="value">The total monetary value of the discount. (required).</param>
        /// <param name="position">The index of the item in the cart items list on which this discount should be applied. (required).</param>
        /// <param name="subPosition">Only used when [cart item flattening](https://docs.talon.one/docs/product/campaigns/managing-general-settings#flattening) is enabled. Indicates which item the discount applies to for cart items with &#x60;quantity&#x60; &gt; 1. .</param>
        /// <param name="desiredValue">The original value of the discount..</param>
        /// <param name="scope">The scope of the discount: - &#x60;additionalCosts&#x60;: The discount applies to all the additional costs of the item. - &#x60;itemTotal&#x60;: The discount applies to the price of the item + the additional costs of the item. - &#x60;price&#x60;: The discount applies to the price of the item. .</param>
        /// <param name="totalDiscount">The total discount given if this effect is a result of a prorated discount..</param>
        /// <param name="desiredTotalDiscount">The original total discount to give if this effect is a result of a prorated discount..</param>
        /// <param name="bundleIndex">The position of the bundle in a list of item bundles created from the same bundle definition..</param>
        /// <param name="bundleName">The name of the bundle definition..</param>
        public SetDiscountPerItemEffectProps(string name = default(string), decimal value = default(decimal), decimal position = default(decimal), decimal subPosition = default(decimal), decimal desiredValue = default(decimal), string scope = default(string), decimal totalDiscount = default(decimal), decimal desiredTotalDiscount = default(decimal), int bundleIndex = default(int), string bundleName = default(string))
        {
            // to ensure "name" is required (not null)
            this.Name = name ?? throw new ArgumentNullException("name is a required property for SetDiscountPerItemEffectProps and cannot be null");
            this.Value = value;
            this.Position = position;
            this.SubPosition = subPosition;
            this.DesiredValue = desiredValue;
            this.Scope = scope;
            this.TotalDiscount = totalDiscount;
            this.DesiredTotalDiscount = desiredTotalDiscount;
            this.BundleIndex = bundleIndex;
            this.BundleName = bundleName;
        }
        
        /// <summary>
        /// The name of the discount. Contains a hashtag character indicating the index of the position of the item the discount applies to. It is identical to the value of the &#x60;position&#x60; property. 
        /// </summary>
        /// <value>The name of the discount. Contains a hashtag character indicating the index of the position of the item the discount applies to. It is identical to the value of the &#x60;position&#x60; property. </value>
        [DataMember(Name="name", EmitDefaultValue=false)]
        public string Name { get; set; }

        /// <summary>
        /// The total monetary value of the discount.
        /// </summary>
        /// <value>The total monetary value of the discount.</value>
        [DataMember(Name="value", EmitDefaultValue=false)]
        public decimal Value { get; set; }

        /// <summary>
        /// The index of the item in the cart items list on which this discount should be applied.
        /// </summary>
        /// <value>The index of the item in the cart items list on which this discount should be applied.</value>
        [DataMember(Name="position", EmitDefaultValue=false)]
        public decimal Position { get; set; }

        /// <summary>
        /// Only used when [cart item flattening](https://docs.talon.one/docs/product/campaigns/managing-general-settings#flattening) is enabled. Indicates which item the discount applies to for cart items with &#x60;quantity&#x60; &gt; 1. 
        /// </summary>
        /// <value>Only used when [cart item flattening](https://docs.talon.one/docs/product/campaigns/managing-general-settings#flattening) is enabled. Indicates which item the discount applies to for cart items with &#x60;quantity&#x60; &gt; 1. </value>
        [DataMember(Name="subPosition", EmitDefaultValue=false)]
        public decimal SubPosition { get; set; }

        /// <summary>
        /// The original value of the discount.
        /// </summary>
        /// <value>The original value of the discount.</value>
        [DataMember(Name="desiredValue", EmitDefaultValue=false)]
        public decimal DesiredValue { get; set; }

        /// <summary>
        /// The scope of the discount: - &#x60;additionalCosts&#x60;: The discount applies to all the additional costs of the item. - &#x60;itemTotal&#x60;: The discount applies to the price of the item + the additional costs of the item. - &#x60;price&#x60;: The discount applies to the price of the item. 
        /// </summary>
        /// <value>The scope of the discount: - &#x60;additionalCosts&#x60;: The discount applies to all the additional costs of the item. - &#x60;itemTotal&#x60;: The discount applies to the price of the item + the additional costs of the item. - &#x60;price&#x60;: The discount applies to the price of the item. </value>
        [DataMember(Name="scope", EmitDefaultValue=false)]
        public string Scope { get; set; }

        /// <summary>
        /// The total discount given if this effect is a result of a prorated discount.
        /// </summary>
        /// <value>The total discount given if this effect is a result of a prorated discount.</value>
        [DataMember(Name="totalDiscount", EmitDefaultValue=false)]
        public decimal TotalDiscount { get; set; }

        /// <summary>
        /// The original total discount to give if this effect is a result of a prorated discount.
        /// </summary>
        /// <value>The original total discount to give if this effect is a result of a prorated discount.</value>
        [DataMember(Name="desiredTotalDiscount", EmitDefaultValue=false)]
        public decimal DesiredTotalDiscount { get; set; }

        /// <summary>
        /// The position of the bundle in a list of item bundles created from the same bundle definition.
        /// </summary>
        /// <value>The position of the bundle in a list of item bundles created from the same bundle definition.</value>
        [DataMember(Name="bundleIndex", EmitDefaultValue=false)]
        public int BundleIndex { get; set; }

        /// <summary>
        /// The name of the bundle definition.
        /// </summary>
        /// <value>The name of the bundle definition.</value>
        [DataMember(Name="bundleName", EmitDefaultValue=false)]
        public string BundleName { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class SetDiscountPerItemEffectProps {\n");
            sb.Append("  Name: ").Append(Name).Append("\n");
            sb.Append("  Value: ").Append(Value).Append("\n");
            sb.Append("  Position: ").Append(Position).Append("\n");
            sb.Append("  SubPosition: ").Append(SubPosition).Append("\n");
            sb.Append("  DesiredValue: ").Append(DesiredValue).Append("\n");
            sb.Append("  Scope: ").Append(Scope).Append("\n");
            sb.Append("  TotalDiscount: ").Append(TotalDiscount).Append("\n");
            sb.Append("  DesiredTotalDiscount: ").Append(DesiredTotalDiscount).Append("\n");
            sb.Append("  BundleIndex: ").Append(BundleIndex).Append("\n");
            sb.Append("  BundleName: ").Append(BundleName).Append("\n");
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
            return this.Equals(input as SetDiscountPerItemEffectProps);
        }

        /// <summary>
        /// Returns true if SetDiscountPerItemEffectProps instances are equal
        /// </summary>
        /// <param name="input">Instance of SetDiscountPerItemEffectProps to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(SetDiscountPerItemEffectProps input)
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
                    this.DesiredValue == input.DesiredValue ||
                    this.DesiredValue.Equals(input.DesiredValue)
                ) && 
                (
                    this.Scope == input.Scope ||
                    (this.Scope != null &&
                    this.Scope.Equals(input.Scope))
                ) && 
                (
                    this.TotalDiscount == input.TotalDiscount ||
                    this.TotalDiscount.Equals(input.TotalDiscount)
                ) && 
                (
                    this.DesiredTotalDiscount == input.DesiredTotalDiscount ||
                    this.DesiredTotalDiscount.Equals(input.DesiredTotalDiscount)
                ) && 
                (
                    this.BundleIndex == input.BundleIndex ||
                    this.BundleIndex.Equals(input.BundleIndex)
                ) && 
                (
                    this.BundleName == input.BundleName ||
                    (this.BundleName != null &&
                    this.BundleName.Equals(input.BundleName))
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
                hashCode = hashCode * 59 + this.Value.GetHashCode();
                hashCode = hashCode * 59 + this.Position.GetHashCode();
                hashCode = hashCode * 59 + this.SubPosition.GetHashCode();
                hashCode = hashCode * 59 + this.DesiredValue.GetHashCode();
                if (this.Scope != null)
                    hashCode = hashCode * 59 + this.Scope.GetHashCode();
                hashCode = hashCode * 59 + this.TotalDiscount.GetHashCode();
                hashCode = hashCode * 59 + this.DesiredTotalDiscount.GetHashCode();
                hashCode = hashCode * 59 + this.BundleIndex.GetHashCode();
                if (this.BundleName != null)
                    hashCode = hashCode * 59 + this.BundleName.GetHashCode();
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
