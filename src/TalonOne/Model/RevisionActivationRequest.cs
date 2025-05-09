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
    /// RevisionActivationRequest
    /// </summary>
    [DataContract]
    public partial class RevisionActivationRequest :  IEquatable<RevisionActivationRequest>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="RevisionActivationRequest" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected RevisionActivationRequest() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="RevisionActivationRequest" /> class.
        /// </summary>
        /// <param name="userIds">The list of IDs of the users who will receive the activation request. (required).</param>
        /// <param name="activateAt">Time when the revisions are finalized after the &#x60;activate_revision&#x60; operation. The current time is used when left blank.  **Note:** It must be an RFC3339 timestamp string. .</param>
        public RevisionActivationRequest(List<int> userIds = default(List<int>), DateTime activateAt = default(DateTime))
        {
            // to ensure "userIds" is required (not null)
            this.UserIds = userIds ?? throw new ArgumentNullException("userIds is a required property for RevisionActivationRequest and cannot be null");
            this.ActivateAt = activateAt;
        }
        
        /// <summary>
        /// The list of IDs of the users who will receive the activation request.
        /// </summary>
        /// <value>The list of IDs of the users who will receive the activation request.</value>
        [DataMember(Name="userIds", EmitDefaultValue=false)]
        public List<int> UserIds { get; set; }

        /// <summary>
        /// Time when the revisions are finalized after the &#x60;activate_revision&#x60; operation. The current time is used when left blank.  **Note:** It must be an RFC3339 timestamp string. 
        /// </summary>
        /// <value>Time when the revisions are finalized after the &#x60;activate_revision&#x60; operation. The current time is used when left blank.  **Note:** It must be an RFC3339 timestamp string. </value>
        [DataMember(Name="activateAt", EmitDefaultValue=false)]
        public DateTime ActivateAt { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class RevisionActivationRequest {\n");
            sb.Append("  UserIds: ").Append(UserIds).Append("\n");
            sb.Append("  ActivateAt: ").Append(ActivateAt).Append("\n");
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
            return this.Equals(input as RevisionActivationRequest);
        }

        /// <summary>
        /// Returns true if RevisionActivationRequest instances are equal
        /// </summary>
        /// <param name="input">Instance of RevisionActivationRequest to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(RevisionActivationRequest input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.UserIds == input.UserIds ||
                    this.UserIds != null &&
                    input.UserIds != null &&
                    this.UserIds.SequenceEqual(input.UserIds)
                ) && 
                (
                    this.ActivateAt == input.ActivateAt ||
                    (this.ActivateAt != null &&
                    this.ActivateAt.Equals(input.ActivateAt))
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
                if (this.UserIds != null)
                    hashCode = hashCode * 59 + this.UserIds.GetHashCode();
                if (this.ActivateAt != null)
                    hashCode = hashCode * 59 + this.ActivateAt.GetHashCode();
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
