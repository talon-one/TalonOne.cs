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
    /// LoyaltyBalanceWithTier
    /// </summary>
    [DataContract]
    public partial class LoyaltyBalanceWithTier :  IEquatable<LoyaltyBalanceWithTier>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="LoyaltyBalanceWithTier" /> class.
        /// </summary>
        /// <param name="activePoints">Total amount of points awarded to this customer and available to spend..</param>
        /// <param name="pendingPoints">Total amount of points awarded to this customer but not available until their start date..</param>
        /// <param name="spentPoints">Total amount of points already spent by this customer..</param>
        /// <param name="expiredPoints">Total amount of points awarded but never redeemed. They cannot be used anymore..</param>
        /// <param name="currentTier">currentTier.</param>
        /// <param name="projectedTier">projectedTier.</param>
        /// <param name="pointsToNextTier">The number of points required to move up a tier..</param>
        /// <param name="nextTierName">The name of the tier consecutive to the current tier..</param>
        public LoyaltyBalanceWithTier(decimal activePoints = default(decimal), decimal pendingPoints = default(decimal), decimal spentPoints = default(decimal), decimal expiredPoints = default(decimal), Tier currentTier = default(Tier), ProjectedTier projectedTier = default(ProjectedTier), decimal pointsToNextTier = default(decimal), string nextTierName = default(string))
        {
            this.ActivePoints = activePoints;
            this.PendingPoints = pendingPoints;
            this.SpentPoints = spentPoints;
            this.ExpiredPoints = expiredPoints;
            this.CurrentTier = currentTier;
            this.ProjectedTier = projectedTier;
            this.PointsToNextTier = pointsToNextTier;
            this.NextTierName = nextTierName;
        }
        
        /// <summary>
        /// Total amount of points awarded to this customer and available to spend.
        /// </summary>
        /// <value>Total amount of points awarded to this customer and available to spend.</value>
        [DataMember(Name="activePoints", EmitDefaultValue=false)]
        public decimal ActivePoints { get; set; }

        /// <summary>
        /// Total amount of points awarded to this customer but not available until their start date.
        /// </summary>
        /// <value>Total amount of points awarded to this customer but not available until their start date.</value>
        [DataMember(Name="pendingPoints", EmitDefaultValue=false)]
        public decimal PendingPoints { get; set; }

        /// <summary>
        /// Total amount of points already spent by this customer.
        /// </summary>
        /// <value>Total amount of points already spent by this customer.</value>
        [DataMember(Name="spentPoints", EmitDefaultValue=false)]
        public decimal SpentPoints { get; set; }

        /// <summary>
        /// Total amount of points awarded but never redeemed. They cannot be used anymore.
        /// </summary>
        /// <value>Total amount of points awarded but never redeemed. They cannot be used anymore.</value>
        [DataMember(Name="expiredPoints", EmitDefaultValue=false)]
        public decimal ExpiredPoints { get; set; }

        /// <summary>
        /// Gets or Sets CurrentTier
        /// </summary>
        [DataMember(Name="currentTier", EmitDefaultValue=false)]
        public Tier CurrentTier { get; set; }

        /// <summary>
        /// Gets or Sets ProjectedTier
        /// </summary>
        [DataMember(Name="projectedTier", EmitDefaultValue=false)]
        public ProjectedTier ProjectedTier { get; set; }

        /// <summary>
        /// The number of points required to move up a tier.
        /// </summary>
        /// <value>The number of points required to move up a tier.</value>
        [DataMember(Name="pointsToNextTier", EmitDefaultValue=false)]
        public decimal PointsToNextTier { get; set; }

        /// <summary>
        /// The name of the tier consecutive to the current tier.
        /// </summary>
        /// <value>The name of the tier consecutive to the current tier.</value>
        [DataMember(Name="nextTierName", EmitDefaultValue=false)]
        public string NextTierName { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class LoyaltyBalanceWithTier {\n");
            sb.Append("  ActivePoints: ").Append(ActivePoints).Append("\n");
            sb.Append("  PendingPoints: ").Append(PendingPoints).Append("\n");
            sb.Append("  SpentPoints: ").Append(SpentPoints).Append("\n");
            sb.Append("  ExpiredPoints: ").Append(ExpiredPoints).Append("\n");
            sb.Append("  CurrentTier: ").Append(CurrentTier).Append("\n");
            sb.Append("  ProjectedTier: ").Append(ProjectedTier).Append("\n");
            sb.Append("  PointsToNextTier: ").Append(PointsToNextTier).Append("\n");
            sb.Append("  NextTierName: ").Append(NextTierName).Append("\n");
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
            return this.Equals(input as LoyaltyBalanceWithTier);
        }

        /// <summary>
        /// Returns true if LoyaltyBalanceWithTier instances are equal
        /// </summary>
        /// <param name="input">Instance of LoyaltyBalanceWithTier to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(LoyaltyBalanceWithTier input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.ActivePoints == input.ActivePoints ||
                    this.ActivePoints.Equals(input.ActivePoints)
                ) && 
                (
                    this.PendingPoints == input.PendingPoints ||
                    this.PendingPoints.Equals(input.PendingPoints)
                ) && 
                (
                    this.SpentPoints == input.SpentPoints ||
                    this.SpentPoints.Equals(input.SpentPoints)
                ) && 
                (
                    this.ExpiredPoints == input.ExpiredPoints ||
                    this.ExpiredPoints.Equals(input.ExpiredPoints)
                ) && 
                (
                    this.CurrentTier == input.CurrentTier ||
                    (this.CurrentTier != null &&
                    this.CurrentTier.Equals(input.CurrentTier))
                ) && 
                (
                    this.ProjectedTier == input.ProjectedTier ||
                    (this.ProjectedTier != null &&
                    this.ProjectedTier.Equals(input.ProjectedTier))
                ) && 
                (
                    this.PointsToNextTier == input.PointsToNextTier ||
                    this.PointsToNextTier.Equals(input.PointsToNextTier)
                ) && 
                (
                    this.NextTierName == input.NextTierName ||
                    (this.NextTierName != null &&
                    this.NextTierName.Equals(input.NextTierName))
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
                hashCode = hashCode * 59 + this.ActivePoints.GetHashCode();
                hashCode = hashCode * 59 + this.PendingPoints.GetHashCode();
                hashCode = hashCode * 59 + this.SpentPoints.GetHashCode();
                hashCode = hashCode * 59 + this.ExpiredPoints.GetHashCode();
                if (this.CurrentTier != null)
                    hashCode = hashCode * 59 + this.CurrentTier.GetHashCode();
                if (this.ProjectedTier != null)
                    hashCode = hashCode * 59 + this.ProjectedTier.GetHashCode();
                hashCode = hashCode * 59 + this.PointsToNextTier.GetHashCode();
                if (this.NextTierName != null)
                    hashCode = hashCode * 59 + this.NextTierName.GetHashCode();
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