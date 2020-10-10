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
    /// The balance in a Loyalty Program for some Customer.
    /// </summary>
    [DataContract]
    public partial class LoyaltyProgramBalance :  IEquatable<LoyaltyProgramBalance>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="LoyaltyProgramBalance" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected LoyaltyProgramBalance() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="LoyaltyProgramBalance" /> class.
        /// </summary>
        /// <param name="currentBalance">currentBalance (required).</param>
        public LoyaltyProgramBalance(decimal currentBalance = default(decimal))
        {
            // to ensure "currentBalance" is required (not null)
            if (currentBalance == null)
            {
                throw new InvalidDataException("currentBalance is a required property for LoyaltyProgramBalance and cannot be null");
            }
            else
            {
                this.CurrentBalance = currentBalance;
            }
            
        }
        
        /// <summary>
        /// Gets or Sets CurrentBalance
        /// </summary>
        [DataMember(Name="currentBalance", EmitDefaultValue=true)]
        public decimal CurrentBalance { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class LoyaltyProgramBalance {\n");
            sb.Append("  CurrentBalance: ").Append(CurrentBalance).Append("\n");
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
            return this.Equals(input as LoyaltyProgramBalance);
        }

        /// <summary>
        /// Returns true if LoyaltyProgramBalance instances are equal
        /// </summary>
        /// <param name="input">Instance of LoyaltyProgramBalance to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(LoyaltyProgramBalance input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.CurrentBalance == input.CurrentBalance ||
                    (this.CurrentBalance != null &&
                    this.CurrentBalance.Equals(input.CurrentBalance))
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
                if (this.CurrentBalance != null)
                    hashCode = hashCode * 59 + this.CurrentBalance.GetHashCode();
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
