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
    /// CustomerProfileAudienceRequestItem
    /// </summary>
    [DataContract]
    public partial class CustomerProfileAudienceRequestItem :  IEquatable<CustomerProfileAudienceRequestItem>, IValidatableObject
    {
        /// <summary>
        /// Defines the action to perform: - &#x60;add&#x60;: Adds the customer profile to the audience.    **Note**: If the customer profile does not exist, it will be created. The profile will not be visible in any Application   until a session or profile update is received for that profile. - &#x60;delete&#x60;: Removes the customer profile from the audience. 
        /// </summary>
        /// <value>Defines the action to perform: - &#x60;add&#x60;: Adds the customer profile to the audience.    **Note**: If the customer profile does not exist, it will be created. The profile will not be visible in any Application   until a session or profile update is received for that profile. - &#x60;delete&#x60;: Removes the customer profile from the audience. </value>
        [JsonConverter(typeof(StringEnumConverter))]
        public enum ActionEnum
        {
            /// <summary>
            /// Enum Add for value: add
            /// </summary>
            [EnumMember(Value = "add")]
            Add = 1,

            /// <summary>
            /// Enum Delete for value: delete
            /// </summary>
            [EnumMember(Value = "delete")]
            Delete = 2

        }

        /// <summary>
        /// Defines the action to perform: - &#x60;add&#x60;: Adds the customer profile to the audience.    **Note**: If the customer profile does not exist, it will be created. The profile will not be visible in any Application   until a session or profile update is received for that profile. - &#x60;delete&#x60;: Removes the customer profile from the audience. 
        /// </summary>
        /// <value>Defines the action to perform: - &#x60;add&#x60;: Adds the customer profile to the audience.    **Note**: If the customer profile does not exist, it will be created. The profile will not be visible in any Application   until a session or profile update is received for that profile. - &#x60;delete&#x60;: Removes the customer profile from the audience. </value>
        [DataMember(Name="action", EmitDefaultValue=false)]
        public ActionEnum Action { get; set; }
        /// <summary>
        /// Initializes a new instance of the <see cref="CustomerProfileAudienceRequestItem" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected CustomerProfileAudienceRequestItem() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="CustomerProfileAudienceRequestItem" /> class.
        /// </summary>
        /// <param name="action">Defines the action to perform: - &#x60;add&#x60;: Adds the customer profile to the audience.    **Note**: If the customer profile does not exist, it will be created. The profile will not be visible in any Application   until a session or profile update is received for that profile. - &#x60;delete&#x60;: Removes the customer profile from the audience.  (required).</param>
        /// <param name="profileIntegrationId">The ID of this customer profile in the third-party integration. (required).</param>
        /// <param name="audienceId">The ID of the audience. You get it via the &#x60;id&#x60; property when [creating an audience](#operation/createAudienceV2). (required).</param>
        public CustomerProfileAudienceRequestItem(ActionEnum action = default(ActionEnum), string profileIntegrationId = default(string), int audienceId = default(int))
        {
            this.Action = action;
            // to ensure "profileIntegrationId" is required (not null)
            this.ProfileIntegrationId = profileIntegrationId ?? throw new ArgumentNullException("profileIntegrationId is a required property for CustomerProfileAudienceRequestItem and cannot be null");
            this.AudienceId = audienceId;
        }
        
        /// <summary>
        /// The ID of this customer profile in the third-party integration.
        /// </summary>
        /// <value>The ID of this customer profile in the third-party integration.</value>
        [DataMember(Name="profileIntegrationId", EmitDefaultValue=false)]
        public string ProfileIntegrationId { get; set; }

        /// <summary>
        /// The ID of the audience. You get it via the &#x60;id&#x60; property when [creating an audience](#operation/createAudienceV2).
        /// </summary>
        /// <value>The ID of the audience. You get it via the &#x60;id&#x60; property when [creating an audience](#operation/createAudienceV2).</value>
        [DataMember(Name="audienceId", EmitDefaultValue=false)]
        public int AudienceId { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class CustomerProfileAudienceRequestItem {\n");
            sb.Append("  Action: ").Append(Action).Append("\n");
            sb.Append("  ProfileIntegrationId: ").Append(ProfileIntegrationId).Append("\n");
            sb.Append("  AudienceId: ").Append(AudienceId).Append("\n");
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
            return this.Equals(input as CustomerProfileAudienceRequestItem);
        }

        /// <summary>
        /// Returns true if CustomerProfileAudienceRequestItem instances are equal
        /// </summary>
        /// <param name="input">Instance of CustomerProfileAudienceRequestItem to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(CustomerProfileAudienceRequestItem input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.Action == input.Action ||
                    this.Action.Equals(input.Action)
                ) && 
                (
                    this.ProfileIntegrationId == input.ProfileIntegrationId ||
                    (this.ProfileIntegrationId != null &&
                    this.ProfileIntegrationId.Equals(input.ProfileIntegrationId))
                ) && 
                (
                    this.AudienceId == input.AudienceId ||
                    this.AudienceId.Equals(input.AudienceId)
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
                hashCode = hashCode * 59 + this.Action.GetHashCode();
                if (this.ProfileIntegrationId != null)
                    hashCode = hashCode * 59 + this.ProfileIntegrationId.GetHashCode();
                hashCode = hashCode * 59 + this.AudienceId.GetHashCode();
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
            // ProfileIntegrationId (string) maxLength
            if(this.ProfileIntegrationId != null && this.ProfileIntegrationId.Length > 1000)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for ProfileIntegrationId, length must be less than 1000.", new [] { "ProfileIntegrationId" });
            }

            yield break;
        }
    }

}
