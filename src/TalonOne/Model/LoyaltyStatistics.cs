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
        /// <param name="totalActivePoints">Total of active points for this loyalty program (required).</param>
        /// <param name="totalPendingPoints">Total of pending points for this loyalty program (required).</param>
        /// <param name="totalSpentPoints">Total of spent points for this loyalty program (required).</param>
        /// <param name="totalExpiredPoints">Total of expired points for this loyalty program (required).</param>
        public LoyaltyStatistics(decimal totalActivePoints = default(decimal), decimal totalPendingPoints = default(decimal), decimal totalSpentPoints = default(decimal), decimal totalExpiredPoints = default(decimal))
        {
            // to ensure "totalActivePoints" is required (not null)
            if (totalActivePoints == null)
            {
                throw new InvalidDataException("totalActivePoints is a required property for LoyaltyStatistics and cannot be null");
            }
            else
            {
                this.TotalActivePoints = totalActivePoints;
            }
            
            // to ensure "totalPendingPoints" is required (not null)
            if (totalPendingPoints == null)
            {
                throw new InvalidDataException("totalPendingPoints is a required property for LoyaltyStatistics and cannot be null");
            }
            else
            {
                this.TotalPendingPoints = totalPendingPoints;
            }
            
            // to ensure "totalSpentPoints" is required (not null)
            if (totalSpentPoints == null)
            {
                throw new InvalidDataException("totalSpentPoints is a required property for LoyaltyStatistics and cannot be null");
            }
            else
            {
                this.TotalSpentPoints = totalSpentPoints;
            }
            
            // to ensure "totalExpiredPoints" is required (not null)
            if (totalExpiredPoints == null)
            {
                throw new InvalidDataException("totalExpiredPoints is a required property for LoyaltyStatistics and cannot be null");
            }
            else
            {
                this.TotalExpiredPoints = totalExpiredPoints;
            }
            
        }
        
        /// <summary>
        /// Total of active points for this loyalty program
        /// </summary>
        /// <value>Total of active points for this loyalty program</value>
        [DataMember(Name="totalActivePoints", EmitDefaultValue=false)]
        public decimal TotalActivePoints { get; set; }

        /// <summary>
        /// Total of pending points for this loyalty program
        /// </summary>
        /// <value>Total of pending points for this loyalty program</value>
        [DataMember(Name="totalPendingPoints", EmitDefaultValue=false)]
        public decimal TotalPendingPoints { get; set; }

        /// <summary>
        /// Total of spent points for this loyalty program
        /// </summary>
        /// <value>Total of spent points for this loyalty program</value>
        [DataMember(Name="totalSpentPoints", EmitDefaultValue=false)]
        public decimal TotalSpentPoints { get; set; }

        /// <summary>
        /// Total of expired points for this loyalty program
        /// </summary>
        /// <value>Total of expired points for this loyalty program</value>
        [DataMember(Name="totalExpiredPoints", EmitDefaultValue=false)]
        public decimal TotalExpiredPoints { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class LoyaltyStatistics {\n");
            sb.Append("  TotalActivePoints: ").Append(TotalActivePoints).Append("\n");
            sb.Append("  TotalPendingPoints: ").Append(TotalPendingPoints).Append("\n");
            sb.Append("  TotalSpentPoints: ").Append(TotalSpentPoints).Append("\n");
            sb.Append("  TotalExpiredPoints: ").Append(TotalExpiredPoints).Append("\n");
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
                    this.TotalActivePoints == input.TotalActivePoints ||
                    (this.TotalActivePoints != null &&
                    this.TotalActivePoints.Equals(input.TotalActivePoints))
                ) && 
                (
                    this.TotalPendingPoints == input.TotalPendingPoints ||
                    (this.TotalPendingPoints != null &&
                    this.TotalPendingPoints.Equals(input.TotalPendingPoints))
                ) && 
                (
                    this.TotalSpentPoints == input.TotalSpentPoints ||
                    (this.TotalSpentPoints != null &&
                    this.TotalSpentPoints.Equals(input.TotalSpentPoints))
                ) && 
                (
                    this.TotalExpiredPoints == input.TotalExpiredPoints ||
                    (this.TotalExpiredPoints != null &&
                    this.TotalExpiredPoints.Equals(input.TotalExpiredPoints))
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
                if (this.TotalActivePoints != null)
                    hashCode = hashCode * 59 + this.TotalActivePoints.GetHashCode();
                if (this.TotalPendingPoints != null)
                    hashCode = hashCode * 59 + this.TotalPendingPoints.GetHashCode();
                if (this.TotalSpentPoints != null)
                    hashCode = hashCode * 59 + this.TotalSpentPoints.GetHashCode();
                if (this.TotalExpiredPoints != null)
                    hashCode = hashCode * 59 + this.TotalExpiredPoints.GetHashCode();
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
