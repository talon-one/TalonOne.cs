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
    /// Picklist
    /// </summary>
    [DataContract]
    public partial class Picklist :  IEquatable<Picklist>, IValidatableObject
    {
        /// <summary>
        /// The type of allowed values in the picklist. If type time is chosen, it must be an RFC3339 timestamp string.
        /// </summary>
        /// <value>The type of allowed values in the picklist. If type time is chosen, it must be an RFC3339 timestamp string.</value>
        [JsonConverter(typeof(StringEnumConverter))]
        public enum TypeEnum
        {
            /// <summary>
            /// Enum String for value: string
            /// </summary>
            [EnumMember(Value = "string")]
            String = 1,

            /// <summary>
            /// Enum Boolean for value: boolean
            /// </summary>
            [EnumMember(Value = "boolean")]
            Boolean = 2,

            /// <summary>
            /// Enum Number for value: number
            /// </summary>
            [EnumMember(Value = "number")]
            Number = 3,

            /// <summary>
            /// Enum Time for value: time
            /// </summary>
            [EnumMember(Value = "time")]
            Time = 4

        }

        /// <summary>
        /// The type of allowed values in the picklist. If type time is chosen, it must be an RFC3339 timestamp string.
        /// </summary>
        /// <value>The type of allowed values in the picklist. If type time is chosen, it must be an RFC3339 timestamp string.</value>
        [DataMember(Name="type", EmitDefaultValue=false)]
        public TypeEnum Type { get; set; }
        /// <summary>
        /// Initializes a new instance of the <see cref="Picklist" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected Picklist() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="Picklist" /> class.
        /// </summary>
        /// <param name="id">Internal ID of this entity. (required).</param>
        /// <param name="created">The time this entity was created. (required).</param>
        /// <param name="type">The type of allowed values in the picklist. If type time is chosen, it must be an RFC3339 timestamp string. (required).</param>
        /// <param name="values">The list of allowed values provided by this picklist. (required).</param>
        /// <param name="modifiedBy">ID of the user who last updated this effect if available..</param>
        /// <param name="createdBy">ID of the user who created this effect. (required).</param>
        /// <param name="accountId">The ID of the account that owns this entity..</param>
        /// <param name="imported">Imported flag shows that a picklist is imported by a CSV file or not.</param>
        public Picklist(int id = default(int), DateTime created = default(DateTime), TypeEnum type = default(TypeEnum), List<string> values = default(List<string>), int modifiedBy = default(int), int createdBy = default(int), int accountId = default(int), bool imported = default(bool))
        {
            this.Id = id;
            this.Created = created;
            this.Type = type;
            // to ensure "values" is required (not null)
            this.Values = values ?? throw new ArgumentNullException("values is a required property for Picklist and cannot be null");
            this.CreatedBy = createdBy;
            this.ModifiedBy = modifiedBy;
            this.AccountId = accountId;
            this.Imported = imported;
        }
        
        /// <summary>
        /// Internal ID of this entity.
        /// </summary>
        /// <value>Internal ID of this entity.</value>
        [DataMember(Name="id", EmitDefaultValue=false)]
        public int Id { get; set; }

        /// <summary>
        /// The time this entity was created.
        /// </summary>
        /// <value>The time this entity was created.</value>
        [DataMember(Name="created", EmitDefaultValue=false)]
        public DateTime Created { get; set; }

        /// <summary>
        /// The list of allowed values provided by this picklist.
        /// </summary>
        /// <value>The list of allowed values provided by this picklist.</value>
        [DataMember(Name="values", EmitDefaultValue=false)]
        public List<string> Values { get; set; }

        /// <summary>
        /// ID of the user who last updated this effect if available.
        /// </summary>
        /// <value>ID of the user who last updated this effect if available.</value>
        [DataMember(Name="modifiedBy", EmitDefaultValue=false)]
        public int ModifiedBy { get; set; }

        /// <summary>
        /// ID of the user who created this effect.
        /// </summary>
        /// <value>ID of the user who created this effect.</value>
        [DataMember(Name="createdBy", EmitDefaultValue=false)]
        public int CreatedBy { get; set; }

        /// <summary>
        /// The ID of the account that owns this entity.
        /// </summary>
        /// <value>The ID of the account that owns this entity.</value>
        [DataMember(Name="accountId", EmitDefaultValue=false)]
        public int AccountId { get; set; }

        /// <summary>
        /// Imported flag shows that a picklist is imported by a CSV file or not
        /// </summary>
        /// <value>Imported flag shows that a picklist is imported by a CSV file or not</value>
        [DataMember(Name="imported", EmitDefaultValue=false)]
        public bool Imported { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class Picklist {\n");
            sb.Append("  Id: ").Append(Id).Append("\n");
            sb.Append("  Created: ").Append(Created).Append("\n");
            sb.Append("  Type: ").Append(Type).Append("\n");
            sb.Append("  Values: ").Append(Values).Append("\n");
            sb.Append("  ModifiedBy: ").Append(ModifiedBy).Append("\n");
            sb.Append("  CreatedBy: ").Append(CreatedBy).Append("\n");
            sb.Append("  AccountId: ").Append(AccountId).Append("\n");
            sb.Append("  Imported: ").Append(Imported).Append("\n");
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
            return this.Equals(input as Picklist);
        }

        /// <summary>
        /// Returns true if Picklist instances are equal
        /// </summary>
        /// <param name="input">Instance of Picklist to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(Picklist input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.Id == input.Id ||
                    this.Id.Equals(input.Id)
                ) && 
                (
                    this.Created == input.Created ||
                    (this.Created != null &&
                    this.Created.Equals(input.Created))
                ) && 
                (
                    this.Type == input.Type ||
                    this.Type.Equals(input.Type)
                ) && 
                (
                    this.Values == input.Values ||
                    this.Values != null &&
                    input.Values != null &&
                    this.Values.SequenceEqual(input.Values)
                ) && 
                (
                    this.ModifiedBy == input.ModifiedBy ||
                    this.ModifiedBy.Equals(input.ModifiedBy)
                ) && 
                (
                    this.CreatedBy == input.CreatedBy ||
                    this.CreatedBy.Equals(input.CreatedBy)
                ) && 
                (
                    this.AccountId == input.AccountId ||
                    this.AccountId.Equals(input.AccountId)
                ) && 
                (
                    this.Imported == input.Imported ||
                    this.Imported.Equals(input.Imported)
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
                hashCode = hashCode * 59 + this.Id.GetHashCode();
                if (this.Created != null)
                    hashCode = hashCode * 59 + this.Created.GetHashCode();
                hashCode = hashCode * 59 + this.Type.GetHashCode();
                if (this.Values != null)
                    hashCode = hashCode * 59 + this.Values.GetHashCode();
                hashCode = hashCode * 59 + this.ModifiedBy.GetHashCode();
                hashCode = hashCode * 59 + this.CreatedBy.GetHashCode();
                hashCode = hashCode * 59 + this.AccountId.GetHashCode();
                hashCode = hashCode * 59 + this.Imported.GetHashCode();
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
