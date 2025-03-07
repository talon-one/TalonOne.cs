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
    /// The properties specific to the \&quot;addLoyaltyPoints\&quot; effect. This gets triggered whenever a validated rule contained an \&quot;add loyalty\&quot; effect. These points are automatically stored and managed inside Talon.One. 
    /// </summary>
    [DataContract]
    public partial class AddLoyaltyPointsEffectProps :  IEquatable<AddLoyaltyPointsEffectProps>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="AddLoyaltyPointsEffectProps" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected AddLoyaltyPointsEffectProps() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="AddLoyaltyPointsEffectProps" /> class.
        /// </summary>
        /// <param name="name">The name / description of this loyalty point addition. (required).</param>
        /// <param name="programId">The ID of the loyalty program where these points were added. (required).</param>
        /// <param name="subLedgerId">The ID of the subledger within the loyalty program where these points were added. (required).</param>
        /// <param name="value">The amount of points that were added. (required).</param>
        /// <param name="desiredValue">The original amount of loyalty points to be awarded..</param>
        /// <param name="recipientIntegrationId">The user for whom these points were added. (required).</param>
        /// <param name="startDate">Date after which points will be valid..</param>
        /// <param name="expiryDate">Date after which points will expire..</param>
        /// <param name="transactionUUID">The identifier of this addition in the loyalty ledger. (required).</param>
        /// <param name="cartItemPosition">The index of the item in the cart items list on which the loyal points addition should be applied..</param>
        /// <param name="cartItemSubPosition">For cart items with &#x60;quantity&#x60; &gt; 1, the sub position indicates to which item the loyalty points addition is applied. .</param>
        /// <param name="cardIdentifier">The alphanumeric identifier of the loyalty card. .</param>
        /// <param name="bundleIndex">The position of the bundle in a list of item bundles created from the same bundle definition..</param>
        /// <param name="bundleName">The name of the bundle definition..</param>
        public AddLoyaltyPointsEffectProps(string name = default(string), int programId = default(int), string subLedgerId = default(string), decimal value = default(decimal), decimal desiredValue = default(decimal), string recipientIntegrationId = default(string), DateTime startDate = default(DateTime), DateTime expiryDate = default(DateTime), string transactionUUID = default(string), decimal cartItemPosition = default(decimal), decimal cartItemSubPosition = default(decimal), string cardIdentifier = default(string), int bundleIndex = default(int), string bundleName = default(string))
        {
            // to ensure "name" is required (not null)
            this.Name = name ?? throw new ArgumentNullException("name is a required property for AddLoyaltyPointsEffectProps and cannot be null");
            this.ProgramId = programId;
            // to ensure "subLedgerId" is required (not null)
            this.SubLedgerId = subLedgerId ?? throw new ArgumentNullException("subLedgerId is a required property for AddLoyaltyPointsEffectProps and cannot be null");
            this.Value = value;
            // to ensure "recipientIntegrationId" is required (not null)
            this.RecipientIntegrationId = recipientIntegrationId ?? throw new ArgumentNullException("recipientIntegrationId is a required property for AddLoyaltyPointsEffectProps and cannot be null");
            // to ensure "transactionUUID" is required (not null)
            this.TransactionUUID = transactionUUID ?? throw new ArgumentNullException("transactionUUID is a required property for AddLoyaltyPointsEffectProps and cannot be null");
            this.DesiredValue = desiredValue;
            this.StartDate = startDate;
            this.ExpiryDate = expiryDate;
            this.CartItemPosition = cartItemPosition;
            this.CartItemSubPosition = cartItemSubPosition;
            this.CardIdentifier = cardIdentifier;
            this.BundleIndex = bundleIndex;
            this.BundleName = bundleName;
        }
        
        /// <summary>
        /// The name / description of this loyalty point addition.
        /// </summary>
        /// <value>The name / description of this loyalty point addition.</value>
        [DataMember(Name="name", EmitDefaultValue=false)]
        public string Name { get; set; }

        /// <summary>
        /// The ID of the loyalty program where these points were added.
        /// </summary>
        /// <value>The ID of the loyalty program where these points were added.</value>
        [DataMember(Name="programId", EmitDefaultValue=false)]
        public int ProgramId { get; set; }

        /// <summary>
        /// The ID of the subledger within the loyalty program where these points were added.
        /// </summary>
        /// <value>The ID of the subledger within the loyalty program where these points were added.</value>
        [DataMember(Name="subLedgerId", EmitDefaultValue=false)]
        public string SubLedgerId { get; set; }

        /// <summary>
        /// The amount of points that were added.
        /// </summary>
        /// <value>The amount of points that were added.</value>
        [DataMember(Name="value", EmitDefaultValue=false)]
        public decimal Value { get; set; }

        /// <summary>
        /// The original amount of loyalty points to be awarded.
        /// </summary>
        /// <value>The original amount of loyalty points to be awarded.</value>
        [DataMember(Name="desiredValue", EmitDefaultValue=false)]
        public decimal DesiredValue { get; set; }

        /// <summary>
        /// The user for whom these points were added.
        /// </summary>
        /// <value>The user for whom these points were added.</value>
        [DataMember(Name="recipientIntegrationId", EmitDefaultValue=false)]
        public string RecipientIntegrationId { get; set; }

        /// <summary>
        /// Date after which points will be valid.
        /// </summary>
        /// <value>Date after which points will be valid.</value>
        [DataMember(Name="startDate", EmitDefaultValue=false)]
        public DateTime StartDate { get; set; }

        /// <summary>
        /// Date after which points will expire.
        /// </summary>
        /// <value>Date after which points will expire.</value>
        [DataMember(Name="expiryDate", EmitDefaultValue=false)]
        public DateTime ExpiryDate { get; set; }

        /// <summary>
        /// The identifier of this addition in the loyalty ledger.
        /// </summary>
        /// <value>The identifier of this addition in the loyalty ledger.</value>
        [DataMember(Name="transactionUUID", EmitDefaultValue=false)]
        public string TransactionUUID { get; set; }

        /// <summary>
        /// The index of the item in the cart items list on which the loyal points addition should be applied.
        /// </summary>
        /// <value>The index of the item in the cart items list on which the loyal points addition should be applied.</value>
        [DataMember(Name="cartItemPosition", EmitDefaultValue=false)]
        public decimal CartItemPosition { get; set; }

        /// <summary>
        /// For cart items with &#x60;quantity&#x60; &gt; 1, the sub position indicates to which item the loyalty points addition is applied. 
        /// </summary>
        /// <value>For cart items with &#x60;quantity&#x60; &gt; 1, the sub position indicates to which item the loyalty points addition is applied. </value>
        [DataMember(Name="cartItemSubPosition", EmitDefaultValue=false)]
        public decimal CartItemSubPosition { get; set; }

        /// <summary>
        /// The alphanumeric identifier of the loyalty card. 
        /// </summary>
        /// <value>The alphanumeric identifier of the loyalty card. </value>
        [DataMember(Name="cardIdentifier", EmitDefaultValue=false)]
        public string CardIdentifier { get; set; }

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
            sb.Append("class AddLoyaltyPointsEffectProps {\n");
            sb.Append("  Name: ").Append(Name).Append("\n");
            sb.Append("  ProgramId: ").Append(ProgramId).Append("\n");
            sb.Append("  SubLedgerId: ").Append(SubLedgerId).Append("\n");
            sb.Append("  Value: ").Append(Value).Append("\n");
            sb.Append("  DesiredValue: ").Append(DesiredValue).Append("\n");
            sb.Append("  RecipientIntegrationId: ").Append(RecipientIntegrationId).Append("\n");
            sb.Append("  StartDate: ").Append(StartDate).Append("\n");
            sb.Append("  ExpiryDate: ").Append(ExpiryDate).Append("\n");
            sb.Append("  TransactionUUID: ").Append(TransactionUUID).Append("\n");
            sb.Append("  CartItemPosition: ").Append(CartItemPosition).Append("\n");
            sb.Append("  CartItemSubPosition: ").Append(CartItemSubPosition).Append("\n");
            sb.Append("  CardIdentifier: ").Append(CardIdentifier).Append("\n");
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
            return this.Equals(input as AddLoyaltyPointsEffectProps);
        }

        /// <summary>
        /// Returns true if AddLoyaltyPointsEffectProps instances are equal
        /// </summary>
        /// <param name="input">Instance of AddLoyaltyPointsEffectProps to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(AddLoyaltyPointsEffectProps input)
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
                    this.DesiredValue == input.DesiredValue ||
                    this.DesiredValue.Equals(input.DesiredValue)
                ) && 
                (
                    this.RecipientIntegrationId == input.RecipientIntegrationId ||
                    (this.RecipientIntegrationId != null &&
                    this.RecipientIntegrationId.Equals(input.RecipientIntegrationId))
                ) && 
                (
                    this.StartDate == input.StartDate ||
                    (this.StartDate != null &&
                    this.StartDate.Equals(input.StartDate))
                ) && 
                (
                    this.ExpiryDate == input.ExpiryDate ||
                    (this.ExpiryDate != null &&
                    this.ExpiryDate.Equals(input.ExpiryDate))
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
                hashCode = hashCode * 59 + this.ProgramId.GetHashCode();
                if (this.SubLedgerId != null)
                    hashCode = hashCode * 59 + this.SubLedgerId.GetHashCode();
                hashCode = hashCode * 59 + this.Value.GetHashCode();
                hashCode = hashCode * 59 + this.DesiredValue.GetHashCode();
                if (this.RecipientIntegrationId != null)
                    hashCode = hashCode * 59 + this.RecipientIntegrationId.GetHashCode();
                if (this.StartDate != null)
                    hashCode = hashCode * 59 + this.StartDate.GetHashCode();
                if (this.ExpiryDate != null)
                    hashCode = hashCode * 59 + this.ExpiryDate.GetHashCode();
                if (this.TransactionUUID != null)
                    hashCode = hashCode * 59 + this.TransactionUUID.GetHashCode();
                hashCode = hashCode * 59 + this.CartItemPosition.GetHashCode();
                hashCode = hashCode * 59 + this.CartItemSubPosition.GetHashCode();
                if (this.CardIdentifier != null)
                    hashCode = hashCode * 59 + this.CardIdentifier.GetHashCode();
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
