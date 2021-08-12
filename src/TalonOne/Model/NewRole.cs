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
    /// NewRole
    /// </summary>
    [DataContract]
    public partial class NewRole :  IEquatable<NewRole>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="NewRole" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected NewRole() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="NewRole" /> class.
        /// </summary>
        /// <param name="name">Name of the role (required).</param>
        /// <param name="description">Description of the role.</param>
        /// <param name="acl">Role Policy this should be a stringified blob of json (required).</param>
        /// <param name="members">An array of user identifiers (required).</param>
        public NewRole(string name = default(string), string description = default(string), string acl = default(string), List<int> members = default(List<int>))
        {
            // to ensure "name" is required (not null)
            this.Name = name ?? throw new ArgumentNullException("name is a required property for NewRole and cannot be null");
            // to ensure "acl" is required (not null)
            this.Acl = acl ?? throw new ArgumentNullException("acl is a required property for NewRole and cannot be null");
            // to ensure "members" is required (not null)
            this.Members = members ?? throw new ArgumentNullException("members is a required property for NewRole and cannot be null");
            this.Description = description;
        }
        
        /// <summary>
        /// Name of the role
        /// </summary>
        /// <value>Name of the role</value>
        [DataMember(Name="name", EmitDefaultValue=false)]
        public string Name { get; set; }

        /// <summary>
        /// Description of the role
        /// </summary>
        /// <value>Description of the role</value>
        [DataMember(Name="description", EmitDefaultValue=false)]
        public string Description { get; set; }

        /// <summary>
        /// Role Policy this should be a stringified blob of json
        /// </summary>
        /// <value>Role Policy this should be a stringified blob of json</value>
        [DataMember(Name="acl", EmitDefaultValue=false)]
        public string Acl { get; set; }

        /// <summary>
        /// An array of user identifiers
        /// </summary>
        /// <value>An array of user identifiers</value>
        [DataMember(Name="members", EmitDefaultValue=false)]
        public List<int> Members { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class NewRole {\n");
            sb.Append("  Name: ").Append(Name).Append("\n");
            sb.Append("  Description: ").Append(Description).Append("\n");
            sb.Append("  Acl: ").Append(Acl).Append("\n");
            sb.Append("  Members: ").Append(Members).Append("\n");
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
            return this.Equals(input as NewRole);
        }

        /// <summary>
        /// Returns true if NewRole instances are equal
        /// </summary>
        /// <param name="input">Instance of NewRole to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(NewRole input)
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
                    this.Description == input.Description ||
                    (this.Description != null &&
                    this.Description.Equals(input.Description))
                ) && 
                (
                    this.Acl == input.Acl ||
                    (this.Acl != null &&
                    this.Acl.Equals(input.Acl))
                ) && 
                (
                    this.Members == input.Members ||
                    this.Members != null &&
                    input.Members != null &&
                    this.Members.SequenceEqual(input.Members)
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
                if (this.Description != null)
                    hashCode = hashCode * 59 + this.Description.GetHashCode();
                if (this.Acl != null)
                    hashCode = hashCode * 59 + this.Acl.GetHashCode();
                if (this.Members != null)
                    hashCode = hashCode * 59 + this.Members.GetHashCode();
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
