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
    /// InlineResponse20012
    /// </summary>
    [DataContract]
    public partial class InlineResponse20012 :  IEquatable<InlineResponse20012>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="InlineResponse20012" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected InlineResponse20012() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="InlineResponse20012" /> class.
        /// </summary>
        /// <param name="totalResultSize">totalResultSize.</param>
        /// <param name="hasMore">hasMore.</param>
        /// <param name="data">data (required).</param>
        public InlineResponse20012(int totalResultSize = default(int), bool hasMore = default(bool), List<ApplicationCustomer> data = default(List<ApplicationCustomer>))
        {
            // to ensure "data" is required (not null)
            if (data == null)
            {
                throw new InvalidDataException("data is a required property for InlineResponse20012 and cannot be null");
            }
            else
            {
                this.Data = data;
            }
            
            this.TotalResultSize = totalResultSize;
            this.HasMore = hasMore;
        }
        
        /// <summary>
        /// Gets or Sets TotalResultSize
        /// </summary>
        [DataMember(Name="totalResultSize", EmitDefaultValue=false)]
        public int TotalResultSize { get; set; }

        /// <summary>
        /// Gets or Sets HasMore
        /// </summary>
        [DataMember(Name="hasMore", EmitDefaultValue=false)]
        public bool HasMore { get; set; }

        /// <summary>
        /// Gets or Sets Data
        /// </summary>
        [DataMember(Name="data", EmitDefaultValue=false)]
        public List<ApplicationCustomer> Data { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class InlineResponse20012 {\n");
            sb.Append("  TotalResultSize: ").Append(TotalResultSize).Append("\n");
            sb.Append("  HasMore: ").Append(HasMore).Append("\n");
            sb.Append("  Data: ").Append(Data).Append("\n");
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
            return this.Equals(input as InlineResponse20012);
        }

        /// <summary>
        /// Returns true if InlineResponse20012 instances are equal
        /// </summary>
        /// <param name="input">Instance of InlineResponse20012 to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(InlineResponse20012 input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.TotalResultSize == input.TotalResultSize ||
                    (this.TotalResultSize != null &&
                    this.TotalResultSize.Equals(input.TotalResultSize))
                ) && 
                (
                    this.HasMore == input.HasMore ||
                    (this.HasMore != null &&
                    this.HasMore.Equals(input.HasMore))
                ) && 
                (
                    this.Data == input.Data ||
                    this.Data != null &&
                    input.Data != null &&
                    this.Data.SequenceEqual(input.Data)
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
                if (this.TotalResultSize != null)
                    hashCode = hashCode * 59 + this.TotalResultSize.GetHashCode();
                if (this.HasMore != null)
                    hashCode = hashCode * 59 + this.HasMore.GetHashCode();
                if (this.Data != null)
                    hashCode = hashCode * 59 + this.Data.GetHashCode();
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
