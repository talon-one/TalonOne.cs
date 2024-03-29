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
    /// CampaignPrioritiesV2
    /// </summary>
    [DataContract]
    public partial class CampaignPrioritiesV2 :  IEquatable<CampaignPrioritiesV2>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="CampaignPrioritiesV2" /> class.
        /// </summary>
        /// <param name="exclusive">exclusive.</param>
        /// <param name="stackable">stackable.</param>
        /// <param name="universal">universal.</param>
        public CampaignPrioritiesV2(List<CampaignSetIDs> exclusive = default(List<CampaignSetIDs>), List<CampaignSetIDs> stackable = default(List<CampaignSetIDs>), List<CampaignSetIDs> universal = default(List<CampaignSetIDs>))
        {
            this.Exclusive = exclusive;
            this.Stackable = stackable;
            this.Universal = universal;
        }
        
        /// <summary>
        /// Gets or Sets Exclusive
        /// </summary>
        [DataMember(Name="exclusive", EmitDefaultValue=false)]
        public List<CampaignSetIDs> Exclusive { get; set; }

        /// <summary>
        /// Gets or Sets Stackable
        /// </summary>
        [DataMember(Name="stackable", EmitDefaultValue=false)]
        public List<CampaignSetIDs> Stackable { get; set; }

        /// <summary>
        /// Gets or Sets Universal
        /// </summary>
        [DataMember(Name="universal", EmitDefaultValue=false)]
        public List<CampaignSetIDs> Universal { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class CampaignPrioritiesV2 {\n");
            sb.Append("  Exclusive: ").Append(Exclusive).Append("\n");
            sb.Append("  Stackable: ").Append(Stackable).Append("\n");
            sb.Append("  Universal: ").Append(Universal).Append("\n");
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
            return this.Equals(input as CampaignPrioritiesV2);
        }

        /// <summary>
        /// Returns true if CampaignPrioritiesV2 instances are equal
        /// </summary>
        /// <param name="input">Instance of CampaignPrioritiesV2 to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(CampaignPrioritiesV2 input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.Exclusive == input.Exclusive ||
                    this.Exclusive != null &&
                    input.Exclusive != null &&
                    this.Exclusive.SequenceEqual(input.Exclusive)
                ) && 
                (
                    this.Stackable == input.Stackable ||
                    this.Stackable != null &&
                    input.Stackable != null &&
                    this.Stackable.SequenceEqual(input.Stackable)
                ) && 
                (
                    this.Universal == input.Universal ||
                    this.Universal != null &&
                    input.Universal != null &&
                    this.Universal.SequenceEqual(input.Universal)
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
                if (this.Exclusive != null)
                    hashCode = hashCode * 59 + this.Exclusive.GetHashCode();
                if (this.Stackable != null)
                    hashCode = hashCode * 59 + this.Stackable.GetHashCode();
                if (this.Universal != null)
                    hashCode = hashCode * 59 + this.Universal.GetHashCode();
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
