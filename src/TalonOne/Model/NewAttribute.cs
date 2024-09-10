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
    /// NewAttribute
    /// </summary>
    [DataContract]
    public partial class NewAttribute :  IEquatable<NewAttribute>, IValidatableObject
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
            Event = 7,

            /// <summary>
            /// Enum Giveaway for value: Giveaway
            /// </summary>
            [EnumMember(Value = "Giveaway")]
            Giveaway = 8,

            /// <summary>
            /// Enum Referral for value: Referral
            /// </summary>
            [EnumMember(Value = "Referral")]
            Referral = 9,

            /// <summary>
            /// Enum Store for value: Store
            /// </summary>
            [EnumMember(Value = "Store")]
            Store = 10

        }

        /// <summary>
        /// The name of the entity that can have this attribute. When creating or updating the entities of a given type, you can include an &#x60;attributes&#x60; object with keys corresponding to the &#x60;name&#x60; of the custom attributes for that type.
        /// </summary>
        /// <value>The name of the entity that can have this attribute. When creating or updating the entities of a given type, you can include an &#x60;attributes&#x60; object with keys corresponding to the &#x60;name&#x60; of the custom attributes for that type.</value>
        [DataMember(Name="entity", EmitDefaultValue=false)]
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
            Time = 4,

            /// <summary>
            /// Enum Liststring for value: (list string)
            /// </summary>
            [EnumMember(Value = "(list string)")]
            Liststring = 5,

            /// <summary>
            /// Enum Listnumber for value: (list number)
            /// </summary>
            [EnumMember(Value = "(list number)")]
            Listnumber = 6,

            /// <summary>
            /// Enum Listtime for value: (list time)
            /// </summary>
            [EnumMember(Value = "(list time)")]
            Listtime = 7,

            /// <summary>
            /// Enum Location for value: location
            /// </summary>
            [EnumMember(Value = "location")]
            Location = 8,

            /// <summary>
            /// Enum Listlocation for value: (list location)
            /// </summary>
            [EnumMember(Value = "(list location)")]
            Listlocation = 9

        }

        /// <summary>
        /// The data type of the attribute, a &#x60;time&#x60; attribute must be sent as a string that conforms to the [RFC3339](https://www.ietf.org/rfc/rfc3339.txt) timestamp format.
        /// </summary>
        /// <value>The data type of the attribute, a &#x60;time&#x60; attribute must be sent as a string that conforms to the [RFC3339](https://www.ietf.org/rfc/rfc3339.txt) timestamp format.</value>
        [DataMember(Name="type", EmitDefaultValue=false)]
        public TypeEnum Type { get; set; }
        /// <summary>
        /// Defines AllowedSubscriptions
        /// </summary>
        [JsonConverter(typeof(StringEnumConverter))]
        public enum AllowedSubscriptionsEnum
        {
            /// <summary>
            /// Enum Application for value: application
            /// </summary>
            [EnumMember(Value = "application")]
            Application = 1,

            /// <summary>
            /// Enum Catalog for value: catalog
            /// </summary>
            [EnumMember(Value = "catalog")]
            Catalog = 2

        }


        /// <summary>
        /// A list of allowed subscription types for this attribute.  **Note:** This only applies to attributes associated with the &#x60;CartItem&#x60; entity. 
        /// </summary>
        /// <value>A list of allowed subscription types for this attribute.  **Note:** This only applies to attributes associated with the &#x60;CartItem&#x60; entity. </value>
        [DataMember(Name="allowedSubscriptions", EmitDefaultValue=false)]
        public List<AllowedSubscriptionsEnum> AllowedSubscriptions { get; set; }
        /// <summary>
        /// Initializes a new instance of the <see cref="NewAttribute" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected NewAttribute() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="NewAttribute" /> class.
        /// </summary>
        /// <param name="entity">The name of the entity that can have this attribute. When creating or updating the entities of a given type, you can include an &#x60;attributes&#x60; object with keys corresponding to the &#x60;name&#x60; of the custom attributes for that type. (required).</param>
        /// <param name="eventType">eventType.</param>
        /// <param name="name">The attribute name that will be used in API requests and Talang. E.g. if &#x60;name &#x3D;&#x3D; \&quot;region\&quot;&#x60; then you would set the region attribute by including an &#x60;attributes.region&#x60; property in your request payload. (required).</param>
        /// <param name="title">The human-readable name for the attribute that will be shown in the Campaign Manager. Like &#x60;name&#x60;, the combination of entity and title must also be unique. (required).</param>
        /// <param name="type">The data type of the attribute, a &#x60;time&#x60; attribute must be sent as a string that conforms to the [RFC3339](https://www.ietf.org/rfc/rfc3339.txt) timestamp format. (required).</param>
        /// <param name="description">A description of this attribute. (required).</param>
        /// <param name="suggestions">A list of suggestions for the attribute. (required).</param>
        /// <param name="hasAllowedList">Whether or not this attribute has an allowed list of values associated with it. (default to false).</param>
        /// <param name="restrictedBySuggestions">Whether or not this attribute&#39;s value is restricted by suggestions (&#x60;suggestions&#x60; property) or by an allowed list of value (&#x60;hasAllowedList&#x60; property).  (default to false).</param>
        /// <param name="editable">Whether or not this attribute can be edited. (required).</param>
        /// <param name="subscribedApplicationsIds">A list of the IDs of the applications where this attribute is available..</param>
        /// <param name="subscribedCatalogsIds">A list of the IDs of the catalogs where this attribute is available..</param>
        /// <param name="allowedSubscriptions">A list of allowed subscription types for this attribute.  **Note:** This only applies to attributes associated with the &#x60;CartItem&#x60; entity. .</param>
        public NewAttribute(EntityEnum entity = default(EntityEnum), string eventType = default(string), string name = default(string), string title = default(string), TypeEnum type = default(TypeEnum), string description = default(string), List<string> suggestions = default(List<string>), bool hasAllowedList = false, bool restrictedBySuggestions = false, bool editable = default(bool), List<int> subscribedApplicationsIds = default(List<int>), List<int> subscribedCatalogsIds = default(List<int>), List<AllowedSubscriptionsEnum> allowedSubscriptions = default(List<AllowedSubscriptionsEnum>))
        {
            this.Entity = entity;
            // to ensure "name" is required (not null)
            this.Name = name ?? throw new ArgumentNullException("name is a required property for NewAttribute and cannot be null");
            // to ensure "title" is required (not null)
            this.Title = title ?? throw new ArgumentNullException("title is a required property for NewAttribute and cannot be null");
            this.Type = type;
            // to ensure "description" is required (not null)
            this.Description = description ?? throw new ArgumentNullException("description is a required property for NewAttribute and cannot be null");
            // to ensure "suggestions" is required (not null)
            this.Suggestions = suggestions ?? throw new ArgumentNullException("suggestions is a required property for NewAttribute and cannot be null");
            this.Editable = editable;
            this.EventType = eventType;
            this.HasAllowedList = hasAllowedList;
            this.RestrictedBySuggestions = restrictedBySuggestions;
            this.SubscribedApplicationsIds = subscribedApplicationsIds;
            this.SubscribedCatalogsIds = subscribedCatalogsIds;
            this.AllowedSubscriptions = allowedSubscriptions;
        }
        
        /// <summary>
        /// Gets or Sets EventType
        /// </summary>
        [DataMember(Name="eventType", EmitDefaultValue=false)]
        public string EventType { get; set; }

        /// <summary>
        /// The attribute name that will be used in API requests and Talang. E.g. if &#x60;name &#x3D;&#x3D; \&quot;region\&quot;&#x60; then you would set the region attribute by including an &#x60;attributes.region&#x60; property in your request payload.
        /// </summary>
        /// <value>The attribute name that will be used in API requests and Talang. E.g. if &#x60;name &#x3D;&#x3D; \&quot;region\&quot;&#x60; then you would set the region attribute by including an &#x60;attributes.region&#x60; property in your request payload.</value>
        [DataMember(Name="name", EmitDefaultValue=false)]
        public string Name { get; set; }

        /// <summary>
        /// The human-readable name for the attribute that will be shown in the Campaign Manager. Like &#x60;name&#x60;, the combination of entity and title must also be unique.
        /// </summary>
        /// <value>The human-readable name for the attribute that will be shown in the Campaign Manager. Like &#x60;name&#x60;, the combination of entity and title must also be unique.</value>
        [DataMember(Name="title", EmitDefaultValue=false)]
        public string Title { get; set; }

        /// <summary>
        /// A description of this attribute.
        /// </summary>
        /// <value>A description of this attribute.</value>
        [DataMember(Name="description", EmitDefaultValue=false)]
        public string Description { get; set; }

        /// <summary>
        /// A list of suggestions for the attribute.
        /// </summary>
        /// <value>A list of suggestions for the attribute.</value>
        [DataMember(Name="suggestions", EmitDefaultValue=false)]
        public List<string> Suggestions { get; set; }

        /// <summary>
        /// Whether or not this attribute has an allowed list of values associated with it.
        /// </summary>
        /// <value>Whether or not this attribute has an allowed list of values associated with it.</value>
        [DataMember(Name="hasAllowedList", EmitDefaultValue=false)]
        public bool HasAllowedList { get; set; }

        /// <summary>
        /// Whether or not this attribute&#39;s value is restricted by suggestions (&#x60;suggestions&#x60; property) or by an allowed list of value (&#x60;hasAllowedList&#x60; property). 
        /// </summary>
        /// <value>Whether or not this attribute&#39;s value is restricted by suggestions (&#x60;suggestions&#x60; property) or by an allowed list of value (&#x60;hasAllowedList&#x60; property). </value>
        [DataMember(Name="restrictedBySuggestions", EmitDefaultValue=false)]
        public bool RestrictedBySuggestions { get; set; }

        /// <summary>
        /// Whether or not this attribute can be edited.
        /// </summary>
        /// <value>Whether or not this attribute can be edited.</value>
        [DataMember(Name="editable", EmitDefaultValue=false)]
        public bool Editable { get; set; }

        /// <summary>
        /// A list of the IDs of the applications where this attribute is available.
        /// </summary>
        /// <value>A list of the IDs of the applications where this attribute is available.</value>
        [DataMember(Name="subscribedApplicationsIds", EmitDefaultValue=false)]
        public List<int> SubscribedApplicationsIds { get; set; }

        /// <summary>
        /// A list of the IDs of the catalogs where this attribute is available.
        /// </summary>
        /// <value>A list of the IDs of the catalogs where this attribute is available.</value>
        [DataMember(Name="subscribedCatalogsIds", EmitDefaultValue=false)]
        public List<int> SubscribedCatalogsIds { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class NewAttribute {\n");
            sb.Append("  Entity: ").Append(Entity).Append("\n");
            sb.Append("  EventType: ").Append(EventType).Append("\n");
            sb.Append("  Name: ").Append(Name).Append("\n");
            sb.Append("  Title: ").Append(Title).Append("\n");
            sb.Append("  Type: ").Append(Type).Append("\n");
            sb.Append("  Description: ").Append(Description).Append("\n");
            sb.Append("  Suggestions: ").Append(Suggestions).Append("\n");
            sb.Append("  HasAllowedList: ").Append(HasAllowedList).Append("\n");
            sb.Append("  RestrictedBySuggestions: ").Append(RestrictedBySuggestions).Append("\n");
            sb.Append("  Editable: ").Append(Editable).Append("\n");
            sb.Append("  SubscribedApplicationsIds: ").Append(SubscribedApplicationsIds).Append("\n");
            sb.Append("  SubscribedCatalogsIds: ").Append(SubscribedCatalogsIds).Append("\n");
            sb.Append("  AllowedSubscriptions: ").Append(AllowedSubscriptions).Append("\n");
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
            return this.Equals(input as NewAttribute);
        }

        /// <summary>
        /// Returns true if NewAttribute instances are equal
        /// </summary>
        /// <param name="input">Instance of NewAttribute to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(NewAttribute input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.Entity == input.Entity ||
                    this.Entity.Equals(input.Entity)
                ) && 
                (
                    this.EventType == input.EventType ||
                    (this.EventType != null &&
                    this.EventType.Equals(input.EventType))
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
                    this.Type.Equals(input.Type)
                ) && 
                (
                    this.Description == input.Description ||
                    (this.Description != null &&
                    this.Description.Equals(input.Description))
                ) && 
                (
                    this.Suggestions == input.Suggestions ||
                    this.Suggestions != null &&
                    input.Suggestions != null &&
                    this.Suggestions.SequenceEqual(input.Suggestions)
                ) && 
                (
                    this.HasAllowedList == input.HasAllowedList ||
                    this.HasAllowedList.Equals(input.HasAllowedList)
                ) && 
                (
                    this.RestrictedBySuggestions == input.RestrictedBySuggestions ||
                    this.RestrictedBySuggestions.Equals(input.RestrictedBySuggestions)
                ) && 
                (
                    this.Editable == input.Editable ||
                    this.Editable.Equals(input.Editable)
                ) && 
                (
                    this.SubscribedApplicationsIds == input.SubscribedApplicationsIds ||
                    this.SubscribedApplicationsIds != null &&
                    input.SubscribedApplicationsIds != null &&
                    this.SubscribedApplicationsIds.SequenceEqual(input.SubscribedApplicationsIds)
                ) && 
                (
                    this.SubscribedCatalogsIds == input.SubscribedCatalogsIds ||
                    this.SubscribedCatalogsIds != null &&
                    input.SubscribedCatalogsIds != null &&
                    this.SubscribedCatalogsIds.SequenceEqual(input.SubscribedCatalogsIds)
                ) && 
                (
                    this.AllowedSubscriptions == input.AllowedSubscriptions ||
                    this.AllowedSubscriptions.SequenceEqual(input.AllowedSubscriptions)
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
                hashCode = hashCode * 59 + this.Entity.GetHashCode();
                if (this.EventType != null)
                    hashCode = hashCode * 59 + this.EventType.GetHashCode();
                if (this.Name != null)
                    hashCode = hashCode * 59 + this.Name.GetHashCode();
                if (this.Title != null)
                    hashCode = hashCode * 59 + this.Title.GetHashCode();
                hashCode = hashCode * 59 + this.Type.GetHashCode();
                if (this.Description != null)
                    hashCode = hashCode * 59 + this.Description.GetHashCode();
                if (this.Suggestions != null)
                    hashCode = hashCode * 59 + this.Suggestions.GetHashCode();
                hashCode = hashCode * 59 + this.HasAllowedList.GetHashCode();
                hashCode = hashCode * 59 + this.RestrictedBySuggestions.GetHashCode();
                hashCode = hashCode * 59 + this.Editable.GetHashCode();
                if (this.SubscribedApplicationsIds != null)
                    hashCode = hashCode * 59 + this.SubscribedApplicationsIds.GetHashCode();
                if (this.SubscribedCatalogsIds != null)
                    hashCode = hashCode * 59 + this.SubscribedCatalogsIds.GetHashCode();
                hashCode = hashCode * 59 + this.AllowedSubscriptions.GetHashCode();
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
            // Name (string) pattern
            Regex regexName = new Regex(@"^[A-Za-z]\\w*$", RegexOptions.CultureInvariant);
            if (false == regexName.Match(this.Name).Success)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for Name, must match a pattern of " + regexName, new [] { "Name" });
            }

            // Title (string) pattern
            Regex regexTitle = new Regex(@"^[A-Za-z][A-Za-z0-9_.!~*'() -]*$", RegexOptions.CultureInvariant);
            if (false == regexTitle.Match(this.Title).Success)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for Title, must match a pattern of " + regexTitle, new [] { "Title" });
            }

            yield break;
        }
    }

}
