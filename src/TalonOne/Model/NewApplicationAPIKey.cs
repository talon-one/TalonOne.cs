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
    /// NewApplicationAPIKey
    /// </summary>
    [DataContract]
    public partial class NewApplicationAPIKey :  IEquatable<NewApplicationAPIKey>, IValidatableObject
    {
        /// <summary>
        /// The third-party platform the API key is valid for. Use &#x60;none&#x60; for a generic API key to be used from your own integration layer. 
        /// </summary>
        /// <value>The third-party platform the API key is valid for. Use &#x60;none&#x60; for a generic API key to be used from your own integration layer. </value>
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
            Mparticle = 4,

            /// <summary>
            /// Enum Shopify for value: shopify
            /// </summary>
            [EnumMember(Value = "shopify")]
            Shopify = 5,

            /// <summary>
            /// Enum Iterable for value: iterable
            /// </summary>
            [EnumMember(Value = "iterable")]
            Iterable = 6,

            /// <summary>
            /// Enum Customerengagement for value: customer_engagement
            /// </summary>
            [EnumMember(Value = "customer_engagement")]
            Customerengagement = 7,

            /// <summary>
            /// Enum Customerdata for value: customer_data
            /// </summary>
            [EnumMember(Value = "customer_data")]
            Customerdata = 8,

            /// <summary>
            /// Enum Salesforce for value: salesforce
            /// </summary>
            [EnumMember(Value = "salesforce")]
            Salesforce = 9,

            /// <summary>
            /// Enum Emarsys for value: emarsys
            /// </summary>
            [EnumMember(Value = "emarsys")]
            Emarsys = 10

        }

        /// <summary>
        /// The third-party platform the API key is valid for. Use &#x60;none&#x60; for a generic API key to be used from your own integration layer. 
        /// </summary>
        /// <value>The third-party platform the API key is valid for. Use &#x60;none&#x60; for a generic API key to be used from your own integration layer. </value>
        [DataMember(Name="platform", EmitDefaultValue=false)]
        public PlatformEnum? Platform { get; set; }
        /// <summary>
        /// The API key type. Can be empty or &#x60;staging&#x60;.  Staging API keys can only be used for dry requests with the [Update customer session](https://docs.talon.one/integration-api#tag/Customer-sessions/operation/updateCustomerSessionV2) endpoint, [Update customer profile](https://docs.talon.one/integration-api#tag/Customer-profiles/operation/updateCustomerProfileV2) endpoint, and [Track event](https://docs.talon.one/integration-api#tag/Events/operation/trackEventV2) endpoint.  When using the _Update customer profile_ endpoint with a staging API key, the query parameter &#x60;runRuleEngine&#x60; must be &#x60;true&#x60;. 
        /// </summary>
        /// <value>The API key type. Can be empty or &#x60;staging&#x60;.  Staging API keys can only be used for dry requests with the [Update customer session](https://docs.talon.one/integration-api#tag/Customer-sessions/operation/updateCustomerSessionV2) endpoint, [Update customer profile](https://docs.talon.one/integration-api#tag/Customer-profiles/operation/updateCustomerProfileV2) endpoint, and [Track event](https://docs.talon.one/integration-api#tag/Events/operation/trackEventV2) endpoint.  When using the _Update customer profile_ endpoint with a staging API key, the query parameter &#x60;runRuleEngine&#x60; must be &#x60;true&#x60;. </value>
        [JsonConverter(typeof(StringEnumConverter))]
        public enum TypeEnum
        {
            /// <summary>
            /// Enum Staging for value: staging
            /// </summary>
            [EnumMember(Value = "staging")]
            Staging = 1

        }

        /// <summary>
        /// The API key type. Can be empty or &#x60;staging&#x60;.  Staging API keys can only be used for dry requests with the [Update customer session](https://docs.talon.one/integration-api#tag/Customer-sessions/operation/updateCustomerSessionV2) endpoint, [Update customer profile](https://docs.talon.one/integration-api#tag/Customer-profiles/operation/updateCustomerProfileV2) endpoint, and [Track event](https://docs.talon.one/integration-api#tag/Events/operation/trackEventV2) endpoint.  When using the _Update customer profile_ endpoint with a staging API key, the query parameter &#x60;runRuleEngine&#x60; must be &#x60;true&#x60;. 
        /// </summary>
        /// <value>The API key type. Can be empty or &#x60;staging&#x60;.  Staging API keys can only be used for dry requests with the [Update customer session](https://docs.talon.one/integration-api#tag/Customer-sessions/operation/updateCustomerSessionV2) endpoint, [Update customer profile](https://docs.talon.one/integration-api#tag/Customer-profiles/operation/updateCustomerProfileV2) endpoint, and [Track event](https://docs.talon.one/integration-api#tag/Events/operation/trackEventV2) endpoint.  When using the _Update customer profile_ endpoint with a staging API key, the query parameter &#x60;runRuleEngine&#x60; must be &#x60;true&#x60;. </value>
        [DataMember(Name="type", EmitDefaultValue=false)]
        public TypeEnum? Type { get; set; }
        /// <summary>
        /// Initializes a new instance of the <see cref="NewApplicationAPIKey" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected NewApplicationAPIKey() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="NewApplicationAPIKey" /> class.
        /// </summary>
        /// <param name="title">Title of the API key. (required).</param>
        /// <param name="expires">The date the API key expires. (required).</param>
        /// <param name="platform">The third-party platform the API key is valid for. Use &#x60;none&#x60; for a generic API key to be used from your own integration layer. .</param>
        /// <param name="type">The API key type. Can be empty or &#x60;staging&#x60;.  Staging API keys can only be used for dry requests with the [Update customer session](https://docs.talon.one/integration-api#tag/Customer-sessions/operation/updateCustomerSessionV2) endpoint, [Update customer profile](https://docs.talon.one/integration-api#tag/Customer-profiles/operation/updateCustomerProfileV2) endpoint, and [Track event](https://docs.talon.one/integration-api#tag/Events/operation/trackEventV2) endpoint.  When using the _Update customer profile_ endpoint with a staging API key, the query parameter &#x60;runRuleEngine&#x60; must be &#x60;true&#x60;. .</param>
        /// <param name="timeOffset">A time offset in nanoseconds associated with the API key. When making a request using the API key, rule evaluation is based on a date that is calculated by adding the offset to the current date. .</param>
        /// <param name="id">ID of the API Key. (required).</param>
        /// <param name="createdBy">ID of user who created. (required).</param>
        /// <param name="accountID">ID of account the key is used for. (required).</param>
        /// <param name="applicationID">ID of application the key is used for. (required).</param>
        /// <param name="created">The date the API key was created. (required).</param>
        /// <param name="key">The API key. (required).</param>
        public NewApplicationAPIKey(string title = default(string), DateTime expires = default(DateTime), PlatformEnum? platform = default(PlatformEnum?), TypeEnum? type = default(TypeEnum?), int timeOffset = default(int), int id = default(int), int createdBy = default(int), int accountID = default(int), int applicationID = default(int), DateTime created = default(DateTime), string key = default(string))
        {
            // to ensure "title" is required (not null)
            this.Title = title ?? throw new ArgumentNullException("title is a required property for NewApplicationAPIKey and cannot be null");
            this.Expires = expires;
            this.Id = id;
            this.CreatedBy = createdBy;
            this.AccountID = accountID;
            this.ApplicationID = applicationID;
            this.Created = created;
            // to ensure "key" is required (not null)
            this.Key = key ?? throw new ArgumentNullException("key is a required property for NewApplicationAPIKey and cannot be null");
            this.Platform = platform;
            this.Type = type;
            this.TimeOffset = timeOffset;
        }
        
        /// <summary>
        /// Title of the API key.
        /// </summary>
        /// <value>Title of the API key.</value>
        [DataMember(Name="title", EmitDefaultValue=false)]
        public string Title { get; set; }

        /// <summary>
        /// The date the API key expires.
        /// </summary>
        /// <value>The date the API key expires.</value>
        [DataMember(Name="expires", EmitDefaultValue=false)]
        public DateTime Expires { get; set; }

        /// <summary>
        /// A time offset in nanoseconds associated with the API key. When making a request using the API key, rule evaluation is based on a date that is calculated by adding the offset to the current date. 
        /// </summary>
        /// <value>A time offset in nanoseconds associated with the API key. When making a request using the API key, rule evaluation is based on a date that is calculated by adding the offset to the current date. </value>
        [DataMember(Name="timeOffset", EmitDefaultValue=false)]
        public int TimeOffset { get; set; }

        /// <summary>
        /// ID of the API Key.
        /// </summary>
        /// <value>ID of the API Key.</value>
        [DataMember(Name="id", EmitDefaultValue=false)]
        public int Id { get; set; }

        /// <summary>
        /// ID of user who created.
        /// </summary>
        /// <value>ID of user who created.</value>
        [DataMember(Name="createdBy", EmitDefaultValue=false)]
        public int CreatedBy { get; set; }

        /// <summary>
        /// ID of account the key is used for.
        /// </summary>
        /// <value>ID of account the key is used for.</value>
        [DataMember(Name="accountID", EmitDefaultValue=false)]
        public int AccountID { get; set; }

        /// <summary>
        /// ID of application the key is used for.
        /// </summary>
        /// <value>ID of application the key is used for.</value>
        [DataMember(Name="applicationID", EmitDefaultValue=false)]
        public int ApplicationID { get; set; }

        /// <summary>
        /// The date the API key was created.
        /// </summary>
        /// <value>The date the API key was created.</value>
        [DataMember(Name="created", EmitDefaultValue=false)]
        public DateTime Created { get; set; }

        /// <summary>
        /// The API key.
        /// </summary>
        /// <value>The API key.</value>
        [DataMember(Name="key", EmitDefaultValue=false)]
        public string Key { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class NewApplicationAPIKey {\n");
            sb.Append("  Title: ").Append(Title).Append("\n");
            sb.Append("  Expires: ").Append(Expires).Append("\n");
            sb.Append("  Platform: ").Append(Platform).Append("\n");
            sb.Append("  Type: ").Append(Type).Append("\n");
            sb.Append("  TimeOffset: ").Append(TimeOffset).Append("\n");
            sb.Append("  Id: ").Append(Id).Append("\n");
            sb.Append("  CreatedBy: ").Append(CreatedBy).Append("\n");
            sb.Append("  AccountID: ").Append(AccountID).Append("\n");
            sb.Append("  ApplicationID: ").Append(ApplicationID).Append("\n");
            sb.Append("  Created: ").Append(Created).Append("\n");
            sb.Append("  Key: ").Append(Key).Append("\n");
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
            return this.Equals(input as NewApplicationAPIKey);
        }

        /// <summary>
        /// Returns true if NewApplicationAPIKey instances are equal
        /// </summary>
        /// <param name="input">Instance of NewApplicationAPIKey to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(NewApplicationAPIKey input)
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
                    this.Platform.Equals(input.Platform)
                ) && 
                (
                    this.Type == input.Type ||
                    this.Type.Equals(input.Type)
                ) && 
                (
                    this.TimeOffset == input.TimeOffset ||
                    this.TimeOffset.Equals(input.TimeOffset)
                ) && 
                (
                    this.Id == input.Id ||
                    this.Id.Equals(input.Id)
                ) && 
                (
                    this.CreatedBy == input.CreatedBy ||
                    this.CreatedBy.Equals(input.CreatedBy)
                ) && 
                (
                    this.AccountID == input.AccountID ||
                    this.AccountID.Equals(input.AccountID)
                ) && 
                (
                    this.ApplicationID == input.ApplicationID ||
                    this.ApplicationID.Equals(input.ApplicationID)
                ) && 
                (
                    this.Created == input.Created ||
                    (this.Created != null &&
                    this.Created.Equals(input.Created))
                ) && 
                (
                    this.Key == input.Key ||
                    (this.Key != null &&
                    this.Key.Equals(input.Key))
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
                hashCode = hashCode * 59 + this.Platform.GetHashCode();
                hashCode = hashCode * 59 + this.Type.GetHashCode();
                hashCode = hashCode * 59 + this.TimeOffset.GetHashCode();
                hashCode = hashCode * 59 + this.Id.GetHashCode();
                hashCode = hashCode * 59 + this.CreatedBy.GetHashCode();
                hashCode = hashCode * 59 + this.AccountID.GetHashCode();
                hashCode = hashCode * 59 + this.ApplicationID.GetHashCode();
                if (this.Created != null)
                    hashCode = hashCode * 59 + this.Created.GetHashCode();
                if (this.Key != null)
                    hashCode = hashCode * 59 + this.Key.GetHashCode();
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
