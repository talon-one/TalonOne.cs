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
    /// BaseNotification
    /// </summary>
    [DataContract]
    public partial class BaseNotification :  IEquatable<BaseNotification>, IValidatableObject
    {
        /// <summary>
        /// The notification type.
        /// </summary>
        /// <value>The notification type.</value>
        [JsonConverter(typeof(StringEnumConverter))]
        public enum TypeEnum
        {
            /// <summary>
            /// Enum Campaign for value: campaign
            /// </summary>
            [EnumMember(Value = "campaign")]
            Campaign = 1,

            /// <summary>
            /// Enum Loyaltyaddeddeductedpoints for value: loyalty_added_deducted_points
            /// </summary>
            [EnumMember(Value = "loyalty_added_deducted_points")]
            Loyaltyaddeddeductedpoints = 2,

            /// <summary>
            /// Enum Coupon for value: coupon
            /// </summary>
            [EnumMember(Value = "coupon")]
            Coupon = 3,

            /// <summary>
            /// Enum Expiringcoupons for value: expiring_coupons
            /// </summary>
            [EnumMember(Value = "expiring_coupons")]
            Expiringcoupons = 4,

            /// <summary>
            /// Enum Expiringpoints for value: expiring_points
            /// </summary>
            [EnumMember(Value = "expiring_points")]
            Expiringpoints = 5,

            /// <summary>
            /// Enum Cardexpiringpoints for value: card_expiring_points
            /// </summary>
            [EnumMember(Value = "card_expiring_points")]
            Cardexpiringpoints = 6,

            /// <summary>
            /// Enum Pendingtoactivepoints for value: pending_to_active_points
            /// </summary>
            [EnumMember(Value = "pending_to_active_points")]
            Pendingtoactivepoints = 7,

            /// <summary>
            /// Enum Strikethroughpricing for value: strikethrough_pricing
            /// </summary>
            [EnumMember(Value = "strikethrough_pricing")]
            Strikethroughpricing = 8,

            /// <summary>
            /// Enum Tierdowngrade for value: tier_downgrade
            /// </summary>
            [EnumMember(Value = "tier_downgrade")]
            Tierdowngrade = 9,

            /// <summary>
            /// Enum Tierupgrade for value: tier_upgrade
            /// </summary>
            [EnumMember(Value = "tier_upgrade")]
            Tierupgrade = 10,

            /// <summary>
            /// Enum Tierwilldowngrade for value: tier_will_downgrade
            /// </summary>
            [EnumMember(Value = "tier_will_downgrade")]
            Tierwilldowngrade = 11

        }

        /// <summary>
        /// The notification type.
        /// </summary>
        /// <value>The notification type.</value>
        [DataMember(Name="type", EmitDefaultValue=false)]
        public TypeEnum Type { get; set; }
        /// <summary>
        /// Initializes a new instance of the <see cref="BaseNotification" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected BaseNotification() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="BaseNotification" /> class.
        /// </summary>
        /// <param name="policy">policy (required).</param>
        /// <param name="enabled">Indicates whether the notification is activated. (default to true).</param>
        /// <param name="webhook">webhook (required).</param>
        /// <param name="id">Unique ID for this entity. (required).</param>
        /// <param name="type">The notification type. (required).</param>
        public BaseNotification(Object policy = default(Object), bool enabled = true, BaseNotificationWebhook webhook = default(BaseNotificationWebhook), int id = default(int), TypeEnum type = default(TypeEnum))
        {
            // to ensure "policy" is required (not null)
            this.Policy = policy ?? throw new ArgumentNullException("policy is a required property for BaseNotification and cannot be null");
            // to ensure "webhook" is required (not null)
            this.Webhook = webhook ?? throw new ArgumentNullException("webhook is a required property for BaseNotification and cannot be null");
            this.Id = id;
            this.Type = type;
            this.Enabled = enabled;
        }
        
        /// <summary>
        /// Gets or Sets Policy
        /// </summary>
        [DataMember(Name="policy", EmitDefaultValue=false)]
        public Object Policy { get; set; }

        /// <summary>
        /// Indicates whether the notification is activated.
        /// </summary>
        /// <value>Indicates whether the notification is activated.</value>
        [DataMember(Name="enabled", EmitDefaultValue=false)]
        public bool Enabled { get; set; }

        /// <summary>
        /// Gets or Sets Webhook
        /// </summary>
        [DataMember(Name="webhook", EmitDefaultValue=false)]
        public BaseNotificationWebhook Webhook { get; set; }

        /// <summary>
        /// Unique ID for this entity.
        /// </summary>
        /// <value>Unique ID for this entity.</value>
        [DataMember(Name="id", EmitDefaultValue=false)]
        public int Id { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class BaseNotification {\n");
            sb.Append("  Policy: ").Append(Policy).Append("\n");
            sb.Append("  Enabled: ").Append(Enabled).Append("\n");
            sb.Append("  Webhook: ").Append(Webhook).Append("\n");
            sb.Append("  Id: ").Append(Id).Append("\n");
            sb.Append("  Type: ").Append(Type).Append("\n");
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
            return this.Equals(input as BaseNotification);
        }

        /// <summary>
        /// Returns true if BaseNotification instances are equal
        /// </summary>
        /// <param name="input">Instance of BaseNotification to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(BaseNotification input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.Policy == input.Policy ||
                    (this.Policy != null &&
                    this.Policy.Equals(input.Policy))
                ) && 
                (
                    this.Enabled == input.Enabled ||
                    this.Enabled.Equals(input.Enabled)
                ) && 
                (
                    this.Webhook == input.Webhook ||
                    (this.Webhook != null &&
                    this.Webhook.Equals(input.Webhook))
                ) && 
                (
                    this.Id == input.Id ||
                    this.Id.Equals(input.Id)
                ) && 
                (
                    this.Type == input.Type ||
                    this.Type.Equals(input.Type)
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
                if (this.Policy != null)
                    hashCode = hashCode * 59 + this.Policy.GetHashCode();
                hashCode = hashCode * 59 + this.Enabled.GetHashCode();
                if (this.Webhook != null)
                    hashCode = hashCode * 59 + this.Webhook.GetHashCode();
                hashCode = hashCode * 59 + this.Id.GetHashCode();
                hashCode = hashCode * 59 + this.Type.GetHashCode();
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
            // Id (int) minimum
            if(this.Id < (int)1)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for Id, must be a value greater than or equal to 1.", new [] { "Id" });
            }

            yield break;
        }
    }

}
