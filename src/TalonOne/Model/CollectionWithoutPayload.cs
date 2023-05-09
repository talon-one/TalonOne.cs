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
    /// CollectionWithoutPayload
    /// </summary>
    [DataContract]
    public partial class CollectionWithoutPayload :  IEquatable<CollectionWithoutPayload>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="CollectionWithoutPayload" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected CollectionWithoutPayload() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="CollectionWithoutPayload" /> class.
        /// </summary>
        /// <param name="id">Internal ID of this entity. (required).</param>
        /// <param name="created">The time this entity was created. (required).</param>
        /// <param name="accountId">The ID of the account that owns this entity. (required).</param>
        /// <param name="modified">The time this entity was last modified. (required).</param>
        /// <param name="description">A short description of the purpose of this collection..</param>
        /// <param name="subscribedApplicationsIds">A list of the IDs of the Applications where this collection is enabled..</param>
        /// <param name="name">The name of this collection. (required).</param>
        /// <param name="modifiedBy">ID of the user who last updated this effect if available..</param>
        /// <param name="createdBy">ID of the user who created this effect. (required).</param>
        /// <param name="applicationId">The ID of the Application that owns this entity..</param>
        /// <param name="campaignId">The ID of the campaign that owns this entity..</param>
        public CollectionWithoutPayload(int id = default(int), DateTime created = default(DateTime), int accountId = default(int), DateTime modified = default(DateTime), string description = default(string), List<int> subscribedApplicationsIds = default(List<int>), string name = default(string), int modifiedBy = default(int), int createdBy = default(int), int applicationId = default(int), int campaignId = default(int))
        {
            this.Id = id;
            this.Created = created;
            this.AccountId = accountId;
            this.Modified = modified;
            // to ensure "name" is required (not null)
            this.Name = name ?? throw new ArgumentNullException("name is a required property for CollectionWithoutPayload and cannot be null");
            this.CreatedBy = createdBy;
            this.Description = description;
            this.SubscribedApplicationsIds = subscribedApplicationsIds;
            this.ModifiedBy = modifiedBy;
            this.ApplicationId = applicationId;
            this.CampaignId = campaignId;
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
        /// The ID of the account that owns this entity.
        /// </summary>
        /// <value>The ID of the account that owns this entity.</value>
        [DataMember(Name="accountId", EmitDefaultValue=false)]
        public int AccountId { get; set; }

        /// <summary>
        /// The time this entity was last modified.
        /// </summary>
        /// <value>The time this entity was last modified.</value>
        [DataMember(Name="modified", EmitDefaultValue=false)]
        public DateTime Modified { get; set; }

        /// <summary>
        /// A short description of the purpose of this collection.
        /// </summary>
        /// <value>A short description of the purpose of this collection.</value>
        [DataMember(Name="description", EmitDefaultValue=false)]
        public string Description { get; set; }

        /// <summary>
        /// A list of the IDs of the Applications where this collection is enabled.
        /// </summary>
        /// <value>A list of the IDs of the Applications where this collection is enabled.</value>
        [DataMember(Name="subscribedApplicationsIds", EmitDefaultValue=false)]
        public List<int> SubscribedApplicationsIds { get; set; }

        /// <summary>
        /// The name of this collection.
        /// </summary>
        /// <value>The name of this collection.</value>
        [DataMember(Name="name", EmitDefaultValue=false)]
        public string Name { get; set; }

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
        /// The ID of the Application that owns this entity.
        /// </summary>
        /// <value>The ID of the Application that owns this entity.</value>
        [DataMember(Name="applicationId", EmitDefaultValue=false)]
        public int ApplicationId { get; set; }

        /// <summary>
        /// The ID of the campaign that owns this entity.
        /// </summary>
        /// <value>The ID of the campaign that owns this entity.</value>
        [DataMember(Name="campaignId", EmitDefaultValue=false)]
        public int CampaignId { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class CollectionWithoutPayload {\n");
            sb.Append("  Id: ").Append(Id).Append("\n");
            sb.Append("  Created: ").Append(Created).Append("\n");
            sb.Append("  AccountId: ").Append(AccountId).Append("\n");
            sb.Append("  Modified: ").Append(Modified).Append("\n");
            sb.Append("  Description: ").Append(Description).Append("\n");
            sb.Append("  SubscribedApplicationsIds: ").Append(SubscribedApplicationsIds).Append("\n");
            sb.Append("  Name: ").Append(Name).Append("\n");
            sb.Append("  ModifiedBy: ").Append(ModifiedBy).Append("\n");
            sb.Append("  CreatedBy: ").Append(CreatedBy).Append("\n");
            sb.Append("  ApplicationId: ").Append(ApplicationId).Append("\n");
            sb.Append("  CampaignId: ").Append(CampaignId).Append("\n");
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
            return this.Equals(input as CollectionWithoutPayload);
        }

        /// <summary>
        /// Returns true if CollectionWithoutPayload instances are equal
        /// </summary>
        /// <param name="input">Instance of CollectionWithoutPayload to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(CollectionWithoutPayload input)
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
                    this.AccountId == input.AccountId ||
                    this.AccountId.Equals(input.AccountId)
                ) && 
                (
                    this.Modified == input.Modified ||
                    (this.Modified != null &&
                    this.Modified.Equals(input.Modified))
                ) && 
                (
                    this.Description == input.Description ||
                    (this.Description != null &&
                    this.Description.Equals(input.Description))
                ) && 
                (
                    this.SubscribedApplicationsIds == input.SubscribedApplicationsIds ||
                    this.SubscribedApplicationsIds != null &&
                    input.SubscribedApplicationsIds != null &&
                    this.SubscribedApplicationsIds.SequenceEqual(input.SubscribedApplicationsIds)
                ) && 
                (
                    this.Name == input.Name ||
                    (this.Name != null &&
                    this.Name.Equals(input.Name))
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
                    this.ApplicationId == input.ApplicationId ||
                    this.ApplicationId.Equals(input.ApplicationId)
                ) && 
                (
                    this.CampaignId == input.CampaignId ||
                    this.CampaignId.Equals(input.CampaignId)
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
                hashCode = hashCode * 59 + this.AccountId.GetHashCode();
                if (this.Modified != null)
                    hashCode = hashCode * 59 + this.Modified.GetHashCode();
                if (this.Description != null)
                    hashCode = hashCode * 59 + this.Description.GetHashCode();
                if (this.SubscribedApplicationsIds != null)
                    hashCode = hashCode * 59 + this.SubscribedApplicationsIds.GetHashCode();
                if (this.Name != null)
                    hashCode = hashCode * 59 + this.Name.GetHashCode();
                hashCode = hashCode * 59 + this.ModifiedBy.GetHashCode();
                hashCode = hashCode * 59 + this.CreatedBy.GetHashCode();
                hashCode = hashCode * 59 + this.ApplicationId.GetHashCode();
                hashCode = hashCode * 59 + this.CampaignId.GetHashCode();
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
            // Name (string) minLength
            if(this.Name != null && this.Name.Length < 1)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for Name, length must be greater than 1.", new [] { "Name" });
            }

            // Name (string) pattern
            Regex regexName = new Regex(@"^[^[:cntrl:]\\s][^[:cntrl:]]*$", RegexOptions.CultureInvariant);
            if (false == regexName.Match(this.Name).Success)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for Name, must match a pattern of " + regexName, new [] { "Name" });
            }

            yield break;
        }
    }

}
