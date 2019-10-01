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
    /// EventType
    /// </summary>
    [DataContract]
    public partial class EventType :  IEquatable<EventType>, IValidatableObject
    {
        /// <summary>
        /// This defines how the request payload will be parsed before your handler code is run.
        /// </summary>
        /// <value>This defines how the request payload will be parsed before your handler code is run.</value>
        [JsonConverter(typeof(StringEnumConverter))]
        public enum MimeTypeEnum
        {
            
            /// <summary>
            /// Enum ApplicationJson for value: application/json
            /// </summary>
            [EnumMember(Value = "application/json")]
            ApplicationJson = 1,
            
            /// <summary>
            /// Enum ApplicationXWwwFormUrlencoded for value: application/x-www-form-urlencoded
            /// </summary>
            [EnumMember(Value = "application/x-www-form-urlencoded")]
            ApplicationXWwwFormUrlencoded = 2,
            
            /// <summary>
            /// Enum None for value: none
            /// </summary>
            [EnumMember(Value = "none")]
            None = 3
        }

        /// <summary>
        /// This defines how the request payload will be parsed before your handler code is run.
        /// </summary>
        /// <value>This defines how the request payload will be parsed before your handler code is run.</value>
        [DataMember(Name="mimeType", EmitDefaultValue=false)]
        public MimeTypeEnum MimeType { get; set; }
        /// <summary>
        /// The language of the handler code. Currently only &#x60;\&quot;talang\&quot;&#x60; is supported.
        /// </summary>
        /// <value>The language of the handler code. Currently only &#x60;\&quot;talang\&quot;&#x60; is supported.</value>
        [JsonConverter(typeof(StringEnumConverter))]
        public enum HandlerLanguageEnum
        {
            
            /// <summary>
            /// Enum Talang for value: talang
            /// </summary>
            [EnumMember(Value = "talang")]
            Talang = 1
        }

        /// <summary>
        /// The language of the handler code. Currently only &#x60;\&quot;talang\&quot;&#x60; is supported.
        /// </summary>
        /// <value>The language of the handler code. Currently only &#x60;\&quot;talang\&quot;&#x60; is supported.</value>
        [DataMember(Name="handlerLanguage", EmitDefaultValue=false)]
        public HandlerLanguageEnum? HandlerLanguage { get; set; }
        /// <summary>
        /// Initializes a new instance of the <see cref="EventType" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected EventType() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="EventType" /> class.
        /// </summary>
        /// <param name="id">Unique ID for this entity. (required).</param>
        /// <param name="created">The exact moment this entity was created. (required).</param>
        /// <param name="applicationIds">The IDs of the applications that are related to this entity. (required).</param>
        /// <param name="title">The human-friendly display name for this event type. Use a short, past-tense, description of the event. (required).</param>
        /// <param name="name">The machine-friendly canonical name for this event type. This will be used in URLs, and cannot be changed after an event type has been created. (required).</param>
        /// <param name="description">An explanation of when the event type is triggered. Write this with a campaign manager in mind. For example:  &gt; The \&quot;Payment Accepted\&quot; event is triggered after successful processing of a payment by our payment gateway.  (required).</param>
        /// <param name="mimeType">This defines how the request payload will be parsed before your handler code is run. (required).</param>
        /// <param name="examplePayload">It is often helpful to include an example payload with the event type definition for documentation purposes..</param>
        /// <param name="schema">It is strongly recommended to define a JSON schema that will be used to perform structural validation of request payloads after parsing. .</param>
        /// <param name="handlerLanguage">The language of the handler code. Currently only &#x60;\&quot;talang\&quot;&#x60; is supported..</param>
        /// <param name="handler">Code that will be run after successful parsing &amp; validation of the payload for this event. This code _may_ choose to evaluate campaign rules.  (required).</param>
        /// <param name="version">The version of this event type. When updating an existing event type this must be **exactly** &#x60;currentVersion + 1&#x60;.  (required).</param>
        public EventType(int? id = default(int?), DateTime? created = default(DateTime?), List<int?> applicationIds = default(List<int?>), string title = default(string), string name = default(string), string description = default(string), MimeTypeEnum mimeType = default(MimeTypeEnum), string examplePayload = default(string), Object schema = default(Object), HandlerLanguageEnum? handlerLanguage = default(HandlerLanguageEnum?), string handler = default(string), int? version = default(int?))
        {
            // to ensure "id" is required (not null)
            if (id == null)
            {
                throw new InvalidDataException("id is a required property for EventType and cannot be null");
            }
            else
            {
                this.Id = id;
            }
            // to ensure "created" is required (not null)
            if (created == null)
            {
                throw new InvalidDataException("created is a required property for EventType and cannot be null");
            }
            else
            {
                this.Created = created;
            }
            // to ensure "applicationIds" is required (not null)
            if (applicationIds == null)
            {
                throw new InvalidDataException("applicationIds is a required property for EventType and cannot be null");
            }
            else
            {
                this.ApplicationIds = applicationIds;
            }
            // to ensure "title" is required (not null)
            if (title == null)
            {
                throw new InvalidDataException("title is a required property for EventType and cannot be null");
            }
            else
            {
                this.Title = title;
            }
            // to ensure "name" is required (not null)
            if (name == null)
            {
                throw new InvalidDataException("name is a required property for EventType and cannot be null");
            }
            else
            {
                this.Name = name;
            }
            // to ensure "description" is required (not null)
            if (description == null)
            {
                throw new InvalidDataException("description is a required property for EventType and cannot be null");
            }
            else
            {
                this.Description = description;
            }
            // to ensure "mimeType" is required (not null)
            if (mimeType == null)
            {
                throw new InvalidDataException("mimeType is a required property for EventType and cannot be null");
            }
            else
            {
                this.MimeType = mimeType;
            }
            // to ensure "handler" is required (not null)
            if (handler == null)
            {
                throw new InvalidDataException("handler is a required property for EventType and cannot be null");
            }
            else
            {
                this.Handler = handler;
            }
            // to ensure "version" is required (not null)
            if (version == null)
            {
                throw new InvalidDataException("version is a required property for EventType and cannot be null");
            }
            else
            {
                this.Version = version;
            }
            this.ExamplePayload = examplePayload;
            this.Schema = schema;
            this.HandlerLanguage = handlerLanguage;
        }
        
        /// <summary>
        /// Unique ID for this entity.
        /// </summary>
        /// <value>Unique ID for this entity.</value>
        [DataMember(Name="id", EmitDefaultValue=false)]
        public int? Id { get; set; }

        /// <summary>
        /// The exact moment this entity was created.
        /// </summary>
        /// <value>The exact moment this entity was created.</value>
        [DataMember(Name="created", EmitDefaultValue=false)]
        public DateTime? Created { get; set; }

        /// <summary>
        /// The IDs of the applications that are related to this entity.
        /// </summary>
        /// <value>The IDs of the applications that are related to this entity.</value>
        [DataMember(Name="applicationIds", EmitDefaultValue=false)]
        public List<int?> ApplicationIds { get; set; }

        /// <summary>
        /// The human-friendly display name for this event type. Use a short, past-tense, description of the event.
        /// </summary>
        /// <value>The human-friendly display name for this event type. Use a short, past-tense, description of the event.</value>
        [DataMember(Name="title", EmitDefaultValue=false)]
        public string Title { get; set; }

        /// <summary>
        /// The machine-friendly canonical name for this event type. This will be used in URLs, and cannot be changed after an event type has been created.
        /// </summary>
        /// <value>The machine-friendly canonical name for this event type. This will be used in URLs, and cannot be changed after an event type has been created.</value>
        [DataMember(Name="name", EmitDefaultValue=false)]
        public string Name { get; set; }

        /// <summary>
        /// An explanation of when the event type is triggered. Write this with a campaign manager in mind. For example:  &gt; The \&quot;Payment Accepted\&quot; event is triggered after successful processing of a payment by our payment gateway. 
        /// </summary>
        /// <value>An explanation of when the event type is triggered. Write this with a campaign manager in mind. For example:  &gt; The \&quot;Payment Accepted\&quot; event is triggered after successful processing of a payment by our payment gateway. </value>
        [DataMember(Name="description", EmitDefaultValue=false)]
        public string Description { get; set; }


        /// <summary>
        /// It is often helpful to include an example payload with the event type definition for documentation purposes.
        /// </summary>
        /// <value>It is often helpful to include an example payload with the event type definition for documentation purposes.</value>
        [DataMember(Name="examplePayload", EmitDefaultValue=false)]
        public string ExamplePayload { get; set; }

        /// <summary>
        /// It is strongly recommended to define a JSON schema that will be used to perform structural validation of request payloads after parsing. 
        /// </summary>
        /// <value>It is strongly recommended to define a JSON schema that will be used to perform structural validation of request payloads after parsing. </value>
        [DataMember(Name="schema", EmitDefaultValue=false)]
        public Object Schema { get; set; }


        /// <summary>
        /// Code that will be run after successful parsing &amp; validation of the payload for this event. This code _may_ choose to evaluate campaign rules. 
        /// </summary>
        /// <value>Code that will be run after successful parsing &amp; validation of the payload for this event. This code _may_ choose to evaluate campaign rules. </value>
        [DataMember(Name="handler", EmitDefaultValue=false)]
        public string Handler { get; set; }

        /// <summary>
        /// The version of this event type. When updating an existing event type this must be **exactly** &#x60;currentVersion + 1&#x60;. 
        /// </summary>
        /// <value>The version of this event type. When updating an existing event type this must be **exactly** &#x60;currentVersion + 1&#x60;. </value>
        [DataMember(Name="version", EmitDefaultValue=false)]
        public int? Version { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class EventType {\n");
            sb.Append("  Id: ").Append(Id).Append("\n");
            sb.Append("  Created: ").Append(Created).Append("\n");
            sb.Append("  ApplicationIds: ").Append(ApplicationIds).Append("\n");
            sb.Append("  Title: ").Append(Title).Append("\n");
            sb.Append("  Name: ").Append(Name).Append("\n");
            sb.Append("  Description: ").Append(Description).Append("\n");
            sb.Append("  MimeType: ").Append(MimeType).Append("\n");
            sb.Append("  ExamplePayload: ").Append(ExamplePayload).Append("\n");
            sb.Append("  Schema: ").Append(Schema).Append("\n");
            sb.Append("  HandlerLanguage: ").Append(HandlerLanguage).Append("\n");
            sb.Append("  Handler: ").Append(Handler).Append("\n");
            sb.Append("  Version: ").Append(Version).Append("\n");
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
            return this.Equals(input as EventType);
        }

        /// <summary>
        /// Returns true if EventType instances are equal
        /// </summary>
        /// <param name="input">Instance of EventType to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(EventType input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.Id == input.Id ||
                    (this.Id != null &&
                    this.Id.Equals(input.Id))
                ) && 
                (
                    this.Created == input.Created ||
                    (this.Created != null &&
                    this.Created.Equals(input.Created))
                ) && 
                (
                    this.ApplicationIds == input.ApplicationIds ||
                    this.ApplicationIds != null &&
                    this.ApplicationIds.SequenceEqual(input.ApplicationIds)
                ) && 
                (
                    this.Title == input.Title ||
                    (this.Title != null &&
                    this.Title.Equals(input.Title))
                ) && 
                (
                    this.Name == input.Name ||
                    (this.Name != null &&
                    this.Name.Equals(input.Name))
                ) && 
                (
                    this.Description == input.Description ||
                    (this.Description != null &&
                    this.Description.Equals(input.Description))
                ) && 
                (
                    this.MimeType == input.MimeType ||
                    (this.MimeType != null &&
                    this.MimeType.Equals(input.MimeType))
                ) && 
                (
                    this.ExamplePayload == input.ExamplePayload ||
                    (this.ExamplePayload != null &&
                    this.ExamplePayload.Equals(input.ExamplePayload))
                ) && 
                (
                    this.Schema == input.Schema ||
                    (this.Schema != null &&
                    this.Schema.Equals(input.Schema))
                ) && 
                (
                    this.HandlerLanguage == input.HandlerLanguage ||
                    (this.HandlerLanguage != null &&
                    this.HandlerLanguage.Equals(input.HandlerLanguage))
                ) && 
                (
                    this.Handler == input.Handler ||
                    (this.Handler != null &&
                    this.Handler.Equals(input.Handler))
                ) && 
                (
                    this.Version == input.Version ||
                    (this.Version != null &&
                    this.Version.Equals(input.Version))
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
                if (this.Id != null)
                    hashCode = hashCode * 59 + this.Id.GetHashCode();
                if (this.Created != null)
                    hashCode = hashCode * 59 + this.Created.GetHashCode();
                if (this.ApplicationIds != null)
                    hashCode = hashCode * 59 + this.ApplicationIds.GetHashCode();
                if (this.Title != null)
                    hashCode = hashCode * 59 + this.Title.GetHashCode();
                if (this.Name != null)
                    hashCode = hashCode * 59 + this.Name.GetHashCode();
                if (this.Description != null)
                    hashCode = hashCode * 59 + this.Description.GetHashCode();
                if (this.MimeType != null)
                    hashCode = hashCode * 59 + this.MimeType.GetHashCode();
                if (this.ExamplePayload != null)
                    hashCode = hashCode * 59 + this.ExamplePayload.GetHashCode();
                if (this.Schema != null)
                    hashCode = hashCode * 59 + this.Schema.GetHashCode();
                if (this.HandlerLanguage != null)
                    hashCode = hashCode * 59 + this.HandlerLanguage.GetHashCode();
                if (this.Handler != null)
                    hashCode = hashCode * 59 + this.Handler.GetHashCode();
                if (this.Version != null)
                    hashCode = hashCode * 59 + this.Version.GetHashCode();
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
            // Title (string) minLength
            if(this.Title != null && this.Title.Length < 1)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for Title, length must be greater than 1.", new [] { "Title" });
            }

            // Name (string) minLength
            if(this.Name != null && this.Name.Length < 1)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for Name, length must be greater than 1.", new [] { "Name" });
            }

            yield break;
        }
    }

}