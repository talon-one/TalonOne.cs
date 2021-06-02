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
    /// Role
    /// </summary>
    [DataContract]
    public partial class Role :  IEquatable<Role>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="Role" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected Role() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="Role" /> class.
        /// </summary>
        /// <param name="id">Unique ID for this entity. (required).</param>
        /// <param name="created">The exact moment this entity was created. (required).</param>
        /// <param name="modified">The exact moment this entity was last modified. (required).</param>
        /// <param name="accountId">The ID of the account that owns this entity. (required).</param>
        /// <param name="campaignGroupID">The ID of the Campaign Group this role was created for..</param>
        /// <param name="name">Name of the role (required).</param>
        /// <param name="description">Description of the role.</param>
        /// <param name="members">A list of user identifiers assigned to this role.</param>
        /// <param name="acl">Role ACL Policy (required).</param>
        public Role(int id = default(int), DateTime created = default(DateTime), DateTime modified = default(DateTime), int accountId = default(int), int campaignGroupID = default(int), string name = default(string), string description = default(string), List<int> members = default(List<int>), Object acl = default(Object))
        {
            // to ensure "id" is required (not null)
            if (id == null)
            {
                throw new InvalidDataException("id is a required property for Role and cannot be null");
            }
            else
            {
                this.Id = id;
            }
            
            // to ensure "created" is required (not null)
            if (created == null)
            {
                throw new InvalidDataException("created is a required property for Role and cannot be null");
            }
            else
            {
                this.Created = created;
            }
            
            // to ensure "modified" is required (not null)
            if (modified == null)
            {
                throw new InvalidDataException("modified is a required property for Role and cannot be null");
            }
            else
            {
                this.Modified = modified;
            }
            
            // to ensure "accountId" is required (not null)
            if (accountId == null)
            {
                throw new InvalidDataException("accountId is a required property for Role and cannot be null");
            }
            else
            {
                this.AccountId = accountId;
            }
            
            // to ensure "name" is required (not null)
            if (name == null)
            {
                throw new InvalidDataException("name is a required property for Role and cannot be null");
            }
            else
            {
                this.Name = name;
            }
            
            // to ensure "acl" is required (not null)
            if (acl == null)
            {
                throw new InvalidDataException("acl is a required property for Role and cannot be null");
            }
            else
            {
                this.Acl = acl;
            }
            
            this.CampaignGroupID = campaignGroupID;
            this.Description = description;
            this.Members = members;
        }
        
        /// <summary>
        /// Unique ID for this entity.
        /// </summary>
        /// <value>Unique ID for this entity.</value>
        [DataMember(Name="id", EmitDefaultValue=true)]
        public int Id { get; set; }

        /// <summary>
        /// The exact moment this entity was created.
        /// </summary>
        /// <value>The exact moment this entity was created.</value>
        [DataMember(Name="created", EmitDefaultValue=true)]
        public DateTime Created { get; set; }

        /// <summary>
        /// The exact moment this entity was last modified.
        /// </summary>
        /// <value>The exact moment this entity was last modified.</value>
        [DataMember(Name="modified", EmitDefaultValue=true)]
        public DateTime Modified { get; set; }

        /// <summary>
        /// The ID of the account that owns this entity.
        /// </summary>
        /// <value>The ID of the account that owns this entity.</value>
        [DataMember(Name="accountId", EmitDefaultValue=true)]
        public int AccountId { get; set; }

        /// <summary>
        /// The ID of the Campaign Group this role was created for.
        /// </summary>
        /// <value>The ID of the Campaign Group this role was created for.</value>
        [DataMember(Name="campaignGroupID", EmitDefaultValue=false)]
        public int CampaignGroupID { get; set; }

        /// <summary>
        /// Name of the role
        /// </summary>
        /// <value>Name of the role</value>
        [DataMember(Name="name", EmitDefaultValue=true)]
        public string Name { get; set; }

        /// <summary>
        /// Description of the role
        /// </summary>
        /// <value>Description of the role</value>
        [DataMember(Name="description", EmitDefaultValue=false)]
        public string Description { get; set; }

        /// <summary>
        /// A list of user identifiers assigned to this role
        /// </summary>
        /// <value>A list of user identifiers assigned to this role</value>
        [DataMember(Name="members", EmitDefaultValue=false)]
        public List<int> Members { get; set; }

        /// <summary>
        /// Role ACL Policy
        /// </summary>
        /// <value>Role ACL Policy</value>
        [DataMember(Name="acl", EmitDefaultValue=true)]
        public Object Acl { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class Role {\n");
            sb.Append("  Id: ").Append(Id).Append("\n");
            sb.Append("  Created: ").Append(Created).Append("\n");
            sb.Append("  Modified: ").Append(Modified).Append("\n");
            sb.Append("  AccountId: ").Append(AccountId).Append("\n");
            sb.Append("  CampaignGroupID: ").Append(CampaignGroupID).Append("\n");
            sb.Append("  Name: ").Append(Name).Append("\n");
            sb.Append("  Description: ").Append(Description).Append("\n");
            sb.Append("  Members: ").Append(Members).Append("\n");
            sb.Append("  Acl: ").Append(Acl).Append("\n");
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
            return this.Equals(input as Role);
        }

        /// <summary>
        /// Returns true if Role instances are equal
        /// </summary>
        /// <param name="input">Instance of Role to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(Role input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.Id == input.Id ||
                    (this.Id != null &&
                    this.Id.Equals(input.Id))
                ) && 
                (
                    this.Created == input.Created ||
                    (this.Created != null &&
                    this.Created.Equals(input.Created))
                ) && 
                (
                    this.Modified == input.Modified ||
                    (this.Modified != null &&
                    this.Modified.Equals(input.Modified))
                ) && 
                (
                    this.AccountId == input.AccountId ||
                    (this.AccountId != null &&
                    this.AccountId.Equals(input.AccountId))
                ) && 
                (
                    this.CampaignGroupID == input.CampaignGroupID ||
                    (this.CampaignGroupID != null &&
                    this.CampaignGroupID.Equals(input.CampaignGroupID))
                ) && 
                (
                    this.Name == input.Name ||
                    (this.Name != null &&
                    this.Name.Equals(input.Name))
                ) && 
                (
                    this.Description == input.Description ||
                    (this.Description != null &&
                    this.Description.Equals(input.Description))
                ) && 
                (
                    this.Members == input.Members ||
                    this.Members != null &&
                    input.Members != null &&
                    this.Members.SequenceEqual(input.Members)
                ) && 
                (
                    this.Acl == input.Acl ||
                    (this.Acl != null &&
                    this.Acl.Equals(input.Acl))
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
                if (this.Id != null)
                    hashCode = hashCode * 59 + this.Id.GetHashCode();
                if (this.Created != null)
                    hashCode = hashCode * 59 + this.Created.GetHashCode();
                if (this.Modified != null)
                    hashCode = hashCode * 59 + this.Modified.GetHashCode();
                if (this.AccountId != null)
                    hashCode = hashCode * 59 + this.AccountId.GetHashCode();
                if (this.CampaignGroupID != null)
                    hashCode = hashCode * 59 + this.CampaignGroupID.GetHashCode();
                if (this.Name != null)
                    hashCode = hashCode * 59 + this.Name.GetHashCode();
                if (this.Description != null)
                    hashCode = hashCode * 59 + this.Description.GetHashCode();
                if (this.Members != null)
                    hashCode = hashCode * 59 + this.Members.GetHashCode();
                if (this.Acl != null)
                    hashCode = hashCode * 59 + this.Acl.GetHashCode();
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
