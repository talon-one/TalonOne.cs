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
    /// List of customer profiles linked to the loyalty card.
    /// </summary>
    [DataContract]
    public partial class LoyaltyCardBalances :  IEquatable<LoyaltyCardBalances>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="LoyaltyCardBalances" /> class.
        /// </summary>
        /// <param name="balance">balance.</param>
        /// <param name="subledgerBalances">Map of the loyalty balances of the subledgers of a ledger..</param>
        /// <param name="profiles">Customer profiles linked to the loyalty card..</param>
        public LoyaltyCardBalances(LoyaltyBalance balance = default(LoyaltyBalance), Dictionary<string, LoyaltyBalance> subledgerBalances = default(Dictionary<string, LoyaltyBalance>), List<LoyaltyCardProfileRegistration> profiles = default(List<LoyaltyCardProfileRegistration>))
        {
            this.Balance = balance;
            this.SubledgerBalances = subledgerBalances;
            this.Profiles = profiles;
        }
        
        /// <summary>
        /// Gets or Sets Balance
        /// </summary>
        [DataMember(Name="balance", EmitDefaultValue=false)]
        public LoyaltyBalance Balance { get; set; }

        /// <summary>
        /// Map of the loyalty balances of the subledgers of a ledger.
        /// </summary>
        /// <value>Map of the loyalty balances of the subledgers of a ledger.</value>
        [DataMember(Name="subledgerBalances", EmitDefaultValue=false)]
        public Dictionary<string, LoyaltyBalance> SubledgerBalances { get; set; }

        /// <summary>
        /// Customer profiles linked to the loyalty card.
        /// </summary>
        /// <value>Customer profiles linked to the loyalty card.</value>
        [DataMember(Name="profiles", EmitDefaultValue=false)]
        public List<LoyaltyCardProfileRegistration> Profiles { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class LoyaltyCardBalances {\n");
            sb.Append("  Balance: ").Append(Balance).Append("\n");
            sb.Append("  SubledgerBalances: ").Append(SubledgerBalances).Append("\n");
            sb.Append("  Profiles: ").Append(Profiles).Append("\n");
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
            return this.Equals(input as LoyaltyCardBalances);
        }

        /// <summary>
        /// Returns true if LoyaltyCardBalances instances are equal
        /// </summary>
        /// <param name="input">Instance of LoyaltyCardBalances to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(LoyaltyCardBalances input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.Balance == input.Balance ||
                    (this.Balance != null &&
                    this.Balance.Equals(input.Balance))
                ) && 
                (
                    this.SubledgerBalances == input.SubledgerBalances ||
                    this.SubledgerBalances != null &&
                    input.SubledgerBalances != null &&
                    this.SubledgerBalances.SequenceEqual(input.SubledgerBalances)
                ) && 
                (
                    this.Profiles == input.Profiles ||
                    this.Profiles != null &&
                    input.Profiles != null &&
                    this.Profiles.SequenceEqual(input.Profiles)
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
                if (this.Balance != null)
                    hashCode = hashCode * 59 + this.Balance.GetHashCode();
                if (this.SubledgerBalances != null)
                    hashCode = hashCode * 59 + this.SubledgerBalances.GetHashCode();
                if (this.Profiles != null)
                    hashCode = hashCode * 59 + this.Profiles.GetHashCode();
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
