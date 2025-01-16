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
    /// TemplateLimitConfig
    /// </summary>
    [DataContract]
    public partial class TemplateLimitConfig :  IEquatable<TemplateLimitConfig>, IValidatableObject
    {
        /// <summary>
        /// The period on which the budget limit recurs.
        /// </summary>
        /// <value>The period on which the budget limit recurs.</value>
        [JsonConverter(typeof(StringEnumConverter))]
        public enum PeriodEnum
        {
            /// <summary>
            /// Enum Daily for value: daily
            /// </summary>
            [EnumMember(Value = "daily")]
            Daily = 1,

            /// <summary>
            /// Enum Weekly for value: weekly
            /// </summary>
            [EnumMember(Value = "weekly")]
            Weekly = 2,

            /// <summary>
            /// Enum Monthly for value: monthly
            /// </summary>
            [EnumMember(Value = "monthly")]
            Monthly = 3,

            /// <summary>
            /// Enum Yearly for value: yearly
            /// </summary>
            [EnumMember(Value = "yearly")]
            Yearly = 4

        }

        /// <summary>
        /// The period on which the budget limit recurs.
        /// </summary>
        /// <value>The period on which the budget limit recurs.</value>
        [DataMember(Name="period", EmitDefaultValue=false)]
        public PeriodEnum? Period { get; set; }
        /// <summary>
        /// Defines Entities
        /// </summary>
        [JsonConverter(typeof(StringEnumConverter))]
        public enum EntitiesEnum
        {
            /// <summary>
            /// Enum Coupon for value: Coupon
            /// </summary>
            [EnumMember(Value = "Coupon")]
            Coupon = 1,

            /// <summary>
            /// Enum Referral for value: Referral
            /// </summary>
            [EnumMember(Value = "Referral")]
            Referral = 2,

            /// <summary>
            /// Enum Profile for value: Profile
            /// </summary>
            [EnumMember(Value = "Profile")]
            Profile = 3,

            /// <summary>
            /// Enum Identifier for value: Identifier
            /// </summary>
            [EnumMember(Value = "Identifier")]
            Identifier = 4,

            /// <summary>
            /// Enum Store for value: Store
            /// </summary>
            [EnumMember(Value = "Store")]
            Store = 5,

            /// <summary>
            /// Enum Session for value: Session
            /// </summary>
            [EnumMember(Value = "Session")]
            Session = 6

        }


        /// <summary>
        /// The entity that this limit applies to.
        /// </summary>
        /// <value>The entity that this limit applies to.</value>
        [DataMember(Name="entities", EmitDefaultValue=false)]
        public List<EntitiesEnum> Entities { get; set; }
        /// <summary>
        /// Initializes a new instance of the <see cref="TemplateLimitConfig" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected TemplateLimitConfig() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="TemplateLimitConfig" /> class.
        /// </summary>
        /// <param name="action">The limitable action to which this limit applies. For example: - &#x60;setDiscount&#x60; - &#x60;setDiscountEffect&#x60; - &#x60;redeemCoupon&#x60; - &#x60;createCoupon&#x60;  (required).</param>
        /// <param name="limit">The value to set for the limit. (required).</param>
        /// <param name="period">The period on which the budget limit recurs..</param>
        /// <param name="entities">The entity that this limit applies to. (required).</param>
        public TemplateLimitConfig(string action = default(string), decimal limit = default(decimal), PeriodEnum? period = default(PeriodEnum?), List<EntitiesEnum> entities = default(List<EntitiesEnum>))
        {
            // to ensure "action" is required (not null)
            this.Action = action ?? throw new ArgumentNullException("action is a required property for TemplateLimitConfig and cannot be null");
            this.Limit = limit;
            // to ensure "entities" is required (not null)
            this.Entities = entities ?? throw new ArgumentNullException("entities is a required property for TemplateLimitConfig and cannot be null");
            this.Period = period;
        }
        
        /// <summary>
        /// The limitable action to which this limit applies. For example: - &#x60;setDiscount&#x60; - &#x60;setDiscountEffect&#x60; - &#x60;redeemCoupon&#x60; - &#x60;createCoupon&#x60; 
        /// </summary>
        /// <value>The limitable action to which this limit applies. For example: - &#x60;setDiscount&#x60; - &#x60;setDiscountEffect&#x60; - &#x60;redeemCoupon&#x60; - &#x60;createCoupon&#x60; </value>
        [DataMember(Name="action", EmitDefaultValue=false)]
        public string Action { get; set; }

        /// <summary>
        /// The value to set for the limit.
        /// </summary>
        /// <value>The value to set for the limit.</value>
        [DataMember(Name="limit", EmitDefaultValue=false)]
        public decimal Limit { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class TemplateLimitConfig {\n");
            sb.Append("  Action: ").Append(Action).Append("\n");
            sb.Append("  Limit: ").Append(Limit).Append("\n");
            sb.Append("  Period: ").Append(Period).Append("\n");
            sb.Append("  Entities: ").Append(Entities).Append("\n");
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
            return this.Equals(input as TemplateLimitConfig);
        }

        /// <summary>
        /// Returns true if TemplateLimitConfig instances are equal
        /// </summary>
        /// <param name="input">Instance of TemplateLimitConfig to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(TemplateLimitConfig input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.Action == input.Action ||
                    (this.Action != null &&
                    this.Action.Equals(input.Action))
                ) && 
                (
                    this.Limit == input.Limit ||
                    this.Limit.Equals(input.Limit)
                ) && 
                (
                    this.Period == input.Period ||
                    this.Period.Equals(input.Period)
                ) && 
                (
                    this.Entities == input.Entities ||
                    this.Entities.SequenceEqual(input.Entities)
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
                if (this.Action != null)
                    hashCode = hashCode * 59 + this.Action.GetHashCode();
                hashCode = hashCode * 59 + this.Limit.GetHashCode();
                hashCode = hashCode * 59 + this.Period.GetHashCode();
                hashCode = hashCode * 59 + this.Entities.GetHashCode();
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
            // Limit (decimal) minimum
            if(this.Limit < (decimal)0)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for Limit, must be a value greater than or equal to 0.", new [] { "Limit" });
            }

            yield break;
        }
    }

}
