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
    /// RoleMembership
    /// </summary>
    [DataContract]
    public partial class RoleMembership :  IEquatable<RoleMembership>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="RoleMembership" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected RoleMembership() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="RoleMembership" /> class.
        /// </summary>
        /// <param name="roleID">ID of role (required).</param>
        /// <param name="userID">ID of User (required).</param>
        public RoleMembership(int roleID = default(int), int userID = default(int))
        {
            // to ensure "roleID" is required (not null)
            if (roleID == null)
            {
                throw new InvalidDataException("roleID is a required property for RoleMembership and cannot be null");
            }
            else
            {
                this.RoleID = roleID;
            }
            
            // to ensure "userID" is required (not null)
            if (userID == null)
            {
                throw new InvalidDataException("userID is a required property for RoleMembership and cannot be null");
            }
            else
            {
                this.UserID = userID;
            }
            
        }
        
        /// <summary>
        /// ID of role
        /// </summary>
        /// <value>ID of role</value>
        [DataMember(Name="RoleID", EmitDefaultValue=false)]
        public int RoleID { get; set; }

        /// <summary>
        /// ID of User
        /// </summary>
        /// <value>ID of User</value>
        [DataMember(Name="UserID", EmitDefaultValue=false)]
        public int UserID { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class RoleMembership {\n");
            sb.Append("  RoleID: ").Append(RoleID).Append("\n");
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
            return this.Equals(input as RoleMembership);
        }

        /// <summary>
        /// Returns true if RoleMembership instances are equal
        /// </summary>
        /// <param name="input">Instance of RoleMembership to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(RoleMembership input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.RoleID == input.RoleID ||
                    (this.RoleID != null &&
                    this.RoleID.Equals(input.RoleID))
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
                if (this.RoleID != null)
                    hashCode = hashCode * 59 + this.RoleID.GetHashCode();
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
