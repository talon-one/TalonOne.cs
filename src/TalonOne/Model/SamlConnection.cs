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
    /// A SAML 2.0 connection.
    /// </summary>
    [DataContract]
    public partial class SamlConnection :  IEquatable<SamlConnection>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="SamlConnection" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected SamlConnection() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="SamlConnection" /> class.
        /// </summary>
        /// <param name="assertionConsumerServiceURL">The location where the SAML assertion is sent with a HTTP POST. (required).</param>
        /// <param name="accountId">The ID of the account that owns this entity. (required).</param>
        /// <param name="name">ID of the SAML service. (required).</param>
        /// <param name="enabled">Determines if this SAML connection active. (required).</param>
        /// <param name="issuer">Identity Provider Entity ID. (required).</param>
        /// <param name="signOnURL">Single Sign-On URL. (required).</param>
        /// <param name="signOutURL">Single Sign-Out URL..</param>
        /// <param name="metadataURL">Metadata URL..</param>
        /// <param name="audienceURI">The application-defined unique identifier that is the intended audience of the SAML assertion. This is most often the SP Entity ID of your application. When not specified, the ACS URL will be used.  (required).</param>
        /// <param name="id">Internal ID of this entity. (required).</param>
        /// <param name="created">The time this entity was created. (required).</param>
        public SamlConnection(string assertionConsumerServiceURL = default(string), int accountId = default(int), string name = default(string), bool enabled = default(bool), string issuer = default(string), string signOnURL = default(string), string signOutURL = default(string), string metadataURL = default(string), string audienceURI = default(string), int id = default(int), DateTime created = default(DateTime))
        {
            // to ensure "assertionConsumerServiceURL" is required (not null)
            this.AssertionConsumerServiceURL = assertionConsumerServiceURL ?? throw new ArgumentNullException("assertionConsumerServiceURL is a required property for SamlConnection and cannot be null");
            this.AccountId = accountId;
            // to ensure "name" is required (not null)
            this.Name = name ?? throw new ArgumentNullException("name is a required property for SamlConnection and cannot be null");
            this.Enabled = enabled;
            // to ensure "issuer" is required (not null)
            this.Issuer = issuer ?? throw new ArgumentNullException("issuer is a required property for SamlConnection and cannot be null");
            // to ensure "signOnURL" is required (not null)
            this.SignOnURL = signOnURL ?? throw new ArgumentNullException("signOnURL is a required property for SamlConnection and cannot be null");
            // to ensure "audienceURI" is required (not null)
            this.AudienceURI = audienceURI ?? throw new ArgumentNullException("audienceURI is a required property for SamlConnection and cannot be null");
            this.Id = id;
            this.Created = created;
            this.SignOutURL = signOutURL;
            this.MetadataURL = metadataURL;
        }
        
        /// <summary>
        /// The location where the SAML assertion is sent with a HTTP POST.
        /// </summary>
        /// <value>The location where the SAML assertion is sent with a HTTP POST.</value>
        [DataMember(Name="assertionConsumerServiceURL", EmitDefaultValue=false)]
        public string AssertionConsumerServiceURL { get; set; }

        /// <summary>
        /// The ID of the account that owns this entity.
        /// </summary>
        /// <value>The ID of the account that owns this entity.</value>
        [DataMember(Name="accountId", EmitDefaultValue=false)]
        public int AccountId { get; set; }

        /// <summary>
        /// ID of the SAML service.
        /// </summary>
        /// <value>ID of the SAML service.</value>
        [DataMember(Name="name", EmitDefaultValue=false)]
        public string Name { get; set; }

        /// <summary>
        /// Determines if this SAML connection active.
        /// </summary>
        /// <value>Determines if this SAML connection active.</value>
        [DataMember(Name="enabled", EmitDefaultValue=false)]
        public bool Enabled { get; set; }

        /// <summary>
        /// Identity Provider Entity ID.
        /// </summary>
        /// <value>Identity Provider Entity ID.</value>
        [DataMember(Name="issuer", EmitDefaultValue=false)]
        public string Issuer { get; set; }

        /// <summary>
        /// Single Sign-On URL.
        /// </summary>
        /// <value>Single Sign-On URL.</value>
        [DataMember(Name="signOnURL", EmitDefaultValue=false)]
        public string SignOnURL { get; set; }

        /// <summary>
        /// Single Sign-Out URL.
        /// </summary>
        /// <value>Single Sign-Out URL.</value>
        [DataMember(Name="signOutURL", EmitDefaultValue=false)]
        public string SignOutURL { get; set; }

        /// <summary>
        /// Metadata URL.
        /// </summary>
        /// <value>Metadata URL.</value>
        [DataMember(Name="metadataURL", EmitDefaultValue=false)]
        public string MetadataURL { get; set; }

        /// <summary>
        /// The application-defined unique identifier that is the intended audience of the SAML assertion. This is most often the SP Entity ID of your application. When not specified, the ACS URL will be used. 
        /// </summary>
        /// <value>The application-defined unique identifier that is the intended audience of the SAML assertion. This is most often the SP Entity ID of your application. When not specified, the ACS URL will be used. </value>
        [DataMember(Name="audienceURI", EmitDefaultValue=false)]
        public string AudienceURI { get; set; }

        /// <summary>
        /// Internal ID of this entity.
        /// </summary>
        /// <value>Internal ID of this entity.</value>
        [DataMember(Name="id", EmitDefaultValue=false)]
        public int Id { get; set; }

        /// <summary>
        /// The time this entity was created.
        /// </summary>
        /// <value>The time this entity was created.</value>
        [DataMember(Name="created", EmitDefaultValue=false)]
        public DateTime Created { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class SamlConnection {\n");
            sb.Append("  AssertionConsumerServiceURL: ").Append(AssertionConsumerServiceURL).Append("\n");
            sb.Append("  AccountId: ").Append(AccountId).Append("\n");
            sb.Append("  Name: ").Append(Name).Append("\n");
            sb.Append("  Enabled: ").Append(Enabled).Append("\n");
            sb.Append("  Issuer: ").Append(Issuer).Append("\n");
            sb.Append("  SignOnURL: ").Append(SignOnURL).Append("\n");
            sb.Append("  SignOutURL: ").Append(SignOutURL).Append("\n");
            sb.Append("  MetadataURL: ").Append(MetadataURL).Append("\n");
            sb.Append("  AudienceURI: ").Append(AudienceURI).Append("\n");
            sb.Append("  Id: ").Append(Id).Append("\n");
            sb.Append("  Created: ").Append(Created).Append("\n");
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
            return this.Equals(input as SamlConnection);
        }

        /// <summary>
        /// Returns true if SamlConnection instances are equal
        /// </summary>
        /// <param name="input">Instance of SamlConnection to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(SamlConnection input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.AssertionConsumerServiceURL == input.AssertionConsumerServiceURL ||
                    (this.AssertionConsumerServiceURL != null &&
                    this.AssertionConsumerServiceURL.Equals(input.AssertionConsumerServiceURL))
                ) && 
                (
                    this.AccountId == input.AccountId ||
                    this.AccountId.Equals(input.AccountId)
                ) && 
                (
                    this.Name == input.Name ||
                    (this.Name != null &&
                    this.Name.Equals(input.Name))
                ) && 
                (
                    this.Enabled == input.Enabled ||
                    this.Enabled.Equals(input.Enabled)
                ) && 
                (
                    this.Issuer == input.Issuer ||
                    (this.Issuer != null &&
                    this.Issuer.Equals(input.Issuer))
                ) && 
                (
                    this.SignOnURL == input.SignOnURL ||
                    (this.SignOnURL != null &&
                    this.SignOnURL.Equals(input.SignOnURL))
                ) && 
                (
                    this.SignOutURL == input.SignOutURL ||
                    (this.SignOutURL != null &&
                    this.SignOutURL.Equals(input.SignOutURL))
                ) && 
                (
                    this.MetadataURL == input.MetadataURL ||
                    (this.MetadataURL != null &&
                    this.MetadataURL.Equals(input.MetadataURL))
                ) && 
                (
                    this.AudienceURI == input.AudienceURI ||
                    (this.AudienceURI != null &&
                    this.AudienceURI.Equals(input.AudienceURI))
                ) && 
                (
                    this.Id == input.Id ||
                    this.Id.Equals(input.Id)
                ) && 
                (
                    this.Created == input.Created ||
                    (this.Created != null &&
                    this.Created.Equals(input.Created))
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
                if (this.AssertionConsumerServiceURL != null)
                    hashCode = hashCode * 59 + this.AssertionConsumerServiceURL.GetHashCode();
                hashCode = hashCode * 59 + this.AccountId.GetHashCode();
                if (this.Name != null)
                    hashCode = hashCode * 59 + this.Name.GetHashCode();
                hashCode = hashCode * 59 + this.Enabled.GetHashCode();
                if (this.Issuer != null)
                    hashCode = hashCode * 59 + this.Issuer.GetHashCode();
                if (this.SignOnURL != null)
                    hashCode = hashCode * 59 + this.SignOnURL.GetHashCode();
                if (this.SignOutURL != null)
                    hashCode = hashCode * 59 + this.SignOutURL.GetHashCode();
                if (this.MetadataURL != null)
                    hashCode = hashCode * 59 + this.MetadataURL.GetHashCode();
                if (this.AudienceURI != null)
                    hashCode = hashCode * 59 + this.AudienceURI.GetHashCode();
                hashCode = hashCode * 59 + this.Id.GetHashCode();
                if (this.Created != null)
                    hashCode = hashCode * 59 + this.Created.GetHashCode();
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
            // Name (string) minLength
            if(this.Name != null && this.Name.Length < 1)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for Name, length must be greater than 1.", new [] { "Name" });
            }

            // Issuer (string) minLength
            if(this.Issuer != null && this.Issuer.Length < 1)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for Issuer, length must be greater than 1.", new [] { "Issuer" });
            }

            // SignOnURL (string) minLength
            if(this.SignOnURL != null && this.SignOnURL.Length < 1)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for SignOnURL, length must be greater than 1.", new [] { "SignOnURL" });
            }

            yield break;
        }
    }

}
