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
    /// Points to deduct.
    /// </summary>
    [DataContract]
    public partial class DeductLoyaltyPoints :  IEquatable<DeductLoyaltyPoints>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="DeductLoyaltyPoints" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected DeductLoyaltyPoints() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="DeductLoyaltyPoints" /> class.
        /// </summary>
        /// <param name="points">Amount of loyalty points. (required).</param>
        /// <param name="name">Name / reason for the point deduction..</param>
        /// <param name="subledgerId">ID of the subledger the points are deducted from..</param>
        /// <param name="applicationId">ID of the Application that is connected to the loyalty program..</param>
        public DeductLoyaltyPoints(decimal points = default(decimal), string name = default(string), string subledgerId = default(string), int applicationId = default(int))
        {
            this.Points = points;
            this.Name = name;
            this.SubledgerId = subledgerId;
            this.ApplicationId = applicationId;
        }
        
        /// <summary>
        /// Amount of loyalty points.
        /// </summary>
        /// <value>Amount of loyalty points.</value>
        [DataMember(Name="points", EmitDefaultValue=false)]
        public decimal Points { get; set; }

        /// <summary>
        /// Name / reason for the point deduction.
        /// </summary>
        /// <value>Name / reason for the point deduction.</value>
        [DataMember(Name="name", EmitDefaultValue=false)]
        public string Name { get; set; }

        /// <summary>
        /// ID of the subledger the points are deducted from.
        /// </summary>
        /// <value>ID of the subledger the points are deducted from.</value>
        [DataMember(Name="subledgerId", EmitDefaultValue=false)]
        public string SubledgerId { get; set; }

        /// <summary>
        /// ID of the Application that is connected to the loyalty program.
        /// </summary>
        /// <value>ID of the Application that is connected to the loyalty program.</value>
        [DataMember(Name="applicationId", EmitDefaultValue=false)]
        public int ApplicationId { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class DeductLoyaltyPoints {\n");
            sb.Append("  Points: ").Append(Points).Append("\n");
            sb.Append("  Name: ").Append(Name).Append("\n");
            sb.Append("  SubledgerId: ").Append(SubledgerId).Append("\n");
            sb.Append("  ApplicationId: ").Append(ApplicationId).Append("\n");
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
            return this.Equals(input as DeductLoyaltyPoints);
        }

        /// <summary>
        /// Returns true if DeductLoyaltyPoints instances are equal
        /// </summary>
        /// <param name="input">Instance of DeductLoyaltyPoints to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(DeductLoyaltyPoints input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.Points == input.Points ||
                    this.Points.Equals(input.Points)
                ) && 
                (
                    this.Name == input.Name ||
                    (this.Name != null &&
                    this.Name.Equals(input.Name))
                ) && 
                (
                    this.SubledgerId == input.SubledgerId ||
                    (this.SubledgerId != null &&
                    this.SubledgerId.Equals(input.SubledgerId))
                ) && 
                (
                    this.ApplicationId == input.ApplicationId ||
                    this.ApplicationId.Equals(input.ApplicationId)
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
                hashCode = hashCode * 59 + this.Points.GetHashCode();
                if (this.Name != null)
                    hashCode = hashCode * 59 + this.Name.GetHashCode();
                if (this.SubledgerId != null)
                    hashCode = hashCode * 59 + this.SubledgerId.GetHashCode();
                hashCode = hashCode * 59 + this.ApplicationId.GetHashCode();
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
            // Points (decimal) maximum
            if(this.Points > (decimal)999999999999.99)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for Points, must be a value less than or equal to 999999999999.99.", new [] { "Points" });
            }

            // Points (decimal) minimum
            if(this.Points < (decimal)0)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for Points, must be a value greater than or equal to 0.", new [] { "Points" });
            }

            yield break;
        }
    }

}
