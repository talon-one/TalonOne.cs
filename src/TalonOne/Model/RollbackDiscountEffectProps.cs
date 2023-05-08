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
    /// The properties specific to the \&quot;rollbackDiscount\&quot; effect. This gets triggered whenever previously closed session is now cancelled or partially returned and a setDiscount effect was cancelled on our internal discount limit counters.
    /// </summary>
    [DataContract]
    public partial class RollbackDiscountEffectProps :  IEquatable<RollbackDiscountEffectProps>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="RollbackDiscountEffectProps" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected RollbackDiscountEffectProps() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="RollbackDiscountEffectProps" /> class.
        /// </summary>
        /// <param name="name">The name of the \&quot;setDiscount\&quot; effect that was rolled back. (required).</param>
        /// <param name="value">The value of the discount that was rolled back. (required).</param>
        /// <param name="cartItemPosition">The index of the item in the cart items for which the discount was rolled back..</param>
        /// <param name="cartItemSubPosition">The index of the item unit in its line item. It is only used for cart items with &#x60;quantity&#x60; &gt; 1 and is only returned when cart item flattening is enabled. .</param>
        /// <param name="additionalCostId">The ID of the additional cost that was rolled back..</param>
        /// <param name="additionalCost">The name of the additional cost that was rolled back..</param>
        /// <param name="scope">The scope of the rolled back discount - For a discount per session, it can be one of &#x60;cartItems&#x60;, &#x60;additionalCosts&#x60; or &#x60;sessionTotal&#x60; - For a discount per item, it can be one of &#x60;price&#x60;, &#x60;additionalCosts&#x60; or &#x60;itemTotal&#x60; .</param>
        public RollbackDiscountEffectProps(string name = default(string), decimal value = default(decimal), decimal cartItemPosition = default(decimal), decimal cartItemSubPosition = default(decimal), int additionalCostId = default(int), string additionalCost = default(string), string scope = default(string))
        {
            // to ensure "name" is required (not null)
            this.Name = name ?? throw new ArgumentNullException("name is a required property for RollbackDiscountEffectProps and cannot be null");
            this.Value = value;
            this.CartItemPosition = cartItemPosition;
            this.CartItemSubPosition = cartItemSubPosition;
            this.AdditionalCostId = additionalCostId;
            this.AdditionalCost = additionalCost;
            this.Scope = scope;
        }
        
        /// <summary>
        /// The name of the \&quot;setDiscount\&quot; effect that was rolled back.
        /// </summary>
        /// <value>The name of the \&quot;setDiscount\&quot; effect that was rolled back.</value>
        [DataMember(Name="name", EmitDefaultValue=false)]
        public string Name { get; set; }

        /// <summary>
        /// The value of the discount that was rolled back.
        /// </summary>
        /// <value>The value of the discount that was rolled back.</value>
        [DataMember(Name="value", EmitDefaultValue=false)]
        public decimal Value { get; set; }

        /// <summary>
        /// The index of the item in the cart items for which the discount was rolled back.
        /// </summary>
        /// <value>The index of the item in the cart items for which the discount was rolled back.</value>
        [DataMember(Name="cartItemPosition", EmitDefaultValue=false)]
        public decimal CartItemPosition { get; set; }

        /// <summary>
        /// The index of the item unit in its line item. It is only used for cart items with &#x60;quantity&#x60; &gt; 1 and is only returned when cart item flattening is enabled. 
        /// </summary>
        /// <value>The index of the item unit in its line item. It is only used for cart items with &#x60;quantity&#x60; &gt; 1 and is only returned when cart item flattening is enabled. </value>
        [DataMember(Name="cartItemSubPosition", EmitDefaultValue=false)]
        public decimal CartItemSubPosition { get; set; }

        /// <summary>
        /// The ID of the additional cost that was rolled back.
        /// </summary>
        /// <value>The ID of the additional cost that was rolled back.</value>
        [DataMember(Name="additionalCostId", EmitDefaultValue=false)]
        public int AdditionalCostId { get; set; }

        /// <summary>
        /// The name of the additional cost that was rolled back.
        /// </summary>
        /// <value>The name of the additional cost that was rolled back.</value>
        [DataMember(Name="additionalCost", EmitDefaultValue=false)]
        public string AdditionalCost { get; set; }

        /// <summary>
        /// The scope of the rolled back discount - For a discount per session, it can be one of &#x60;cartItems&#x60;, &#x60;additionalCosts&#x60; or &#x60;sessionTotal&#x60; - For a discount per item, it can be one of &#x60;price&#x60;, &#x60;additionalCosts&#x60; or &#x60;itemTotal&#x60; 
        /// </summary>
        /// <value>The scope of the rolled back discount - For a discount per session, it can be one of &#x60;cartItems&#x60;, &#x60;additionalCosts&#x60; or &#x60;sessionTotal&#x60; - For a discount per item, it can be one of &#x60;price&#x60;, &#x60;additionalCosts&#x60; or &#x60;itemTotal&#x60; </value>
        [DataMember(Name="scope", EmitDefaultValue=false)]
        public string Scope { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class RollbackDiscountEffectProps {\n");
            sb.Append("  Name: ").Append(Name).Append("\n");
            sb.Append("  Value: ").Append(Value).Append("\n");
            sb.Append("  CartItemPosition: ").Append(CartItemPosition).Append("\n");
            sb.Append("  CartItemSubPosition: ").Append(CartItemSubPosition).Append("\n");
            sb.Append("  AdditionalCostId: ").Append(AdditionalCostId).Append("\n");
            sb.Append("  AdditionalCost: ").Append(AdditionalCost).Append("\n");
            sb.Append("  Scope: ").Append(Scope).Append("\n");
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
            return this.Equals(input as RollbackDiscountEffectProps);
        }

        /// <summary>
        /// Returns true if RollbackDiscountEffectProps instances are equal
        /// </summary>
        /// <param name="input">Instance of RollbackDiscountEffectProps to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(RollbackDiscountEffectProps input)
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
                    this.CartItemPosition == input.CartItemPosition ||
                    this.CartItemPosition.Equals(input.CartItemPosition)
                ) && 
                (
                    this.CartItemSubPosition == input.CartItemSubPosition ||
                    this.CartItemSubPosition.Equals(input.CartItemSubPosition)
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
                    this.Scope == input.Scope ||
                    (this.Scope != null &&
                    this.Scope.Equals(input.Scope))
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
                hashCode = hashCode * 59 + this.CartItemPosition.GetHashCode();
                hashCode = hashCode * 59 + this.CartItemSubPosition.GetHashCode();
                hashCode = hashCode * 59 + this.AdditionalCostId.GetHashCode();
                if (this.AdditionalCost != null)
                    hashCode = hashCode * 59 + this.AdditionalCost.GetHashCode();
                if (this.Scope != null)
                    hashCode = hashCode * 59 + this.Scope.GetHashCode();
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
