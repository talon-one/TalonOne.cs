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
    /// AnalyticsProductSKU
    /// </summary>
    [DataContract]
    public partial class AnalyticsProductSKU :  IEquatable<AnalyticsProductSKU>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="AnalyticsProductSKU" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected AnalyticsProductSKU() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="AnalyticsProductSKU" /> class.
        /// </summary>
        /// <param name="id">The ID of the SKU linked to the analytics-level product. (required).</param>
        /// <param name="sku">The SKU linked to the analytics-level product. (required).</param>
        /// <param name="lastUpdated">Values in UTC for the date the SKU linked to the analytics-level product was last updated. (required).</param>
        public AnalyticsProductSKU(int id = default(int), string sku = default(string), DateTime lastUpdated = default(DateTime))
        {
            this.Id = id;
            // to ensure "sku" is required (not null)
            this.Sku = sku ?? throw new ArgumentNullException("sku is a required property for AnalyticsProductSKU and cannot be null");
            this.LastUpdated = lastUpdated;
        }
        
        /// <summary>
        /// The ID of the SKU linked to the analytics-level product.
        /// </summary>
        /// <value>The ID of the SKU linked to the analytics-level product.</value>
        [DataMember(Name="id", EmitDefaultValue=false)]
        public int Id { get; set; }

        /// <summary>
        /// The SKU linked to the analytics-level product.
        /// </summary>
        /// <value>The SKU linked to the analytics-level product.</value>
        [DataMember(Name="sku", EmitDefaultValue=false)]
        public string Sku { get; set; }

        /// <summary>
        /// Values in UTC for the date the SKU linked to the analytics-level product was last updated.
        /// </summary>
        /// <value>Values in UTC for the date the SKU linked to the analytics-level product was last updated.</value>
        [DataMember(Name="lastUpdated", EmitDefaultValue=false)]
        public DateTime LastUpdated { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class AnalyticsProductSKU {\n");
            sb.Append("  Id: ").Append(Id).Append("\n");
            sb.Append("  Sku: ").Append(Sku).Append("\n");
            sb.Append("  LastUpdated: ").Append(LastUpdated).Append("\n");
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
            return this.Equals(input as AnalyticsProductSKU);
        }

        /// <summary>
        /// Returns true if AnalyticsProductSKU instances are equal
        /// </summary>
        /// <param name="input">Instance of AnalyticsProductSKU to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(AnalyticsProductSKU input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.Id == input.Id ||
                    this.Id.Equals(input.Id)
                ) && 
                (
                    this.Sku == input.Sku ||
                    (this.Sku != null &&
                    this.Sku.Equals(input.Sku))
                ) && 
                (
                    this.LastUpdated == input.LastUpdated ||
                    (this.LastUpdated != null &&
                    this.LastUpdated.Equals(input.LastUpdated))
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
                hashCode = hashCode * 59 + this.Id.GetHashCode();
                if (this.Sku != null)
                    hashCode = hashCode * 59 + this.Sku.GetHashCode();
                if (this.LastUpdated != null)
                    hashCode = hashCode * 59 + this.LastUpdated.GetHashCode();
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
