/* 
 * Talon.One API
 *
 * The Talon.One API is used to manage applications and campaigns, as well as to integrate with your application. The operations in the _Integration API_ section are used to integrate with our platform, while the other operations are used to manage applications and campaigns.  ### Where is the API?  The API is available at the same hostname as these docs. For example, if you are reading this page at `https://mycompany.talon.one/docs/api/`, the URL for the [updateCustomerProfile][] operation is `https://mycompany.talon.one/v1/customer_profiles/id`  [updateCustomerProfile]: #operation- -v1-customer_profiles- -integrationId- -put 
 *
 * OpenAPI spec version: 1.0.0
 * 
 * Generated by: https://github.com/swagger-api/swagger-codegen.git
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
using SwaggerDateConverter = TalonOne.Client.SwaggerDateConverter;

namespace TalonOne.Model
{
    /// <summary>
    /// SamlConnection
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
        /// <param name="id">Unique ID for this entity. (required).</param>
        /// <param name="created">The exact moment this entity was created. (required).</param>
        public SamlConnection(string assertionConsumerServiceURL = default(string), int? accountId = default(int?), string name = default(string), bool? enabled = default(bool?), string issuer = default(string), string signOnURL = default(string), string signOutURL = default(string), string metadataURL = default(string), string audienceURI = default(string), int? id = default(int?), DateTime? created = default(DateTime?))
        {
            // to ensure "assertionConsumerServiceURL" is required (not null)
            if (assertionConsumerServiceURL == null)
            {
                throw new InvalidDataException("assertionConsumerServiceURL is a required property for SamlConnection and cannot be null");
            }
            else
            {
                this.AssertionConsumerServiceURL = assertionConsumerServiceURL;
            }
            // to ensure "accountId" is required (not null)
            if (accountId == null)
            {
                throw new InvalidDataException("accountId is a required property for SamlConnection and cannot be null");
            }
            else
            {
                this.AccountId = accountId;
            }
            // to ensure "name" is required (not null)
            if (name == null)
            {
                throw new InvalidDataException("name is a required property for SamlConnection and cannot be null");
            }
            else
            {
                this.Name = name;
            }
            // to ensure "enabled" is required (not null)
            if (enabled == null)
            {
                throw new InvalidDataException("enabled is a required property for SamlConnection and cannot be null");
            }
            else
            {
                this.Enabled = enabled;
            }
            // to ensure "issuer" is required (not null)
            if (issuer == null)
            {
                throw new InvalidDataException("issuer is a required property for SamlConnection and cannot be null");
            }
            else
            {
                this.Issuer = issuer;
            }
            // to ensure "signOnURL" is required (not null)
            if (signOnURL == null)
            {
                throw new InvalidDataException("signOnURL is a required property for SamlConnection and cannot be null");
            }
            else
            {
                this.SignOnURL = signOnURL;
            }
            // to ensure "audienceURI" is required (not null)
            if (audienceURI == null)
            {
                throw new InvalidDataException("audienceURI is a required property for SamlConnection and cannot be null");
            }
            else
            {
                this.AudienceURI = audienceURI;
            }
            // to ensure "id" is required (not null)
            if (id == null)
            {
                throw new InvalidDataException("id is a required property for SamlConnection and cannot be null");
            }
            else
            {
                this.Id = id;
            }
            // to ensure "created" is required (not null)
            if (created == null)
            {
                throw new InvalidDataException("created is a required property for SamlConnection and cannot be null");
            }
            else
            {
                this.Created = created;
            }
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
        public int? AccountId { get; set; }

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
        public bool? Enabled { get; set; }

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
        /// Unique ID for this entity.
        /// </summary>
        /// <value>Unique ID for this entity.</value>
        [DataMember(Name="id", EmitDefaultValue=false)]
        public int? Id { get; set; }

        /// <summary>
        /// The exact moment this entity was created.
        /// </summary>
        /// <value>The exact moment this entity was created.</value>
        [DataMember(Name="created", EmitDefaultValue=false)]
        public DateTime? Created { get; set; }

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
                    (this.AccountId != null &&
                    this.AccountId.Equals(input.AccountId))
                ) && 
                (
                    this.Name == input.Name ||
                    (this.Name != null &&
                    this.Name.Equals(input.Name))
                ) && 
                (
                    this.Enabled == input.Enabled ||
                    (this.Enabled != null &&
                    this.Enabled.Equals(input.Enabled))
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
                    (this.Id != null &&
                    this.Id.Equals(input.Id))
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
                if (this.AccountId != null)
                    hashCode = hashCode * 59 + this.AccountId.GetHashCode();
                if (this.Name != null)
                    hashCode = hashCode * 59 + this.Name.GetHashCode();
                if (this.Enabled != null)
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
                if (this.Id != null)
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
