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
    /// Event
    /// </summary>
    [DataContract]
    public partial class Event :  IEquatable<Event>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="Event" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected Event() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="Event" /> class.
        /// </summary>
        /// <param name="id">Unique ID for this entity. (required).</param>
        /// <param name="created">The exact moment this entity was created. (required).</param>
        /// <param name="applicationId">The ID of the application that owns this entity. (required).</param>
        /// <param name="profileId">ID of the customers profile as used within this Talon.One account. May be omitted or set to the empty string if the customer does not yet have a known profile ID..</param>
        /// <param name="type">A string representing the event. Must not be a reserved event name. (required).</param>
        /// <param name="attributes">Arbitrary additional JSON data associated with the event. (required).</param>
        /// <param name="sessionId">The ID of the session that this event occurred in..</param>
        /// <param name="effects">An array of \&quot;effects\&quot; that must be applied in response to this event. Example effects include &#x60;addItemToCart&#x60; or &#x60;setDiscount&#x60;.  (required).</param>
        /// <param name="ledgerEntries">Ledger entries for the event. (required).</param>
        /// <param name="meta">meta.</param>
        public Event(int id = default(int), DateTime created = default(DateTime), int applicationId = default(int), string profileId = default(string), string type = default(string), Object attributes = default(Object), string sessionId = default(string), List<Object> effects = default(List<Object>), List<LedgerEntry> ledgerEntries = default(List<LedgerEntry>), Meta meta = default(Meta))
        {
            // to ensure "id" is required (not null)
            if (id == null)
            {
                throw new InvalidDataException("id is a required property for Event and cannot be null");
            }
            else
            {
                this.Id = id;
            }
            
            // to ensure "created" is required (not null)
            if (created == null)
            {
                throw new InvalidDataException("created is a required property for Event and cannot be null");
            }
            else
            {
                this.Created = created;
            }
            
            // to ensure "applicationId" is required (not null)
            if (applicationId == null)
            {
                throw new InvalidDataException("applicationId is a required property for Event and cannot be null");
            }
            else
            {
                this.ApplicationId = applicationId;
            }
            
            // to ensure "type" is required (not null)
            if (type == null)
            {
                throw new InvalidDataException("type is a required property for Event and cannot be null");
            }
            else
            {
                this.Type = type;
            }
            
            // to ensure "attributes" is required (not null)
            if (attributes == null)
            {
                throw new InvalidDataException("attributes is a required property for Event and cannot be null");
            }
            else
            {
                this.Attributes = attributes;
            }
            
            // to ensure "effects" is required (not null)
            if (effects == null)
            {
                throw new InvalidDataException("effects is a required property for Event and cannot be null");
            }
            else
            {
                this.Effects = effects;
            }
            
            // to ensure "ledgerEntries" is required (not null)
            if (ledgerEntries == null)
            {
                throw new InvalidDataException("ledgerEntries is a required property for Event and cannot be null");
            }
            else
            {
                this.LedgerEntries = ledgerEntries;
            }
            
            this.ProfileId = profileId;
            this.SessionId = sessionId;
            this.Meta = meta;
        }
        
        /// <summary>
        /// Unique ID for this entity.
        /// </summary>
        /// <value>Unique ID for this entity.</value>
        [DataMember(Name="id", EmitDefaultValue=true)]
        public int Id { get; set; }

        /// <summary>
        /// The exact moment this entity was created.
        /// </summary>
        /// <value>The exact moment this entity was created.</value>
        [DataMember(Name="created", EmitDefaultValue=true)]
        public DateTime Created { get; set; }

        /// <summary>
        /// The ID of the application that owns this entity.
        /// </summary>
        /// <value>The ID of the application that owns this entity.</value>
        [DataMember(Name="applicationId", EmitDefaultValue=true)]
        public int ApplicationId { get; set; }

        /// <summary>
        /// ID of the customers profile as used within this Talon.One account. May be omitted or set to the empty string if the customer does not yet have a known profile ID.
        /// </summary>
        /// <value>ID of the customers profile as used within this Talon.One account. May be omitted or set to the empty string if the customer does not yet have a known profile ID.</value>
        [DataMember(Name="profileId", EmitDefaultValue=false)]
        public string ProfileId { get; set; }

        /// <summary>
        /// A string representing the event. Must not be a reserved event name.
        /// </summary>
        /// <value>A string representing the event. Must not be a reserved event name.</value>
        [DataMember(Name="type", EmitDefaultValue=true)]
        public string Type { get; set; }

        /// <summary>
        /// Arbitrary additional JSON data associated with the event.
        /// </summary>
        /// <value>Arbitrary additional JSON data associated with the event.</value>
        [DataMember(Name="attributes", EmitDefaultValue=true)]
        public Object Attributes { get; set; }

        /// <summary>
        /// The ID of the session that this event occurred in.
        /// </summary>
        /// <value>The ID of the session that this event occurred in.</value>
        [DataMember(Name="sessionId", EmitDefaultValue=false)]
        public string SessionId { get; set; }

        /// <summary>
        /// An array of \&quot;effects\&quot; that must be applied in response to this event. Example effects include &#x60;addItemToCart&#x60; or &#x60;setDiscount&#x60;. 
        /// </summary>
        /// <value>An array of \&quot;effects\&quot; that must be applied in response to this event. Example effects include &#x60;addItemToCart&#x60; or &#x60;setDiscount&#x60;. </value>
        [DataMember(Name="effects", EmitDefaultValue=true)]
        public List<Object> Effects { get; set; }

        /// <summary>
        /// Ledger entries for the event.
        /// </summary>
        /// <value>Ledger entries for the event.</value>
        [DataMember(Name="ledgerEntries", EmitDefaultValue=true)]
        public List<LedgerEntry> LedgerEntries { get; set; }

        /// <summary>
        /// Gets or Sets Meta
        /// </summary>
        [DataMember(Name="meta", EmitDefaultValue=false)]
        public Meta Meta { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class Event {\n");
            sb.Append("  Id: ").Append(Id).Append("\n");
            sb.Append("  Created: ").Append(Created).Append("\n");
            sb.Append("  ApplicationId: ").Append(ApplicationId).Append("\n");
            sb.Append("  ProfileId: ").Append(ProfileId).Append("\n");
            sb.Append("  Type: ").Append(Type).Append("\n");
            sb.Append("  Attributes: ").Append(Attributes).Append("\n");
            sb.Append("  SessionId: ").Append(SessionId).Append("\n");
            sb.Append("  Effects: ").Append(Effects).Append("\n");
            sb.Append("  LedgerEntries: ").Append(LedgerEntries).Append("\n");
            sb.Append("  Meta: ").Append(Meta).Append("\n");
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
            return this.Equals(input as Event);
        }

        /// <summary>
        /// Returns true if Event instances are equal
        /// </summary>
        /// <param name="input">Instance of Event to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(Event input)
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
                    this.ApplicationId == input.ApplicationId ||
                    (this.ApplicationId != null &&
                    this.ApplicationId.Equals(input.ApplicationId))
                ) && 
                (
                    this.ProfileId == input.ProfileId ||
                    (this.ProfileId != null &&
                    this.ProfileId.Equals(input.ProfileId))
                ) && 
                (
                    this.Type == input.Type ||
                    (this.Type != null &&
                    this.Type.Equals(input.Type))
                ) && 
                (
                    this.Attributes == input.Attributes ||
                    (this.Attributes != null &&
                    this.Attributes.Equals(input.Attributes))
                ) && 
                (
                    this.SessionId == input.SessionId ||
                    (this.SessionId != null &&
                    this.SessionId.Equals(input.SessionId))
                ) && 
                (
                    this.Effects == input.Effects ||
                    this.Effects != null &&
                    input.Effects != null &&
                    this.Effects.SequenceEqual(input.Effects)
                ) && 
                (
                    this.LedgerEntries == input.LedgerEntries ||
                    this.LedgerEntries != null &&
                    input.LedgerEntries != null &&
                    this.LedgerEntries.SequenceEqual(input.LedgerEntries)
                ) && 
                (
                    this.Meta == input.Meta ||
                    (this.Meta != null &&
                    this.Meta.Equals(input.Meta))
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
                if (this.ApplicationId != null)
                    hashCode = hashCode * 59 + this.ApplicationId.GetHashCode();
                if (this.ProfileId != null)
                    hashCode = hashCode * 59 + this.ProfileId.GetHashCode();
                if (this.Type != null)
                    hashCode = hashCode * 59 + this.Type.GetHashCode();
                if (this.Attributes != null)
                    hashCode = hashCode * 59 + this.Attributes.GetHashCode();
                if (this.SessionId != null)
                    hashCode = hashCode * 59 + this.SessionId.GetHashCode();
                if (this.Effects != null)
                    hashCode = hashCode * 59 + this.Effects.GetHashCode();
                if (this.LedgerEntries != null)
                    hashCode = hashCode * 59 + this.LedgerEntries.GetHashCode();
                if (this.Meta != null)
                    hashCode = hashCode * 59 + this.Meta.GetHashCode();
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

            // Type (string) minLength
            if(this.Type != null && this.Type.Length < 1)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for Type, length must be greater than 1.", new [] { "Type" });
            }
            
            yield break;
        }
    }

}
