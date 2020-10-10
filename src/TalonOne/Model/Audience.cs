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
    /// Audience
    /// </summary>
    [DataContract]
    public partial class Audience :  IEquatable<Audience>, IValidatableObject
    {
        /// <summary>
        /// Integration that this audience was created in.
        /// </summary>
        /// <value>Integration that this audience was created in.</value>
        [JsonConverter(typeof(StringEnumConverter))]
        public enum IntegrationEnum
        {
            /// <summary>
            /// Enum Mparticle for value: mparticle
            /// </summary>
            [EnumMember(Value = "mparticle")]
            Mparticle = 1

        }

        /// <summary>
        /// Integration that this audience was created in.
        /// </summary>
        /// <value>Integration that this audience was created in.</value>
        [DataMember(Name="integration", EmitDefaultValue=true)]
        public IntegrationEnum Integration { get; set; }
        /// <summary>
        /// Initializes a new instance of the <see cref="Audience" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected Audience() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="Audience" /> class.
        /// </summary>
        /// <param name="accountId">The ID of the account that owns this entity. (required).</param>
        /// <param name="id">Unique ID for this entity. (required).</param>
        /// <param name="created">The exact moment this entity was created. (required).</param>
        /// <param name="name">The human-friendly display name for this Audience. (required).</param>
        /// <param name="integration">Integration that this audience was created in. (required).</param>
        /// <param name="integrationId">The ID of this Audience in the third-party integration (required).</param>
        public Audience(int accountId = default(int), int id = default(int), DateTime created = default(DateTime), string name = default(string), IntegrationEnum integration = default(IntegrationEnum), string integrationId = default(string))
        {
            // to ensure "accountId" is required (not null)
            if (accountId == null)
            {
                throw new InvalidDataException("accountId is a required property for Audience and cannot be null");
            }
            else
            {
                this.AccountId = accountId;
            }
            
            // to ensure "id" is required (not null)
            if (id == null)
            {
                throw new InvalidDataException("id is a required property for Audience and cannot be null");
            }
            else
            {
                this.Id = id;
            }
            
            // to ensure "created" is required (not null)
            if (created == null)
            {
                throw new InvalidDataException("created is a required property for Audience and cannot be null");
            }
            else
            {
                this.Created = created;
            }
            
            // to ensure "name" is required (not null)
            if (name == null)
            {
                throw new InvalidDataException("name is a required property for Audience and cannot be null");
            }
            else
            {
                this.Name = name;
            }
            
            // to ensure "integration" is required (not null)
            if (integration == null)
            {
                throw new InvalidDataException("integration is a required property for Audience and cannot be null");
            }
            else
            {
                this.Integration = integration;
            }
            
            // to ensure "integrationId" is required (not null)
            if (integrationId == null)
            {
                throw new InvalidDataException("integrationId is a required property for Audience and cannot be null");
            }
            else
            {
                this.IntegrationId = integrationId;
            }
            
        }
        
        /// <summary>
        /// The ID of the account that owns this entity.
        /// </summary>
        /// <value>The ID of the account that owns this entity.</value>
        [DataMember(Name="accountId", EmitDefaultValue=true)]
        public int AccountId { get; set; }

        /// <summary>
        /// Unique ID for this entity.
        /// </summary>
        /// <value>Unique ID for this entity.</value>
        [DataMember(Name="id", EmitDefaultValue=true)]
        public int Id { get; set; }

        /// <summary>
        /// The exact moment this entity was created.
        /// </summary>
        /// <value>The exact moment this entity was created.</value>
        [DataMember(Name="created", EmitDefaultValue=true)]
        public DateTime Created { get; set; }

        /// <summary>
        /// The human-friendly display name for this Audience.
        /// </summary>
        /// <value>The human-friendly display name for this Audience.</value>
        [DataMember(Name="name", EmitDefaultValue=true)]
        public string Name { get; set; }


        /// <summary>
        /// The ID of this Audience in the third-party integration
        /// </summary>
        /// <value>The ID of this Audience in the third-party integration</value>
        [DataMember(Name="integrationId", EmitDefaultValue=true)]
        public string IntegrationId { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class Audience {\n");
            sb.Append("  AccountId: ").Append(AccountId).Append("\n");
            sb.Append("  Id: ").Append(Id).Append("\n");
            sb.Append("  Created: ").Append(Created).Append("\n");
            sb.Append("  Name: ").Append(Name).Append("\n");
            sb.Append("  Integration: ").Append(Integration).Append("\n");
            sb.Append("  IntegrationId: ").Append(IntegrationId).Append("\n");
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
            return this.Equals(input as Audience);
        }

        /// <summary>
        /// Returns true if Audience instances are equal
        /// </summary>
        /// <param name="input">Instance of Audience to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(Audience input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.AccountId == input.AccountId ||
                    (this.AccountId != null &&
                    this.AccountId.Equals(input.AccountId))
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
                ) && 
                (
                    this.Name == input.Name ||
                    (this.Name != null &&
                    this.Name.Equals(input.Name))
                ) && 
                (
                    this.Integration == input.Integration ||
                    (this.Integration != null &&
                    this.Integration.Equals(input.Integration))
                ) && 
                (
                    this.IntegrationId == input.IntegrationId ||
                    (this.IntegrationId != null &&
                    this.IntegrationId.Equals(input.IntegrationId))
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
                if (this.AccountId != null)
                    hashCode = hashCode * 59 + this.AccountId.GetHashCode();
                if (this.Id != null)
                    hashCode = hashCode * 59 + this.Id.GetHashCode();
                if (this.Created != null)
                    hashCode = hashCode * 59 + this.Created.GetHashCode();
                if (this.Name != null)
                    hashCode = hashCode * 59 + this.Name.GetHashCode();
                if (this.Integration != null)
                    hashCode = hashCode * 59 + this.Integration.GetHashCode();
                if (this.IntegrationId != null)
                    hashCode = hashCode * 59 + this.IntegrationId.GetHashCode();
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
            

            // IntegrationId (string) minLength
            if(this.IntegrationId != null && this.IntegrationId.Length < 1)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for IntegrationId, length must be greater than 1.", new [] { "IntegrationId" });
            }
            
            yield break;
        }
    }

}
