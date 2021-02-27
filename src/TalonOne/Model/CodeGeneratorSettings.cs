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
    /// CodeGeneratorSettings
    /// </summary>
    [DataContract]
    public partial class CodeGeneratorSettings :  IEquatable<CodeGeneratorSettings>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="CodeGeneratorSettings" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected CodeGeneratorSettings() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="CodeGeneratorSettings" /> class.
        /// </summary>
        /// <param name="validCharacters">Set of characters to be used when generating random part of code. Defaults to [A-Z, 0-9] (in terms of RegExp). (required).</param>
        /// <param name="couponPattern">The pattern that will be used to generate coupon codes. The character &#x60;#&#x60; acts as a placeholder and will be replaced by a random character from the &#x60;validCharacters&#x60; set.  (required).</param>
        public CodeGeneratorSettings(List<string> validCharacters = default(List<string>), string couponPattern = default(string))
        {
            // to ensure "validCharacters" is required (not null)
            if (validCharacters == null)
            {
                throw new InvalidDataException("validCharacters is a required property for CodeGeneratorSettings and cannot be null");
            }
            else
            {
                this.ValidCharacters = validCharacters;
            }
            
            // to ensure "couponPattern" is required (not null)
            if (couponPattern == null)
            {
                throw new InvalidDataException("couponPattern is a required property for CodeGeneratorSettings and cannot be null");
            }
            else
            {
                this.CouponPattern = couponPattern;
            }
            
        }
        
        /// <summary>
        /// Set of characters to be used when generating random part of code. Defaults to [A-Z, 0-9] (in terms of RegExp).
        /// </summary>
        /// <value>Set of characters to be used when generating random part of code. Defaults to [A-Z, 0-9] (in terms of RegExp).</value>
        [DataMember(Name="validCharacters", EmitDefaultValue=true)]
        public List<string> ValidCharacters { get; set; }

        /// <summary>
        /// The pattern that will be used to generate coupon codes. The character &#x60;#&#x60; acts as a placeholder and will be replaced by a random character from the &#x60;validCharacters&#x60; set. 
        /// </summary>
        /// <value>The pattern that will be used to generate coupon codes. The character &#x60;#&#x60; acts as a placeholder and will be replaced by a random character from the &#x60;validCharacters&#x60; set. </value>
        [DataMember(Name="couponPattern", EmitDefaultValue=true)]
        public string CouponPattern { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class CodeGeneratorSettings {\n");
            sb.Append("  ValidCharacters: ").Append(ValidCharacters).Append("\n");
            sb.Append("  CouponPattern: ").Append(CouponPattern).Append("\n");
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
            return this.Equals(input as CodeGeneratorSettings);
        }

        /// <summary>
        /// Returns true if CodeGeneratorSettings instances are equal
        /// </summary>
        /// <param name="input">Instance of CodeGeneratorSettings to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(CodeGeneratorSettings input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.ValidCharacters == input.ValidCharacters ||
                    this.ValidCharacters != null &&
                    input.ValidCharacters != null &&
                    this.ValidCharacters.SequenceEqual(input.ValidCharacters)
                ) && 
                (
                    this.CouponPattern == input.CouponPattern ||
                    (this.CouponPattern != null &&
                    this.CouponPattern.Equals(input.CouponPattern))
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
                if (this.ValidCharacters != null)
                    hashCode = hashCode * 59 + this.ValidCharacters.GetHashCode();
                if (this.CouponPattern != null)
                    hashCode = hashCode * 59 + this.CouponPattern.GetHashCode();
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
            // CouponPattern (string) maxLength
            if(this.CouponPattern != null && this.CouponPattern.Length > 100)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for CouponPattern, length must be less than 100.", new [] { "CouponPattern" });
            }

            // CouponPattern (string) minLength
            if(this.CouponPattern != null && this.CouponPattern.Length < 3)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for CouponPattern, length must be greater than 3.", new [] { "CouponPattern" });
            }
            
            yield break;
        }
    }

}
