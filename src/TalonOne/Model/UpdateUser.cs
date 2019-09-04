/* 
 * Talon.One API
 *
 * The Talon.One API is used to manage applications and campaigns, as well as to integrate with your application. The operations in the _Integration API_ section are used to integrate with our platform, while the other operations are used to manage applications and campaigns.  ### Where is the API?  The API is available at the same hostname as these docs. For example, if you are reading this page at `https://mycompany.talon.one/docs/api/`, the URL for the [updateCustomerProfile][] operation is `https://mycompany.talon.one/v1/customer_profiles/id`  [updateCustomerProfile]: #operation- -v1-customer_profiles- -integrationId- -put 
 *
 * OpenAPI spec version: 1.0.0
 * 
 * Generated by: https://github.com/swagger-api/swagger-codegen.git
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
using SwaggerDateConverter = TalonOne.Client.SwaggerDateConverter;

namespace TalonOne.Model
{
    /// <summary>
    /// UpdateUser
    /// </summary>
    [DataContract]
    public partial class UpdateUser :  IEquatable<UpdateUser>, IValidatableObject
    {
        /// <summary>
        /// New state (\&quot;deactivated\&quot; or \&quot;active\&quot;) for the user. Only usable by admins for the user.
        /// </summary>
        /// <value>New state (\&quot;deactivated\&quot; or \&quot;active\&quot;) for the user. Only usable by admins for the user.</value>
        [JsonConverter(typeof(StringEnumConverter))]
        public enum StateEnum
        {
            
            /// <summary>
            /// Enum Deactivated for value: deactivated
            /// </summary>
            [EnumMember(Value = "deactivated")]
            Deactivated = 1,
            
            /// <summary>
            /// Enum Active for value: active
            /// </summary>
            [EnumMember(Value = "active")]
            Active = 2
        }

        /// <summary>
        /// New state (\&quot;deactivated\&quot; or \&quot;active\&quot;) for the user. Only usable by admins for the user.
        /// </summary>
        /// <value>New state (\&quot;deactivated\&quot; or \&quot;active\&quot;) for the user. Only usable by admins for the user.</value>
        [DataMember(Name="state", EmitDefaultValue=false)]
        public StateEnum? State { get; set; }
        /// <summary>
        /// Initializes a new instance of the <see cref="UpdateUser" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected UpdateUser() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="UpdateUser" /> class.
        /// </summary>
        /// <param name="email">The email address associated with your account. (required).</param>
        /// <param name="name">Your name..</param>
        /// <param name="password">Your old password..</param>
        /// <param name="newPassword">Your new password..</param>
        /// <param name="policy">a blob of acl json.</param>
        /// <param name="state">New state (\&quot;deactivated\&quot; or \&quot;active\&quot;) for the user. Only usable by admins for the user..</param>
        /// <param name="releaseUpdate">Update the user via email.</param>
        /// <param name="latestFeature">The latest feature you&#39;ve been notified..</param>
        /// <param name="roles">Update.</param>
        public UpdateUser(string email = default(string), string name = default(string), string password = default(string), string newPassword = default(string), string policy = default(string), StateEnum? state = default(StateEnum?), bool? releaseUpdate = default(bool?), string latestFeature = default(string), List<int?> roles = default(List<int?>))
        {
            // to ensure "email" is required (not null)
            if (email == null)
            {
                throw new InvalidDataException("email is a required property for UpdateUser and cannot be null");
            }
            else
            {
                this.Email = email;
            }
            this.Name = name;
            this.Password = password;
            this.NewPassword = newPassword;
            this.Policy = policy;
            this.State = state;
            this.ReleaseUpdate = releaseUpdate;
            this.LatestFeature = latestFeature;
            this.Roles = roles;
        }
        
        /// <summary>
        /// The email address associated with your account.
        /// </summary>
        /// <value>The email address associated with your account.</value>
        [DataMember(Name="email", EmitDefaultValue=false)]
        public string Email { get; set; }

        /// <summary>
        /// Your name.
        /// </summary>
        /// <value>Your name.</value>
        [DataMember(Name="name", EmitDefaultValue=false)]
        public string Name { get; set; }

        /// <summary>
        /// Your old password.
        /// </summary>
        /// <value>Your old password.</value>
        [DataMember(Name="password", EmitDefaultValue=false)]
        public string Password { get; set; }

        /// <summary>
        /// Your new password.
        /// </summary>
        /// <value>Your new password.</value>
        [DataMember(Name="newPassword", EmitDefaultValue=false)]
        public string NewPassword { get; set; }

        /// <summary>
        /// a blob of acl json
        /// </summary>
        /// <value>a blob of acl json</value>
        [DataMember(Name="policy", EmitDefaultValue=false)]
        public string Policy { get; set; }


        /// <summary>
        /// Update the user via email
        /// </summary>
        /// <value>Update the user via email</value>
        [DataMember(Name="releaseUpdate", EmitDefaultValue=false)]
        public bool? ReleaseUpdate { get; set; }

        /// <summary>
        /// The latest feature you&#39;ve been notified.
        /// </summary>
        /// <value>The latest feature you&#39;ve been notified.</value>
        [DataMember(Name="latestFeature", EmitDefaultValue=false)]
        public string LatestFeature { get; set; }

        /// <summary>
        /// Update
        /// </summary>
        /// <value>Update</value>
        [DataMember(Name="roles", EmitDefaultValue=false)]
        public List<int?> Roles { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class UpdateUser {\n");
            sb.Append("  Email: ").Append(Email).Append("\n");
            sb.Append("  Name: ").Append(Name).Append("\n");
            sb.Append("  Password: ").Append(Password).Append("\n");
            sb.Append("  NewPassword: ").Append(NewPassword).Append("\n");
            sb.Append("  Policy: ").Append(Policy).Append("\n");
            sb.Append("  State: ").Append(State).Append("\n");
            sb.Append("  ReleaseUpdate: ").Append(ReleaseUpdate).Append("\n");
            sb.Append("  LatestFeature: ").Append(LatestFeature).Append("\n");
            sb.Append("  Roles: ").Append(Roles).Append("\n");
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
            return this.Equals(input as UpdateUser);
        }

        /// <summary>
        /// Returns true if UpdateUser instances are equal
        /// </summary>
        /// <param name="input">Instance of UpdateUser to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(UpdateUser input)
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
                    this.Name == input.Name ||
                    (this.Name != null &&
                    this.Name.Equals(input.Name))
                ) && 
                (
                    this.Password == input.Password ||
                    (this.Password != null &&
                    this.Password.Equals(input.Password))
                ) && 
                (
                    this.NewPassword == input.NewPassword ||
                    (this.NewPassword != null &&
                    this.NewPassword.Equals(input.NewPassword))
                ) && 
                (
                    this.Policy == input.Policy ||
                    (this.Policy != null &&
                    this.Policy.Equals(input.Policy))
                ) && 
                (
                    this.State == input.State ||
                    (this.State != null &&
                    this.State.Equals(input.State))
                ) && 
                (
                    this.ReleaseUpdate == input.ReleaseUpdate ||
                    (this.ReleaseUpdate != null &&
                    this.ReleaseUpdate.Equals(input.ReleaseUpdate))
                ) && 
                (
                    this.LatestFeature == input.LatestFeature ||
                    (this.LatestFeature != null &&
                    this.LatestFeature.Equals(input.LatestFeature))
                ) && 
                (
                    this.Roles == input.Roles ||
                    this.Roles != null &&
                    this.Roles.SequenceEqual(input.Roles)
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
                if (this.Name != null)
                    hashCode = hashCode * 59 + this.Name.GetHashCode();
                if (this.Password != null)
                    hashCode = hashCode * 59 + this.Password.GetHashCode();
                if (this.NewPassword != null)
                    hashCode = hashCode * 59 + this.NewPassword.GetHashCode();
                if (this.Policy != null)
                    hashCode = hashCode * 59 + this.Policy.GetHashCode();
                if (this.State != null)
                    hashCode = hashCode * 59 + this.State.GetHashCode();
                if (this.ReleaseUpdate != null)
                    hashCode = hashCode * 59 + this.ReleaseUpdate.GetHashCode();
                if (this.LatestFeature != null)
                    hashCode = hashCode * 59 + this.LatestFeature.GetHashCode();
                if (this.Roles != null)
                    hashCode = hashCode * 59 + this.Roles.GetHashCode();
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
