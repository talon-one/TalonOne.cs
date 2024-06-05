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
    /// UpdateUser
    /// </summary>
    [DataContract]
    public partial class UpdateUser :  IEquatable<UpdateUser>, IValidatableObject
    {
        /// <summary>
        /// The state of the user.   - &#x60;deactivated&#x60;: The user has been deactivated.   - &#x60;active&#x60;: The user is active.  **Note**: Only &#x60;admin&#x60; users can update the state of another user. 
        /// </summary>
        /// <value>The state of the user.   - &#x60;deactivated&#x60;: The user has been deactivated.   - &#x60;active&#x60;: The user is active.  **Note**: Only &#x60;admin&#x60; users can update the state of another user. </value>
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
        /// The state of the user.   - &#x60;deactivated&#x60;: The user has been deactivated.   - &#x60;active&#x60;: The user is active.  **Note**: Only &#x60;admin&#x60; users can update the state of another user. 
        /// </summary>
        /// <value>The state of the user.   - &#x60;deactivated&#x60;: The user has been deactivated.   - &#x60;active&#x60;: The user is active.  **Note**: Only &#x60;admin&#x60; users can update the state of another user. </value>
        [DataMember(Name="state", EmitDefaultValue=false)]
        public StateEnum? State { get; set; }
        /// <summary>
        /// Initializes a new instance of the <see cref="UpdateUser" /> class.
        /// </summary>
        /// <param name="name">Name of the user..</param>
        /// <param name="state">The state of the user.   - &#x60;deactivated&#x60;: The user has been deactivated.   - &#x60;active&#x60;: The user is active.  **Note**: Only &#x60;admin&#x60; users can update the state of another user. .</param>
        /// <param name="isAdmin">Indicates whether the user is an &#x60;admin&#x60;..</param>
        /// <param name="policy">Indicates the access level of the user..</param>
        /// <param name="roles">A list of the IDs of the roles assigned to the user.  **Note**: To find the ID of a role, use the [List roles](/management-api#tag/Roles/operation/listAllRolesV2) endpoint. .</param>
        /// <param name="applicationNotificationSubscriptions">Application notifications that the user is subscribed to..</param>
        public UpdateUser(string name = default(string), StateEnum? state = default(StateEnum?), bool isAdmin = default(bool), string policy = default(string), List<int> roles = default(List<int>), Object applicationNotificationSubscriptions = default(Object))
        {
            this.Name = name;
            this.State = state;
            this.IsAdmin = isAdmin;
            this.Policy = policy;
            this.Roles = roles;
            this.ApplicationNotificationSubscriptions = applicationNotificationSubscriptions;
        }
        
        /// <summary>
        /// Name of the user.
        /// </summary>
        /// <value>Name of the user.</value>
        [DataMember(Name="name", EmitDefaultValue=false)]
        public string Name { get; set; }

        /// <summary>
        /// Indicates whether the user is an &#x60;admin&#x60;.
        /// </summary>
        /// <value>Indicates whether the user is an &#x60;admin&#x60;.</value>
        [DataMember(Name="isAdmin", EmitDefaultValue=false)]
        public bool IsAdmin { get; set; }

        /// <summary>
        /// Indicates the access level of the user.
        /// </summary>
        /// <value>Indicates the access level of the user.</value>
        [DataMember(Name="policy", EmitDefaultValue=false)]
        public string Policy { get; set; }

        /// <summary>
        /// A list of the IDs of the roles assigned to the user.  **Note**: To find the ID of a role, use the [List roles](/management-api#tag/Roles/operation/listAllRolesV2) endpoint. 
        /// </summary>
        /// <value>A list of the IDs of the roles assigned to the user.  **Note**: To find the ID of a role, use the [List roles](/management-api#tag/Roles/operation/listAllRolesV2) endpoint. </value>
        [DataMember(Name="roles", EmitDefaultValue=false)]
        public List<int> Roles { get; set; }

        /// <summary>
        /// Application notifications that the user is subscribed to.
        /// </summary>
        /// <value>Application notifications that the user is subscribed to.</value>
        [DataMember(Name="applicationNotificationSubscriptions", EmitDefaultValue=false)]
        public Object ApplicationNotificationSubscriptions { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class UpdateUser {\n");
            sb.Append("  Name: ").Append(Name).Append("\n");
            sb.Append("  State: ").Append(State).Append("\n");
            sb.Append("  IsAdmin: ").Append(IsAdmin).Append("\n");
            sb.Append("  Policy: ").Append(Policy).Append("\n");
            sb.Append("  Roles: ").Append(Roles).Append("\n");
            sb.Append("  ApplicationNotificationSubscriptions: ").Append(ApplicationNotificationSubscriptions).Append("\n");
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
                    this.Name == input.Name ||
                    (this.Name != null &&
                    this.Name.Equals(input.Name))
                ) && 
                (
                    this.State == input.State ||
                    this.State.Equals(input.State)
                ) && 
                (
                    this.IsAdmin == input.IsAdmin ||
                    this.IsAdmin.Equals(input.IsAdmin)
                ) && 
                (
                    this.Policy == input.Policy ||
                    (this.Policy != null &&
                    this.Policy.Equals(input.Policy))
                ) && 
                (
                    this.Roles == input.Roles ||
                    this.Roles != null &&
                    input.Roles != null &&
                    this.Roles.SequenceEqual(input.Roles)
                ) && 
                (
                    this.ApplicationNotificationSubscriptions == input.ApplicationNotificationSubscriptions ||
                    (this.ApplicationNotificationSubscriptions != null &&
                    this.ApplicationNotificationSubscriptions.Equals(input.ApplicationNotificationSubscriptions))
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
                hashCode = hashCode * 59 + this.State.GetHashCode();
                hashCode = hashCode * 59 + this.IsAdmin.GetHashCode();
                if (this.Policy != null)
                    hashCode = hashCode * 59 + this.Policy.GetHashCode();
                if (this.Roles != null)
                    hashCode = hashCode * 59 + this.Roles.GetHashCode();
                if (this.ApplicationNotificationSubscriptions != null)
                    hashCode = hashCode * 59 + this.ApplicationNotificationSubscriptions.GetHashCode();
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
