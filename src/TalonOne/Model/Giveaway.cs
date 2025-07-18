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
    /// Giveaway
    /// </summary>
    [DataContract]
    public partial class Giveaway :  IEquatable<Giveaway>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="Giveaway" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected Giveaway() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="Giveaway" /> class.
        /// </summary>
        /// <param name="id">The internal ID of this entity. (required).</param>
        /// <param name="created">The time this entity was created. (required).</param>
        /// <param name="code">The code value of this giveaway. (required).</param>
        /// <param name="poolId">The ID of the pool to return giveaway codes from. (required).</param>
        /// <param name="startDate">Timestamp at which point the giveaway becomes valid..</param>
        /// <param name="endDate">Timestamp at which point the giveaway becomes invalid..</param>
        /// <param name="attributes">Arbitrary properties associated with this giveaway..</param>
        /// <param name="used">Indicates whether this giveaway code was given before..</param>
        /// <param name="importId">The ID of the Import which created this giveaway..</param>
        /// <param name="profileIntegrationId">The third-party integration ID of the customer profile that was awarded the giveaway, if the giveaway was awarded..</param>
        /// <param name="profileId">The internal ID of the customer profile that was awarded the giveaway, if the giveaway was awarded and an internal ID exists..</param>
        public Giveaway(int id = default(int), DateTime created = default(DateTime), string code = default(string), int poolId = default(int), DateTime startDate = default(DateTime), DateTime endDate = default(DateTime), Object attributes = default(Object), bool used = default(bool), int importId = default(int), string profileIntegrationId = default(string), int profileId = default(int))
        {
            this.Id = id;
            this.Created = created;
            // to ensure "code" is required (not null)
            this.Code = code ?? throw new ArgumentNullException("code is a required property for Giveaway and cannot be null");
            this.PoolId = poolId;
            this.StartDate = startDate;
            this.EndDate = endDate;
            this.Attributes = attributes;
            this.Used = used;
            this.ImportId = importId;
            this.ProfileIntegrationId = profileIntegrationId;
            this.ProfileId = profileId;
        }
        
        /// <summary>
        /// The internal ID of this entity.
        /// </summary>
        /// <value>The internal ID of this entity.</value>
        [DataMember(Name="id", EmitDefaultValue=false)]
        public int Id { get; set; }

        /// <summary>
        /// The time this entity was created.
        /// </summary>
        /// <value>The time this entity was created.</value>
        [DataMember(Name="created", EmitDefaultValue=false)]
        public DateTime Created { get; set; }

        /// <summary>
        /// The code value of this giveaway.
        /// </summary>
        /// <value>The code value of this giveaway.</value>
        [DataMember(Name="code", EmitDefaultValue=false)]
        public string Code { get; set; }

        /// <summary>
        /// The ID of the pool to return giveaway codes from.
        /// </summary>
        /// <value>The ID of the pool to return giveaway codes from.</value>
        [DataMember(Name="poolId", EmitDefaultValue=false)]
        public int PoolId { get; set; }

        /// <summary>
        /// Timestamp at which point the giveaway becomes valid.
        /// </summary>
        /// <value>Timestamp at which point the giveaway becomes valid.</value>
        [DataMember(Name="startDate", EmitDefaultValue=false)]
        public DateTime StartDate { get; set; }

        /// <summary>
        /// Timestamp at which point the giveaway becomes invalid.
        /// </summary>
        /// <value>Timestamp at which point the giveaway becomes invalid.</value>
        [DataMember(Name="endDate", EmitDefaultValue=false)]
        public DateTime EndDate { get; set; }

        /// <summary>
        /// Arbitrary properties associated with this giveaway.
        /// </summary>
        /// <value>Arbitrary properties associated with this giveaway.</value>
        [DataMember(Name="attributes", EmitDefaultValue=false)]
        public Object Attributes { get; set; }

        /// <summary>
        /// Indicates whether this giveaway code was given before.
        /// </summary>
        /// <value>Indicates whether this giveaway code was given before.</value>
        [DataMember(Name="used", EmitDefaultValue=false)]
        public bool Used { get; set; }

        /// <summary>
        /// The ID of the Import which created this giveaway.
        /// </summary>
        /// <value>The ID of the Import which created this giveaway.</value>
        [DataMember(Name="importId", EmitDefaultValue=false)]
        public int ImportId { get; set; }

        /// <summary>
        /// The third-party integration ID of the customer profile that was awarded the giveaway, if the giveaway was awarded.
        /// </summary>
        /// <value>The third-party integration ID of the customer profile that was awarded the giveaway, if the giveaway was awarded.</value>
        [DataMember(Name="profileIntegrationId", EmitDefaultValue=false)]
        public string ProfileIntegrationId { get; set; }

        /// <summary>
        /// The internal ID of the customer profile that was awarded the giveaway, if the giveaway was awarded and an internal ID exists.
        /// </summary>
        /// <value>The internal ID of the customer profile that was awarded the giveaway, if the giveaway was awarded and an internal ID exists.</value>
        [DataMember(Name="profileId", EmitDefaultValue=false)]
        public int ProfileId { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class Giveaway {\n");
            sb.Append("  Id: ").Append(Id).Append("\n");
            sb.Append("  Created: ").Append(Created).Append("\n");
            sb.Append("  Code: ").Append(Code).Append("\n");
            sb.Append("  PoolId: ").Append(PoolId).Append("\n");
            sb.Append("  StartDate: ").Append(StartDate).Append("\n");
            sb.Append("  EndDate: ").Append(EndDate).Append("\n");
            sb.Append("  Attributes: ").Append(Attributes).Append("\n");
            sb.Append("  Used: ").Append(Used).Append("\n");
            sb.Append("  ImportId: ").Append(ImportId).Append("\n");
            sb.Append("  ProfileIntegrationId: ").Append(ProfileIntegrationId).Append("\n");
            sb.Append("  ProfileId: ").Append(ProfileId).Append("\n");
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
            return this.Equals(input as Giveaway);
        }

        /// <summary>
        /// Returns true if Giveaway instances are equal
        /// </summary>
        /// <param name="input">Instance of Giveaway to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(Giveaway input)
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
                    this.Code == input.Code ||
                    (this.Code != null &&
                    this.Code.Equals(input.Code))
                ) && 
                (
                    this.PoolId == input.PoolId ||
                    this.PoolId.Equals(input.PoolId)
                ) && 
                (
                    this.StartDate == input.StartDate ||
                    (this.StartDate != null &&
                    this.StartDate.Equals(input.StartDate))
                ) && 
                (
                    this.EndDate == input.EndDate ||
                    (this.EndDate != null &&
                    this.EndDate.Equals(input.EndDate))
                ) && 
                (
                    this.Attributes == input.Attributes ||
                    (this.Attributes != null &&
                    this.Attributes.Equals(input.Attributes))
                ) && 
                (
                    this.Used == input.Used ||
                    this.Used.Equals(input.Used)
                ) && 
                (
                    this.ImportId == input.ImportId ||
                    this.ImportId.Equals(input.ImportId)
                ) && 
                (
                    this.ProfileIntegrationId == input.ProfileIntegrationId ||
                    (this.ProfileIntegrationId != null &&
                    this.ProfileIntegrationId.Equals(input.ProfileIntegrationId))
                ) && 
                (
                    this.ProfileId == input.ProfileId ||
                    this.ProfileId.Equals(input.ProfileId)
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
                if (this.Code != null)
                    hashCode = hashCode * 59 + this.Code.GetHashCode();
                hashCode = hashCode * 59 + this.PoolId.GetHashCode();
                if (this.StartDate != null)
                    hashCode = hashCode * 59 + this.StartDate.GetHashCode();
                if (this.EndDate != null)
                    hashCode = hashCode * 59 + this.EndDate.GetHashCode();
                if (this.Attributes != null)
                    hashCode = hashCode * 59 + this.Attributes.GetHashCode();
                hashCode = hashCode * 59 + this.Used.GetHashCode();
                hashCode = hashCode * 59 + this.ImportId.GetHashCode();
                if (this.ProfileIntegrationId != null)
                    hashCode = hashCode * 59 + this.ProfileIntegrationId.GetHashCode();
                hashCode = hashCode * 59 + this.ProfileId.GetHashCode();
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
