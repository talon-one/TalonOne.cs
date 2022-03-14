/* 
 * Talon.One API
 *
 * Use the Talon.One API to integrate with your application and to manage applications and campaigns:  - Use the operations in the [Integration API section](#integration-api) are used to integrate with our platform - Use the operation in the [Management API section](#management-api) to manage applications and campaigns.  ## Determining the base URL of the endpoints  The API is available at the same hostname as your Campaign Manager deployment. For example, if you are reading this page at `https://mycompany.talon.one/docs/api/`, the URL for the [updateCustomerSession](https://docs.talon.one/integration-api/#operation/updateCustomerSessionV2) endpoint is `https://mycompany.talon.one/v2/customer_sessions/{Id}` 
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
    /// NewAudience
    /// </summary>
    [DataContract]
    public partial class NewAudience :  IEquatable<NewAudience>, IValidatableObject
    {
        /// <summary>
        /// Integration that this audience was created in. Can be used for mParticle and Segment audiences.
        /// </summary>
        /// <value>Integration that this audience was created in. Can be used for mParticle and Segment audiences.</value>
        [JsonConverter(typeof(StringEnumConverter))]
        public enum IntegrationEnum
        {
            /// <summary>
            /// Enum Mparticle for value: mparticle
            /// </summary>
            [EnumMember(Value = "mparticle")]
            Mparticle = 1,

            /// <summary>
            /// Enum Segment for value: segment
            /// </summary>
            [EnumMember(Value = "segment")]
            Segment = 2

        }

        /// <summary>
        /// Integration that this audience was created in. Can be used for mParticle and Segment audiences.
        /// </summary>
        /// <value>Integration that this audience was created in. Can be used for mParticle and Segment audiences.</value>
        [DataMember(Name="integration", EmitDefaultValue=false)]
        public IntegrationEnum? Integration { get; set; }
        /// <summary>
        /// Initializes a new instance of the <see cref="NewAudience" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected NewAudience() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="NewAudience" /> class.
        /// </summary>
        /// <param name="name">The human-friendly display name for this audience. (required).</param>
        /// <param name="integration">Integration that this audience was created in. Can be used for mParticle and Segment audiences..</param>
        /// <param name="integrationId">The ID of this audience in the third-party integration..</param>
        public NewAudience(string name = default(string), IntegrationEnum? integration = default(IntegrationEnum?), string integrationId = default(string))
        {
            // to ensure "name" is required (not null)
            this.Name = name ?? throw new ArgumentNullException("name is a required property for NewAudience and cannot be null");
            this.Integration = integration;
            this.IntegrationId = integrationId;
        }
        
        /// <summary>
        /// The human-friendly display name for this audience.
        /// </summary>
        /// <value>The human-friendly display name for this audience.</value>
        [DataMember(Name="name", EmitDefaultValue=false)]
        public string Name { get; set; }

        /// <summary>
        /// The ID of this audience in the third-party integration.
        /// </summary>
        /// <value>The ID of this audience in the third-party integration.</value>
        [DataMember(Name="integrationId", EmitDefaultValue=false)]
        public string IntegrationId { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class NewAudience {\n");
            sb.Append("  Name: ").Append(Name).Append("\n");
            sb.Append("  Integration: ").Append(Integration).Append("\n");
            sb.Append("  IntegrationId: ").Append(IntegrationId).Append("\n");
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
            return this.Equals(input as NewAudience);
        }

        /// <summary>
        /// Returns true if NewAudience instances are equal
        /// </summary>
        /// <param name="input">Instance of NewAudience to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(NewAudience input)
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
                    this.Integration == input.Integration ||
                    this.Integration.Equals(input.Integration)
                ) && 
                (
                    this.IntegrationId == input.IntegrationId ||
                    (this.IntegrationId != null &&
                    this.IntegrationId.Equals(input.IntegrationId))
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
                hashCode = hashCode * 59 + this.Integration.GetHashCode();
                if (this.IntegrationId != null)
                    hashCode = hashCode * 59 + this.IntegrationId.GetHashCode();
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
            // Name (string) minLength
            if(this.Name != null && this.Name.Length < 1)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for Name, length must be greater than 1.", new [] { "Name" });
            }

            // IntegrationId (string) minLength
            if(this.IntegrationId != null && this.IntegrationId.Length < 1)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for IntegrationId, length must be greater than 1.", new [] { "IntegrationId" });
            }

            yield break;
        }
    }

}
