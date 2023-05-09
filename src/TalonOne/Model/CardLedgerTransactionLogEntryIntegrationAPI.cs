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
    /// Log entry for a given loyalty card transaction.
    /// </summary>
    [DataContract]
    public partial class CardLedgerTransactionLogEntryIntegrationAPI :  IEquatable<CardLedgerTransactionLogEntryIntegrationAPI>, IValidatableObject
    {
        /// <summary>
        /// Type of transaction. Possible values:   - &#x60;addition&#x60;: Signifies added points.   - &#x60;subtraction&#x60;: Signifies deducted points. 
        /// </summary>
        /// <value>Type of transaction. Possible values:   - &#x60;addition&#x60;: Signifies added points.   - &#x60;subtraction&#x60;: Signifies deducted points. </value>
        [JsonConverter(typeof(StringEnumConverter))]
        public enum TypeEnum
        {
            /// <summary>
            /// Enum Addition for value: addition
            /// </summary>
            [EnumMember(Value = "addition")]
            Addition = 1,

            /// <summary>
            /// Enum Subtraction for value: subtraction
            /// </summary>
            [EnumMember(Value = "subtraction")]
            Subtraction = 2

        }

        /// <summary>
        /// Type of transaction. Possible values:   - &#x60;addition&#x60;: Signifies added points.   - &#x60;subtraction&#x60;: Signifies deducted points. 
        /// </summary>
        /// <value>Type of transaction. Possible values:   - &#x60;addition&#x60;: Signifies added points.   - &#x60;subtraction&#x60;: Signifies deducted points. </value>
        [DataMember(Name="type", EmitDefaultValue=false)]
        public TypeEnum Type { get; set; }
        /// <summary>
        /// Initializes a new instance of the <see cref="CardLedgerTransactionLogEntryIntegrationAPI" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected CardLedgerTransactionLogEntryIntegrationAPI() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="CardLedgerTransactionLogEntryIntegrationAPI" /> class.
        /// </summary>
        /// <param name="created">Date and time the loyalty card transaction occurred. (required).</param>
        /// <param name="programId">ID of the loyalty program. (required).</param>
        /// <param name="cardIdentifier">The alphanumeric identifier of the loyalty card.  (required).</param>
        /// <param name="customerSessionId">ID of the customer session where the transaction occurred..</param>
        /// <param name="type">Type of transaction. Possible values:   - &#x60;addition&#x60;: Signifies added points.   - &#x60;subtraction&#x60;: Signifies deducted points.  (required).</param>
        /// <param name="name">Name or reason of the loyalty ledger transaction. (required).</param>
        /// <param name="startDate">When points become active. Possible values:   - &#x60;immediate&#x60;: Points are active immediately.   - a timestamp value: Points become active at a given date and time.  (required).</param>
        /// <param name="expiryDate">Date when points expire. Possible values are:   - &#x60;unlimited&#x60;: Points have no expiration date.   - &#x60;timestamp value&#x60;: Points expire on the given date.  (required).</param>
        /// <param name="subledgerId">ID of the subledger. (required).</param>
        /// <param name="amount">Amount of loyalty points added or deducted in the transaction. (required).</param>
        /// <param name="id">ID of the loyalty ledger transaction. (required).</param>
        /// <param name="rulesetId">The ID of the ruleset containing the rule that triggered this effect..</param>
        /// <param name="ruleName">The name of the rule that triggered this effect..</param>
        public CardLedgerTransactionLogEntryIntegrationAPI(DateTime created = default(DateTime), int programId = default(int), string cardIdentifier = default(string), string customerSessionId = default(string), TypeEnum type = default(TypeEnum), string name = default(string), string startDate = default(string), string expiryDate = default(string), string subledgerId = default(string), decimal amount = default(decimal), int id = default(int), int rulesetId = default(int), string ruleName = default(string))
        {
            this.Created = created;
            this.ProgramId = programId;
            // to ensure "cardIdentifier" is required (not null)
            this.CardIdentifier = cardIdentifier ?? throw new ArgumentNullException("cardIdentifier is a required property for CardLedgerTransactionLogEntryIntegrationAPI and cannot be null");
            this.Type = type;
            // to ensure "name" is required (not null)
            this.Name = name ?? throw new ArgumentNullException("name is a required property for CardLedgerTransactionLogEntryIntegrationAPI and cannot be null");
            // to ensure "startDate" is required (not null)
            this.StartDate = startDate ?? throw new ArgumentNullException("startDate is a required property for CardLedgerTransactionLogEntryIntegrationAPI and cannot be null");
            // to ensure "expiryDate" is required (not null)
            this.ExpiryDate = expiryDate ?? throw new ArgumentNullException("expiryDate is a required property for CardLedgerTransactionLogEntryIntegrationAPI and cannot be null");
            // to ensure "subledgerId" is required (not null)
            this.SubledgerId = subledgerId ?? throw new ArgumentNullException("subledgerId is a required property for CardLedgerTransactionLogEntryIntegrationAPI and cannot be null");
            this.Amount = amount;
            this.Id = id;
            this.CustomerSessionId = customerSessionId;
            this.RulesetId = rulesetId;
            this.RuleName = ruleName;
        }
        
        /// <summary>
        /// Date and time the loyalty card transaction occurred.
        /// </summary>
        /// <value>Date and time the loyalty card transaction occurred.</value>
        [DataMember(Name="created", EmitDefaultValue=false)]
        public DateTime Created { get; set; }

        /// <summary>
        /// ID of the loyalty program.
        /// </summary>
        /// <value>ID of the loyalty program.</value>
        [DataMember(Name="programId", EmitDefaultValue=false)]
        public int ProgramId { get; set; }

        /// <summary>
        /// The alphanumeric identifier of the loyalty card. 
        /// </summary>
        /// <value>The alphanumeric identifier of the loyalty card. </value>
        [DataMember(Name="cardIdentifier", EmitDefaultValue=false)]
        public string CardIdentifier { get; set; }

        /// <summary>
        /// ID of the customer session where the transaction occurred.
        /// </summary>
        /// <value>ID of the customer session where the transaction occurred.</value>
        [DataMember(Name="customerSessionId", EmitDefaultValue=false)]
        public string CustomerSessionId { get; set; }

        /// <summary>
        /// Name or reason of the loyalty ledger transaction.
        /// </summary>
        /// <value>Name or reason of the loyalty ledger transaction.</value>
        [DataMember(Name="name", EmitDefaultValue=false)]
        public string Name { get; set; }

        /// <summary>
        /// When points become active. Possible values:   - &#x60;immediate&#x60;: Points are active immediately.   - a timestamp value: Points become active at a given date and time. 
        /// </summary>
        /// <value>When points become active. Possible values:   - &#x60;immediate&#x60;: Points are active immediately.   - a timestamp value: Points become active at a given date and time. </value>
        [DataMember(Name="startDate", EmitDefaultValue=false)]
        public string StartDate { get; set; }

        /// <summary>
        /// Date when points expire. Possible values are:   - &#x60;unlimited&#x60;: Points have no expiration date.   - &#x60;timestamp value&#x60;: Points expire on the given date. 
        /// </summary>
        /// <value>Date when points expire. Possible values are:   - &#x60;unlimited&#x60;: Points have no expiration date.   - &#x60;timestamp value&#x60;: Points expire on the given date. </value>
        [DataMember(Name="expiryDate", EmitDefaultValue=false)]
        public string ExpiryDate { get; set; }

        /// <summary>
        /// ID of the subledger.
        /// </summary>
        /// <value>ID of the subledger.</value>
        [DataMember(Name="subledgerId", EmitDefaultValue=false)]
        public string SubledgerId { get; set; }

        /// <summary>
        /// Amount of loyalty points added or deducted in the transaction.
        /// </summary>
        /// <value>Amount of loyalty points added or deducted in the transaction.</value>
        [DataMember(Name="amount", EmitDefaultValue=false)]
        public decimal Amount { get; set; }

        /// <summary>
        /// ID of the loyalty ledger transaction.
        /// </summary>
        /// <value>ID of the loyalty ledger transaction.</value>
        [DataMember(Name="id", EmitDefaultValue=false)]
        public int Id { get; set; }

        /// <summary>
        /// The ID of the ruleset containing the rule that triggered this effect.
        /// </summary>
        /// <value>The ID of the ruleset containing the rule that triggered this effect.</value>
        [DataMember(Name="rulesetId", EmitDefaultValue=false)]
        public int RulesetId { get; set; }

        /// <summary>
        /// The name of the rule that triggered this effect.
        /// </summary>
        /// <value>The name of the rule that triggered this effect.</value>
        [DataMember(Name="ruleName", EmitDefaultValue=false)]
        public string RuleName { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class CardLedgerTransactionLogEntryIntegrationAPI {\n");
            sb.Append("  Created: ").Append(Created).Append("\n");
            sb.Append("  ProgramId: ").Append(ProgramId).Append("\n");
            sb.Append("  CardIdentifier: ").Append(CardIdentifier).Append("\n");
            sb.Append("  CustomerSessionId: ").Append(CustomerSessionId).Append("\n");
            sb.Append("  Type: ").Append(Type).Append("\n");
            sb.Append("  Name: ").Append(Name).Append("\n");
            sb.Append("  StartDate: ").Append(StartDate).Append("\n");
            sb.Append("  ExpiryDate: ").Append(ExpiryDate).Append("\n");
            sb.Append("  SubledgerId: ").Append(SubledgerId).Append("\n");
            sb.Append("  Amount: ").Append(Amount).Append("\n");
            sb.Append("  Id: ").Append(Id).Append("\n");
            sb.Append("  RulesetId: ").Append(RulesetId).Append("\n");
            sb.Append("  RuleName: ").Append(RuleName).Append("\n");
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
            return this.Equals(input as CardLedgerTransactionLogEntryIntegrationAPI);
        }

        /// <summary>
        /// Returns true if CardLedgerTransactionLogEntryIntegrationAPI instances are equal
        /// </summary>
        /// <param name="input">Instance of CardLedgerTransactionLogEntryIntegrationAPI to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(CardLedgerTransactionLogEntryIntegrationAPI input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.Created == input.Created ||
                    (this.Created != null &&
                    this.Created.Equals(input.Created))
                ) && 
                (
                    this.ProgramId == input.ProgramId ||
                    this.ProgramId.Equals(input.ProgramId)
                ) && 
                (
                    this.CardIdentifier == input.CardIdentifier ||
                    (this.CardIdentifier != null &&
                    this.CardIdentifier.Equals(input.CardIdentifier))
                ) && 
                (
                    this.CustomerSessionId == input.CustomerSessionId ||
                    (this.CustomerSessionId != null &&
                    this.CustomerSessionId.Equals(input.CustomerSessionId))
                ) && 
                (
                    this.Type == input.Type ||
                    this.Type.Equals(input.Type)
                ) && 
                (
                    this.Name == input.Name ||
                    (this.Name != null &&
                    this.Name.Equals(input.Name))
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
                    this.SubledgerId == input.SubledgerId ||
                    (this.SubledgerId != null &&
                    this.SubledgerId.Equals(input.SubledgerId))
                ) && 
                (
                    this.Amount == input.Amount ||
                    this.Amount.Equals(input.Amount)
                ) && 
                (
                    this.Id == input.Id ||
                    this.Id.Equals(input.Id)
                ) && 
                (
                    this.RulesetId == input.RulesetId ||
                    this.RulesetId.Equals(input.RulesetId)
                ) && 
                (
                    this.RuleName == input.RuleName ||
                    (this.RuleName != null &&
                    this.RuleName.Equals(input.RuleName))
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
                if (this.Created != null)
                    hashCode = hashCode * 59 + this.Created.GetHashCode();
                hashCode = hashCode * 59 + this.ProgramId.GetHashCode();
                if (this.CardIdentifier != null)
                    hashCode = hashCode * 59 + this.CardIdentifier.GetHashCode();
                if (this.CustomerSessionId != null)
                    hashCode = hashCode * 59 + this.CustomerSessionId.GetHashCode();
                hashCode = hashCode * 59 + this.Type.GetHashCode();
                if (this.Name != null)
                    hashCode = hashCode * 59 + this.Name.GetHashCode();
                if (this.StartDate != null)
                    hashCode = hashCode * 59 + this.StartDate.GetHashCode();
                if (this.ExpiryDate != null)
                    hashCode = hashCode * 59 + this.ExpiryDate.GetHashCode();
                if (this.SubledgerId != null)
                    hashCode = hashCode * 59 + this.SubledgerId.GetHashCode();
                hashCode = hashCode * 59 + this.Amount.GetHashCode();
                hashCode = hashCode * 59 + this.Id.GetHashCode();
                hashCode = hashCode * 59 + this.RulesetId.GetHashCode();
                if (this.RuleName != null)
                    hashCode = hashCode * 59 + this.RuleName.GetHashCode();
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
            // CardIdentifier (string) maxLength
            if(this.CardIdentifier != null && this.CardIdentifier.Length > 108)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for CardIdentifier, length must be less than 108.", new [] { "CardIdentifier" });
            }

            // CustomerSessionId (string) maxLength
            if(this.CustomerSessionId != null && this.CustomerSessionId.Length > 255)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for CustomerSessionId, length must be less than 255.", new [] { "CustomerSessionId" });
            }

            // Type (string) maxLength
            if(this.Type != default(TypeEnum))
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for Type, length must be less than 255.", new [] { "Type" });
            }

            // Name (string) maxLength
            if(this.Name != null && this.Name.Length > 255)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for Name, length must be less than 255.", new [] { "Name" });
            }

            // StartDate (string) maxLength
            if(this.StartDate != null && this.StartDate.Length > 64)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for StartDate, length must be less than 64.", new [] { "StartDate" });
            }

            // SubledgerId (string) maxLength
            if(this.SubledgerId != null && this.SubledgerId.Length > 64)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for SubledgerId, length must be less than 64.", new [] { "SubledgerId" });
            }

            yield break;
        }
    }

}
