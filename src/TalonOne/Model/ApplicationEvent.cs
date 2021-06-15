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
    /// ApplicationEvent
    /// </summary>
    [DataContract]
    public partial class ApplicationEvent :  IEquatable<ApplicationEvent>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ApplicationEvent" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected ApplicationEvent() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="ApplicationEvent" /> class.
        /// </summary>
        /// <param name="id">Unique ID for this entity. (required).</param>
        /// <param name="created">The exact moment this entity was created. (required).</param>
        /// <param name="applicationId">The ID of the application that owns this entity. (required).</param>
        /// <param name="profileId">The globally unique Talon.One ID of the customer that created this entity..</param>
        /// <param name="sessionId">The globally unique Talon.One ID of the session that contains this event..</param>
        /// <param name="type">A string representing the event. Must not be a reserved event name. (required).</param>
        /// <param name="attributes">Additional JSON serialized data associated with the event. (required).</param>
        /// <param name="effects">An array containing the effects that were applied as a result of this event. (required).</param>
        /// <param name="ruleFailureReasons">An array containing the rule failure reasons which happened during this event..</param>
        public ApplicationEvent(int id = default(int), DateTime created = default(DateTime), int applicationId = default(int), int profileId = default(int), int sessionId = default(int), string type = default(string), Object attributes = default(Object), List<Object> effects = default(List<Object>), List<RuleFailureReason> ruleFailureReasons = default(List<RuleFailureReason>))
        {
            this.Id = id;
            this.Created = created;
            this.ApplicationId = applicationId;
            // to ensure "type" is required (not null)
            this.Type = type ?? throw new ArgumentNullException("type is a required property for ApplicationEvent and cannot be null");
            // to ensure "attributes" is required (not null)
            this.Attributes = attributes ?? throw new ArgumentNullException("attributes is a required property for ApplicationEvent and cannot be null");
            // to ensure "effects" is required (not null)
            this.Effects = effects ?? throw new ArgumentNullException("effects is a required property for ApplicationEvent and cannot be null");
            this.ProfileId = profileId;
            this.SessionId = sessionId;
            this.RuleFailureReasons = ruleFailureReasons;
        }
        
        /// <summary>
        /// Unique ID for this entity.
        /// </summary>
        /// <value>Unique ID for this entity.</value>
        [DataMember(Name="id", EmitDefaultValue=false)]
        public int Id { get; set; }

        /// <summary>
        /// The exact moment this entity was created.
        /// </summary>
        /// <value>The exact moment this entity was created.</value>
        [DataMember(Name="created", EmitDefaultValue=false)]
        public DateTime Created { get; set; }

        /// <summary>
        /// The ID of the application that owns this entity.
        /// </summary>
        /// <value>The ID of the application that owns this entity.</value>
        [DataMember(Name="applicationId", EmitDefaultValue=false)]
        public int ApplicationId { get; set; }

        /// <summary>
        /// The globally unique Talon.One ID of the customer that created this entity.
        /// </summary>
        /// <value>The globally unique Talon.One ID of the customer that created this entity.</value>
        [DataMember(Name="profileId", EmitDefaultValue=false)]
        public int ProfileId { get; set; }

        /// <summary>
        /// The globally unique Talon.One ID of the session that contains this event.
        /// </summary>
        /// <value>The globally unique Talon.One ID of the session that contains this event.</value>
        [DataMember(Name="sessionId", EmitDefaultValue=false)]
        public int SessionId { get; set; }

        /// <summary>
        /// A string representing the event. Must not be a reserved event name.
        /// </summary>
        /// <value>A string representing the event. Must not be a reserved event name.</value>
        [DataMember(Name="type", EmitDefaultValue=false)]
        public string Type { get; set; }

        /// <summary>
        /// Additional JSON serialized data associated with the event.
        /// </summary>
        /// <value>Additional JSON serialized data associated with the event.</value>
        [DataMember(Name="attributes", EmitDefaultValue=false)]
        public Object Attributes { get; set; }

        /// <summary>
        /// An array containing the effects that were applied as a result of this event.
        /// </summary>
        /// <value>An array containing the effects that were applied as a result of this event.</value>
        [DataMember(Name="effects", EmitDefaultValue=false)]
        public List<Object> Effects { get; set; }

        /// <summary>
        /// An array containing the rule failure reasons which happened during this event.
        /// </summary>
        /// <value>An array containing the rule failure reasons which happened during this event.</value>
        [DataMember(Name="ruleFailureReasons", EmitDefaultValue=false)]
        public List<RuleFailureReason> RuleFailureReasons { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ApplicationEvent {\n");
            sb.Append("  Id: ").Append(Id).Append("\n");
            sb.Append("  Created: ").Append(Created).Append("\n");
            sb.Append("  ApplicationId: ").Append(ApplicationId).Append("\n");
            sb.Append("  ProfileId: ").Append(ProfileId).Append("\n");
            sb.Append("  SessionId: ").Append(SessionId).Append("\n");
            sb.Append("  Type: ").Append(Type).Append("\n");
            sb.Append("  Attributes: ").Append(Attributes).Append("\n");
            sb.Append("  Effects: ").Append(Effects).Append("\n");
            sb.Append("  RuleFailureReasons: ").Append(RuleFailureReasons).Append("\n");
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
            return this.Equals(input as ApplicationEvent);
        }

        /// <summary>
        /// Returns true if ApplicationEvent instances are equal
        /// </summary>
        /// <param name="input">Instance of ApplicationEvent to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(ApplicationEvent input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.Id == input.Id ||
                    this.Id.Equals(input.Id)
                ) && 
                (
                    this.Created == input.Created ||
                    (this.Created != null &&
                    this.Created.Equals(input.Created))
                ) && 
                (
                    this.ApplicationId == input.ApplicationId ||
                    this.ApplicationId.Equals(input.ApplicationId)
                ) && 
                (
                    this.ProfileId == input.ProfileId ||
                    this.ProfileId.Equals(input.ProfileId)
                ) && 
                (
                    this.SessionId == input.SessionId ||
                    this.SessionId.Equals(input.SessionId)
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
                    this.Effects == input.Effects ||
                    this.Effects != null &&
                    input.Effects != null &&
                    this.Effects.SequenceEqual(input.Effects)
                ) && 
                (
                    this.RuleFailureReasons == input.RuleFailureReasons ||
                    this.RuleFailureReasons != null &&
                    input.RuleFailureReasons != null &&
                    this.RuleFailureReasons.SequenceEqual(input.RuleFailureReasons)
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
                if (this.Created != null)
                    hashCode = hashCode * 59 + this.Created.GetHashCode();
                hashCode = hashCode * 59 + this.ApplicationId.GetHashCode();
                hashCode = hashCode * 59 + this.ProfileId.GetHashCode();
                hashCode = hashCode * 59 + this.SessionId.GetHashCode();
                if (this.Type != null)
                    hashCode = hashCode * 59 + this.Type.GetHashCode();
                if (this.Attributes != null)
                    hashCode = hashCode * 59 + this.Attributes.GetHashCode();
                if (this.Effects != null)
                    hashCode = hashCode * 59 + this.Effects.GetHashCode();
                if (this.RuleFailureReasons != null)
                    hashCode = hashCode * 59 + this.RuleFailureReasons.GetHashCode();
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
