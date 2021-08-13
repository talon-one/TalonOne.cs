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
    /// NewCustomerSession
    /// </summary>
    [DataContract]
    public partial class NewCustomerSession :  IEquatable<NewCustomerSession>, IValidatableObject
    {
        /// <summary>
        /// Indicates the current state of the session. Sessions can be created as &#x60;open&#x60; or &#x60;closed&#x60;, after which valid transitions are:  1. &#x60;open&#x60; → &#x60;closed&#x60; 2. &#x60;open&#x60; → &#x60;cancelled&#x60; 3. &#x60;closed&#x60; → &#x60;cancelled&#x60;  For more information, see [Entities](/docs/dev/concepts/entities#customer-session). 
        /// </summary>
        /// <value>Indicates the current state of the session. Sessions can be created as &#x60;open&#x60; or &#x60;closed&#x60;, after which valid transitions are:  1. &#x60;open&#x60; → &#x60;closed&#x60; 2. &#x60;open&#x60; → &#x60;cancelled&#x60; 3. &#x60;closed&#x60; → &#x60;cancelled&#x60;  For more information, see [Entities](/docs/dev/concepts/entities#customer-session). </value>
        [JsonConverter(typeof(StringEnumConverter))]
        public enum StateEnum
        {
            /// <summary>
            /// Enum Open for value: open
            /// </summary>
            [EnumMember(Value = "open")]
            Open = 1,

            /// <summary>
            /// Enum Closed for value: closed
            /// </summary>
            [EnumMember(Value = "closed")]
            Closed = 2,

            /// <summary>
            /// Enum Cancelled for value: cancelled
            /// </summary>
            [EnumMember(Value = "cancelled")]
            Cancelled = 3

        }

        /// <summary>
        /// Indicates the current state of the session. Sessions can be created as &#x60;open&#x60; or &#x60;closed&#x60;, after which valid transitions are:  1. &#x60;open&#x60; → &#x60;closed&#x60; 2. &#x60;open&#x60; → &#x60;cancelled&#x60; 3. &#x60;closed&#x60; → &#x60;cancelled&#x60;  For more information, see [Entities](/docs/dev/concepts/entities#customer-session). 
        /// </summary>
        /// <value>Indicates the current state of the session. Sessions can be created as &#x60;open&#x60; or &#x60;closed&#x60;, after which valid transitions are:  1. &#x60;open&#x60; → &#x60;closed&#x60; 2. &#x60;open&#x60; → &#x60;cancelled&#x60; 3. &#x60;closed&#x60; → &#x60;cancelled&#x60;  For more information, see [Entities](/docs/dev/concepts/entities#customer-session). </value>
        [DataMember(Name="state", EmitDefaultValue=false)]
        public StateEnum? State { get; set; }
        /// <summary>
        /// Initializes a new instance of the <see cref="NewCustomerSession" /> class.
        /// </summary>
        /// <param name="profileId">ID of the customers profile as used within this Talon.One account. May be omitted or set to the empty string if the customer does not yet have a known profile ID..</param>
        /// <param name="coupon">Any coupon code entered..</param>
        /// <param name="referral">Any referral code entered..</param>
        /// <param name="state">Indicates the current state of the session. Sessions can be created as &#x60;open&#x60; or &#x60;closed&#x60;, after which valid transitions are:  1. &#x60;open&#x60; → &#x60;closed&#x60; 2. &#x60;open&#x60; → &#x60;cancelled&#x60; 3. &#x60;closed&#x60; → &#x60;cancelled&#x60;  For more information, see [Entities](/docs/dev/concepts/entities#customer-session).  (default to StateEnum.Open).</param>
        /// <param name="cartItems">Serialized JSON representation..</param>
        /// <param name="identifiers">Session custom identifiers that you can set limits on or use inside your rules.  For example, you can use IP addresses as identifiers to potentially identify devices and limit discounts abuse in case of customers creating multiple accounts. .</param>
        /// <param name="total">The total sum of the cart in one session..</param>
        /// <param name="attributes">A key-value map of the sessions attributes. The potentially valid attributes are configured in your accounts developer settings. .</param>
        public NewCustomerSession(string profileId = default(string), string coupon = default(string), string referral = default(string), StateEnum? state = StateEnum.Open, List<CartItem> cartItems = default(List<CartItem>), List<string> identifiers = default(List<string>), decimal total = default(decimal), Object attributes = default(Object))
        {
            this.ProfileId = profileId;
            this.Coupon = coupon;
            this.Referral = referral;
            this.State = state;
            this.CartItems = cartItems;
            this.Identifiers = identifiers;
            this.Total = total;
            this.Attributes = attributes;
        }
        
        /// <summary>
        /// ID of the customers profile as used within this Talon.One account. May be omitted or set to the empty string if the customer does not yet have a known profile ID.
        /// </summary>
        /// <value>ID of the customers profile as used within this Talon.One account. May be omitted or set to the empty string if the customer does not yet have a known profile ID.</value>
        [DataMember(Name="profileId", EmitDefaultValue=false)]
        public string ProfileId { get; set; }

        /// <summary>
        /// Any coupon code entered.
        /// </summary>
        /// <value>Any coupon code entered.</value>
        [DataMember(Name="coupon", EmitDefaultValue=false)]
        public string Coupon { get; set; }

        /// <summary>
        /// Any referral code entered.
        /// </summary>
        /// <value>Any referral code entered.</value>
        [DataMember(Name="referral", EmitDefaultValue=false)]
        public string Referral { get; set; }

        /// <summary>
        /// Serialized JSON representation.
        /// </summary>
        /// <value>Serialized JSON representation.</value>
        [DataMember(Name="cartItems", EmitDefaultValue=false)]
        public List<CartItem> CartItems { get; set; }

        /// <summary>
        /// Session custom identifiers that you can set limits on or use inside your rules.  For example, you can use IP addresses as identifiers to potentially identify devices and limit discounts abuse in case of customers creating multiple accounts. 
        /// </summary>
        /// <value>Session custom identifiers that you can set limits on or use inside your rules.  For example, you can use IP addresses as identifiers to potentially identify devices and limit discounts abuse in case of customers creating multiple accounts. </value>
        [DataMember(Name="identifiers", EmitDefaultValue=false)]
        public List<string> Identifiers { get; set; }

        /// <summary>
        /// The total sum of the cart in one session.
        /// </summary>
        /// <value>The total sum of the cart in one session.</value>
        [DataMember(Name="total", EmitDefaultValue=false)]
        public decimal Total { get; set; }

        /// <summary>
        /// A key-value map of the sessions attributes. The potentially valid attributes are configured in your accounts developer settings. 
        /// </summary>
        /// <value>A key-value map of the sessions attributes. The potentially valid attributes are configured in your accounts developer settings. </value>
        [DataMember(Name="attributes", EmitDefaultValue=false)]
        public Object Attributes { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class NewCustomerSession {\n");
            sb.Append("  ProfileId: ").Append(ProfileId).Append("\n");
            sb.Append("  Coupon: ").Append(Coupon).Append("\n");
            sb.Append("  Referral: ").Append(Referral).Append("\n");
            sb.Append("  State: ").Append(State).Append("\n");
            sb.Append("  CartItems: ").Append(CartItems).Append("\n");
            sb.Append("  Identifiers: ").Append(Identifiers).Append("\n");
            sb.Append("  Total: ").Append(Total).Append("\n");
            sb.Append("  Attributes: ").Append(Attributes).Append("\n");
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
            return this.Equals(input as NewCustomerSession);
        }

        /// <summary>
        /// Returns true if NewCustomerSession instances are equal
        /// </summary>
        /// <param name="input">Instance of NewCustomerSession to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(NewCustomerSession input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.ProfileId == input.ProfileId ||
                    (this.ProfileId != null &&
                    this.ProfileId.Equals(input.ProfileId))
                ) && 
                (
                    this.Coupon == input.Coupon ||
                    (this.Coupon != null &&
                    this.Coupon.Equals(input.Coupon))
                ) && 
                (
                    this.Referral == input.Referral ||
                    (this.Referral != null &&
                    this.Referral.Equals(input.Referral))
                ) && 
                (
                    this.State == input.State ||
                    this.State.Equals(input.State)
                ) && 
                (
                    this.CartItems == input.CartItems ||
                    this.CartItems != null &&
                    input.CartItems != null &&
                    this.CartItems.SequenceEqual(input.CartItems)
                ) && 
                (
                    this.Identifiers == input.Identifiers ||
                    this.Identifiers != null &&
                    input.Identifiers != null &&
                    this.Identifiers.SequenceEqual(input.Identifiers)
                ) && 
                (
                    this.Total == input.Total ||
                    this.Total.Equals(input.Total)
                ) && 
                (
                    this.Attributes == input.Attributes ||
                    (this.Attributes != null &&
                    this.Attributes.Equals(input.Attributes))
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
                if (this.ProfileId != null)
                    hashCode = hashCode * 59 + this.ProfileId.GetHashCode();
                if (this.Coupon != null)
                    hashCode = hashCode * 59 + this.Coupon.GetHashCode();
                if (this.Referral != null)
                    hashCode = hashCode * 59 + this.Referral.GetHashCode();
                hashCode = hashCode * 59 + this.State.GetHashCode();
                if (this.CartItems != null)
                    hashCode = hashCode * 59 + this.CartItems.GetHashCode();
                if (this.Identifiers != null)
                    hashCode = hashCode * 59 + this.Identifiers.GetHashCode();
                hashCode = hashCode * 59 + this.Total.GetHashCode();
                if (this.Attributes != null)
                    hashCode = hashCode * 59 + this.Attributes.GetHashCode();
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
            // Coupon (string) maxLength
            if(this.Coupon != null && this.Coupon.Length > 100)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for Coupon, length must be less than 100.", new [] { "Coupon" });
            }

            // Referral (string) maxLength
            if(this.Referral != null && this.Referral.Length > 100)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for Referral, length must be less than 100.", new [] { "Referral" });
            }

            yield break;
        }
    }

}
