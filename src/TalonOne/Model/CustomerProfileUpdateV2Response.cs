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
    /// Contains the updated customer profiles entities. This is the response type returned by the V2 PUT customer_profiles endpoint 
    /// </summary>
    [DataContract]
    public partial class CustomerProfileUpdateV2Response :  IEquatable<CustomerProfileUpdateV2Response>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="CustomerProfileUpdateV2Response" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected CustomerProfileUpdateV2Response() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="CustomerProfileUpdateV2Response" /> class.
        /// </summary>
        /// <param name="customerProfile">customerProfile (required).</param>
        public CustomerProfileUpdateV2Response(CustomerProfile customerProfile = default(CustomerProfile))
        {
            // to ensure "customerProfile" is required (not null)
            this.CustomerProfile = customerProfile ?? throw new ArgumentNullException("customerProfile is a required property for CustomerProfileUpdateV2Response and cannot be null");
        }
        
        /// <summary>
        /// Gets or Sets CustomerProfile
        /// </summary>
        [DataMember(Name="customerProfile", EmitDefaultValue=false)]
        public CustomerProfile CustomerProfile { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class CustomerProfileUpdateV2Response {\n");
            sb.Append("  CustomerProfile: ").Append(CustomerProfile).Append("\n");
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
            return this.Equals(input as CustomerProfileUpdateV2Response);
        }

        /// <summary>
        /// Returns true if CustomerProfileUpdateV2Response instances are equal
        /// </summary>
        /// <param name="input">Instance of CustomerProfileUpdateV2Response to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(CustomerProfileUpdateV2Response input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.CustomerProfile == input.CustomerProfile ||
                    (this.CustomerProfile != null &&
                    this.CustomerProfile.Equals(input.CustomerProfile))
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
                if (this.CustomerProfile != null)
                    hashCode = hashCode * 59 + this.CustomerProfile.GetHashCode();
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