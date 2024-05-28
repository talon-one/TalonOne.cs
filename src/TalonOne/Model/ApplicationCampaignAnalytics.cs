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
    /// ApplicationCampaignAnalytics
    /// </summary>
    [DataContract]
    public partial class ApplicationCampaignAnalytics :  IEquatable<ApplicationCampaignAnalytics>, IValidatableObject
    {
        /// <summary>
        /// The state of the campaign.  **Note:** A disabled or archived campaign is not evaluated for rules or coupons. 
        /// </summary>
        /// <value>The state of the campaign.  **Note:** A disabled or archived campaign is not evaluated for rules or coupons. </value>
        [JsonConverter(typeof(StringEnumConverter))]
        public enum CampaignStateEnum
        {
            /// <summary>
            /// Enum Enabled for value: enabled
            /// </summary>
            [EnumMember(Value = "enabled")]
            Enabled = 1,

            /// <summary>
            /// Enum Disabled for value: disabled
            /// </summary>
            [EnumMember(Value = "disabled")]
            Disabled = 2,

            /// <summary>
            /// Enum Archived for value: archived
            /// </summary>
            [EnumMember(Value = "archived")]
            Archived = 3

        }

        /// <summary>
        /// The state of the campaign.  **Note:** A disabled or archived campaign is not evaluated for rules or coupons. 
        /// </summary>
        /// <value>The state of the campaign.  **Note:** A disabled or archived campaign is not evaluated for rules or coupons. </value>
        [DataMember(Name="campaignState", EmitDefaultValue=false)]
        public CampaignStateEnum? CampaignState { get; set; }
        /// <summary>
        /// Initializes a new instance of the <see cref="ApplicationCampaignAnalytics" /> class.
        /// </summary>
        /// <param name="startTime">The start of the aggregation time frame in UTC..</param>
        /// <param name="endTime">The end of the aggregation time frame in UTC..</param>
        /// <param name="campaignId">The ID of the campaign..</param>
        /// <param name="campaignName">The name of the campaign..</param>
        /// <param name="campaignTags">A list of tags for the campaign..</param>
        /// <param name="campaignState">The state of the campaign.  **Note:** A disabled or archived campaign is not evaluated for rules or coupons.  (default to CampaignStateEnum.Enabled).</param>
        /// <param name="campaignActiveRulesetId">The [ID of the ruleset](https://docs.talon.one/management-api#operation/getRulesets) this campaign applies on customer session evaluation. .</param>
        /// <param name="campaignStartTime">Date and time when the campaign becomes active..</param>
        /// <param name="campaignEndTime">Date and time when the campaign becomes inactive..</param>
        /// <param name="totalRevenue">totalRevenue.</param>
        /// <param name="sessionsCount">sessionsCount.</param>
        /// <param name="avgItemsPerSession">avgItemsPerSession.</param>
        /// <param name="avgSessionValue">avgSessionValue.</param>
        /// <param name="totalDiscounts">totalDiscounts.</param>
        /// <param name="couponsCount">couponsCount.</param>
        public ApplicationCampaignAnalytics(DateTime startTime = default(DateTime), DateTime endTime = default(DateTime), int campaignId = default(int), string campaignName = default(string), List<string> campaignTags = default(List<string>), CampaignStateEnum? campaignState = CampaignStateEnum.Enabled, int campaignActiveRulesetId = default(int), DateTime campaignStartTime = default(DateTime), DateTime campaignEndTime = default(DateTime), ApplicationCampaignAnalyticsTotalRevenue totalRevenue = default(ApplicationCampaignAnalyticsTotalRevenue), ApplicationCampaignAnalyticsSessionsCount sessionsCount = default(ApplicationCampaignAnalyticsSessionsCount), ApplicationCampaignAnalyticsAvgItemsPerSession avgItemsPerSession = default(ApplicationCampaignAnalyticsAvgItemsPerSession), ApplicationCampaignAnalyticsAvgSessionValue avgSessionValue = default(ApplicationCampaignAnalyticsAvgSessionValue), ApplicationCampaignAnalyticsTotalDiscounts totalDiscounts = default(ApplicationCampaignAnalyticsTotalDiscounts), ApplicationCampaignAnalyticsCouponsCount couponsCount = default(ApplicationCampaignAnalyticsCouponsCount))
        {
            this.StartTime = startTime;
            this.EndTime = endTime;
            this.CampaignId = campaignId;
            this.CampaignName = campaignName;
            this.CampaignTags = campaignTags;
            this.CampaignState = campaignState;
            this.CampaignActiveRulesetId = campaignActiveRulesetId;
            this.CampaignStartTime = campaignStartTime;
            this.CampaignEndTime = campaignEndTime;
            this.TotalRevenue = totalRevenue;
            this.SessionsCount = sessionsCount;
            this.AvgItemsPerSession = avgItemsPerSession;
            this.AvgSessionValue = avgSessionValue;
            this.TotalDiscounts = totalDiscounts;
            this.CouponsCount = couponsCount;
        }
        
        /// <summary>
        /// The start of the aggregation time frame in UTC.
        /// </summary>
        /// <value>The start of the aggregation time frame in UTC.</value>
        [DataMember(Name="startTime", EmitDefaultValue=false)]
        public DateTime StartTime { get; set; }

        /// <summary>
        /// The end of the aggregation time frame in UTC.
        /// </summary>
        /// <value>The end of the aggregation time frame in UTC.</value>
        [DataMember(Name="endTime", EmitDefaultValue=false)]
        public DateTime EndTime { get; set; }

        /// <summary>
        /// The ID of the campaign.
        /// </summary>
        /// <value>The ID of the campaign.</value>
        [DataMember(Name="campaignId", EmitDefaultValue=false)]
        public int CampaignId { get; set; }

        /// <summary>
        /// The name of the campaign.
        /// </summary>
        /// <value>The name of the campaign.</value>
        [DataMember(Name="campaignName", EmitDefaultValue=false)]
        public string CampaignName { get; set; }

        /// <summary>
        /// A list of tags for the campaign.
        /// </summary>
        /// <value>A list of tags for the campaign.</value>
        [DataMember(Name="campaignTags", EmitDefaultValue=false)]
        public List<string> CampaignTags { get; set; }

        /// <summary>
        /// The [ID of the ruleset](https://docs.talon.one/management-api#operation/getRulesets) this campaign applies on customer session evaluation. 
        /// </summary>
        /// <value>The [ID of the ruleset](https://docs.talon.one/management-api#operation/getRulesets) this campaign applies on customer session evaluation. </value>
        [DataMember(Name="campaignActiveRulesetId", EmitDefaultValue=false)]
        public int CampaignActiveRulesetId { get; set; }

        /// <summary>
        /// Date and time when the campaign becomes active.
        /// </summary>
        /// <value>Date and time when the campaign becomes active.</value>
        [DataMember(Name="campaignStartTime", EmitDefaultValue=false)]
        public DateTime CampaignStartTime { get; set; }

        /// <summary>
        /// Date and time when the campaign becomes inactive.
        /// </summary>
        /// <value>Date and time when the campaign becomes inactive.</value>
        [DataMember(Name="campaignEndTime", EmitDefaultValue=false)]
        public DateTime CampaignEndTime { get; set; }

        /// <summary>
        /// Gets or Sets TotalRevenue
        /// </summary>
        [DataMember(Name="totalRevenue", EmitDefaultValue=false)]
        public ApplicationCampaignAnalyticsTotalRevenue TotalRevenue { get; set; }

        /// <summary>
        /// Gets or Sets SessionsCount
        /// </summary>
        [DataMember(Name="sessionsCount", EmitDefaultValue=false)]
        public ApplicationCampaignAnalyticsSessionsCount SessionsCount { get; set; }

        /// <summary>
        /// Gets or Sets AvgItemsPerSession
        /// </summary>
        [DataMember(Name="avgItemsPerSession", EmitDefaultValue=false)]
        public ApplicationCampaignAnalyticsAvgItemsPerSession AvgItemsPerSession { get; set; }

        /// <summary>
        /// Gets or Sets AvgSessionValue
        /// </summary>
        [DataMember(Name="avgSessionValue", EmitDefaultValue=false)]
        public ApplicationCampaignAnalyticsAvgSessionValue AvgSessionValue { get; set; }

        /// <summary>
        /// Gets or Sets TotalDiscounts
        /// </summary>
        [DataMember(Name="totalDiscounts", EmitDefaultValue=false)]
        public ApplicationCampaignAnalyticsTotalDiscounts TotalDiscounts { get; set; }

        /// <summary>
        /// Gets or Sets CouponsCount
        /// </summary>
        [DataMember(Name="couponsCount", EmitDefaultValue=false)]
        public ApplicationCampaignAnalyticsCouponsCount CouponsCount { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ApplicationCampaignAnalytics {\n");
            sb.Append("  StartTime: ").Append(StartTime).Append("\n");
            sb.Append("  EndTime: ").Append(EndTime).Append("\n");
            sb.Append("  CampaignId: ").Append(CampaignId).Append("\n");
            sb.Append("  CampaignName: ").Append(CampaignName).Append("\n");
            sb.Append("  CampaignTags: ").Append(CampaignTags).Append("\n");
            sb.Append("  CampaignState: ").Append(CampaignState).Append("\n");
            sb.Append("  CampaignActiveRulesetId: ").Append(CampaignActiveRulesetId).Append("\n");
            sb.Append("  CampaignStartTime: ").Append(CampaignStartTime).Append("\n");
            sb.Append("  CampaignEndTime: ").Append(CampaignEndTime).Append("\n");
            sb.Append("  TotalRevenue: ").Append(TotalRevenue).Append("\n");
            sb.Append("  SessionsCount: ").Append(SessionsCount).Append("\n");
            sb.Append("  AvgItemsPerSession: ").Append(AvgItemsPerSession).Append("\n");
            sb.Append("  AvgSessionValue: ").Append(AvgSessionValue).Append("\n");
            sb.Append("  TotalDiscounts: ").Append(TotalDiscounts).Append("\n");
            sb.Append("  CouponsCount: ").Append(CouponsCount).Append("\n");
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
            return this.Equals(input as ApplicationCampaignAnalytics);
        }

        /// <summary>
        /// Returns true if ApplicationCampaignAnalytics instances are equal
        /// </summary>
        /// <param name="input">Instance of ApplicationCampaignAnalytics to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(ApplicationCampaignAnalytics input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.StartTime == input.StartTime ||
                    (this.StartTime != null &&
                    this.StartTime.Equals(input.StartTime))
                ) && 
                (
                    this.EndTime == input.EndTime ||
                    (this.EndTime != null &&
                    this.EndTime.Equals(input.EndTime))
                ) && 
                (
                    this.CampaignId == input.CampaignId ||
                    this.CampaignId.Equals(input.CampaignId)
                ) && 
                (
                    this.CampaignName == input.CampaignName ||
                    (this.CampaignName != null &&
                    this.CampaignName.Equals(input.CampaignName))
                ) && 
                (
                    this.CampaignTags == input.CampaignTags ||
                    this.CampaignTags != null &&
                    input.CampaignTags != null &&
                    this.CampaignTags.SequenceEqual(input.CampaignTags)
                ) && 
                (
                    this.CampaignState == input.CampaignState ||
                    this.CampaignState.Equals(input.CampaignState)
                ) && 
                (
                    this.CampaignActiveRulesetId == input.CampaignActiveRulesetId ||
                    this.CampaignActiveRulesetId.Equals(input.CampaignActiveRulesetId)
                ) && 
                (
                    this.CampaignStartTime == input.CampaignStartTime ||
                    (this.CampaignStartTime != null &&
                    this.CampaignStartTime.Equals(input.CampaignStartTime))
                ) && 
                (
                    this.CampaignEndTime == input.CampaignEndTime ||
                    (this.CampaignEndTime != null &&
                    this.CampaignEndTime.Equals(input.CampaignEndTime))
                ) && 
                (
                    this.TotalRevenue == input.TotalRevenue ||
                    (this.TotalRevenue != null &&
                    this.TotalRevenue.Equals(input.TotalRevenue))
                ) && 
                (
                    this.SessionsCount == input.SessionsCount ||
                    (this.SessionsCount != null &&
                    this.SessionsCount.Equals(input.SessionsCount))
                ) && 
                (
                    this.AvgItemsPerSession == input.AvgItemsPerSession ||
                    (this.AvgItemsPerSession != null &&
                    this.AvgItemsPerSession.Equals(input.AvgItemsPerSession))
                ) && 
                (
                    this.AvgSessionValue == input.AvgSessionValue ||
                    (this.AvgSessionValue != null &&
                    this.AvgSessionValue.Equals(input.AvgSessionValue))
                ) && 
                (
                    this.TotalDiscounts == input.TotalDiscounts ||
                    (this.TotalDiscounts != null &&
                    this.TotalDiscounts.Equals(input.TotalDiscounts))
                ) && 
                (
                    this.CouponsCount == input.CouponsCount ||
                    (this.CouponsCount != null &&
                    this.CouponsCount.Equals(input.CouponsCount))
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
                if (this.StartTime != null)
                    hashCode = hashCode * 59 + this.StartTime.GetHashCode();
                if (this.EndTime != null)
                    hashCode = hashCode * 59 + this.EndTime.GetHashCode();
                hashCode = hashCode * 59 + this.CampaignId.GetHashCode();
                if (this.CampaignName != null)
                    hashCode = hashCode * 59 + this.CampaignName.GetHashCode();
                if (this.CampaignTags != null)
                    hashCode = hashCode * 59 + this.CampaignTags.GetHashCode();
                hashCode = hashCode * 59 + this.CampaignState.GetHashCode();
                hashCode = hashCode * 59 + this.CampaignActiveRulesetId.GetHashCode();
                if (this.CampaignStartTime != null)
                    hashCode = hashCode * 59 + this.CampaignStartTime.GetHashCode();
                if (this.CampaignEndTime != null)
                    hashCode = hashCode * 59 + this.CampaignEndTime.GetHashCode();
                if (this.TotalRevenue != null)
                    hashCode = hashCode * 59 + this.TotalRevenue.GetHashCode();
                if (this.SessionsCount != null)
                    hashCode = hashCode * 59 + this.SessionsCount.GetHashCode();
                if (this.AvgItemsPerSession != null)
                    hashCode = hashCode * 59 + this.AvgItemsPerSession.GetHashCode();
                if (this.AvgSessionValue != null)
                    hashCode = hashCode * 59 + this.AvgSessionValue.GetHashCode();
                if (this.TotalDiscounts != null)
                    hashCode = hashCode * 59 + this.TotalDiscounts.GetHashCode();
                if (this.CouponsCount != null)
                    hashCode = hashCode * 59 + this.CouponsCount.GetHashCode();
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
