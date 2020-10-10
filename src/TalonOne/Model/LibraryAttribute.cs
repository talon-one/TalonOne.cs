/* 
 * Talon.One API
 *
 * The Talon.One API is used to manage applications and campaigns, as well as to integrate with your application. The operations in the _Integration API_ section are used to integrate with our platform, while the other operations are used to manage applications and campaigns.  ### Where is the API?  The API is available at the same hostname as these docs. For example, if you are reading this page at `https://mycompany.talon.one/docs/api/`, the URL for the [updateCustomerProfile][] operation is `https://mycompany.talon.one/v1/customer_profiles/id`  [updateCustomerProfile]: #operation- -v1-customer_profiles- -integrationId- -put 
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
    /// LibraryAttribute
    /// </summary>
    [DataContract]
    public partial class LibraryAttribute :  IEquatable<LibraryAttribute>, IValidatableObject
    {
        /// <summary>
        /// The name of the entity that can have this attribute. When creating or updating the entities of a given type, you can include an &#x60;attributes&#x60; object with keys corresponding to the &#x60;name&#x60; of the custom attributes for that type.
        /// </summary>
        /// <value>The name of the entity that can have this attribute. When creating or updating the entities of a given type, you can include an &#x60;attributes&#x60; object with keys corresponding to the &#x60;name&#x60; of the custom attributes for that type.</value>
        [JsonConverter(typeof(StringEnumConverter))]
        public enum EntityEnum
        {
            /// <summary>
            /// Enum Application for value: Application
            /// </summary>
            [EnumMember(Value = "Application")]
            Application = 1,

            /// <summary>
            /// Enum Campaign for value: Campaign
            /// </summary>
            [EnumMember(Value = "Campaign")]
            Campaign = 2,

            /// <summary>
            /// Enum CustomerProfile for value: CustomerProfile
            /// </summary>
            [EnumMember(Value = "CustomerProfile")]
            CustomerProfile = 3,

            /// <summary>
            /// Enum CustomerSession for value: CustomerSession
            /// </summary>
            [EnumMember(Value = "CustomerSession")]
            CustomerSession = 4,

            /// <summary>
            /// Enum CartItem for value: CartItem
            /// </summary>
            [EnumMember(Value = "CartItem")]
            CartItem = 5,

            /// <summary>
            /// Enum Coupon for value: Coupon
            /// </summary>
            [EnumMember(Value = "Coupon")]
            Coupon = 6,

            /// <summary>
            /// Enum Event for value: Event
            /// </summary>
            [EnumMember(Value = "Event")]
            Event = 7

        }

        /// <summary>
        /// The name of the entity that can have this attribute. When creating or updating the entities of a given type, you can include an &#x60;attributes&#x60; object with keys corresponding to the &#x60;name&#x60; of the custom attributes for that type.
        /// </summary>
        /// <value>The name of the entity that can have this attribute. When creating or updating the entities of a given type, you can include an &#x60;attributes&#x60; object with keys corresponding to the &#x60;name&#x60; of the custom attributes for that type.</value>
        [DataMember(Name="entity", EmitDefaultValue=true)]
        public EntityEnum Entity { get; set; }
        /// <summary>
        /// The data type of the attribute, a &#x60;time&#x60; attribute must be sent as a string that conforms to the [RFC3339](https://www.ietf.org/rfc/rfc3339.txt) timestamp format.
        /// </summary>
        /// <value>The data type of the attribute, a &#x60;time&#x60; attribute must be sent as a string that conforms to the [RFC3339](https://www.ietf.org/rfc/rfc3339.txt) timestamp format.</value>
        [JsonConverter(typeof(StringEnumConverter))]
        public enum TypeEnum
        {
            /// <summary>
            /// Enum String for value: string
            /// </summary>
            [EnumMember(Value = "string")]
            String = 1,

            /// <summary>
            /// Enum Number for value: number
            /// </summary>
            [EnumMember(Value = "number")]
            Number = 2,

            /// <summary>
            /// Enum Boolean for value: boolean
            /// </summary>
            [EnumMember(Value = "boolean")]
            Boolean = 3,

            /// <summary>
            /// Enum Time for value: time
            /// </summary>
            [EnumMember(Value = "time")]
            Time = 4

        }

        /// <summary>
        /// The data type of the attribute, a &#x60;time&#x60; attribute must be sent as a string that conforms to the [RFC3339](https://www.ietf.org/rfc/rfc3339.txt) timestamp format.
        /// </summary>
        /// <value>The data type of the attribute, a &#x60;time&#x60; attribute must be sent as a string that conforms to the [RFC3339](https://www.ietf.org/rfc/rfc3339.txt) timestamp format.</value>
        [DataMember(Name="type", EmitDefaultValue=true)]
        public TypeEnum Type { get; set; }
        /// <summary>
        /// Initializes a new instance of the <see cref="LibraryAttribute" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected LibraryAttribute() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="LibraryAttribute" /> class.
        /// </summary>
        /// <param name="entity">The name of the entity that can have this attribute. When creating or updating the entities of a given type, you can include an &#x60;attributes&#x60; object with keys corresponding to the &#x60;name&#x60; of the custom attributes for that type. (required).</param>
        /// <param name="name">The attribute name that will be used in API requests and Talang. E.g. if &#x60;name &#x3D;&#x3D; \&quot;region\&quot;&#x60; then you would set the region attribute by including an &#x60;attributes.region&#x60; property in your request payload.  (required).</param>
        /// <param name="title">The human-readable name for the attribute that will be shown in the Campaign Manager. Like &#x60;name&#x60;, the combination of entity and title must also be unique. (required).</param>
        /// <param name="type">The data type of the attribute, a &#x60;time&#x60; attribute must be sent as a string that conforms to the [RFC3339](https://www.ietf.org/rfc/rfc3339.txt) timestamp format. (required).</param>
        /// <param name="description">A description of the attribute. (required).</param>
        /// <param name="presets">The presets that indicate to which industry the attribute applies to. (required).</param>
        /// <param name="suggestions">Short suggestions that are used to group attributes. (required).</param>
        public LibraryAttribute(EntityEnum entity = default(EntityEnum), string name = default(string), string title = default(string), TypeEnum type = default(TypeEnum), string description = default(string), List<string> presets = default(List<string>), List<string> suggestions = default(List<string>))
        {
            // to ensure "entity" is required (not null)
            if (entity == null)
            {
                throw new InvalidDataException("entity is a required property for LibraryAttribute and cannot be null");
            }
            else
            {
                this.Entity = entity;
            }
            
            // to ensure "name" is required (not null)
            if (name == null)
            {
                throw new InvalidDataException("name is a required property for LibraryAttribute and cannot be null");
            }
            else
            {
                this.Name = name;
            }
            
            // to ensure "title" is required (not null)
            if (title == null)
            {
                throw new InvalidDataException("title is a required property for LibraryAttribute and cannot be null");
            }
            else
            {
                this.Title = title;
            }
            
            // to ensure "type" is required (not null)
            if (type == null)
            {
                throw new InvalidDataException("type is a required property for LibraryAttribute and cannot be null");
            }
            else
            {
                this.Type = type;
            }
            
            // to ensure "description" is required (not null)
            if (description == null)
            {
                throw new InvalidDataException("description is a required property for LibraryAttribute and cannot be null");
            }
            else
            {
                this.Description = description;
            }
            
            // to ensure "presets" is required (not null)
            if (presets == null)
            {
                throw new InvalidDataException("presets is a required property for LibraryAttribute and cannot be null");
            }
            else
            {
                this.Presets = presets;
            }
            
            // to ensure "suggestions" is required (not null)
            if (suggestions == null)
            {
                throw new InvalidDataException("suggestions is a required property for LibraryAttribute and cannot be null");
            }
            else
            {
                this.Suggestions = suggestions;
            }
            
        }
        

        /// <summary>
        /// The attribute name that will be used in API requests and Talang. E.g. if &#x60;name &#x3D;&#x3D; \&quot;region\&quot;&#x60; then you would set the region attribute by including an &#x60;attributes.region&#x60; property in your request payload. 
        /// </summary>
        /// <value>The attribute name that will be used in API requests and Talang. E.g. if &#x60;name &#x3D;&#x3D; \&quot;region\&quot;&#x60; then you would set the region attribute by including an &#x60;attributes.region&#x60; property in your request payload. </value>
        [DataMember(Name="name", EmitDefaultValue=true)]
        public string Name { get; set; }

        /// <summary>
        /// The human-readable name for the attribute that will be shown in the Campaign Manager. Like &#x60;name&#x60;, the combination of entity and title must also be unique.
        /// </summary>
        /// <value>The human-readable name for the attribute that will be shown in the Campaign Manager. Like &#x60;name&#x60;, the combination of entity and title must also be unique.</value>
        [DataMember(Name="title", EmitDefaultValue=true)]
        public string Title { get; set; }


        /// <summary>
        /// A description of the attribute.
        /// </summary>
        /// <value>A description of the attribute.</value>
        [DataMember(Name="description", EmitDefaultValue=true)]
        public string Description { get; set; }

        /// <summary>
        /// The presets that indicate to which industry the attribute applies to.
        /// </summary>
        /// <value>The presets that indicate to which industry the attribute applies to.</value>
        [DataMember(Name="presets", EmitDefaultValue=true)]
        public List<string> Presets { get; set; }

        /// <summary>
        /// Short suggestions that are used to group attributes.
        /// </summary>
        /// <value>Short suggestions that are used to group attributes.</value>
        [DataMember(Name="suggestions", EmitDefaultValue=true)]
        public List<string> Suggestions { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class LibraryAttribute {\n");
            sb.Append("  Entity: ").Append(Entity).Append("\n");
            sb.Append("  Name: ").Append(Name).Append("\n");
            sb.Append("  Title: ").Append(Title).Append("\n");
            sb.Append("  Type: ").Append(Type).Append("\n");
            sb.Append("  Description: ").Append(Description).Append("\n");
            sb.Append("  Presets: ").Append(Presets).Append("\n");
            sb.Append("  Suggestions: ").Append(Suggestions).Append("\n");
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
            return this.Equals(input as LibraryAttribute);
        }

        /// <summary>
        /// Returns true if LibraryAttribute instances are equal
        /// </summary>
        /// <param name="input">Instance of LibraryAttribute to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(LibraryAttribute input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.Entity == input.Entity ||
                    (this.Entity != null &&
                    this.Entity.Equals(input.Entity))
                ) && 
                (
                    this.Name == input.Name ||
                    (this.Name != null &&
                    this.Name.Equals(input.Name))
                ) && 
                (
                    this.Title == input.Title ||
                    (this.Title != null &&
                    this.Title.Equals(input.Title))
                ) && 
                (
                    this.Type == input.Type ||
                    (this.Type != null &&
                    this.Type.Equals(input.Type))
                ) && 
                (
                    this.Description == input.Description ||
                    (this.Description != null &&
                    this.Description.Equals(input.Description))
                ) && 
                (
                    this.Presets == input.Presets ||
                    this.Presets != null &&
                    input.Presets != null &&
                    this.Presets.SequenceEqual(input.Presets)
                ) && 
                (
                    this.Suggestions == input.Suggestions ||
                    this.Suggestions != null &&
                    input.Suggestions != null &&
                    this.Suggestions.SequenceEqual(input.Suggestions)
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
                if (this.Entity != null)
                    hashCode = hashCode * 59 + this.Entity.GetHashCode();
                if (this.Name != null)
                    hashCode = hashCode * 59 + this.Name.GetHashCode();
                if (this.Title != null)
                    hashCode = hashCode * 59 + this.Title.GetHashCode();
                if (this.Type != null)
                    hashCode = hashCode * 59 + this.Type.GetHashCode();
                if (this.Description != null)
                    hashCode = hashCode * 59 + this.Description.GetHashCode();
                if (this.Presets != null)
                    hashCode = hashCode * 59 + this.Presets.GetHashCode();
                if (this.Suggestions != null)
                    hashCode = hashCode * 59 + this.Suggestions.GetHashCode();
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
