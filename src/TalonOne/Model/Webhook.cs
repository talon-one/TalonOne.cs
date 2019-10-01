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
    /// Webhook
    /// </summary>
    [DataContract]
    public partial class Webhook :  IEquatable<Webhook>, IValidatableObject
    {
        /// <summary>
        /// API method for this webhook
        /// </summary>
        /// <value>API method for this webhook</value>
        [JsonConverter(typeof(StringEnumConverter))]
        public enum VerbEnum
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
        /// API method for this webhook
        /// </summary>
        /// <value>API method for this webhook</value>
        [DataMember(Name="verb", EmitDefaultValue=false)]
        public VerbEnum Verb { get; set; }
        /// <summary>
        /// Initializes a new instance of the <see cref="Webhook" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected Webhook() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="Webhook" /> class.
        /// </summary>
        /// <param name="id">Unique ID for this entity. (required).</param>
        /// <param name="created">The exact moment this entity was created. (required).</param>
        /// <param name="modified">The exact moment this entity was last modified. (required).</param>
        /// <param name="applicationIds">The IDs of the applications that are related to this entity. The IDs of the applications that are related to this entity. (required).</param>
        /// <param name="title">Friendly title for this webhook (required).</param>
        /// <param name="verb">API method for this webhook (required).</param>
        /// <param name="url">API url (supports templating using parameters) for this webhook (required).</param>
        /// <param name="headers">List of API HTTP headers for this webhook (required).</param>
        /// <param name="payload">API payload (supports templating using parameters) for this webhook.</param>
        /// <param name="_params">Array of template argument definitions (required).</param>
        /// <param name="enabled">Enables or disables webhook from showing in rule builder (required).</param>
        public Webhook(int? id = default(int?), DateTime? created = default(DateTime?), DateTime? modified = default(DateTime?), List<int?> applicationIds = default(List<int?>), string title = default(string), VerbEnum verb = default(VerbEnum), string url = default(string), List<string> headers = default(List<string>), string payload = default(string), List<TemplateArgDef> _params = default(List<TemplateArgDef>), bool? enabled = default(bool?))
        {
            // to ensure "id" is required (not null)
            if (id == null)
            {
                throw new InvalidDataException("id is a required property for Webhook and cannot be null");
            }
            else
            {
                this.Id = id;
            }
            // to ensure "created" is required (not null)
            if (created == null)
            {
                throw new InvalidDataException("created is a required property for Webhook and cannot be null");
            }
            else
            {
                this.Created = created;
            }
            // to ensure "modified" is required (not null)
            if (modified == null)
            {
                throw new InvalidDataException("modified is a required property for Webhook and cannot be null");
            }
            else
            {
                this.Modified = modified;
            }
            // to ensure "applicationIds" is required (not null)
            if (applicationIds == null)
            {
                throw new InvalidDataException("applicationIds is a required property for Webhook and cannot be null");
            }
            else
            {
                this.ApplicationIds = applicationIds;
            }
            // to ensure "title" is required (not null)
            if (title == null)
            {
                throw new InvalidDataException("title is a required property for Webhook and cannot be null");
            }
            else
            {
                this.Title = title;
            }
            // to ensure "verb" is required (not null)
            if (verb == null)
            {
                throw new InvalidDataException("verb is a required property for Webhook and cannot be null");
            }
            else
            {
                this.Verb = verb;
            }
            // to ensure "url" is required (not null)
            if (url == null)
            {
                throw new InvalidDataException("url is a required property for Webhook and cannot be null");
            }
            else
            {
                this.Url = url;
            }
            // to ensure "headers" is required (not null)
            if (headers == null)
            {
                throw new InvalidDataException("headers is a required property for Webhook and cannot be null");
            }
            else
            {
                this.Headers = headers;
            }
            // to ensure "_params" is required (not null)
            if (_params == null)
            {
                throw new InvalidDataException("_params is a required property for Webhook and cannot be null");
            }
            else
            {
                this.Params = _params;
            }
            // to ensure "enabled" is required (not null)
            if (enabled == null)
            {
                throw new InvalidDataException("enabled is a required property for Webhook and cannot be null");
            }
            else
            {
                this.Enabled = enabled;
            }
            this.Payload = payload;
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
        /// The exact moment this entity was last modified.
        /// </summary>
        /// <value>The exact moment this entity was last modified.</value>
        [DataMember(Name="modified", EmitDefaultValue=false)]
        public DateTime? Modified { get; set; }

        /// <summary>
        /// The IDs of the applications that are related to this entity. The IDs of the applications that are related to this entity.
        /// </summary>
        /// <value>The IDs of the applications that are related to this entity. The IDs of the applications that are related to this entity.</value>
        [DataMember(Name="applicationIds", EmitDefaultValue=false)]
        public List<int?> ApplicationIds { get; set; }

        /// <summary>
        /// Friendly title for this webhook
        /// </summary>
        /// <value>Friendly title for this webhook</value>
        [DataMember(Name="title", EmitDefaultValue=false)]
        public string Title { get; set; }


        /// <summary>
        /// API url (supports templating using parameters) for this webhook
        /// </summary>
        /// <value>API url (supports templating using parameters) for this webhook</value>
        [DataMember(Name="url", EmitDefaultValue=false)]
        public string Url { get; set; }

        /// <summary>
        /// List of API HTTP headers for this webhook
        /// </summary>
        /// <value>List of API HTTP headers for this webhook</value>
        [DataMember(Name="headers", EmitDefaultValue=false)]
        public List<string> Headers { get; set; }

        /// <summary>
        /// API payload (supports templating using parameters) for this webhook
        /// </summary>
        /// <value>API payload (supports templating using parameters) for this webhook</value>
        [DataMember(Name="payload", EmitDefaultValue=false)]
        public string Payload { get; set; }

        /// <summary>
        /// Array of template argument definitions
        /// </summary>
        /// <value>Array of template argument definitions</value>
        [DataMember(Name="params", EmitDefaultValue=false)]
        public List<TemplateArgDef> Params { get; set; }

        /// <summary>
        /// Enables or disables webhook from showing in rule builder
        /// </summary>
        /// <value>Enables or disables webhook from showing in rule builder</value>
        [DataMember(Name="enabled", EmitDefaultValue=false)]
        public bool? Enabled { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class Webhook {\n");
            sb.Append("  Id: ").Append(Id).Append("\n");
            sb.Append("  Created: ").Append(Created).Append("\n");
            sb.Append("  Modified: ").Append(Modified).Append("\n");
            sb.Append("  ApplicationIds: ").Append(ApplicationIds).Append("\n");
            sb.Append("  Title: ").Append(Title).Append("\n");
            sb.Append("  Verb: ").Append(Verb).Append("\n");
            sb.Append("  Url: ").Append(Url).Append("\n");
            sb.Append("  Headers: ").Append(Headers).Append("\n");
            sb.Append("  Payload: ").Append(Payload).Append("\n");
            sb.Append("  Params: ").Append(Params).Append("\n");
            sb.Append("  Enabled: ").Append(Enabled).Append("\n");
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
            return this.Equals(input as Webhook);
        }

        /// <summary>
        /// Returns true if Webhook instances are equal
        /// </summary>
        /// <param name="input">Instance of Webhook to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(Webhook input)
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
                    this.Modified == input.Modified ||
                    (this.Modified != null &&
                    this.Modified.Equals(input.Modified))
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
                    this.Verb == input.Verb ||
                    (this.Verb != null &&
                    this.Verb.Equals(input.Verb))
                ) && 
                (
                    this.Url == input.Url ||
                    (this.Url != null &&
                    this.Url.Equals(input.Url))
                ) && 
                (
                    this.Headers == input.Headers ||
                    this.Headers != null &&
                    this.Headers.SequenceEqual(input.Headers)
                ) && 
                (
                    this.Payload == input.Payload ||
                    (this.Payload != null &&
                    this.Payload.Equals(input.Payload))
                ) && 
                (
                    this.Params == input.Params ||
                    this.Params != null &&
                    this.Params.SequenceEqual(input.Params)
                ) && 
                (
                    this.Enabled == input.Enabled ||
                    (this.Enabled != null &&
                    this.Enabled.Equals(input.Enabled))
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
                if (this.Modified != null)
                    hashCode = hashCode * 59 + this.Modified.GetHashCode();
                if (this.ApplicationIds != null)
                    hashCode = hashCode * 59 + this.ApplicationIds.GetHashCode();
                if (this.Title != null)
                    hashCode = hashCode * 59 + this.Title.GetHashCode();
                if (this.Verb != null)
                    hashCode = hashCode * 59 + this.Verb.GetHashCode();
                if (this.Url != null)
                    hashCode = hashCode * 59 + this.Url.GetHashCode();
                if (this.Headers != null)
                    hashCode = hashCode * 59 + this.Headers.GetHashCode();
                if (this.Payload != null)
                    hashCode = hashCode * 59 + this.Payload.GetHashCode();
                if (this.Params != null)
                    hashCode = hashCode * 59 + this.Params.GetHashCode();
                if (this.Enabled != null)
                    hashCode = hashCode * 59 + this.Enabled.GetHashCode();
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
