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
    /// AccountLimits
    /// </summary>
    [DataContract]
    public partial class AccountLimits :  IEquatable<AccountLimits>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="AccountLimits" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected AccountLimits() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="AccountLimits" /> class.
        /// </summary>
        /// <param name="liveApplications">Total number of allowed live applications in the account. (required).</param>
        /// <param name="sandboxApplications">Total number of allowed sandbox applications in the account. (required).</param>
        /// <param name="activeCampaigns">Total number of allowed active campaigns in live applications in the account. (required).</param>
        /// <param name="coupons">Total number of allowed coupons in the account. (required).</param>
        /// <param name="referralCodes">Total number of allowed referral codes in the account. (required).</param>
        /// <param name="activeRules">Total number of allowed active rulesets in the account. (required).</param>
        /// <param name="liveLoyaltyPrograms">Total number of allowed live loyalty programs in the account. (required).</param>
        /// <param name="sandboxLoyaltyPrograms">Total number of allowed sandbox loyalty programs in the account. (required).</param>
        /// <param name="webhooks">Total number of allowed webhooks in the account. (required).</param>
        /// <param name="users">Total number of allowed users in the account. (required).</param>
        /// <param name="apiVolume">Allowed volume of API requests to the account. (required).</param>
        /// <param name="promotionTypes">Array of promotion types that are employed in the account. (required).</param>
        public AccountLimits(int liveApplications = default(int), int sandboxApplications = default(int), int activeCampaigns = default(int), int coupons = default(int), int referralCodes = default(int), int activeRules = default(int), int liveLoyaltyPrograms = default(int), int sandboxLoyaltyPrograms = default(int), int webhooks = default(int), int users = default(int), int apiVolume = default(int), List<string> promotionTypes = default(List<string>))
        {
            this.LiveApplications = liveApplications;
            this.SandboxApplications = sandboxApplications;
            this.ActiveCampaigns = activeCampaigns;
            this.Coupons = coupons;
            this.ReferralCodes = referralCodes;
            this.ActiveRules = activeRules;
            this.LiveLoyaltyPrograms = liveLoyaltyPrograms;
            this.SandboxLoyaltyPrograms = sandboxLoyaltyPrograms;
            this.Webhooks = webhooks;
            this.Users = users;
            this.ApiVolume = apiVolume;
            // to ensure "promotionTypes" is required (not null)
            this.PromotionTypes = promotionTypes ?? throw new ArgumentNullException("promotionTypes is a required property for AccountLimits and cannot be null");
        }
        
        /// <summary>
        /// Total number of allowed live applications in the account.
        /// </summary>
        /// <value>Total number of allowed live applications in the account.</value>
        [DataMember(Name="liveApplications", EmitDefaultValue=false)]
        public int LiveApplications { get; set; }

        /// <summary>
        /// Total number of allowed sandbox applications in the account.
        /// </summary>
        /// <value>Total number of allowed sandbox applications in the account.</value>
        [DataMember(Name="sandboxApplications", EmitDefaultValue=false)]
        public int SandboxApplications { get; set; }

        /// <summary>
        /// Total number of allowed active campaigns in live applications in the account.
        /// </summary>
        /// <value>Total number of allowed active campaigns in live applications in the account.</value>
        [DataMember(Name="activeCampaigns", EmitDefaultValue=false)]
        public int ActiveCampaigns { get; set; }

        /// <summary>
        /// Total number of allowed coupons in the account.
        /// </summary>
        /// <value>Total number of allowed coupons in the account.</value>
        [DataMember(Name="coupons", EmitDefaultValue=false)]
        public int Coupons { get; set; }

        /// <summary>
        /// Total number of allowed referral codes in the account.
        /// </summary>
        /// <value>Total number of allowed referral codes in the account.</value>
        [DataMember(Name="referralCodes", EmitDefaultValue=false)]
        public int ReferralCodes { get; set; }

        /// <summary>
        /// Total number of allowed active rulesets in the account.
        /// </summary>
        /// <value>Total number of allowed active rulesets in the account.</value>
        [DataMember(Name="activeRules", EmitDefaultValue=false)]
        public int ActiveRules { get; set; }

        /// <summary>
        /// Total number of allowed live loyalty programs in the account.
        /// </summary>
        /// <value>Total number of allowed live loyalty programs in the account.</value>
        [DataMember(Name="liveLoyaltyPrograms", EmitDefaultValue=false)]
        public int LiveLoyaltyPrograms { get; set; }

        /// <summary>
        /// Total number of allowed sandbox loyalty programs in the account.
        /// </summary>
        /// <value>Total number of allowed sandbox loyalty programs in the account.</value>
        [DataMember(Name="sandboxLoyaltyPrograms", EmitDefaultValue=false)]
        public int SandboxLoyaltyPrograms { get; set; }

        /// <summary>
        /// Total number of allowed webhooks in the account.
        /// </summary>
        /// <value>Total number of allowed webhooks in the account.</value>
        [DataMember(Name="webhooks", EmitDefaultValue=false)]
        public int Webhooks { get; set; }

        /// <summary>
        /// Total number of allowed users in the account.
        /// </summary>
        /// <value>Total number of allowed users in the account.</value>
        [DataMember(Name="users", EmitDefaultValue=false)]
        public int Users { get; set; }

        /// <summary>
        /// Allowed volume of API requests to the account.
        /// </summary>
        /// <value>Allowed volume of API requests to the account.</value>
        [DataMember(Name="apiVolume", EmitDefaultValue=false)]
        public int ApiVolume { get; set; }

        /// <summary>
        /// Array of promotion types that are employed in the account.
        /// </summary>
        /// <value>Array of promotion types that are employed in the account.</value>
        [DataMember(Name="promotionTypes", EmitDefaultValue=false)]
        public List<string> PromotionTypes { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class AccountLimits {\n");
            sb.Append("  LiveApplications: ").Append(LiveApplications).Append("\n");
            sb.Append("  SandboxApplications: ").Append(SandboxApplications).Append("\n");
            sb.Append("  ActiveCampaigns: ").Append(ActiveCampaigns).Append("\n");
            sb.Append("  Coupons: ").Append(Coupons).Append("\n");
            sb.Append("  ReferralCodes: ").Append(ReferralCodes).Append("\n");
            sb.Append("  ActiveRules: ").Append(ActiveRules).Append("\n");
            sb.Append("  LiveLoyaltyPrograms: ").Append(LiveLoyaltyPrograms).Append("\n");
            sb.Append("  SandboxLoyaltyPrograms: ").Append(SandboxLoyaltyPrograms).Append("\n");
            sb.Append("  Webhooks: ").Append(Webhooks).Append("\n");
            sb.Append("  Users: ").Append(Users).Append("\n");
            sb.Append("  ApiVolume: ").Append(ApiVolume).Append("\n");
            sb.Append("  PromotionTypes: ").Append(PromotionTypes).Append("\n");
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
            return this.Equals(input as AccountLimits);
        }

        /// <summary>
        /// Returns true if AccountLimits instances are equal
        /// </summary>
        /// <param name="input">Instance of AccountLimits to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(AccountLimits input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.LiveApplications == input.LiveApplications ||
                    this.LiveApplications.Equals(input.LiveApplications)
                ) && 
                (
                    this.SandboxApplications == input.SandboxApplications ||
                    this.SandboxApplications.Equals(input.SandboxApplications)
                ) && 
                (
                    this.ActiveCampaigns == input.ActiveCampaigns ||
                    this.ActiveCampaigns.Equals(input.ActiveCampaigns)
                ) && 
                (
                    this.Coupons == input.Coupons ||
                    this.Coupons.Equals(input.Coupons)
                ) && 
                (
                    this.ReferralCodes == input.ReferralCodes ||
                    this.ReferralCodes.Equals(input.ReferralCodes)
                ) && 
                (
                    this.ActiveRules == input.ActiveRules ||
                    this.ActiveRules.Equals(input.ActiveRules)
                ) && 
                (
                    this.LiveLoyaltyPrograms == input.LiveLoyaltyPrograms ||
                    this.LiveLoyaltyPrograms.Equals(input.LiveLoyaltyPrograms)
                ) && 
                (
                    this.SandboxLoyaltyPrograms == input.SandboxLoyaltyPrograms ||
                    this.SandboxLoyaltyPrograms.Equals(input.SandboxLoyaltyPrograms)
                ) && 
                (
                    this.Webhooks == input.Webhooks ||
                    this.Webhooks.Equals(input.Webhooks)
                ) && 
                (
                    this.Users == input.Users ||
                    this.Users.Equals(input.Users)
                ) && 
                (
                    this.ApiVolume == input.ApiVolume ||
                    this.ApiVolume.Equals(input.ApiVolume)
                ) && 
                (
                    this.PromotionTypes == input.PromotionTypes ||
                    this.PromotionTypes != null &&
                    input.PromotionTypes != null &&
                    this.PromotionTypes.SequenceEqual(input.PromotionTypes)
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
                hashCode = hashCode * 59 + this.LiveApplications.GetHashCode();
                hashCode = hashCode * 59 + this.SandboxApplications.GetHashCode();
                hashCode = hashCode * 59 + this.ActiveCampaigns.GetHashCode();
                hashCode = hashCode * 59 + this.Coupons.GetHashCode();
                hashCode = hashCode * 59 + this.ReferralCodes.GetHashCode();
                hashCode = hashCode * 59 + this.ActiveRules.GetHashCode();
                hashCode = hashCode * 59 + this.LiveLoyaltyPrograms.GetHashCode();
                hashCode = hashCode * 59 + this.SandboxLoyaltyPrograms.GetHashCode();
                hashCode = hashCode * 59 + this.Webhooks.GetHashCode();
                hashCode = hashCode * 59 + this.Users.GetHashCode();
                hashCode = hashCode * 59 + this.ApiVolume.GetHashCode();
                if (this.PromotionTypes != null)
                    hashCode = hashCode * 59 + this.PromotionTypes.GetHashCode();
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
