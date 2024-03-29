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
    /// Information about the event that triggered the strikethrough labeling.
    /// </summary>
    [DataContract]
    public partial class StrikethroughTrigger :  IEquatable<StrikethroughTrigger>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="StrikethroughTrigger" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected StrikethroughTrigger() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="StrikethroughTrigger" /> class.
        /// </summary>
        /// <param name="id">The ID of the event that triggered the strikethrough labeling. (required).</param>
        /// <param name="type">The type of event that triggered the strikethrough labeling. (required).</param>
        /// <param name="triggeredAt">The creation time of the event that triggered the strikethrough labeling. (required).</param>
        /// <param name="totalAffectedItems">The total number of items affected by the event that triggered the strikethrough labeling. (required).</param>
        /// <param name="payload">The arbitrary properties associated with this trigger type. (required).</param>
        public StrikethroughTrigger(int id = default(int), string type = default(string), DateTime triggeredAt = default(DateTime), int totalAffectedItems = default(int), Object payload = default(Object))
        {
            this.Id = id;
            // to ensure "type" is required (not null)
            this.Type = type ?? throw new ArgumentNullException("type is a required property for StrikethroughTrigger and cannot be null");
            this.TriggeredAt = triggeredAt;
            this.TotalAffectedItems = totalAffectedItems;
            // to ensure "payload" is required (not null)
            this.Payload = payload ?? throw new ArgumentNullException("payload is a required property for StrikethroughTrigger and cannot be null");
        }
        
        /// <summary>
        /// The ID of the event that triggered the strikethrough labeling.
        /// </summary>
        /// <value>The ID of the event that triggered the strikethrough labeling.</value>
        [DataMember(Name="id", EmitDefaultValue=false)]
        public int Id { get; set; }

        /// <summary>
        /// The type of event that triggered the strikethrough labeling.
        /// </summary>
        /// <value>The type of event that triggered the strikethrough labeling.</value>
        [DataMember(Name="type", EmitDefaultValue=false)]
        public string Type { get; set; }

        /// <summary>
        /// The creation time of the event that triggered the strikethrough labeling.
        /// </summary>
        /// <value>The creation time of the event that triggered the strikethrough labeling.</value>
        [DataMember(Name="triggeredAt", EmitDefaultValue=false)]
        public DateTime TriggeredAt { get; set; }

        /// <summary>
        /// The total number of items affected by the event that triggered the strikethrough labeling.
        /// </summary>
        /// <value>The total number of items affected by the event that triggered the strikethrough labeling.</value>
        [DataMember(Name="totalAffectedItems", EmitDefaultValue=false)]
        public int TotalAffectedItems { get; set; }

        /// <summary>
        /// The arbitrary properties associated with this trigger type.
        /// </summary>
        /// <value>The arbitrary properties associated with this trigger type.</value>
        [DataMember(Name="payload", EmitDefaultValue=false)]
        public Object Payload { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class StrikethroughTrigger {\n");
            sb.Append("  Id: ").Append(Id).Append("\n");
            sb.Append("  Type: ").Append(Type).Append("\n");
            sb.Append("  TriggeredAt: ").Append(TriggeredAt).Append("\n");
            sb.Append("  TotalAffectedItems: ").Append(TotalAffectedItems).Append("\n");
            sb.Append("  Payload: ").Append(Payload).Append("\n");
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
            return this.Equals(input as StrikethroughTrigger);
        }

        /// <summary>
        /// Returns true if StrikethroughTrigger instances are equal
        /// </summary>
        /// <param name="input">Instance of StrikethroughTrigger to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(StrikethroughTrigger input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.Id == input.Id ||
                    this.Id.Equals(input.Id)
                ) && 
                (
                    this.Type == input.Type ||
                    (this.Type != null &&
                    this.Type.Equals(input.Type))
                ) && 
                (
                    this.TriggeredAt == input.TriggeredAt ||
                    (this.TriggeredAt != null &&
                    this.TriggeredAt.Equals(input.TriggeredAt))
                ) && 
                (
                    this.TotalAffectedItems == input.TotalAffectedItems ||
                    this.TotalAffectedItems.Equals(input.TotalAffectedItems)
                ) && 
                (
                    this.Payload == input.Payload ||
                    (this.Payload != null &&
                    this.Payload.Equals(input.Payload))
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
                if (this.Type != null)
                    hashCode = hashCode * 59 + this.Type.GetHashCode();
                if (this.TriggeredAt != null)
                    hashCode = hashCode * 59 + this.TriggeredAt.GetHashCode();
                hashCode = hashCode * 59 + this.TotalAffectedItems.GetHashCode();
                if (this.Payload != null)
                    hashCode = hashCode * 59 + this.Payload.GetHashCode();
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
