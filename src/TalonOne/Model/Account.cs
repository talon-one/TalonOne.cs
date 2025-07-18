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
    /// Account
    /// </summary>
    [DataContract]
    public partial class Account :  IEquatable<Account>, IValidatableObject
    {
        /// <summary>
        /// State of the account (active, deactivated).
        /// </summary>
        /// <value>State of the account (active, deactivated).</value>
        [JsonConverter(typeof(StringEnumConverter))]
        public enum StateEnum
        {
            /// <summary>
            /// Enum Active for value: active
            /// </summary>
            [EnumMember(Value = "active")]
            Active = 1,

            /// <summary>
            /// Enum Deactivated for value: deactivated
            /// </summary>
            [EnumMember(Value = "deactivated")]
            Deactivated = 2

        }

        /// <summary>
        /// State of the account (active, deactivated).
        /// </summary>
        /// <value>State of the account (active, deactivated).</value>
        [DataMember(Name="state", EmitDefaultValue=false)]
        public StateEnum State { get; set; }
        /// <summary>
        /// Initializes a new instance of the <see cref="Account" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected Account() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="Account" /> class.
        /// </summary>
        /// <param name="id">The internal ID of this entity. (required).</param>
        /// <param name="created">The time this entity was created. (required).</param>
        /// <param name="modified">The time this entity was last modified. (required).</param>
        /// <param name="companyName">companyName (required).</param>
        /// <param name="domainName">Subdomain Name for yourcompany.talon.one. (required).</param>
        /// <param name="state">State of the account (active, deactivated). (required).</param>
        /// <param name="billingEmail">The billing email address associated with your company account. (required).</param>
        /// <param name="planName">The name of your booked plan..</param>
        /// <param name="planExpires">The point in time at which your current plan expires..</param>
        /// <param name="applicationLimit">The maximum number of Applications covered by your plan..</param>
        /// <param name="userLimit">The maximum number of Campaign Manager Users covered by your plan..</param>
        /// <param name="campaignLimit">The maximum number of Campaigns covered by your plan..</param>
        /// <param name="apiLimit">The maximum number of Integration API calls covered by your plan per billing period..</param>
        /// <param name="applicationCount">The current number of Applications in your account. (required).</param>
        /// <param name="userCount">The current number of Campaign Manager Users in your account. (required).</param>
        /// <param name="campaignsActiveCount">The current number of active Campaigns in your account. (required).</param>
        /// <param name="campaignsInactiveCount">The current number of inactive Campaigns in your account. (required).</param>
        /// <param name="attributes">Arbitrary properties associated with this campaign..</param>
        public Account(int id = default(int), DateTime created = default(DateTime), DateTime modified = default(DateTime), string companyName = default(string), string domainName = default(string), StateEnum state = default(StateEnum), string billingEmail = default(string), string planName = default(string), DateTime planExpires = default(DateTime), int applicationLimit = default(int), int userLimit = default(int), int campaignLimit = default(int), int apiLimit = default(int), int applicationCount = default(int), int userCount = default(int), int campaignsActiveCount = default(int), int campaignsInactiveCount = default(int), Object attributes = default(Object))
        {
            this.Id = id;
            this.Created = created;
            this.Modified = modified;
            // to ensure "companyName" is required (not null)
            this.CompanyName = companyName ?? throw new ArgumentNullException("companyName is a required property for Account and cannot be null");
            // to ensure "domainName" is required (not null)
            this.DomainName = domainName ?? throw new ArgumentNullException("domainName is a required property for Account and cannot be null");
            this.State = state;
            // to ensure "billingEmail" is required (not null)
            this.BillingEmail = billingEmail ?? throw new ArgumentNullException("billingEmail is a required property for Account and cannot be null");
            this.ApplicationCount = applicationCount;
            this.UserCount = userCount;
            this.CampaignsActiveCount = campaignsActiveCount;
            this.CampaignsInactiveCount = campaignsInactiveCount;
            this.PlanName = planName;
            this.PlanExpires = planExpires;
            this.ApplicationLimit = applicationLimit;
            this.UserLimit = userLimit;
            this.CampaignLimit = campaignLimit;
            this.ApiLimit = apiLimit;
            this.Attributes = attributes;
        }
        
        /// <summary>
        /// The internal ID of this entity.
        /// </summary>
        /// <value>The internal ID of this entity.</value>
        [DataMember(Name="id", EmitDefaultValue=false)]
        public int Id { get; set; }

        /// <summary>
        /// The time this entity was created.
        /// </summary>
        /// <value>The time this entity was created.</value>
        [DataMember(Name="created", EmitDefaultValue=false)]
        public DateTime Created { get; set; }

        /// <summary>
        /// The time this entity was last modified.
        /// </summary>
        /// <value>The time this entity was last modified.</value>
        [DataMember(Name="modified", EmitDefaultValue=false)]
        public DateTime Modified { get; set; }

        /// <summary>
        /// Gets or Sets CompanyName
        /// </summary>
        [DataMember(Name="companyName", EmitDefaultValue=false)]
        public string CompanyName { get; set; }

        /// <summary>
        /// Subdomain Name for yourcompany.talon.one.
        /// </summary>
        /// <value>Subdomain Name for yourcompany.talon.one.</value>
        [DataMember(Name="domainName", EmitDefaultValue=false)]
        public string DomainName { get; set; }

        /// <summary>
        /// The billing email address associated with your company account.
        /// </summary>
        /// <value>The billing email address associated with your company account.</value>
        [DataMember(Name="billingEmail", EmitDefaultValue=false)]
        public string BillingEmail { get; set; }

        /// <summary>
        /// The name of your booked plan.
        /// </summary>
        /// <value>The name of your booked plan.</value>
        [DataMember(Name="planName", EmitDefaultValue=false)]
        public string PlanName { get; set; }

        /// <summary>
        /// The point in time at which your current plan expires.
        /// </summary>
        /// <value>The point in time at which your current plan expires.</value>
        [DataMember(Name="planExpires", EmitDefaultValue=false)]
        public DateTime PlanExpires { get; set; }

        /// <summary>
        /// The maximum number of Applications covered by your plan.
        /// </summary>
        /// <value>The maximum number of Applications covered by your plan.</value>
        [DataMember(Name="applicationLimit", EmitDefaultValue=false)]
        public int ApplicationLimit { get; set; }

        /// <summary>
        /// The maximum number of Campaign Manager Users covered by your plan.
        /// </summary>
        /// <value>The maximum number of Campaign Manager Users covered by your plan.</value>
        [DataMember(Name="userLimit", EmitDefaultValue=false)]
        public int UserLimit { get; set; }

        /// <summary>
        /// The maximum number of Campaigns covered by your plan.
        /// </summary>
        /// <value>The maximum number of Campaigns covered by your plan.</value>
        [DataMember(Name="campaignLimit", EmitDefaultValue=false)]
        public int CampaignLimit { get; set; }

        /// <summary>
        /// The maximum number of Integration API calls covered by your plan per billing period.
        /// </summary>
        /// <value>The maximum number of Integration API calls covered by your plan per billing period.</value>
        [DataMember(Name="apiLimit", EmitDefaultValue=false)]
        public int ApiLimit { get; set; }

        /// <summary>
        /// The current number of Applications in your account.
        /// </summary>
        /// <value>The current number of Applications in your account.</value>
        [DataMember(Name="applicationCount", EmitDefaultValue=false)]
        public int ApplicationCount { get; set; }

        /// <summary>
        /// The current number of Campaign Manager Users in your account.
        /// </summary>
        /// <value>The current number of Campaign Manager Users in your account.</value>
        [DataMember(Name="userCount", EmitDefaultValue=false)]
        public int UserCount { get; set; }

        /// <summary>
        /// The current number of active Campaigns in your account.
        /// </summary>
        /// <value>The current number of active Campaigns in your account.</value>
        [DataMember(Name="campaignsActiveCount", EmitDefaultValue=false)]
        public int CampaignsActiveCount { get; set; }

        /// <summary>
        /// The current number of inactive Campaigns in your account.
        /// </summary>
        /// <value>The current number of inactive Campaigns in your account.</value>
        [DataMember(Name="campaignsInactiveCount", EmitDefaultValue=false)]
        public int CampaignsInactiveCount { get; set; }

        /// <summary>
        /// Arbitrary properties associated with this campaign.
        /// </summary>
        /// <value>Arbitrary properties associated with this campaign.</value>
        [DataMember(Name="attributes", EmitDefaultValue=false)]
        public Object Attributes { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class Account {\n");
            sb.Append("  Id: ").Append(Id).Append("\n");
            sb.Append("  Created: ").Append(Created).Append("\n");
            sb.Append("  Modified: ").Append(Modified).Append("\n");
            sb.Append("  CompanyName: ").Append(CompanyName).Append("\n");
            sb.Append("  DomainName: ").Append(DomainName).Append("\n");
            sb.Append("  State: ").Append(State).Append("\n");
            sb.Append("  BillingEmail: ").Append(BillingEmail).Append("\n");
            sb.Append("  PlanName: ").Append(PlanName).Append("\n");
            sb.Append("  PlanExpires: ").Append(PlanExpires).Append("\n");
            sb.Append("  ApplicationLimit: ").Append(ApplicationLimit).Append("\n");
            sb.Append("  UserLimit: ").Append(UserLimit).Append("\n");
            sb.Append("  CampaignLimit: ").Append(CampaignLimit).Append("\n");
            sb.Append("  ApiLimit: ").Append(ApiLimit).Append("\n");
            sb.Append("  ApplicationCount: ").Append(ApplicationCount).Append("\n");
            sb.Append("  UserCount: ").Append(UserCount).Append("\n");
            sb.Append("  CampaignsActiveCount: ").Append(CampaignsActiveCount).Append("\n");
            sb.Append("  CampaignsInactiveCount: ").Append(CampaignsInactiveCount).Append("\n");
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
            return this.Equals(input as Account);
        }

        /// <summary>
        /// Returns true if Account instances are equal
        /// </summary>
        /// <param name="input">Instance of Account to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(Account input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.Id == input.Id ||
                    this.Id.Equals(input.Id)
                ) && 
                (
                    this.Created == input.Created ||
                    (this.Created != null &&
                    this.Created.Equals(input.Created))
                ) && 
                (
                    this.Modified == input.Modified ||
                    (this.Modified != null &&
                    this.Modified.Equals(input.Modified))
                ) && 
                (
                    this.CompanyName == input.CompanyName ||
                    (this.CompanyName != null &&
                    this.CompanyName.Equals(input.CompanyName))
                ) && 
                (
                    this.DomainName == input.DomainName ||
                    (this.DomainName != null &&
                    this.DomainName.Equals(input.DomainName))
                ) && 
                (
                    this.State == input.State ||
                    this.State.Equals(input.State)
                ) && 
                (
                    this.BillingEmail == input.BillingEmail ||
                    (this.BillingEmail != null &&
                    this.BillingEmail.Equals(input.BillingEmail))
                ) && 
                (
                    this.PlanName == input.PlanName ||
                    (this.PlanName != null &&
                    this.PlanName.Equals(input.PlanName))
                ) && 
                (
                    this.PlanExpires == input.PlanExpires ||
                    (this.PlanExpires != null &&
                    this.PlanExpires.Equals(input.PlanExpires))
                ) && 
                (
                    this.ApplicationLimit == input.ApplicationLimit ||
                    this.ApplicationLimit.Equals(input.ApplicationLimit)
                ) && 
                (
                    this.UserLimit == input.UserLimit ||
                    this.UserLimit.Equals(input.UserLimit)
                ) && 
                (
                    this.CampaignLimit == input.CampaignLimit ||
                    this.CampaignLimit.Equals(input.CampaignLimit)
                ) && 
                (
                    this.ApiLimit == input.ApiLimit ||
                    this.ApiLimit.Equals(input.ApiLimit)
                ) && 
                (
                    this.ApplicationCount == input.ApplicationCount ||
                    this.ApplicationCount.Equals(input.ApplicationCount)
                ) && 
                (
                    this.UserCount == input.UserCount ||
                    this.UserCount.Equals(input.UserCount)
                ) && 
                (
                    this.CampaignsActiveCount == input.CampaignsActiveCount ||
                    this.CampaignsActiveCount.Equals(input.CampaignsActiveCount)
                ) && 
                (
                    this.CampaignsInactiveCount == input.CampaignsInactiveCount ||
                    this.CampaignsInactiveCount.Equals(input.CampaignsInactiveCount)
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
                hashCode = hashCode * 59 + this.Id.GetHashCode();
                if (this.Created != null)
                    hashCode = hashCode * 59 + this.Created.GetHashCode();
                if (this.Modified != null)
                    hashCode = hashCode * 59 + this.Modified.GetHashCode();
                if (this.CompanyName != null)
                    hashCode = hashCode * 59 + this.CompanyName.GetHashCode();
                if (this.DomainName != null)
                    hashCode = hashCode * 59 + this.DomainName.GetHashCode();
                hashCode = hashCode * 59 + this.State.GetHashCode();
                if (this.BillingEmail != null)
                    hashCode = hashCode * 59 + this.BillingEmail.GetHashCode();
                if (this.PlanName != null)
                    hashCode = hashCode * 59 + this.PlanName.GetHashCode();
                if (this.PlanExpires != null)
                    hashCode = hashCode * 59 + this.PlanExpires.GetHashCode();
                hashCode = hashCode * 59 + this.ApplicationLimit.GetHashCode();
                hashCode = hashCode * 59 + this.UserLimit.GetHashCode();
                hashCode = hashCode * 59 + this.CampaignLimit.GetHashCode();
                hashCode = hashCode * 59 + this.ApiLimit.GetHashCode();
                hashCode = hashCode * 59 + this.ApplicationCount.GetHashCode();
                hashCode = hashCode * 59 + this.UserCount.GetHashCode();
                hashCode = hashCode * 59 + this.CampaignsActiveCount.GetHashCode();
                hashCode = hashCode * 59 + this.CampaignsInactiveCount.GetHashCode();
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
            // CompanyName (string) minLength
            if(this.CompanyName != null && this.CompanyName.Length < 1)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for CompanyName, length must be greater than 1.", new [] { "CompanyName" });
            }

            yield break;
        }
    }

}
