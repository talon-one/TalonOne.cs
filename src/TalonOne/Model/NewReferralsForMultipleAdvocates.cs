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
    /// NewReferralsForMultipleAdvocates
    /// </summary>
    [DataContract]
    public partial class NewReferralsForMultipleAdvocates :  IEquatable<NewReferralsForMultipleAdvocates>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="NewReferralsForMultipleAdvocates" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected NewReferralsForMultipleAdvocates() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="NewReferralsForMultipleAdvocates" /> class.
        /// </summary>
        /// <param name="startDate">Timestamp at which point the referral code becomes valid..</param>
        /// <param name="expiryDate">Expiry date of the referral code. Referral never expires if this is omitted, zero, or negative..</param>
        /// <param name="usageLimit">The number of times a referral code can be used. This can be set to 0 for no limit, but any campaign usage limits will still apply.  (required).</param>
        /// <param name="campaignId">The ID of the campaign from which the referral received the referral code. (required).</param>
        /// <param name="advocateProfileIntegrationIds">An array containing all the respective advocate profiles. (required).</param>
        /// <param name="attributes">Arbitrary properties associated with this item..</param>
        /// <param name="validCharacters">Set of characters to be used when generating random part of code. Defaults to [A-Z, 0-9] (in terms of RegExp)..</param>
        /// <param name="referralPattern">The pattern that will be used to generate referrals. The character &#x60;#&#x60; acts as a placeholder and will be replaced by a random character from the &#x60;validCharacters&#x60; set. .</param>
        public NewReferralsForMultipleAdvocates(DateTime startDate = default(DateTime), DateTime expiryDate = default(DateTime), int usageLimit = default(int), int campaignId = default(int), List<string> advocateProfileIntegrationIds = default(List<string>), Object attributes = default(Object), List<string> validCharacters = default(List<string>), string referralPattern = default(string))
        {
            this.UsageLimit = usageLimit;
            this.CampaignId = campaignId;
            // to ensure "advocateProfileIntegrationIds" is required (not null)
            this.AdvocateProfileIntegrationIds = advocateProfileIntegrationIds ?? throw new ArgumentNullException("advocateProfileIntegrationIds is a required property for NewReferralsForMultipleAdvocates and cannot be null");
            this.StartDate = startDate;
            this.ExpiryDate = expiryDate;
            this.Attributes = attributes;
            this.ValidCharacters = validCharacters;
            this.ReferralPattern = referralPattern;
        }
        
        /// <summary>
        /// Timestamp at which point the referral code becomes valid.
        /// </summary>
        /// <value>Timestamp at which point the referral code becomes valid.</value>
        [DataMember(Name="startDate", EmitDefaultValue=false)]
        public DateTime StartDate { get; set; }

        /// <summary>
        /// Expiry date of the referral code. Referral never expires if this is omitted, zero, or negative.
        /// </summary>
        /// <value>Expiry date of the referral code. Referral never expires if this is omitted, zero, or negative.</value>
        [DataMember(Name="expiryDate", EmitDefaultValue=false)]
        public DateTime ExpiryDate { get; set; }

        /// <summary>
        /// The number of times a referral code can be used. This can be set to 0 for no limit, but any campaign usage limits will still apply. 
        /// </summary>
        /// <value>The number of times a referral code can be used. This can be set to 0 for no limit, but any campaign usage limits will still apply. </value>
        [DataMember(Name="usageLimit", EmitDefaultValue=false)]
        public int UsageLimit { get; set; }

        /// <summary>
        /// The ID of the campaign from which the referral received the referral code.
        /// </summary>
        /// <value>The ID of the campaign from which the referral received the referral code.</value>
        [DataMember(Name="campaignId", EmitDefaultValue=false)]
        public int CampaignId { get; set; }

        /// <summary>
        /// An array containing all the respective advocate profiles.
        /// </summary>
        /// <value>An array containing all the respective advocate profiles.</value>
        [DataMember(Name="advocateProfileIntegrationIds", EmitDefaultValue=false)]
        public List<string> AdvocateProfileIntegrationIds { get; set; }

        /// <summary>
        /// Arbitrary properties associated with this item.
        /// </summary>
        /// <value>Arbitrary properties associated with this item.</value>
        [DataMember(Name="attributes", EmitDefaultValue=false)]
        public Object Attributes { get; set; }

        /// <summary>
        /// Set of characters to be used when generating random part of code. Defaults to [A-Z, 0-9] (in terms of RegExp).
        /// </summary>
        /// <value>Set of characters to be used when generating random part of code. Defaults to [A-Z, 0-9] (in terms of RegExp).</value>
        [DataMember(Name="validCharacters", EmitDefaultValue=false)]
        public List<string> ValidCharacters { get; set; }

        /// <summary>
        /// The pattern that will be used to generate referrals. The character &#x60;#&#x60; acts as a placeholder and will be replaced by a random character from the &#x60;validCharacters&#x60; set. 
        /// </summary>
        /// <value>The pattern that will be used to generate referrals. The character &#x60;#&#x60; acts as a placeholder and will be replaced by a random character from the &#x60;validCharacters&#x60; set. </value>
        [DataMember(Name="referralPattern", EmitDefaultValue=false)]
        public string ReferralPattern { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class NewReferralsForMultipleAdvocates {\n");
            sb.Append("  StartDate: ").Append(StartDate).Append("\n");
            sb.Append("  ExpiryDate: ").Append(ExpiryDate).Append("\n");
            sb.Append("  UsageLimit: ").Append(UsageLimit).Append("\n");
            sb.Append("  CampaignId: ").Append(CampaignId).Append("\n");
            sb.Append("  AdvocateProfileIntegrationIds: ").Append(AdvocateProfileIntegrationIds).Append("\n");
            sb.Append("  Attributes: ").Append(Attributes).Append("\n");
            sb.Append("  ValidCharacters: ").Append(ValidCharacters).Append("\n");
            sb.Append("  ReferralPattern: ").Append(ReferralPattern).Append("\n");
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
            return this.Equals(input as NewReferralsForMultipleAdvocates);
        }

        /// <summary>
        /// Returns true if NewReferralsForMultipleAdvocates instances are equal
        /// </summary>
        /// <param name="input">Instance of NewReferralsForMultipleAdvocates to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(NewReferralsForMultipleAdvocates input)
        {
            if (input == null)
                return false;

            return 
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
                    this.UsageLimit == input.UsageLimit ||
                    this.UsageLimit.Equals(input.UsageLimit)
                ) && 
                (
                    this.CampaignId == input.CampaignId ||
                    this.CampaignId.Equals(input.CampaignId)
                ) && 
                (
                    this.AdvocateProfileIntegrationIds == input.AdvocateProfileIntegrationIds ||
                    this.AdvocateProfileIntegrationIds != null &&
                    input.AdvocateProfileIntegrationIds != null &&
                    this.AdvocateProfileIntegrationIds.SequenceEqual(input.AdvocateProfileIntegrationIds)
                ) && 
                (
                    this.Attributes == input.Attributes ||
                    (this.Attributes != null &&
                    this.Attributes.Equals(input.Attributes))
                ) && 
                (
                    this.ValidCharacters == input.ValidCharacters ||
                    this.ValidCharacters != null &&
                    input.ValidCharacters != null &&
                    this.ValidCharacters.SequenceEqual(input.ValidCharacters)
                ) && 
                (
                    this.ReferralPattern == input.ReferralPattern ||
                    (this.ReferralPattern != null &&
                    this.ReferralPattern.Equals(input.ReferralPattern))
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
                if (this.StartDate != null)
                    hashCode = hashCode * 59 + this.StartDate.GetHashCode();
                if (this.ExpiryDate != null)
                    hashCode = hashCode * 59 + this.ExpiryDate.GetHashCode();
                hashCode = hashCode * 59 + this.UsageLimit.GetHashCode();
                hashCode = hashCode * 59 + this.CampaignId.GetHashCode();
                if (this.AdvocateProfileIntegrationIds != null)
                    hashCode = hashCode * 59 + this.AdvocateProfileIntegrationIds.GetHashCode();
                if (this.Attributes != null)
                    hashCode = hashCode * 59 + this.Attributes.GetHashCode();
                if (this.ValidCharacters != null)
                    hashCode = hashCode * 59 + this.ValidCharacters.GetHashCode();
                if (this.ReferralPattern != null)
                    hashCode = hashCode * 59 + this.ReferralPattern.GetHashCode();
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

            // ReferralPattern (string) maxLength
            if(this.ReferralPattern != null && this.ReferralPattern.Length > 100)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for ReferralPattern, length must be less than 100.", new [] { "ReferralPattern" });
            }

            // ReferralPattern (string) minLength
            if(this.ReferralPattern != null && this.ReferralPattern.Length < 3)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for ReferralPattern, length must be greater than 3.", new [] { "ReferralPattern" });
            }

            yield break;
        }
    }

}
