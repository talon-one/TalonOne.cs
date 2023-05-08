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
    /// CampaignActivationRequest
    /// </summary>
    [DataContract]
    public partial class CampaignActivationRequest :  IEquatable<CampaignActivationRequest>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="CampaignActivationRequest" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected CampaignActivationRequest() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="CampaignActivationRequest" /> class.
        /// </summary>
        /// <param name="userIds">The list of IDs of the users who will receive the activation request. (required).</param>
        public CampaignActivationRequest(List<int> userIds = default(List<int>))
        {
            // to ensure "userIds" is required (not null)
            this.UserIds = userIds ?? throw new ArgumentNullException("userIds is a required property for CampaignActivationRequest and cannot be null");
        }
        
        /// <summary>
        /// The list of IDs of the users who will receive the activation request.
        /// </summary>
        /// <value>The list of IDs of the users who will receive the activation request.</value>
        [DataMember(Name="userIds", EmitDefaultValue=false)]
        public List<int> UserIds { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class CampaignActivationRequest {\n");
            sb.Append("  UserIds: ").Append(UserIds).Append("\n");
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
            return this.Equals(input as CampaignActivationRequest);
        }

        /// <summary>
        /// Returns true if CampaignActivationRequest instances are equal
        /// </summary>
        /// <param name="input">Instance of CampaignActivationRequest to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(CampaignActivationRequest input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.UserIds == input.UserIds ||
                    this.UserIds != null &&
                    input.UserIds != null &&
                    this.UserIds.SequenceEqual(input.UserIds)
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