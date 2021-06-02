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
    /// A tier in a loyalty program
    /// </summary>
    [DataContract]
    public partial class NewLoyaltyTier :  IEquatable<NewLoyaltyTier>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="NewLoyaltyTier" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected NewLoyaltyTier() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="NewLoyaltyTier" /> class.
        /// </summary>
        /// <param name="name">The name of the tier (required).</param>
        /// <param name="minPoints">The minimum amount of points required to be eligible for the tier (required).</param>
        public NewLoyaltyTier(string name = default(string), decimal minPoints = default(decimal))
        {
            // to ensure "name" is required (not null)
            if (name == null)
            {
                throw new InvalidDataException("name is a required property for NewLoyaltyTier and cannot be null");
            }
            else
            {
                this.Name = name;
            }
            
            // to ensure "minPoints" is required (not null)
            if (minPoints == null)
            {
                throw new InvalidDataException("minPoints is a required property for NewLoyaltyTier and cannot be null");
            }
            else
            {
                this.MinPoints = minPoints;
            }
            
        }
        
        /// <summary>
        /// The name of the tier
        /// </summary>
        /// <value>The name of the tier</value>
        [DataMember(Name="name", EmitDefaultValue=true)]
        public string Name { get; set; }

        /// <summary>
        /// The minimum amount of points required to be eligible for the tier
        /// </summary>
        /// <value>The minimum amount of points required to be eligible for the tier</value>
        [DataMember(Name="minPoints", EmitDefaultValue=true)]
        public decimal MinPoints { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class NewLoyaltyTier {\n");
            sb.Append("  Name: ").Append(Name).Append("\n");
            sb.Append("  MinPoints: ").Append(MinPoints).Append("\n");
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
            return this.Equals(input as NewLoyaltyTier);
        }

        /// <summary>
        /// Returns true if NewLoyaltyTier instances are equal
        /// </summary>
        /// <param name="input">Instance of NewLoyaltyTier to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(NewLoyaltyTier input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.Name == input.Name ||
                    (this.Name != null &&
                    this.Name.Equals(input.Name))
                ) && 
                (
                    this.MinPoints == input.MinPoints ||
                    (this.MinPoints != null &&
                    this.MinPoints.Equals(input.MinPoints))
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
                if (this.Name != null)
                    hashCode = hashCode * 59 + this.Name.GetHashCode();
                if (this.MinPoints != null)
                    hashCode = hashCode * 59 + this.MinPoints.GetHashCode();
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

            
            // MinPoints (decimal) maximum
            if(this.MinPoints > (decimal)1E+8)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for MinPoints, must be a value less than or equal to 1E+8.", new [] { "MinPoints" });
            }

            // MinPoints (decimal) minimum
            if(this.MinPoints < (decimal)0)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for MinPoints, must be a value greater than or equal to 0.", new [] { "MinPoints" });
            }

            yield break;
        }
    }

}
