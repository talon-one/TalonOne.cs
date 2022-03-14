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
    /// Group of all loyalty points expected in the future.
    /// </summary>
    [DataContract]
    public partial class LoyaltyProjection :  IEquatable<LoyaltyProjection>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="LoyaltyProjection" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected LoyaltyProjection() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="LoyaltyProjection" /> class.
        /// </summary>
        /// <param name="projections">projections.</param>
        /// <param name="totalExpiringPoints">Sum of points to be expired by the projection date set in the query parameter. (required).</param>
        /// <param name="totalActivatingPoints">Sum of points to be active by the projection date set in the query parameter. (required).</param>
        public LoyaltyProjection(List<LoyaltyProjectionData> projections = default(List<LoyaltyProjectionData>), decimal totalExpiringPoints = default(decimal), decimal totalActivatingPoints = default(decimal))
        {
            this.TotalExpiringPoints = totalExpiringPoints;
            this.TotalActivatingPoints = totalActivatingPoints;
            this.Projections = projections;
        }
        
        /// <summary>
        /// Gets or Sets Projections
        /// </summary>
        [DataMember(Name="projections", EmitDefaultValue=false)]
        public List<LoyaltyProjectionData> Projections { get; set; }

        /// <summary>
        /// Sum of points to be expired by the projection date set in the query parameter.
        /// </summary>
        /// <value>Sum of points to be expired by the projection date set in the query parameter.</value>
        [DataMember(Name="totalExpiringPoints", EmitDefaultValue=false)]
        public decimal TotalExpiringPoints { get; set; }

        /// <summary>
        /// Sum of points to be active by the projection date set in the query parameter.
        /// </summary>
        /// <value>Sum of points to be active by the projection date set in the query parameter.</value>
        [DataMember(Name="totalActivatingPoints", EmitDefaultValue=false)]
        public decimal TotalActivatingPoints { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class LoyaltyProjection {\n");
            sb.Append("  Projections: ").Append(Projections).Append("\n");
            sb.Append("  TotalExpiringPoints: ").Append(TotalExpiringPoints).Append("\n");
            sb.Append("  TotalActivatingPoints: ").Append(TotalActivatingPoints).Append("\n");
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
            return this.Equals(input as LoyaltyProjection);
        }

        /// <summary>
        /// Returns true if LoyaltyProjection instances are equal
        /// </summary>
        /// <param name="input">Instance of LoyaltyProjection to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(LoyaltyProjection input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.Projections == input.Projections ||
                    this.Projections != null &&
                    input.Projections != null &&
                    this.Projections.SequenceEqual(input.Projections)
                ) && 
                (
                    this.TotalExpiringPoints == input.TotalExpiringPoints ||
                    this.TotalExpiringPoints.Equals(input.TotalExpiringPoints)
                ) && 
                (
                    this.TotalActivatingPoints == input.TotalActivatingPoints ||
                    this.TotalActivatingPoints.Equals(input.TotalActivatingPoints)
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
                if (this.Projections != null)
                    hashCode = hashCode * 59 + this.Projections.GetHashCode();
                hashCode = hashCode * 59 + this.TotalExpiringPoints.GetHashCode();
                hashCode = hashCode * 59 + this.TotalActivatingPoints.GetHashCode();
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