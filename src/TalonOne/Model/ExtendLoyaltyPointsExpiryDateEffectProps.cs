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
    /// The properties specific to the \&quot;extendLoyaltyPointsExpiryDate\&quot; effect. This gets triggered when a validated rule contains the \&quot;extend expiry date\&quot; effect. The current expiry date gets extended by the time frame given in the effect. 
    /// </summary>
    [DataContract]
    public partial class ExtendLoyaltyPointsExpiryDateEffectProps :  IEquatable<ExtendLoyaltyPointsExpiryDateEffectProps>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ExtendLoyaltyPointsExpiryDateEffectProps" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected ExtendLoyaltyPointsExpiryDateEffectProps() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="ExtendLoyaltyPointsExpiryDateEffectProps" /> class.
        /// </summary>
        /// <param name="programId">ID of the loyalty program that contains these points. (required).</param>
        /// <param name="subLedgerId">API name of the loyalty program subledger that contains these points. added. (required).</param>
        /// <param name="extensionDuration">Time frame by which the expiry date extends.  The time format is either: - immediate, or - an **integer** followed by a letter indicating the time unit.  Examples: &#x60;immediate&#x60;, &#x60;30s&#x60;, &#x60;40m&#x60;, &#x60;1h&#x60;, &#x60;5D&#x60;, &#x60;7W&#x60;, &#x60;10M&#x60;, &#x60;15Y&#x60;.  Available units:  - &#x60;s&#x60;: seconds - &#x60;m&#x60;: minutes - &#x60;h&#x60;: hours - &#x60;D&#x60;: days - &#x60;W&#x60;: weeks - &#x60;M&#x60;: months - &#x60;Y&#x60;: years  You can round certain units up or down: - &#x60;_D&#x60; for rounding down days only. Signifies the start of the day. - &#x60;_U&#x60; for rounding up days, weeks, months and years. Signifies the end of the day, week, month or year.  (required).</param>
        /// <param name="transactionUUIDs">The list of identifiers of transactions affected affected by the extension..</param>
        /// <param name="previousExpirationDate">Expiry date before applying the extension. (required).</param>
        public ExtendLoyaltyPointsExpiryDateEffectProps(int programId = default(int), string subLedgerId = default(string), string extensionDuration = default(string), List<string> transactionUUIDs = default(List<string>), DateTime previousExpirationDate = default(DateTime))
        {
            this.ProgramId = programId;
            // to ensure "subLedgerId" is required (not null)
            this.SubLedgerId = subLedgerId ?? throw new ArgumentNullException("subLedgerId is a required property for ExtendLoyaltyPointsExpiryDateEffectProps and cannot be null");
            // to ensure "extensionDuration" is required (not null)
            this.ExtensionDuration = extensionDuration ?? throw new ArgumentNullException("extensionDuration is a required property for ExtendLoyaltyPointsExpiryDateEffectProps and cannot be null");
            this.PreviousExpirationDate = previousExpirationDate;
            this.TransactionUUIDs = transactionUUIDs;
        }
        
        /// <summary>
        /// ID of the loyalty program that contains these points.
        /// </summary>
        /// <value>ID of the loyalty program that contains these points.</value>
        [DataMember(Name="programId", EmitDefaultValue=false)]
        public int ProgramId { get; set; }

        /// <summary>
        /// API name of the loyalty program subledger that contains these points. added.
        /// </summary>
        /// <value>API name of the loyalty program subledger that contains these points. added.</value>
        [DataMember(Name="subLedgerId", EmitDefaultValue=false)]
        public string SubLedgerId { get; set; }

        /// <summary>
        /// Time frame by which the expiry date extends.  The time format is either: - immediate, or - an **integer** followed by a letter indicating the time unit.  Examples: &#x60;immediate&#x60;, &#x60;30s&#x60;, &#x60;40m&#x60;, &#x60;1h&#x60;, &#x60;5D&#x60;, &#x60;7W&#x60;, &#x60;10M&#x60;, &#x60;15Y&#x60;.  Available units:  - &#x60;s&#x60;: seconds - &#x60;m&#x60;: minutes - &#x60;h&#x60;: hours - &#x60;D&#x60;: days - &#x60;W&#x60;: weeks - &#x60;M&#x60;: months - &#x60;Y&#x60;: years  You can round certain units up or down: - &#x60;_D&#x60; for rounding down days only. Signifies the start of the day. - &#x60;_U&#x60; for rounding up days, weeks, months and years. Signifies the end of the day, week, month or year. 
        /// </summary>
        /// <value>Time frame by which the expiry date extends.  The time format is either: - immediate, or - an **integer** followed by a letter indicating the time unit.  Examples: &#x60;immediate&#x60;, &#x60;30s&#x60;, &#x60;40m&#x60;, &#x60;1h&#x60;, &#x60;5D&#x60;, &#x60;7W&#x60;, &#x60;10M&#x60;, &#x60;15Y&#x60;.  Available units:  - &#x60;s&#x60;: seconds - &#x60;m&#x60;: minutes - &#x60;h&#x60;: hours - &#x60;D&#x60;: days - &#x60;W&#x60;: weeks - &#x60;M&#x60;: months - &#x60;Y&#x60;: years  You can round certain units up or down: - &#x60;_D&#x60; for rounding down days only. Signifies the start of the day. - &#x60;_U&#x60; for rounding up days, weeks, months and years. Signifies the end of the day, week, month or year. </value>
        [DataMember(Name="extensionDuration", EmitDefaultValue=false)]
        public string ExtensionDuration { get; set; }

        /// <summary>
        /// The list of identifiers of transactions affected affected by the extension.
        /// </summary>
        /// <value>The list of identifiers of transactions affected affected by the extension.</value>
        [DataMember(Name="transactionUUIDs", EmitDefaultValue=false)]
        public List<string> TransactionUUIDs { get; set; }

        /// <summary>
        /// Expiry date before applying the extension.
        /// </summary>
        /// <value>Expiry date before applying the extension.</value>
        [DataMember(Name="previousExpirationDate", EmitDefaultValue=false)]
        public DateTime PreviousExpirationDate { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ExtendLoyaltyPointsExpiryDateEffectProps {\n");
            sb.Append("  ProgramId: ").Append(ProgramId).Append("\n");
            sb.Append("  SubLedgerId: ").Append(SubLedgerId).Append("\n");
            sb.Append("  ExtensionDuration: ").Append(ExtensionDuration).Append("\n");
            sb.Append("  TransactionUUIDs: ").Append(TransactionUUIDs).Append("\n");
            sb.Append("  PreviousExpirationDate: ").Append(PreviousExpirationDate).Append("\n");
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
            return this.Equals(input as ExtendLoyaltyPointsExpiryDateEffectProps);
        }

        /// <summary>
        /// Returns true if ExtendLoyaltyPointsExpiryDateEffectProps instances are equal
        /// </summary>
        /// <param name="input">Instance of ExtendLoyaltyPointsExpiryDateEffectProps to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(ExtendLoyaltyPointsExpiryDateEffectProps input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.ProgramId == input.ProgramId ||
                    this.ProgramId.Equals(input.ProgramId)
                ) && 
                (
                    this.SubLedgerId == input.SubLedgerId ||
                    (this.SubLedgerId != null &&
                    this.SubLedgerId.Equals(input.SubLedgerId))
                ) && 
                (
                    this.ExtensionDuration == input.ExtensionDuration ||
                    (this.ExtensionDuration != null &&
                    this.ExtensionDuration.Equals(input.ExtensionDuration))
                ) && 
                (
                    this.TransactionUUIDs == input.TransactionUUIDs ||
                    this.TransactionUUIDs != null &&
                    input.TransactionUUIDs != null &&
                    this.TransactionUUIDs.SequenceEqual(input.TransactionUUIDs)
                ) && 
                (
                    this.PreviousExpirationDate == input.PreviousExpirationDate ||
                    (this.PreviousExpirationDate != null &&
                    this.PreviousExpirationDate.Equals(input.PreviousExpirationDate))
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
                hashCode = hashCode * 59 + this.ProgramId.GetHashCode();
                if (this.SubLedgerId != null)
                    hashCode = hashCode * 59 + this.SubLedgerId.GetHashCode();
                if (this.ExtensionDuration != null)
                    hashCode = hashCode * 59 + this.ExtensionDuration.GetHashCode();
                if (this.TransactionUUIDs != null)
                    hashCode = hashCode * 59 + this.TransactionUUIDs.GetHashCode();
                if (this.PreviousExpirationDate != null)
                    hashCode = hashCode * 59 + this.PreviousExpirationDate.GetHashCode();
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
