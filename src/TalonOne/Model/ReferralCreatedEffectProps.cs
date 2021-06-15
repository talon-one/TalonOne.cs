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
    /// The properties specific to the \&quot;referralCreated\&quot; effect. This gets triggered whenever a validated rule contained a \&quot;create referral\&quot; effect, and a referral code was created for a customer. See \&quot;createdReferrals\&quot; on the response for all details of this referral code.
    /// </summary>
    [DataContract]
    public partial class ReferralCreatedEffectProps :  IEquatable<ReferralCreatedEffectProps>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ReferralCreatedEffectProps" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected ReferralCreatedEffectProps() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="ReferralCreatedEffectProps" /> class.
        /// </summary>
        /// <param name="value">The referral code that was created (required).</param>
        public ReferralCreatedEffectProps(string value = default(string))
        {
            // to ensure "value" is required (not null)
            this.Value = value ?? throw new ArgumentNullException("value is a required property for ReferralCreatedEffectProps and cannot be null");
        }
        
        /// <summary>
        /// The referral code that was created
        /// </summary>
        /// <value>The referral code that was created</value>
        [DataMember(Name="value", EmitDefaultValue=false)]
        public string Value { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ReferralCreatedEffectProps {\n");
            sb.Append("  Value: ").Append(Value).Append("\n");
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
            return this.Equals(input as ReferralCreatedEffectProps);
        }

        /// <summary>
        /// Returns true if ReferralCreatedEffectProps instances are equal
        /// </summary>
        /// <param name="input">Instance of ReferralCreatedEffectProps to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(ReferralCreatedEffectProps input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.Value == input.Value ||
                    (this.Value != null &&
                    this.Value.Equals(input.Value))
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
                if (this.Value != null)
                    hashCode = hashCode * 59 + this.Value.GetHashCode();
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
