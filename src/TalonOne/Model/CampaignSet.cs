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
    /// CampaignSet
    /// </summary>
    [DataContract]
    public partial class CampaignSet :  IEquatable<CampaignSet>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="CampaignSet" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected CampaignSet() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="CampaignSet" /> class.
        /// </summary>
        /// <param name="id">Internal ID of this entity. (required).</param>
        /// <param name="created">The time this entity was created. (required).</param>
        /// <param name="applicationId">The ID of the application that owns this entity. (required).</param>
        /// <param name="version">Version of the campaign set. (required).</param>
        /// <param name="set">set (required).</param>
        /// <param name="updatedBy">Name of the user who last updated this campaign set, if available..</param>
        public CampaignSet(int id = default(int), DateTime created = default(DateTime), int applicationId = default(int), int version = default(int), CampaignSetBranchNode set = default(CampaignSetBranchNode), string updatedBy = default(string))
        {
            this.Id = id;
            this.Created = created;
            this.ApplicationId = applicationId;
            this.Version = version;
            // to ensure "set" is required (not null)
            this.Set = set ?? throw new ArgumentNullException("set is a required property for CampaignSet and cannot be null");
            this.UpdatedBy = updatedBy;
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
        /// The ID of the application that owns this entity.
        /// </summary>
        /// <value>The ID of the application that owns this entity.</value>
        [DataMember(Name="applicationId", EmitDefaultValue=false)]
        public int ApplicationId { get; set; }

        /// <summary>
        /// Version of the campaign set.
        /// </summary>
        /// <value>Version of the campaign set.</value>
        [DataMember(Name="version", EmitDefaultValue=false)]
        public int Version { get; set; }

        /// <summary>
        /// Gets or Sets Set
        /// </summary>
        [DataMember(Name="set", EmitDefaultValue=false)]
        public CampaignSetBranchNode Set { get; set; }

        /// <summary>
        /// Name of the user who last updated this campaign set, if available.
        /// </summary>
        /// <value>Name of the user who last updated this campaign set, if available.</value>
        [DataMember(Name="updatedBy", EmitDefaultValue=false)]
        public string UpdatedBy { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class CampaignSet {\n");
            sb.Append("  Id: ").Append(Id).Append("\n");
            sb.Append("  Created: ").Append(Created).Append("\n");
            sb.Append("  ApplicationId: ").Append(ApplicationId).Append("\n");
            sb.Append("  Version: ").Append(Version).Append("\n");
            sb.Append("  Set: ").Append(Set).Append("\n");
            sb.Append("  UpdatedBy: ").Append(UpdatedBy).Append("\n");
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
            return this.Equals(input as CampaignSet);
        }

        /// <summary>
        /// Returns true if CampaignSet instances are equal
        /// </summary>
        /// <param name="input">Instance of CampaignSet to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(CampaignSet input)
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
                    this.ApplicationId == input.ApplicationId ||
                    this.ApplicationId.Equals(input.ApplicationId)
                ) && 
                (
                    this.Version == input.Version ||
                    this.Version.Equals(input.Version)
                ) && 
                (
                    this.Set == input.Set ||
                    (this.Set != null &&
                    this.Set.Equals(input.Set))
                ) && 
                (
                    this.UpdatedBy == input.UpdatedBy ||
                    (this.UpdatedBy != null &&
                    this.UpdatedBy.Equals(input.UpdatedBy))
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
                hashCode = hashCode * 59 + this.ApplicationId.GetHashCode();
                hashCode = hashCode * 59 + this.Version.GetHashCode();
                if (this.Set != null)
                    hashCode = hashCode * 59 + this.Set.GetHashCode();
                if (this.UpdatedBy != null)
                    hashCode = hashCode * 59 + this.UpdatedBy.GetHashCode();
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
            // Version (int) minimum
            if(this.Version < (int)1)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for Version, must be a value greater than or equal to 1.", new [] { "Version" });
            }

            yield break;
        }
    }

}
