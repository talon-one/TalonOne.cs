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
    /// CreateApplicationAPIKey
    /// </summary>
    [DataContract]
    public partial class CreateApplicationAPIKey :  IEquatable<CreateApplicationAPIKey>, IValidatableObject
    {
        /// <summary>
        /// Platform the API key is valid for.
        /// </summary>
        /// <value>Platform the API key is valid for.</value>
        [JsonConverter(typeof(StringEnumConverter))]
        public enum PlatformEnum
        {
            /// <summary>
            /// Enum None for value: none
            /// </summary>
            [EnumMember(Value = "none")]
            None = 1,

            /// <summary>
            /// Enum Segment for value: segment
            /// </summary>
            [EnumMember(Value = "segment")]
            Segment = 2,

            /// <summary>
            /// Enum Braze for value: braze
            /// </summary>
            [EnumMember(Value = "braze")]
            Braze = 3,

            /// <summary>
            /// Enum Mparticle for value: mparticle
            /// </summary>
            [EnumMember(Value = "mparticle")]
            Mparticle = 4

        }

        /// <summary>
        /// Platform the API key is valid for.
        /// </summary>
        /// <value>Platform the API key is valid for.</value>
        [DataMember(Name="platform", EmitDefaultValue=false)]
        public PlatformEnum? Platform { get; set; }
        /// <summary>
        /// Initializes a new instance of the <see cref="CreateApplicationAPIKey" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected CreateApplicationAPIKey() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="CreateApplicationAPIKey" /> class.
        /// </summary>
        /// <param name="title">Title for API Key (required).</param>
        /// <param name="expires">The date the API key expired (required).</param>
        /// <param name="platform">Platform the API key is valid for..</param>
        public CreateApplicationAPIKey(string title = default(string), DateTime expires = default(DateTime), PlatformEnum? platform = default(PlatformEnum?))
        {
            // to ensure "title" is required (not null)
            if (title == null)
            {
                throw new InvalidDataException("title is a required property for CreateApplicationAPIKey and cannot be null");
            }
            else
            {
                this.Title = title;
            }
            
            // to ensure "expires" is required (not null)
            if (expires == null)
            {
                throw new InvalidDataException("expires is a required property for CreateApplicationAPIKey and cannot be null");
            }
            else
            {
                this.Expires = expires;
            }
            
            this.Platform = platform;
        }
        
        /// <summary>
        /// Title for API Key
        /// </summary>
        /// <value>Title for API Key</value>
        [DataMember(Name="title", EmitDefaultValue=false)]
        public string Title { get; set; }

        /// <summary>
        /// The date the API key expired
        /// </summary>
        /// <value>The date the API key expired</value>
        [DataMember(Name="expires", EmitDefaultValue=false)]
        public DateTime Expires { get; set; }


        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class CreateApplicationAPIKey {\n");
            sb.Append("  Title: ").Append(Title).Append("\n");
            sb.Append("  Expires: ").Append(Expires).Append("\n");
            sb.Append("  Platform: ").Append(Platform).Append("\n");
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
            return this.Equals(input as CreateApplicationAPIKey);
        }

        /// <summary>
        /// Returns true if CreateApplicationAPIKey instances are equal
        /// </summary>
        /// <param name="input">Instance of CreateApplicationAPIKey to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(CreateApplicationAPIKey input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.Title == input.Title ||
                    (this.Title != null &&
                    this.Title.Equals(input.Title))
                ) && 
                (
                    this.Expires == input.Expires ||
                    (this.Expires != null &&
                    this.Expires.Equals(input.Expires))
                ) && 
                (
                    this.Platform == input.Platform ||
                    (this.Platform != null &&
                    this.Platform.Equals(input.Platform))
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
                if (this.Title != null)
                    hashCode = hashCode * 59 + this.Title.GetHashCode();
                if (this.Expires != null)
                    hashCode = hashCode * 59 + this.Expires.GetHashCode();
                if (this.Platform != null)
                    hashCode = hashCode * 59 + this.Platform.GetHashCode();
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
