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
    /// AccountAnalytics
    /// </summary>
    [DataContract]
    public partial class AccountAnalytics :  IEquatable<AccountAnalytics>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="AccountAnalytics" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected AccountAnalytics() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="AccountAnalytics" /> class.
        /// </summary>
        /// <param name="applications">Total number of applications in the account. (required).</param>
        /// <param name="liveApplications">Total number of live applications in the account. (required).</param>
        /// <param name="sandboxApplications">Total number of sandbox applications in the account. (required).</param>
        /// <param name="campaigns">Total number of campaigns in the account. (required).</param>
        /// <param name="activeCampaigns">Total number of active campaigns in the account. (required).</param>
        /// <param name="liveActiveCampaigns">Total number of active campaigns in live applications in the account. (required).</param>
        /// <param name="coupons">Total number of coupons in the account. (required).</param>
        /// <param name="activeCoupons">Total number of active coupons in the account. (required).</param>
        /// <param name="expiredCoupons">Total number of expired coupons in the account. (required).</param>
        /// <param name="referralCodes">Total number of referral codes in the account. (required).</param>
        /// <param name="activeReferralCodes">Total number of active referral codes in the account. (required).</param>
        /// <param name="expiredReferralCodes">Total number of expired referral codes in the account. (required).</param>
        /// <param name="activeRules">Total number of active rules in the account. (required).</param>
        /// <param name="users">Total number of users in the account. (required).</param>
        /// <param name="roles">Total number of roles in the account. (required).</param>
        /// <param name="customAttributes">Total number of custom attributes in the account. (required).</param>
        /// <param name="webhooks">Total number of webhooks in the account. (required).</param>
        /// <param name="loyaltyPrograms">Total number of all loyalty programs in the account. (required).</param>
        /// <param name="liveLoyaltyPrograms">Total number of live loyalty programs in the account. (required).</param>
        /// <param name="lastUpdatedAt">The point in time when the analytics numbers were updated last. (required).</param>
        public AccountAnalytics(int applications = default(int), int liveApplications = default(int), int sandboxApplications = default(int), int campaigns = default(int), int activeCampaigns = default(int), int liveActiveCampaigns = default(int), int coupons = default(int), int activeCoupons = default(int), int expiredCoupons = default(int), int referralCodes = default(int), int activeReferralCodes = default(int), int expiredReferralCodes = default(int), int activeRules = default(int), int users = default(int), int roles = default(int), int customAttributes = default(int), int webhooks = default(int), int loyaltyPrograms = default(int), int liveLoyaltyPrograms = default(int), DateTime lastUpdatedAt = default(DateTime))
        {
            this.Applications = applications;
            this.LiveApplications = liveApplications;
            this.SandboxApplications = sandboxApplications;
            this.Campaigns = campaigns;
            this.ActiveCampaigns = activeCampaigns;
            this.LiveActiveCampaigns = liveActiveCampaigns;
            this.Coupons = coupons;
            this.ActiveCoupons = activeCoupons;
            this.ExpiredCoupons = expiredCoupons;
            this.ReferralCodes = referralCodes;
            this.ActiveReferralCodes = activeReferralCodes;
            this.ExpiredReferralCodes = expiredReferralCodes;
            this.ActiveRules = activeRules;
            this.Users = users;
            this.Roles = roles;
            this.CustomAttributes = customAttributes;
            this.Webhooks = webhooks;
            this.LoyaltyPrograms = loyaltyPrograms;
            this.LiveLoyaltyPrograms = liveLoyaltyPrograms;
            this.LastUpdatedAt = lastUpdatedAt;
        }
        
        /// <summary>
        /// Total number of applications in the account.
        /// </summary>
        /// <value>Total number of applications in the account.</value>
        [DataMember(Name="applications", EmitDefaultValue=false)]
        public int Applications { get; set; }

        /// <summary>
        /// Total number of live applications in the account.
        /// </summary>
        /// <value>Total number of live applications in the account.</value>
        [DataMember(Name="liveApplications", EmitDefaultValue=false)]
        public int LiveApplications { get; set; }

        /// <summary>
        /// Total number of sandbox applications in the account.
        /// </summary>
        /// <value>Total number of sandbox applications in the account.</value>
        [DataMember(Name="sandboxApplications", EmitDefaultValue=false)]
        public int SandboxApplications { get; set; }

        /// <summary>
        /// Total number of campaigns in the account.
        /// </summary>
        /// <value>Total number of campaigns in the account.</value>
        [DataMember(Name="campaigns", EmitDefaultValue=false)]
        public int Campaigns { get; set; }

        /// <summary>
        /// Total number of active campaigns in the account.
        /// </summary>
        /// <value>Total number of active campaigns in the account.</value>
        [DataMember(Name="activeCampaigns", EmitDefaultValue=false)]
        public int ActiveCampaigns { get; set; }

        /// <summary>
        /// Total number of active campaigns in live applications in the account.
        /// </summary>
        /// <value>Total number of active campaigns in live applications in the account.</value>
        [DataMember(Name="liveActiveCampaigns", EmitDefaultValue=false)]
        public int LiveActiveCampaigns { get; set; }

        /// <summary>
        /// Total number of coupons in the account.
        /// </summary>
        /// <value>Total number of coupons in the account.</value>
        [DataMember(Name="coupons", EmitDefaultValue=false)]
        public int Coupons { get; set; }

        /// <summary>
        /// Total number of active coupons in the account.
        /// </summary>
        /// <value>Total number of active coupons in the account.</value>
        [DataMember(Name="activeCoupons", EmitDefaultValue=false)]
        public int ActiveCoupons { get; set; }

        /// <summary>
        /// Total number of expired coupons in the account.
        /// </summary>
        /// <value>Total number of expired coupons in the account.</value>
        [DataMember(Name="expiredCoupons", EmitDefaultValue=false)]
        public int ExpiredCoupons { get; set; }

        /// <summary>
        /// Total number of referral codes in the account.
        /// </summary>
        /// <value>Total number of referral codes in the account.</value>
        [DataMember(Name="referralCodes", EmitDefaultValue=false)]
        public int ReferralCodes { get; set; }

        /// <summary>
        /// Total number of active referral codes in the account.
        /// </summary>
        /// <value>Total number of active referral codes in the account.</value>
        [DataMember(Name="activeReferralCodes", EmitDefaultValue=false)]
        public int ActiveReferralCodes { get; set; }

        /// <summary>
        /// Total number of expired referral codes in the account.
        /// </summary>
        /// <value>Total number of expired referral codes in the account.</value>
        [DataMember(Name="expiredReferralCodes", EmitDefaultValue=false)]
        public int ExpiredReferralCodes { get; set; }

        /// <summary>
        /// Total number of active rules in the account.
        /// </summary>
        /// <value>Total number of active rules in the account.</value>
        [DataMember(Name="activeRules", EmitDefaultValue=false)]
        public int ActiveRules { get; set; }

        /// <summary>
        /// Total number of users in the account.
        /// </summary>
        /// <value>Total number of users in the account.</value>
        [DataMember(Name="users", EmitDefaultValue=false)]
        public int Users { get; set; }

        /// <summary>
        /// Total number of roles in the account.
        /// </summary>
        /// <value>Total number of roles in the account.</value>
        [DataMember(Name="roles", EmitDefaultValue=false)]
        public int Roles { get; set; }

        /// <summary>
        /// Total number of custom attributes in the account.
        /// </summary>
        /// <value>Total number of custom attributes in the account.</value>
        [DataMember(Name="customAttributes", EmitDefaultValue=false)]
        public int CustomAttributes { get; set; }

        /// <summary>
        /// Total number of webhooks in the account.
        /// </summary>
        /// <value>Total number of webhooks in the account.</value>
        [DataMember(Name="webhooks", EmitDefaultValue=false)]
        public int Webhooks { get; set; }

        /// <summary>
        /// Total number of all loyalty programs in the account.
        /// </summary>
        /// <value>Total number of all loyalty programs in the account.</value>
        [DataMember(Name="loyaltyPrograms", EmitDefaultValue=false)]
        public int LoyaltyPrograms { get; set; }

        /// <summary>
        /// Total number of live loyalty programs in the account.
        /// </summary>
        /// <value>Total number of live loyalty programs in the account.</value>
        [DataMember(Name="liveLoyaltyPrograms", EmitDefaultValue=false)]
        public int LiveLoyaltyPrograms { get; set; }

        /// <summary>
        /// The point in time when the analytics numbers were updated last.
        /// </summary>
        /// <value>The point in time when the analytics numbers were updated last.</value>
        [DataMember(Name="lastUpdatedAt", EmitDefaultValue=false)]
        public DateTime LastUpdatedAt { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class AccountAnalytics {\n");
            sb.Append("  Applications: ").Append(Applications).Append("\n");
            sb.Append("  LiveApplications: ").Append(LiveApplications).Append("\n");
            sb.Append("  SandboxApplications: ").Append(SandboxApplications).Append("\n");
            sb.Append("  Campaigns: ").Append(Campaigns).Append("\n");
            sb.Append("  ActiveCampaigns: ").Append(ActiveCampaigns).Append("\n");
            sb.Append("  LiveActiveCampaigns: ").Append(LiveActiveCampaigns).Append("\n");
            sb.Append("  Coupons: ").Append(Coupons).Append("\n");
            sb.Append("  ActiveCoupons: ").Append(ActiveCoupons).Append("\n");
            sb.Append("  ExpiredCoupons: ").Append(ExpiredCoupons).Append("\n");
            sb.Append("  ReferralCodes: ").Append(ReferralCodes).Append("\n");
            sb.Append("  ActiveReferralCodes: ").Append(ActiveReferralCodes).Append("\n");
            sb.Append("  ExpiredReferralCodes: ").Append(ExpiredReferralCodes).Append("\n");
            sb.Append("  ActiveRules: ").Append(ActiveRules).Append("\n");
            sb.Append("  Users: ").Append(Users).Append("\n");
            sb.Append("  Roles: ").Append(Roles).Append("\n");
            sb.Append("  CustomAttributes: ").Append(CustomAttributes).Append("\n");
            sb.Append("  Webhooks: ").Append(Webhooks).Append("\n");
            sb.Append("  LoyaltyPrograms: ").Append(LoyaltyPrograms).Append("\n");
            sb.Append("  LiveLoyaltyPrograms: ").Append(LiveLoyaltyPrograms).Append("\n");
            sb.Append("  LastUpdatedAt: ").Append(LastUpdatedAt).Append("\n");
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
            return this.Equals(input as AccountAnalytics);
        }

        /// <summary>
        /// Returns true if AccountAnalytics instances are equal
        /// </summary>
        /// <param name="input">Instance of AccountAnalytics to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(AccountAnalytics input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.Applications == input.Applications ||
                    this.Applications.Equals(input.Applications)
                ) && 
                (
                    this.LiveApplications == input.LiveApplications ||
                    this.LiveApplications.Equals(input.LiveApplications)
                ) && 
                (
                    this.SandboxApplications == input.SandboxApplications ||
                    this.SandboxApplications.Equals(input.SandboxApplications)
                ) && 
                (
                    this.Campaigns == input.Campaigns ||
                    this.Campaigns.Equals(input.Campaigns)
                ) && 
                (
                    this.ActiveCampaigns == input.ActiveCampaigns ||
                    this.ActiveCampaigns.Equals(input.ActiveCampaigns)
                ) && 
                (
                    this.LiveActiveCampaigns == input.LiveActiveCampaigns ||
                    this.LiveActiveCampaigns.Equals(input.LiveActiveCampaigns)
                ) && 
                (
                    this.Coupons == input.Coupons ||
                    this.Coupons.Equals(input.Coupons)
                ) && 
                (
                    this.ActiveCoupons == input.ActiveCoupons ||
                    this.ActiveCoupons.Equals(input.ActiveCoupons)
                ) && 
                (
                    this.ExpiredCoupons == input.ExpiredCoupons ||
                    this.ExpiredCoupons.Equals(input.ExpiredCoupons)
                ) && 
                (
                    this.ReferralCodes == input.ReferralCodes ||
                    this.ReferralCodes.Equals(input.ReferralCodes)
                ) && 
                (
                    this.ActiveReferralCodes == input.ActiveReferralCodes ||
                    this.ActiveReferralCodes.Equals(input.ActiveReferralCodes)
                ) && 
                (
                    this.ExpiredReferralCodes == input.ExpiredReferralCodes ||
                    this.ExpiredReferralCodes.Equals(input.ExpiredReferralCodes)
                ) && 
                (
                    this.ActiveRules == input.ActiveRules ||
                    this.ActiveRules.Equals(input.ActiveRules)
                ) && 
                (
                    this.Users == input.Users ||
                    this.Users.Equals(input.Users)
                ) && 
                (
                    this.Roles == input.Roles ||
                    this.Roles.Equals(input.Roles)
                ) && 
                (
                    this.CustomAttributes == input.CustomAttributes ||
                    this.CustomAttributes.Equals(input.CustomAttributes)
                ) && 
                (
                    this.Webhooks == input.Webhooks ||
                    this.Webhooks.Equals(input.Webhooks)
                ) && 
                (
                    this.LoyaltyPrograms == input.LoyaltyPrograms ||
                    this.LoyaltyPrograms.Equals(input.LoyaltyPrograms)
                ) && 
                (
                    this.LiveLoyaltyPrograms == input.LiveLoyaltyPrograms ||
                    this.LiveLoyaltyPrograms.Equals(input.LiveLoyaltyPrograms)
                ) && 
                (
                    this.LastUpdatedAt == input.LastUpdatedAt ||
                    (this.LastUpdatedAt != null &&
                    this.LastUpdatedAt.Equals(input.LastUpdatedAt))
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
                hashCode = hashCode * 59 + this.Applications.GetHashCode();
                hashCode = hashCode * 59 + this.LiveApplications.GetHashCode();
                hashCode = hashCode * 59 + this.SandboxApplications.GetHashCode();
                hashCode = hashCode * 59 + this.Campaigns.GetHashCode();
                hashCode = hashCode * 59 + this.ActiveCampaigns.GetHashCode();
                hashCode = hashCode * 59 + this.LiveActiveCampaigns.GetHashCode();
                hashCode = hashCode * 59 + this.Coupons.GetHashCode();
                hashCode = hashCode * 59 + this.ActiveCoupons.GetHashCode();
                hashCode = hashCode * 59 + this.ExpiredCoupons.GetHashCode();
                hashCode = hashCode * 59 + this.ReferralCodes.GetHashCode();
                hashCode = hashCode * 59 + this.ActiveReferralCodes.GetHashCode();
                hashCode = hashCode * 59 + this.ExpiredReferralCodes.GetHashCode();
                hashCode = hashCode * 59 + this.ActiveRules.GetHashCode();
                hashCode = hashCode * 59 + this.Users.GetHashCode();
                hashCode = hashCode * 59 + this.Roles.GetHashCode();
                hashCode = hashCode * 59 + this.CustomAttributes.GetHashCode();
                hashCode = hashCode * 59 + this.Webhooks.GetHashCode();
                hashCode = hashCode * 59 + this.LoyaltyPrograms.GetHashCode();
                hashCode = hashCode * 59 + this.LiveLoyaltyPrograms.GetHashCode();
                if (this.LastUpdatedAt != null)
                    hashCode = hashCode * 59 + this.LastUpdatedAt.GetHashCode();
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
