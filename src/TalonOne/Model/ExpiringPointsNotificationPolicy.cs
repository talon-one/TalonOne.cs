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
    /// ExpiringPointsNotificationPolicy
    /// </summary>
    [DataContract]
    public partial class ExpiringPointsNotificationPolicy :  IEquatable<ExpiringPointsNotificationPolicy>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ExpiringPointsNotificationPolicy" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected ExpiringPointsNotificationPolicy() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="ExpiringPointsNotificationPolicy" /> class.
        /// </summary>
        /// <param name="name">Notification name. (required).</param>
        /// <param name="triggers">triggers (required).</param>
        /// <param name="batchingEnabled">Indicates whether batching is activated. (default to true).</param>
        public ExpiringPointsNotificationPolicy(string name = default(string), List<ExpiringPointsNotificationTrigger> triggers = default(List<ExpiringPointsNotificationTrigger>), bool batchingEnabled = true)
        {
            // to ensure "name" is required (not null)
            this.Name = name ?? throw new ArgumentNullException("name is a required property for ExpiringPointsNotificationPolicy and cannot be null");
            // to ensure "triggers" is required (not null)
            this.Triggers = triggers ?? throw new ArgumentNullException("triggers is a required property for ExpiringPointsNotificationPolicy and cannot be null");
            this.BatchingEnabled = batchingEnabled;
        }
        
        /// <summary>
        /// Notification name.
        /// </summary>
        /// <value>Notification name.</value>
        [DataMember(Name="name", EmitDefaultValue=false)]
        public string Name { get; set; }

        /// <summary>
        /// Gets or Sets Triggers
        /// </summary>
        [DataMember(Name="triggers", EmitDefaultValue=false)]
        public List<ExpiringPointsNotificationTrigger> Triggers { get; set; }

        /// <summary>
        /// Indicates whether batching is activated.
        /// </summary>
        /// <value>Indicates whether batching is activated.</value>
        [DataMember(Name="batchingEnabled", EmitDefaultValue=false)]
        public bool BatchingEnabled { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ExpiringPointsNotificationPolicy {\n");
            sb.Append("  Name: ").Append(Name).Append("\n");
            sb.Append("  Triggers: ").Append(Triggers).Append("\n");
            sb.Append("  BatchingEnabled: ").Append(BatchingEnabled).Append("\n");
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
            return this.Equals(input as ExpiringPointsNotificationPolicy);
        }

        /// <summary>
        /// Returns true if ExpiringPointsNotificationPolicy instances are equal
        /// </summary>
        /// <param name="input">Instance of ExpiringPointsNotificationPolicy to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(ExpiringPointsNotificationPolicy input)
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
                    this.Triggers == input.Triggers ||
                    this.Triggers != null &&
                    input.Triggers != null &&
                    this.Triggers.SequenceEqual(input.Triggers)
                ) && 
                (
                    this.BatchingEnabled == input.BatchingEnabled ||
                    this.BatchingEnabled.Equals(input.BatchingEnabled)
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
                if (this.Triggers != null)
                    hashCode = hashCode * 59 + this.Triggers.GetHashCode();
                hashCode = hashCode * 59 + this.BatchingEnabled.GetHashCode();
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

            yield break;
        }
    }

}
