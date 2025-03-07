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
    /// The properties specific to the \&quot;rollbackAddedLoyaltyPoints\&quot; effect. This gets triggered whenever previously a closed session with an addLoyaltyPoints effect is cancelled.
    /// </summary>
    [DataContract]
    public partial class RollbackAddedLoyaltyPointsEffectProps :  IEquatable<RollbackAddedLoyaltyPointsEffectProps>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="RollbackAddedLoyaltyPointsEffectProps" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected RollbackAddedLoyaltyPointsEffectProps() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="RollbackAddedLoyaltyPointsEffectProps" /> class.
        /// </summary>
        /// <param name="programId">The ID of the loyalty program where the points were originally added. (required).</param>
        /// <param name="subLedgerId">The ID of the subledger within the loyalty program where these points were originally added. (required).</param>
        /// <param name="value">The amount of points that were rolled back. (required).</param>
        /// <param name="recipientIntegrationId">The user for whom these points were originally added. (required).</param>
        /// <param name="transactionUUID">The identifier of &#39;deduction&#39; entry added to the ledger as the &#x60;addLoyaltyPoints&#x60; effect is rolled back. (required).</param>
        /// <param name="cartItemPosition">The index of the item in the cart items for which the loyalty points were rolled back..</param>
        /// <param name="cartItemSubPosition">For cart items with &#x60;quantity&#x60; &gt; 1, the sub-position indicates to which item the loyalty points were rolled back. .</param>
        /// <param name="cardIdentifier">The alphanumeric identifier of the loyalty card. .</param>
        public RollbackAddedLoyaltyPointsEffectProps(int programId = default(int), string subLedgerId = default(string), decimal value = default(decimal), string recipientIntegrationId = default(string), string transactionUUID = default(string), decimal cartItemPosition = default(decimal), decimal cartItemSubPosition = default(decimal), string cardIdentifier = default(string))
        {
            this.ProgramId = programId;
            // to ensure "subLedgerId" is required (not null)
            this.SubLedgerId = subLedgerId ?? throw new ArgumentNullException("subLedgerId is a required property for RollbackAddedLoyaltyPointsEffectProps and cannot be null");
            this.Value = value;
            // to ensure "recipientIntegrationId" is required (not null)
            this.RecipientIntegrationId = recipientIntegrationId ?? throw new ArgumentNullException("recipientIntegrationId is a required property for RollbackAddedLoyaltyPointsEffectProps and cannot be null");
            // to ensure "transactionUUID" is required (not null)
            this.TransactionUUID = transactionUUID ?? throw new ArgumentNullException("transactionUUID is a required property for RollbackAddedLoyaltyPointsEffectProps and cannot be null");
            this.CartItemPosition = cartItemPosition;
            this.CartItemSubPosition = cartItemSubPosition;
            this.CardIdentifier = cardIdentifier;
        }
        
        /// <summary>
        /// The ID of the loyalty program where the points were originally added.
        /// </summary>
        /// <value>The ID of the loyalty program where the points were originally added.</value>
        [DataMember(Name="programId", EmitDefaultValue=false)]
        public int ProgramId { get; set; }

        /// <summary>
        /// The ID of the subledger within the loyalty program where these points were originally added.
        /// </summary>
        /// <value>The ID of the subledger within the loyalty program where these points were originally added.</value>
        [DataMember(Name="subLedgerId", EmitDefaultValue=false)]
        public string SubLedgerId { get; set; }

        /// <summary>
        /// The amount of points that were rolled back.
        /// </summary>
        /// <value>The amount of points that were rolled back.</value>
        [DataMember(Name="value", EmitDefaultValue=false)]
        public decimal Value { get; set; }

        /// <summary>
        /// The user for whom these points were originally added.
        /// </summary>
        /// <value>The user for whom these points were originally added.</value>
        [DataMember(Name="recipientIntegrationId", EmitDefaultValue=false)]
        public string RecipientIntegrationId { get; set; }

        /// <summary>
        /// The identifier of &#39;deduction&#39; entry added to the ledger as the &#x60;addLoyaltyPoints&#x60; effect is rolled back.
        /// </summary>
        /// <value>The identifier of &#39;deduction&#39; entry added to the ledger as the &#x60;addLoyaltyPoints&#x60; effect is rolled back.</value>
        [DataMember(Name="transactionUUID", EmitDefaultValue=false)]
        public string TransactionUUID { get; set; }

        /// <summary>
        /// The index of the item in the cart items for which the loyalty points were rolled back.
        /// </summary>
        /// <value>The index of the item in the cart items for which the loyalty points were rolled back.</value>
        [DataMember(Name="cartItemPosition", EmitDefaultValue=false)]
        public decimal CartItemPosition { get; set; }

        /// <summary>
        /// For cart items with &#x60;quantity&#x60; &gt; 1, the sub-position indicates to which item the loyalty points were rolled back. 
        /// </summary>
        /// <value>For cart items with &#x60;quantity&#x60; &gt; 1, the sub-position indicates to which item the loyalty points were rolled back. </value>
        [DataMember(Name="cartItemSubPosition", EmitDefaultValue=false)]
        public decimal CartItemSubPosition { get; set; }

        /// <summary>
        /// The alphanumeric identifier of the loyalty card. 
        /// </summary>
        /// <value>The alphanumeric identifier of the loyalty card. </value>
        [DataMember(Name="cardIdentifier", EmitDefaultValue=false)]
        public string CardIdentifier { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class RollbackAddedLoyaltyPointsEffectProps {\n");
            sb.Append("  ProgramId: ").Append(ProgramId).Append("\n");
            sb.Append("  SubLedgerId: ").Append(SubLedgerId).Append("\n");
            sb.Append("  Value: ").Append(Value).Append("\n");
            sb.Append("  RecipientIntegrationId: ").Append(RecipientIntegrationId).Append("\n");
            sb.Append("  TransactionUUID: ").Append(TransactionUUID).Append("\n");
            sb.Append("  CartItemPosition: ").Append(CartItemPosition).Append("\n");
            sb.Append("  CartItemSubPosition: ").Append(CartItemSubPosition).Append("\n");
            sb.Append("  CardIdentifier: ").Append(CardIdentifier).Append("\n");
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
            return this.Equals(input as RollbackAddedLoyaltyPointsEffectProps);
        }

        /// <summary>
        /// Returns true if RollbackAddedLoyaltyPointsEffectProps instances are equal
        /// </summary>
        /// <param name="input">Instance of RollbackAddedLoyaltyPointsEffectProps to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(RollbackAddedLoyaltyPointsEffectProps input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.ProgramId == input.ProgramId ||
                    this.ProgramId.Equals(input.ProgramId)
                ) && 
                (
                    this.SubLedgerId == input.SubLedgerId ||
                    (this.SubLedgerId != null &&
                    this.SubLedgerId.Equals(input.SubLedgerId))
                ) && 
                (
                    this.Value == input.Value ||
                    this.Value.Equals(input.Value)
                ) && 
                (
                    this.RecipientIntegrationId == input.RecipientIntegrationId ||
                    (this.RecipientIntegrationId != null &&
                    this.RecipientIntegrationId.Equals(input.RecipientIntegrationId))
                ) && 
                (
                    this.TransactionUUID == input.TransactionUUID ||
                    (this.TransactionUUID != null &&
                    this.TransactionUUID.Equals(input.TransactionUUID))
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
                    this.CardIdentifier == input.CardIdentifier ||
                    (this.CardIdentifier != null &&
                    this.CardIdentifier.Equals(input.CardIdentifier))
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
                hashCode = hashCode * 59 + this.ProgramId.GetHashCode();
                if (this.SubLedgerId != null)
                    hashCode = hashCode * 59 + this.SubLedgerId.GetHashCode();
                hashCode = hashCode * 59 + this.Value.GetHashCode();
                if (this.RecipientIntegrationId != null)
                    hashCode = hashCode * 59 + this.RecipientIntegrationId.GetHashCode();
                if (this.TransactionUUID != null)
                    hashCode = hashCode * 59 + this.TransactionUUID.GetHashCode();
                hashCode = hashCode * 59 + this.CartItemPosition.GetHashCode();
                hashCode = hashCode * 59 + this.CartItemSubPosition.GetHashCode();
                if (this.CardIdentifier != null)
                    hashCode = hashCode * 59 + this.CardIdentifier.GetHashCode();
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
            // RecipientIntegrationId (string) maxLength
            if(this.RecipientIntegrationId != null && this.RecipientIntegrationId.Length > 1000)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for RecipientIntegrationId, length must be less than 1000.", new [] { "RecipientIntegrationId" });
            }

            // CardIdentifier (string) maxLength
            if(this.CardIdentifier != null && this.CardIdentifier.Length > 108)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for CardIdentifier, length must be less than 108.", new [] { "CardIdentifier" });
            }

            // CardIdentifier (string) pattern
            Regex regexCardIdentifier = new Regex(@"^[A-Za-z0-9_-]*$", RegexOptions.CultureInvariant);
            if (false == regexCardIdentifier.Match(this.CardIdentifier).Success)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for CardIdentifier, must match a pattern of " + regexCardIdentifier, new [] { "CardIdentifier" });
            }

            yield break;
        }
    }

}
