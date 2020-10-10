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
    /// NewUser
    /// </summary>
    [DataContract]
    public partial class NewUser :  IEquatable<NewUser>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="NewUser" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected NewUser() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="NewUser" /> class.
        /// </summary>
        /// <param name="email">The email address associated with your account. (required).</param>
        /// <param name="password">The password for your account. (required).</param>
        /// <param name="name">Your name..</param>
        /// <param name="inviteToken">inviteToken (required).</param>
        public NewUser(string email = default(string), string password = default(string), string name = default(string), string inviteToken = default(string))
        {
            // to ensure "email" is required (not null)
            if (email == null)
            {
                throw new InvalidDataException("email is a required property for NewUser and cannot be null");
            }
            else
            {
                this.Email = email;
            }
            
            // to ensure "password" is required (not null)
            if (password == null)
            {
                throw new InvalidDataException("password is a required property for NewUser and cannot be null");
            }
            else
            {
                this.Password = password;
            }
            
            // to ensure "inviteToken" is required (not null)
            if (inviteToken == null)
            {
                throw new InvalidDataException("inviteToken is a required property for NewUser and cannot be null");
            }
            else
            {
                this.InviteToken = inviteToken;
            }
            
            this.Name = name;
        }
        
        /// <summary>
        /// The email address associated with your account.
        /// </summary>
        /// <value>The email address associated with your account.</value>
        [DataMember(Name="email", EmitDefaultValue=true)]
        public string Email { get; set; }

        /// <summary>
        /// The password for your account.
        /// </summary>
        /// <value>The password for your account.</value>
        [DataMember(Name="password", EmitDefaultValue=true)]
        public string Password { get; set; }

        /// <summary>
        /// Your name.
        /// </summary>
        /// <value>Your name.</value>
        [DataMember(Name="name", EmitDefaultValue=false)]
        public string Name { get; set; }

        /// <summary>
        /// Gets or Sets InviteToken
        /// </summary>
        [DataMember(Name="inviteToken", EmitDefaultValue=true)]
        public string InviteToken { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class NewUser {\n");
            sb.Append("  Email: ").Append(Email).Append("\n");
            sb.Append("  Password: ").Append(Password).Append("\n");
            sb.Append("  Name: ").Append(Name).Append("\n");
            sb.Append("  InviteToken: ").Append(InviteToken).Append("\n");
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
            return this.Equals(input as NewUser);
        }

        /// <summary>
        /// Returns true if NewUser instances are equal
        /// </summary>
        /// <param name="input">Instance of NewUser to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(NewUser input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.Email == input.Email ||
                    (this.Email != null &&
                    this.Email.Equals(input.Email))
                ) && 
                (
                    this.Password == input.Password ||
                    (this.Password != null &&
                    this.Password.Equals(input.Password))
                ) && 
                (
                    this.Name == input.Name ||
                    (this.Name != null &&
                    this.Name.Equals(input.Name))
                ) && 
                (
                    this.InviteToken == input.InviteToken ||
                    (this.InviteToken != null &&
                    this.InviteToken.Equals(input.InviteToken))
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
                if (this.Email != null)
                    hashCode = hashCode * 59 + this.Email.GetHashCode();
                if (this.Password != null)
                    hashCode = hashCode * 59 + this.Password.GetHashCode();
                if (this.Name != null)
                    hashCode = hashCode * 59 + this.Name.GetHashCode();
                if (this.InviteToken != null)
                    hashCode = hashCode * 59 + this.InviteToken.GetHashCode();
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

            // InviteToken (string) minLength
            if(this.InviteToken != null && this.InviteToken.Length < 1)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for InviteToken, length must be greater than 1.", new [] { "InviteToken" });
            }
            
            yield break;
        }
    }

}
