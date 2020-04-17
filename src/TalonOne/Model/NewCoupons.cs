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
    /// NewCoupons
    /// </summary>
    [DataContract]
    public partial class NewCoupons :  IEquatable<NewCoupons>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="NewCoupons" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected NewCoupons() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="NewCoupons" /> class.
        /// </summary>
        /// <param name="usageLimit">The number of times a coupon code can be redeemed. This can be set to 0 for no limit, but any campaign usage limits will still apply.  (required).</param>
        /// <param name="startDate">Timestamp at which point the coupon becomes valid..</param>
        /// <param name="expiryDate">Expiry date of the coupon. Coupon never expires if this is omitted, zero, or negative..</param>
        /// <param name="validCharacters">Set of characters to be used when generating random part of code. Defaults to [A-Z, 0-9] (in terms of RegExp). (required).</param>
        /// <param name="couponPattern">The pattern that will be used to generate coupon codes. The character &#x60;#&#x60; acts as a placeholder and will be replaced by a random character from the &#x60;validCharacters&#x60; set.  (required).</param>
        /// <param name="numberOfCoupons">The number of new coupon codes to generate for the campaign. Must be at least 1. (required).</param>
        /// <param name="uniquePrefix">A unique prefix to prepend to all generated coupons..</param>
        /// <param name="attributes">Arbitrary properties associated with this item.</param>
        /// <param name="recipientIntegrationId">The integration ID for this coupon&#39;s beneficiary&#39;s profile.</param>
        public NewCoupons(int usageLimit = default(int), DateTime startDate = default(DateTime), DateTime expiryDate = default(DateTime), List<string> validCharacters = default(List<string>), string couponPattern = default(string), int numberOfCoupons = default(int), string uniquePrefix = default(string), Object attributes = default(Object), string recipientIntegrationId = default(string))
        {
            // to ensure "usageLimit" is required (not null)
            if (usageLimit == null)
            {
                throw new InvalidDataException("usageLimit is a required property for NewCoupons and cannot be null");
            }
            else
            {
                this.UsageLimit = usageLimit;
            }
            
            // to ensure "validCharacters" is required (not null)
            if (validCharacters == null)
            {
                throw new InvalidDataException("validCharacters is a required property for NewCoupons and cannot be null");
            }
            else
            {
                this.ValidCharacters = validCharacters;
            }
            
            // to ensure "couponPattern" is required (not null)
            if (couponPattern == null)
            {
                throw new InvalidDataException("couponPattern is a required property for NewCoupons and cannot be null");
            }
            else
            {
                this.CouponPattern = couponPattern;
            }
            
            // to ensure "numberOfCoupons" is required (not null)
            if (numberOfCoupons == null)
            {
                throw new InvalidDataException("numberOfCoupons is a required property for NewCoupons and cannot be null");
            }
            else
            {
                this.NumberOfCoupons = numberOfCoupons;
            }
            
            this.StartDate = startDate;
            this.ExpiryDate = expiryDate;
            this.UniquePrefix = uniquePrefix;
            this.Attributes = attributes;
            this.RecipientIntegrationId = recipientIntegrationId;
        }
        
        /// <summary>
        /// The number of times a coupon code can be redeemed. This can be set to 0 for no limit, but any campaign usage limits will still apply. 
        /// </summary>
        /// <value>The number of times a coupon code can be redeemed. This can be set to 0 for no limit, but any campaign usage limits will still apply. </value>
        [DataMember(Name="usageLimit", EmitDefaultValue=false)]
        public int UsageLimit { get; set; }

        /// <summary>
        /// Timestamp at which point the coupon becomes valid.
        /// </summary>
        /// <value>Timestamp at which point the coupon becomes valid.</value>
        [DataMember(Name="startDate", EmitDefaultValue=false)]
        public DateTime StartDate { get; set; }

        /// <summary>
        /// Expiry date of the coupon. Coupon never expires if this is omitted, zero, or negative.
        /// </summary>
        /// <value>Expiry date of the coupon. Coupon never expires if this is omitted, zero, or negative.</value>
        [DataMember(Name="expiryDate", EmitDefaultValue=false)]
        public DateTime ExpiryDate { get; set; }

        /// <summary>
        /// Set of characters to be used when generating random part of code. Defaults to [A-Z, 0-9] (in terms of RegExp).
        /// </summary>
        /// <value>Set of characters to be used when generating random part of code. Defaults to [A-Z, 0-9] (in terms of RegExp).</value>
        [DataMember(Name="validCharacters", EmitDefaultValue=false)]
        public List<string> ValidCharacters { get; set; }

        /// <summary>
        /// The pattern that will be used to generate coupon codes. The character &#x60;#&#x60; acts as a placeholder and will be replaced by a random character from the &#x60;validCharacters&#x60; set. 
        /// </summary>
        /// <value>The pattern that will be used to generate coupon codes. The character &#x60;#&#x60; acts as a placeholder and will be replaced by a random character from the &#x60;validCharacters&#x60; set. </value>
        [DataMember(Name="couponPattern", EmitDefaultValue=false)]
        public string CouponPattern { get; set; }

        /// <summary>
        /// The number of new coupon codes to generate for the campaign. Must be at least 1.
        /// </summary>
        /// <value>The number of new coupon codes to generate for the campaign. Must be at least 1.</value>
        [DataMember(Name="numberOfCoupons", EmitDefaultValue=false)]
        public int NumberOfCoupons { get; set; }

        /// <summary>
        /// A unique prefix to prepend to all generated coupons.
        /// </summary>
        /// <value>A unique prefix to prepend to all generated coupons.</value>
        [DataMember(Name="uniquePrefix", EmitDefaultValue=false)]
        public string UniquePrefix { get; set; }

        /// <summary>
        /// Arbitrary properties associated with this item
        /// </summary>
        /// <value>Arbitrary properties associated with this item</value>
        [DataMember(Name="attributes", EmitDefaultValue=false)]
        public Object Attributes { get; set; }

        /// <summary>
        /// The integration ID for this coupon&#39;s beneficiary&#39;s profile
        /// </summary>
        /// <value>The integration ID for this coupon&#39;s beneficiary&#39;s profile</value>
        [DataMember(Name="recipientIntegrationId", EmitDefaultValue=false)]
        public string RecipientIntegrationId { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class NewCoupons {\n");
            sb.Append("  UsageLimit: ").Append(UsageLimit).Append("\n");
            sb.Append("  StartDate: ").Append(StartDate).Append("\n");
            sb.Append("  ExpiryDate: ").Append(ExpiryDate).Append("\n");
            sb.Append("  ValidCharacters: ").Append(ValidCharacters).Append("\n");
            sb.Append("  CouponPattern: ").Append(CouponPattern).Append("\n");
            sb.Append("  NumberOfCoupons: ").Append(NumberOfCoupons).Append("\n");
            sb.Append("  UniquePrefix: ").Append(UniquePrefix).Append("\n");
            sb.Append("  Attributes: ").Append(Attributes).Append("\n");
            sb.Append("  RecipientIntegrationId: ").Append(RecipientIntegrationId).Append("\n");
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
            return this.Equals(input as NewCoupons);
        }

        /// <summary>
        /// Returns true if NewCoupons instances are equal
        /// </summary>
        /// <param name="input">Instance of NewCoupons to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(NewCoupons input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.UsageLimit == input.UsageLimit ||
                    (this.UsageLimit != null &&
                    this.UsageLimit.Equals(input.UsageLimit))
                ) && 
                (
                    this.StartDate == input.StartDate ||
                    (this.StartDate != null &&
                    this.StartDate.Equals(input.StartDate))
                ) && 
                (
                    this.ExpiryDate == input.ExpiryDate ||
                    (this.ExpiryDate != null &&
                    this.ExpiryDate.Equals(input.ExpiryDate))
                ) && 
                (
                    this.ValidCharacters == input.ValidCharacters ||
                    this.ValidCharacters != null &&
                    input.ValidCharacters != null &&
                    this.ValidCharacters.SequenceEqual(input.ValidCharacters)
                ) && 
                (
                    this.CouponPattern == input.CouponPattern ||
                    (this.CouponPattern != null &&
                    this.CouponPattern.Equals(input.CouponPattern))
                ) && 
                (
                    this.NumberOfCoupons == input.NumberOfCoupons ||
                    (this.NumberOfCoupons != null &&
                    this.NumberOfCoupons.Equals(input.NumberOfCoupons))
                ) && 
                (
                    this.UniquePrefix == input.UniquePrefix ||
                    (this.UniquePrefix != null &&
                    this.UniquePrefix.Equals(input.UniquePrefix))
                ) && 
                (
                    this.Attributes == input.Attributes ||
                    (this.Attributes != null &&
                    this.Attributes.Equals(input.Attributes))
                ) && 
                (
                    this.RecipientIntegrationId == input.RecipientIntegrationId ||
                    (this.RecipientIntegrationId != null &&
                    this.RecipientIntegrationId.Equals(input.RecipientIntegrationId))
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
                if (this.UsageLimit != null)
                    hashCode = hashCode * 59 + this.UsageLimit.GetHashCode();
                if (this.StartDate != null)
                    hashCode = hashCode * 59 + this.StartDate.GetHashCode();
                if (this.ExpiryDate != null)
                    hashCode = hashCode * 59 + this.ExpiryDate.GetHashCode();
                if (this.ValidCharacters != null)
                    hashCode = hashCode * 59 + this.ValidCharacters.GetHashCode();
                if (this.CouponPattern != null)
                    hashCode = hashCode * 59 + this.CouponPattern.GetHashCode();
                if (this.NumberOfCoupons != null)
                    hashCode = hashCode * 59 + this.NumberOfCoupons.GetHashCode();
                if (this.UniquePrefix != null)
                    hashCode = hashCode * 59 + this.UniquePrefix.GetHashCode();
                if (this.Attributes != null)
                    hashCode = hashCode * 59 + this.Attributes.GetHashCode();
                if (this.RecipientIntegrationId != null)
                    hashCode = hashCode * 59 + this.RecipientIntegrationId.GetHashCode();
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
            // UsageLimit (int) maximum
            if(this.UsageLimit > (int)999999)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for UsageLimit, must be a value less than or equal to 999999.", new [] { "UsageLimit" });
            }

            // UsageLimit (int) minimum
            if(this.UsageLimit < (int)0)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for UsageLimit, must be a value greater than or equal to 0.", new [] { "UsageLimit" });
            }

            // CouponPattern (string) minLength
            if(this.CouponPattern != null && this.CouponPattern.Length < 3)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for CouponPattern, length must be greater than 3.", new [] { "CouponPattern" });
            }

            yield break;
        }
    }

}
