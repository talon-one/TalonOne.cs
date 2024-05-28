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
    /// Points to add.
    /// </summary>
    [DataContract]
    public partial class AddLoyaltyPoints :  IEquatable<AddLoyaltyPoints>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="AddLoyaltyPoints" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected AddLoyaltyPoints() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="AddLoyaltyPoints" /> class.
        /// </summary>
        /// <param name="points">Amount of loyalty points. (required).</param>
        /// <param name="name">Name / reason for the point addition..</param>
        /// <param name="validityDuration">The time format is either: - &#x60;immediate&#x60; or, - an **integer** followed by one letter indicating the time unit.  Examples: &#x60;immediate&#x60;, &#x60;30s&#x60;, &#x60;40m&#x60;, &#x60;1h&#x60;, &#x60;5D&#x60;, &#x60;7W&#x60;, &#x60;10M&#x60;, &#x60;15Y&#x60;.  Available units:  - &#x60;s&#x60;: seconds - &#x60;m&#x60;: minutes - &#x60;h&#x60;: hours - &#x60;D&#x60;: days - &#x60;W&#x60;: weeks - &#x60;M&#x60;: months - &#x60;Y&#x60;: years  You can round certain units up or down: - &#x60;_D&#x60; for rounding down days only. Signifies the start of the day. - &#x60;_U&#x60; for rounding up days, weeks, months and years. Signifies the end of the day, week, month or year.  If passed, &#x60;validUntil&#x60; should be omitted. .</param>
        /// <param name="validUntil">Date and time when points should expire. The value should be provided in RFC 3339 format. If passed, &#x60;validityDuration&#x60; should be omitted. .</param>
        /// <param name="pendingDuration">The amount of time before the points are considered valid.  The time format is either: - &#x60;immediate&#x60; or, - an **integer** followed by one letter indicating the time unit.  Examples: &#x60;immediate&#x60;, &#x60;30s&#x60;, &#x60;40m&#x60;, &#x60;1h&#x60;, &#x60;5D&#x60;, &#x60;7W&#x60;, &#x60;10M&#x60;, &#x60;15Y&#x60;.  Available units:  - &#x60;s&#x60;: seconds - &#x60;m&#x60;: minutes - &#x60;h&#x60;: hours - &#x60;D&#x60;: days - &#x60;W&#x60;: weeks - &#x60;M&#x60;: months - &#x60;Y&#x60;: years  You can round certain units up or down: - &#x60;_D&#x60; for rounding down days only. Signifies the start of the day. - &#x60;_U&#x60; for rounding up days, weeks, months and years. Signifies the end of the day, week, month or year. .</param>
        /// <param name="pendingUntil">Date and time after the points are considered valid. The value should be provided in RFC 3339 format. If passed, &#x60;pendingDuration&#x60; should be omitted. .</param>
        /// <param name="subledgerId">ID of the subledger the points are added to. If there is no existing subledger with this ID, the subledger is created automatically..</param>
        /// <param name="applicationId">ID of the Application that is connected to the loyalty program. It is displayed in your Talon.One deployment URL..</param>
        public AddLoyaltyPoints(decimal points = default(decimal), string name = default(string), string validityDuration = default(string), DateTime validUntil = default(DateTime), string pendingDuration = default(string), DateTime pendingUntil = default(DateTime), string subledgerId = default(string), int applicationId = default(int))
        {
            this.Points = points;
            this.Name = name;
            this.ValidityDuration = validityDuration;
            this.ValidUntil = validUntil;
            this.PendingDuration = pendingDuration;
            this.PendingUntil = pendingUntil;
            this.SubledgerId = subledgerId;
            this.ApplicationId = applicationId;
        }
        
        /// <summary>
        /// Amount of loyalty points.
        /// </summary>
        /// <value>Amount of loyalty points.</value>
        [DataMember(Name="points", EmitDefaultValue=false)]
        public decimal Points { get; set; }

        /// <summary>
        /// Name / reason for the point addition.
        /// </summary>
        /// <value>Name / reason for the point addition.</value>
        [DataMember(Name="name", EmitDefaultValue=false)]
        public string Name { get; set; }

        /// <summary>
        /// The time format is either: - &#x60;immediate&#x60; or, - an **integer** followed by one letter indicating the time unit.  Examples: &#x60;immediate&#x60;, &#x60;30s&#x60;, &#x60;40m&#x60;, &#x60;1h&#x60;, &#x60;5D&#x60;, &#x60;7W&#x60;, &#x60;10M&#x60;, &#x60;15Y&#x60;.  Available units:  - &#x60;s&#x60;: seconds - &#x60;m&#x60;: minutes - &#x60;h&#x60;: hours - &#x60;D&#x60;: days - &#x60;W&#x60;: weeks - &#x60;M&#x60;: months - &#x60;Y&#x60;: years  You can round certain units up or down: - &#x60;_D&#x60; for rounding down days only. Signifies the start of the day. - &#x60;_U&#x60; for rounding up days, weeks, months and years. Signifies the end of the day, week, month or year.  If passed, &#x60;validUntil&#x60; should be omitted. 
        /// </summary>
        /// <value>The time format is either: - &#x60;immediate&#x60; or, - an **integer** followed by one letter indicating the time unit.  Examples: &#x60;immediate&#x60;, &#x60;30s&#x60;, &#x60;40m&#x60;, &#x60;1h&#x60;, &#x60;5D&#x60;, &#x60;7W&#x60;, &#x60;10M&#x60;, &#x60;15Y&#x60;.  Available units:  - &#x60;s&#x60;: seconds - &#x60;m&#x60;: minutes - &#x60;h&#x60;: hours - &#x60;D&#x60;: days - &#x60;W&#x60;: weeks - &#x60;M&#x60;: months - &#x60;Y&#x60;: years  You can round certain units up or down: - &#x60;_D&#x60; for rounding down days only. Signifies the start of the day. - &#x60;_U&#x60; for rounding up days, weeks, months and years. Signifies the end of the day, week, month or year.  If passed, &#x60;validUntil&#x60; should be omitted. </value>
        [DataMember(Name="validityDuration", EmitDefaultValue=false)]
        public string ValidityDuration { get; set; }

        /// <summary>
        /// Date and time when points should expire. The value should be provided in RFC 3339 format. If passed, &#x60;validityDuration&#x60; should be omitted. 
        /// </summary>
        /// <value>Date and time when points should expire. The value should be provided in RFC 3339 format. If passed, &#x60;validityDuration&#x60; should be omitted. </value>
        [DataMember(Name="validUntil", EmitDefaultValue=false)]
        public DateTime ValidUntil { get; set; }

        /// <summary>
        /// The amount of time before the points are considered valid.  The time format is either: - &#x60;immediate&#x60; or, - an **integer** followed by one letter indicating the time unit.  Examples: &#x60;immediate&#x60;, &#x60;30s&#x60;, &#x60;40m&#x60;, &#x60;1h&#x60;, &#x60;5D&#x60;, &#x60;7W&#x60;, &#x60;10M&#x60;, &#x60;15Y&#x60;.  Available units:  - &#x60;s&#x60;: seconds - &#x60;m&#x60;: minutes - &#x60;h&#x60;: hours - &#x60;D&#x60;: days - &#x60;W&#x60;: weeks - &#x60;M&#x60;: months - &#x60;Y&#x60;: years  You can round certain units up or down: - &#x60;_D&#x60; for rounding down days only. Signifies the start of the day. - &#x60;_U&#x60; for rounding up days, weeks, months and years. Signifies the end of the day, week, month or year. 
        /// </summary>
        /// <value>The amount of time before the points are considered valid.  The time format is either: - &#x60;immediate&#x60; or, - an **integer** followed by one letter indicating the time unit.  Examples: &#x60;immediate&#x60;, &#x60;30s&#x60;, &#x60;40m&#x60;, &#x60;1h&#x60;, &#x60;5D&#x60;, &#x60;7W&#x60;, &#x60;10M&#x60;, &#x60;15Y&#x60;.  Available units:  - &#x60;s&#x60;: seconds - &#x60;m&#x60;: minutes - &#x60;h&#x60;: hours - &#x60;D&#x60;: days - &#x60;W&#x60;: weeks - &#x60;M&#x60;: months - &#x60;Y&#x60;: years  You can round certain units up or down: - &#x60;_D&#x60; for rounding down days only. Signifies the start of the day. - &#x60;_U&#x60; for rounding up days, weeks, months and years. Signifies the end of the day, week, month or year. </value>
        [DataMember(Name="pendingDuration", EmitDefaultValue=false)]
        public string PendingDuration { get; set; }

        /// <summary>
        /// Date and time after the points are considered valid. The value should be provided in RFC 3339 format. If passed, &#x60;pendingDuration&#x60; should be omitted. 
        /// </summary>
        /// <value>Date and time after the points are considered valid. The value should be provided in RFC 3339 format. If passed, &#x60;pendingDuration&#x60; should be omitted. </value>
        [DataMember(Name="pendingUntil", EmitDefaultValue=false)]
        public DateTime PendingUntil { get; set; }

        /// <summary>
        /// ID of the subledger the points are added to. If there is no existing subledger with this ID, the subledger is created automatically.
        /// </summary>
        /// <value>ID of the subledger the points are added to. If there is no existing subledger with this ID, the subledger is created automatically.</value>
        [DataMember(Name="subledgerId", EmitDefaultValue=false)]
        public string SubledgerId { get; set; }

        /// <summary>
        /// ID of the Application that is connected to the loyalty program. It is displayed in your Talon.One deployment URL.
        /// </summary>
        /// <value>ID of the Application that is connected to the loyalty program. It is displayed in your Talon.One deployment URL.</value>
        [DataMember(Name="applicationId", EmitDefaultValue=false)]
        public int ApplicationId { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class AddLoyaltyPoints {\n");
            sb.Append("  Points: ").Append(Points).Append("\n");
            sb.Append("  Name: ").Append(Name).Append("\n");
            sb.Append("  ValidityDuration: ").Append(ValidityDuration).Append("\n");
            sb.Append("  ValidUntil: ").Append(ValidUntil).Append("\n");
            sb.Append("  PendingDuration: ").Append(PendingDuration).Append("\n");
            sb.Append("  PendingUntil: ").Append(PendingUntil).Append("\n");
            sb.Append("  SubledgerId: ").Append(SubledgerId).Append("\n");
            sb.Append("  ApplicationId: ").Append(ApplicationId).Append("\n");
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
            return this.Equals(input as AddLoyaltyPoints);
        }

        /// <summary>
        /// Returns true if AddLoyaltyPoints instances are equal
        /// </summary>
        /// <param name="input">Instance of AddLoyaltyPoints to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(AddLoyaltyPoints input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.Points == input.Points ||
                    this.Points.Equals(input.Points)
                ) && 
                (
                    this.Name == input.Name ||
                    (this.Name != null &&
                    this.Name.Equals(input.Name))
                ) && 
                (
                    this.ValidityDuration == input.ValidityDuration ||
                    (this.ValidityDuration != null &&
                    this.ValidityDuration.Equals(input.ValidityDuration))
                ) && 
                (
                    this.ValidUntil == input.ValidUntil ||
                    (this.ValidUntil != null &&
                    this.ValidUntil.Equals(input.ValidUntil))
                ) && 
                (
                    this.PendingDuration == input.PendingDuration ||
                    (this.PendingDuration != null &&
                    this.PendingDuration.Equals(input.PendingDuration))
                ) && 
                (
                    this.PendingUntil == input.PendingUntil ||
                    (this.PendingUntil != null &&
                    this.PendingUntil.Equals(input.PendingUntil))
                ) && 
                (
                    this.SubledgerId == input.SubledgerId ||
                    (this.SubledgerId != null &&
                    this.SubledgerId.Equals(input.SubledgerId))
                ) && 
                (
                    this.ApplicationId == input.ApplicationId ||
                    this.ApplicationId.Equals(input.ApplicationId)
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
                hashCode = hashCode * 59 + this.Points.GetHashCode();
                if (this.Name != null)
                    hashCode = hashCode * 59 + this.Name.GetHashCode();
                if (this.ValidityDuration != null)
                    hashCode = hashCode * 59 + this.ValidityDuration.GetHashCode();
                if (this.ValidUntil != null)
                    hashCode = hashCode * 59 + this.ValidUntil.GetHashCode();
                if (this.PendingDuration != null)
                    hashCode = hashCode * 59 + this.PendingDuration.GetHashCode();
                if (this.PendingUntil != null)
                    hashCode = hashCode * 59 + this.PendingUntil.GetHashCode();
                if (this.SubledgerId != null)
                    hashCode = hashCode * 59 + this.SubledgerId.GetHashCode();
                hashCode = hashCode * 59 + this.ApplicationId.GetHashCode();
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
            // Points (decimal) maximum
            if(this.Points > (decimal)999999999999.99)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for Points, must be a value less than or equal to 999999999999.99.", new [] { "Points" });
            }

            // Points (decimal) minimum
            if(this.Points < (decimal)0)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for Points, must be a value greater than or equal to 0.", new [] { "Points" });
            }

            yield break;
        }
    }

}
