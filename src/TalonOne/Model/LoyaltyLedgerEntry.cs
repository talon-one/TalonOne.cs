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
    /// A single row of the ledger, describing one addition or deduction.
    /// </summary>
    [DataContract]
    public partial class LoyaltyLedgerEntry :  IEquatable<LoyaltyLedgerEntry>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="LoyaltyLedgerEntry" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected LoyaltyLedgerEntry() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="LoyaltyLedgerEntry" /> class.
        /// </summary>
        /// <param name="created">created (required).</param>
        /// <param name="programID">programID (required).</param>
        /// <param name="customerProfileID">customerProfileID (required).</param>
        /// <param name="customerSessionID">customerSessionID.</param>
        /// <param name="eventID">eventID.</param>
        /// <param name="type">The type of the ledger transaction. Possible values are addition, subtraction, expire or expiring (for expiring points ledgers)  (required).</param>
        /// <param name="amount">amount (required).</param>
        /// <param name="expiryDate">expiryDate.</param>
        /// <param name="name">A name referencing the condition or effect that added this entry, or the specific name provided in an API call. (required).</param>
        /// <param name="subLedgerID">This specifies if we are adding loyalty points to the main ledger or a subledger (required).</param>
        /// <param name="userID">This is the ID of the user who created this entry, if the addition or subtraction was done manually..</param>
        public LoyaltyLedgerEntry(DateTime created = default(DateTime), int programID = default(int), string customerProfileID = default(string), string customerSessionID = default(string), int eventID = default(int), string type = default(string), decimal amount = default(decimal), DateTime expiryDate = default(DateTime), string name = default(string), string subLedgerID = default(string), int userID = default(int))
        {
            // to ensure "created" is required (not null)
            if (created == null)
            {
                throw new InvalidDataException("created is a required property for LoyaltyLedgerEntry and cannot be null");
            }
            else
            {
                this.Created = created;
            }
            
            // to ensure "programID" is required (not null)
            if (programID == null)
            {
                throw new InvalidDataException("programID is a required property for LoyaltyLedgerEntry and cannot be null");
            }
            else
            {
                this.ProgramID = programID;
            }
            
            // to ensure "customerProfileID" is required (not null)
            if (customerProfileID == null)
            {
                throw new InvalidDataException("customerProfileID is a required property for LoyaltyLedgerEntry and cannot be null");
            }
            else
            {
                this.CustomerProfileID = customerProfileID;
            }
            
            // to ensure "type" is required (not null)
            if (type == null)
            {
                throw new InvalidDataException("type is a required property for LoyaltyLedgerEntry and cannot be null");
            }
            else
            {
                this.Type = type;
            }
            
            // to ensure "amount" is required (not null)
            if (amount == null)
            {
                throw new InvalidDataException("amount is a required property for LoyaltyLedgerEntry and cannot be null");
            }
            else
            {
                this.Amount = amount;
            }
            
            // to ensure "name" is required (not null)
            if (name == null)
            {
                throw new InvalidDataException("name is a required property for LoyaltyLedgerEntry and cannot be null");
            }
            else
            {
                this.Name = name;
            }
            
            // to ensure "subLedgerID" is required (not null)
            if (subLedgerID == null)
            {
                throw new InvalidDataException("subLedgerID is a required property for LoyaltyLedgerEntry and cannot be null");
            }
            else
            {
                this.SubLedgerID = subLedgerID;
            }
            
            this.CustomerSessionID = customerSessionID;
            this.EventID = eventID;
            this.ExpiryDate = expiryDate;
            this.UserID = userID;
        }
        
        /// <summary>
        /// Gets or Sets Created
        /// </summary>
        [DataMember(Name="created", EmitDefaultValue=false)]
        public DateTime Created { get; set; }

        /// <summary>
        /// Gets or Sets ProgramID
        /// </summary>
        [DataMember(Name="programID", EmitDefaultValue=false)]
        public int ProgramID { get; set; }

        /// <summary>
        /// Gets or Sets CustomerProfileID
        /// </summary>
        [DataMember(Name="customerProfileID", EmitDefaultValue=false)]
        public string CustomerProfileID { get; set; }

        /// <summary>
        /// Gets or Sets CustomerSessionID
        /// </summary>
        [DataMember(Name="customerSessionID", EmitDefaultValue=false)]
        public string CustomerSessionID { get; set; }

        /// <summary>
        /// Gets or Sets EventID
        /// </summary>
        [DataMember(Name="eventID", EmitDefaultValue=false)]
        public int EventID { get; set; }

        /// <summary>
        /// The type of the ledger transaction. Possible values are addition, subtraction, expire or expiring (for expiring points ledgers) 
        /// </summary>
        /// <value>The type of the ledger transaction. Possible values are addition, subtraction, expire or expiring (for expiring points ledgers) </value>
        [DataMember(Name="type", EmitDefaultValue=false)]
        public string Type { get; set; }

        /// <summary>
        /// Gets or Sets Amount
        /// </summary>
        [DataMember(Name="amount", EmitDefaultValue=false)]
        public decimal Amount { get; set; }

        /// <summary>
        /// Gets or Sets ExpiryDate
        /// </summary>
        [DataMember(Name="expiryDate", EmitDefaultValue=false)]
        public DateTime ExpiryDate { get; set; }

        /// <summary>
        /// A name referencing the condition or effect that added this entry, or the specific name provided in an API call.
        /// </summary>
        /// <value>A name referencing the condition or effect that added this entry, or the specific name provided in an API call.</value>
        [DataMember(Name="name", EmitDefaultValue=false)]
        public string Name { get; set; }

        /// <summary>
        /// This specifies if we are adding loyalty points to the main ledger or a subledger
        /// </summary>
        /// <value>This specifies if we are adding loyalty points to the main ledger or a subledger</value>
        [DataMember(Name="subLedgerID", EmitDefaultValue=false)]
        public string SubLedgerID { get; set; }

        /// <summary>
        /// This is the ID of the user who created this entry, if the addition or subtraction was done manually.
        /// </summary>
        /// <value>This is the ID of the user who created this entry, if the addition or subtraction was done manually.</value>
        [DataMember(Name="userID", EmitDefaultValue=false)]
        public int UserID { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class LoyaltyLedgerEntry {\n");
            sb.Append("  Created: ").Append(Created).Append("\n");
            sb.Append("  ProgramID: ").Append(ProgramID).Append("\n");
            sb.Append("  CustomerProfileID: ").Append(CustomerProfileID).Append("\n");
            sb.Append("  CustomerSessionID: ").Append(CustomerSessionID).Append("\n");
            sb.Append("  EventID: ").Append(EventID).Append("\n");
            sb.Append("  Type: ").Append(Type).Append("\n");
            sb.Append("  Amount: ").Append(Amount).Append("\n");
            sb.Append("  ExpiryDate: ").Append(ExpiryDate).Append("\n");
            sb.Append("  Name: ").Append(Name).Append("\n");
            sb.Append("  SubLedgerID: ").Append(SubLedgerID).Append("\n");
            sb.Append("  UserID: ").Append(UserID).Append("\n");
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
            return this.Equals(input as LoyaltyLedgerEntry);
        }

        /// <summary>
        /// Returns true if LoyaltyLedgerEntry instances are equal
        /// </summary>
        /// <param name="input">Instance of LoyaltyLedgerEntry to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(LoyaltyLedgerEntry input)
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
                    this.ProgramID == input.ProgramID ||
                    (this.ProgramID != null &&
                    this.ProgramID.Equals(input.ProgramID))
                ) && 
                (
                    this.CustomerProfileID == input.CustomerProfileID ||
                    (this.CustomerProfileID != null &&
                    this.CustomerProfileID.Equals(input.CustomerProfileID))
                ) && 
                (
                    this.CustomerSessionID == input.CustomerSessionID ||
                    (this.CustomerSessionID != null &&
                    this.CustomerSessionID.Equals(input.CustomerSessionID))
                ) && 
                (
                    this.EventID == input.EventID ||
                    (this.EventID != null &&
                    this.EventID.Equals(input.EventID))
                ) && 
                (
                    this.Type == input.Type ||
                    (this.Type != null &&
                    this.Type.Equals(input.Type))
                ) && 
                (
                    this.Amount == input.Amount ||
                    (this.Amount != null &&
                    this.Amount.Equals(input.Amount))
                ) && 
                (
                    this.ExpiryDate == input.ExpiryDate ||
                    (this.ExpiryDate != null &&
                    this.ExpiryDate.Equals(input.ExpiryDate))
                ) && 
                (
                    this.Name == input.Name ||
                    (this.Name != null &&
                    this.Name.Equals(input.Name))
                ) && 
                (
                    this.SubLedgerID == input.SubLedgerID ||
                    (this.SubLedgerID != null &&
                    this.SubLedgerID.Equals(input.SubLedgerID))
                ) && 
                (
                    this.UserID == input.UserID ||
                    (this.UserID != null &&
                    this.UserID.Equals(input.UserID))
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
                if (this.ProgramID != null)
                    hashCode = hashCode * 59 + this.ProgramID.GetHashCode();
                if (this.CustomerProfileID != null)
                    hashCode = hashCode * 59 + this.CustomerProfileID.GetHashCode();
                if (this.CustomerSessionID != null)
                    hashCode = hashCode * 59 + this.CustomerSessionID.GetHashCode();
                if (this.EventID != null)
                    hashCode = hashCode * 59 + this.EventID.GetHashCode();
                if (this.Type != null)
                    hashCode = hashCode * 59 + this.Type.GetHashCode();
                if (this.Amount != null)
                    hashCode = hashCode * 59 + this.Amount.GetHashCode();
                if (this.ExpiryDate != null)
                    hashCode = hashCode * 59 + this.ExpiryDate.GetHashCode();
                if (this.Name != null)
                    hashCode = hashCode * 59 + this.Name.GetHashCode();
                if (this.SubLedgerID != null)
                    hashCode = hashCode * 59 + this.SubLedgerID.GetHashCode();
                if (this.UserID != null)
                    hashCode = hashCode * 59 + this.UserID.GetHashCode();
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
