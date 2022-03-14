/* 
 * Talon.One API
 *
 * Use the Talon.One API to integrate with your application and to manage applications and campaigns:  - Use the operations in the [Integration API section](#integration-api) are used to integrate with our platform - Use the operation in the [Management API section](#management-api) to manage applications and campaigns.  ## Determining the base URL of the endpoints  The API is available at the same hostname as your Campaign Manager deployment. For example, if you are reading this page at `https://mycompany.talon.one/docs/api/`, the URL for the [updateCustomerSession](https://docs.talon.one/integration-api/#operation/updateCustomerSessionV2) endpoint is `https://mycompany.talon.one/v2/customer_sessions/{Id}` 
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
    /// LoyaltyStatistics
    /// </summary>
    [DataContract]
    public partial class LoyaltyStatistics :  IEquatable<LoyaltyStatistics>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="LoyaltyStatistics" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected LoyaltyStatistics() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="LoyaltyStatistics" /> class.
        /// </summary>
        /// <param name="date">Date at which data point was collected. (required).</param>
        /// <param name="totalActivePoints">Total of active points for this loyalty program. (required).</param>
        /// <param name="totalPendingPoints">Total of pending points for this loyalty program. (required).</param>
        /// <param name="totalSpentPoints">Total of spent points for this loyalty program. (required).</param>
        /// <param name="totalExpiredPoints">Total of expired points for this loyalty program. (required).</param>
        /// <param name="totalMembers">Number of loyalty program members. (required).</param>
        /// <param name="newMembers">Number of members who joined on this day. (required).</param>
        /// <param name="spentPoints">spentPoints (required).</param>
        /// <param name="earnedPoints">earnedPoints (required).</param>
        public LoyaltyStatistics(DateTime date = default(DateTime), decimal totalActivePoints = default(decimal), decimal totalPendingPoints = default(decimal), decimal totalSpentPoints = default(decimal), decimal totalExpiredPoints = default(decimal), decimal totalMembers = default(decimal), decimal newMembers = default(decimal), LoyaltyDashboardPointsBreakdown spentPoints = default(LoyaltyDashboardPointsBreakdown), LoyaltyDashboardPointsBreakdown earnedPoints = default(LoyaltyDashboardPointsBreakdown))
        {
            this.Date = date;
            this.TotalActivePoints = totalActivePoints;
            this.TotalPendingPoints = totalPendingPoints;
            this.TotalSpentPoints = totalSpentPoints;
            this.TotalExpiredPoints = totalExpiredPoints;
            this.TotalMembers = totalMembers;
            this.NewMembers = newMembers;
            // to ensure "spentPoints" is required (not null)
            this.SpentPoints = spentPoints ?? throw new ArgumentNullException("spentPoints is a required property for LoyaltyStatistics and cannot be null");
            // to ensure "earnedPoints" is required (not null)
            this.EarnedPoints = earnedPoints ?? throw new ArgumentNullException("earnedPoints is a required property for LoyaltyStatistics and cannot be null");
        }
        
        /// <summary>
        /// Date at which data point was collected.
        /// </summary>
        /// <value>Date at which data point was collected.</value>
        [DataMember(Name="date", EmitDefaultValue=false)]
        public DateTime Date { get; set; }

        /// <summary>
        /// Total of active points for this loyalty program.
        /// </summary>
        /// <value>Total of active points for this loyalty program.</value>
        [DataMember(Name="totalActivePoints", EmitDefaultValue=false)]
        public decimal TotalActivePoints { get; set; }

        /// <summary>
        /// Total of pending points for this loyalty program.
        /// </summary>
        /// <value>Total of pending points for this loyalty program.</value>
        [DataMember(Name="totalPendingPoints", EmitDefaultValue=false)]
        public decimal TotalPendingPoints { get; set; }

        /// <summary>
        /// Total of spent points for this loyalty program.
        /// </summary>
        /// <value>Total of spent points for this loyalty program.</value>
        [DataMember(Name="totalSpentPoints", EmitDefaultValue=false)]
        public decimal TotalSpentPoints { get; set; }

        /// <summary>
        /// Total of expired points for this loyalty program.
        /// </summary>
        /// <value>Total of expired points for this loyalty program.</value>
        [DataMember(Name="totalExpiredPoints", EmitDefaultValue=false)]
        public decimal TotalExpiredPoints { get; set; }

        /// <summary>
        /// Number of loyalty program members.
        /// </summary>
        /// <value>Number of loyalty program members.</value>
        [DataMember(Name="totalMembers", EmitDefaultValue=false)]
        public decimal TotalMembers { get; set; }

        /// <summary>
        /// Number of members who joined on this day.
        /// </summary>
        /// <value>Number of members who joined on this day.</value>
        [DataMember(Name="newMembers", EmitDefaultValue=false)]
        public decimal NewMembers { get; set; }

        /// <summary>
        /// Gets or Sets SpentPoints
        /// </summary>
        [DataMember(Name="spentPoints", EmitDefaultValue=false)]
        public LoyaltyDashboardPointsBreakdown SpentPoints { get; set; }

        /// <summary>
        /// Gets or Sets EarnedPoints
        /// </summary>
        [DataMember(Name="earnedPoints", EmitDefaultValue=false)]
        public LoyaltyDashboardPointsBreakdown EarnedPoints { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class LoyaltyStatistics {\n");
            sb.Append("  Date: ").Append(Date).Append("\n");
            sb.Append("  TotalActivePoints: ").Append(TotalActivePoints).Append("\n");
            sb.Append("  TotalPendingPoints: ").Append(TotalPendingPoints).Append("\n");
            sb.Append("  TotalSpentPoints: ").Append(TotalSpentPoints).Append("\n");
            sb.Append("  TotalExpiredPoints: ").Append(TotalExpiredPoints).Append("\n");
            sb.Append("  TotalMembers: ").Append(TotalMembers).Append("\n");
            sb.Append("  NewMembers: ").Append(NewMembers).Append("\n");
            sb.Append("  SpentPoints: ").Append(SpentPoints).Append("\n");
            sb.Append("  EarnedPoints: ").Append(EarnedPoints).Append("\n");
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
            return this.Equals(input as LoyaltyStatistics);
        }

        /// <summary>
        /// Returns true if LoyaltyStatistics instances are equal
        /// </summary>
        /// <param name="input">Instance of LoyaltyStatistics to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(LoyaltyStatistics input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.Date == input.Date ||
                    (this.Date != null &&
                    this.Date.Equals(input.Date))
                ) && 
                (
                    this.TotalActivePoints == input.TotalActivePoints ||
                    this.TotalActivePoints.Equals(input.TotalActivePoints)
                ) && 
                (
                    this.TotalPendingPoints == input.TotalPendingPoints ||
                    this.TotalPendingPoints.Equals(input.TotalPendingPoints)
                ) && 
                (
                    this.TotalSpentPoints == input.TotalSpentPoints ||
                    this.TotalSpentPoints.Equals(input.TotalSpentPoints)
                ) && 
                (
                    this.TotalExpiredPoints == input.TotalExpiredPoints ||
                    this.TotalExpiredPoints.Equals(input.TotalExpiredPoints)
                ) && 
                (
                    this.TotalMembers == input.TotalMembers ||
                    this.TotalMembers.Equals(input.TotalMembers)
                ) && 
                (
                    this.NewMembers == input.NewMembers ||
                    this.NewMembers.Equals(input.NewMembers)
                ) && 
                (
                    this.SpentPoints == input.SpentPoints ||
                    (this.SpentPoints != null &&
                    this.SpentPoints.Equals(input.SpentPoints))
                ) && 
                (
                    this.EarnedPoints == input.EarnedPoints ||
                    (this.EarnedPoints != null &&
                    this.EarnedPoints.Equals(input.EarnedPoints))
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
                if (this.Date != null)
                    hashCode = hashCode * 59 + this.Date.GetHashCode();
                hashCode = hashCode * 59 + this.TotalActivePoints.GetHashCode();
                hashCode = hashCode * 59 + this.TotalPendingPoints.GetHashCode();
                hashCode = hashCode * 59 + this.TotalSpentPoints.GetHashCode();
                hashCode = hashCode * 59 + this.TotalExpiredPoints.GetHashCode();
                hashCode = hashCode * 59 + this.TotalMembers.GetHashCode();
                hashCode = hashCode * 59 + this.NewMembers.GetHashCode();
                if (this.SpentPoints != null)
                    hashCode = hashCode * 59 + this.SpentPoints.GetHashCode();
                if (this.EarnedPoints != null)
                    hashCode = hashCode * 59 + this.EarnedPoints.GetHashCode();
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
