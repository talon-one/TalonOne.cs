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
    /// OutgoingIntegrationTemplateWithConfigurationDetails
    /// </summary>
    [DataContract]
    public partial class OutgoingIntegrationTemplateWithConfigurationDetails :  IEquatable<OutgoingIntegrationTemplateWithConfigurationDetails>, IValidatableObject
    {
        /// <summary>
        /// API method for this webhook.
        /// </summary>
        /// <value>API method for this webhook.</value>
        [JsonConverter(typeof(StringEnumConverter))]
        public enum MethodEnum
        {
            /// <summary>
            /// Enum POST for value: POST
            /// </summary>
            [EnumMember(Value = "POST")]
            POST = 1,

            /// <summary>
            /// Enum PUT for value: PUT
            /// </summary>
            [EnumMember(Value = "PUT")]
            PUT = 2,

            /// <summary>
            /// Enum GET for value: GET
            /// </summary>
            [EnumMember(Value = "GET")]
            GET = 3,

            /// <summary>
            /// Enum DELETE for value: DELETE
            /// </summary>
            [EnumMember(Value = "DELETE")]
            DELETE = 4,

            /// <summary>
            /// Enum PATCH for value: PATCH
            /// </summary>
            [EnumMember(Value = "PATCH")]
            PATCH = 5

        }

        /// <summary>
        /// API method for this webhook.
        /// </summary>
        /// <value>API method for this webhook.</value>
        [DataMember(Name="method", EmitDefaultValue=false)]
        public MethodEnum Method { get; set; }
        /// <summary>
        /// Initializes a new instance of the <see cref="OutgoingIntegrationTemplateWithConfigurationDetails" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected OutgoingIntegrationTemplateWithConfigurationDetails() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="OutgoingIntegrationTemplateWithConfigurationDetails" /> class.
        /// </summary>
        /// <param name="id">Unique ID for this entity. (required).</param>
        /// <param name="integrationType">Unique ID of outgoing integration type. (required).</param>
        /// <param name="title">The title of the integration template. (required).</param>
        /// <param name="description">The description of the specific outgoing integration template. (required).</param>
        /// <param name="payload">The API payload (supports templating using parameters) for this integration template. (required).</param>
        /// <param name="method">API method for this webhook. (required).</param>
        /// <param name="relativeUrl">The relative URL corresponding to each integration template. (required).</param>
        /// <param name="headers">The list of HTTP headers for this integration template. (required).</param>
        /// <param name="policy">The outgoing integration policy specific to each integration type. (required).</param>
        public OutgoingIntegrationTemplateWithConfigurationDetails(int id = default(int), int integrationType = default(int), string title = default(string), string description = default(string), string payload = default(string), MethodEnum method = default(MethodEnum), string relativeUrl = default(string), List<string> headers = default(List<string>), Object policy = default(Object))
        {
            this.Id = id;
            this.IntegrationType = integrationType;
            // to ensure "title" is required (not null)
            this.Title = title ?? throw new ArgumentNullException("title is a required property for OutgoingIntegrationTemplateWithConfigurationDetails and cannot be null");
            // to ensure "description" is required (not null)
            this.Description = description ?? throw new ArgumentNullException("description is a required property for OutgoingIntegrationTemplateWithConfigurationDetails and cannot be null");
            // to ensure "payload" is required (not null)
            this.Payload = payload ?? throw new ArgumentNullException("payload is a required property for OutgoingIntegrationTemplateWithConfigurationDetails and cannot be null");
            this.Method = method;
            // to ensure "relativeUrl" is required (not null)
            this.RelativeUrl = relativeUrl ?? throw new ArgumentNullException("relativeUrl is a required property for OutgoingIntegrationTemplateWithConfigurationDetails and cannot be null");
            // to ensure "headers" is required (not null)
            this.Headers = headers ?? throw new ArgumentNullException("headers is a required property for OutgoingIntegrationTemplateWithConfigurationDetails and cannot be null");
            // to ensure "policy" is required (not null)
            this.Policy = policy ?? throw new ArgumentNullException("policy is a required property for OutgoingIntegrationTemplateWithConfigurationDetails and cannot be null");
        }
        
        /// <summary>
        /// Unique ID for this entity.
        /// </summary>
        /// <value>Unique ID for this entity.</value>
        [DataMember(Name="id", EmitDefaultValue=false)]
        public int Id { get; set; }

        /// <summary>
        /// Unique ID of outgoing integration type.
        /// </summary>
        /// <value>Unique ID of outgoing integration type.</value>
        [DataMember(Name="integrationType", EmitDefaultValue=false)]
        public int IntegrationType { get; set; }

        /// <summary>
        /// The title of the integration template.
        /// </summary>
        /// <value>The title of the integration template.</value>
        [DataMember(Name="title", EmitDefaultValue=false)]
        public string Title { get; set; }

        /// <summary>
        /// The description of the specific outgoing integration template.
        /// </summary>
        /// <value>The description of the specific outgoing integration template.</value>
        [DataMember(Name="description", EmitDefaultValue=false)]
        public string Description { get; set; }

        /// <summary>
        /// The API payload (supports templating using parameters) for this integration template.
        /// </summary>
        /// <value>The API payload (supports templating using parameters) for this integration template.</value>
        [DataMember(Name="payload", EmitDefaultValue=false)]
        public string Payload { get; set; }

        /// <summary>
        /// The relative URL corresponding to each integration template.
        /// </summary>
        /// <value>The relative URL corresponding to each integration template.</value>
        [DataMember(Name="relativeUrl", EmitDefaultValue=false)]
        public string RelativeUrl { get; set; }

        /// <summary>
        /// The list of HTTP headers for this integration template.
        /// </summary>
        /// <value>The list of HTTP headers for this integration template.</value>
        [DataMember(Name="headers", EmitDefaultValue=false)]
        public List<string> Headers { get; set; }

        /// <summary>
        /// The outgoing integration policy specific to each integration type.
        /// </summary>
        /// <value>The outgoing integration policy specific to each integration type.</value>
        [DataMember(Name="policy", EmitDefaultValue=false)]
        public Object Policy { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class OutgoingIntegrationTemplateWithConfigurationDetails {\n");
            sb.Append("  Id: ").Append(Id).Append("\n");
            sb.Append("  IntegrationType: ").Append(IntegrationType).Append("\n");
            sb.Append("  Title: ").Append(Title).Append("\n");
            sb.Append("  Description: ").Append(Description).Append("\n");
            sb.Append("  Payload: ").Append(Payload).Append("\n");
            sb.Append("  Method: ").Append(Method).Append("\n");
            sb.Append("  RelativeUrl: ").Append(RelativeUrl).Append("\n");
            sb.Append("  Headers: ").Append(Headers).Append("\n");
            sb.Append("  Policy: ").Append(Policy).Append("\n");
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
            return this.Equals(input as OutgoingIntegrationTemplateWithConfigurationDetails);
        }

        /// <summary>
        /// Returns true if OutgoingIntegrationTemplateWithConfigurationDetails instances are equal
        /// </summary>
        /// <param name="input">Instance of OutgoingIntegrationTemplateWithConfigurationDetails to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(OutgoingIntegrationTemplateWithConfigurationDetails input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.Id == input.Id ||
                    this.Id.Equals(input.Id)
                ) && 
                (
                    this.IntegrationType == input.IntegrationType ||
                    this.IntegrationType.Equals(input.IntegrationType)
                ) && 
                (
                    this.Title == input.Title ||
                    (this.Title != null &&
                    this.Title.Equals(input.Title))
                ) && 
                (
                    this.Description == input.Description ||
                    (this.Description != null &&
                    this.Description.Equals(input.Description))
                ) && 
                (
                    this.Payload == input.Payload ||
                    (this.Payload != null &&
                    this.Payload.Equals(input.Payload))
                ) && 
                (
                    this.Method == input.Method ||
                    this.Method.Equals(input.Method)
                ) && 
                (
                    this.RelativeUrl == input.RelativeUrl ||
                    (this.RelativeUrl != null &&
                    this.RelativeUrl.Equals(input.RelativeUrl))
                ) && 
                (
                    this.Headers == input.Headers ||
                    this.Headers != null &&
                    input.Headers != null &&
                    this.Headers.SequenceEqual(input.Headers)
                ) && 
                (
                    this.Policy == input.Policy ||
                    (this.Policy != null &&
                    this.Policy.Equals(input.Policy))
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
                hashCode = hashCode * 59 + this.Id.GetHashCode();
                hashCode = hashCode * 59 + this.IntegrationType.GetHashCode();
                if (this.Title != null)
                    hashCode = hashCode * 59 + this.Title.GetHashCode();
                if (this.Description != null)
                    hashCode = hashCode * 59 + this.Description.GetHashCode();
                if (this.Payload != null)
                    hashCode = hashCode * 59 + this.Payload.GetHashCode();
                hashCode = hashCode * 59 + this.Method.GetHashCode();
                if (this.RelativeUrl != null)
                    hashCode = hashCode * 59 + this.RelativeUrl.GetHashCode();
                if (this.Headers != null)
                    hashCode = hashCode * 59 + this.Headers.GetHashCode();
                if (this.Policy != null)
                    hashCode = hashCode * 59 + this.Policy.GetHashCode();
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
            // Title (string) maxLength
            if(this.Title != null && this.Title.Length > 255)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for Title, length must be less than 255.", new [] { "Title" });
            }

            // Title (string) minLength
            if(this.Title != null && this.Title.Length < 1)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for Title, length must be greater than 1.", new [] { "Title" });
            }

            // Description (string) maxLength
            if(this.Description != null && this.Description.Length > 1000)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for Description, length must be less than 1000.", new [] { "Description" });
            }

            // Description (string) minLength
            if(this.Description != null && this.Description.Length < 1)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for Description, length must be greater than 1.", new [] { "Description" });
            }

            yield break;
        }
    }

}
