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
    /// ApplicationAPIKey
    /// </summary>
    [DataContract]
    public partial class ApplicationAPIKey :  IEquatable<ApplicationAPIKey>, IValidatableObject
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
        /// Initializes a new instance of the <see cref="ApplicationAPIKey" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected ApplicationAPIKey() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="ApplicationAPIKey" /> class.
        /// </summary>
        /// <param name="title">Title for API Key (required).</param>
        /// <param name="expires">The date the API key expired (required).</param>
        /// <param name="platform">Platform the API key is valid for..</param>
        /// <param name="id">ID of the API Key (required).</param>
        /// <param name="createdBy">ID of user who created (required).</param>
        /// <param name="accountID">ID of account the key is used for (required).</param>
        /// <param name="applicationID">ID of application the key is used for (required).</param>
        /// <param name="created">The date the API key was created (required).</param>
        public ApplicationAPIKey(string title = default(string), DateTime expires = default(DateTime), PlatformEnum? platform = default(PlatformEnum?), int id = default(int), int createdBy = default(int), int accountID = default(int), int applicationID = default(int), DateTime created = default(DateTime))
        {
            // to ensure "title" is required (not null)
            if (title == null)
            {
                throw new InvalidDataException("title is a required property for ApplicationAPIKey and cannot be null");
            }
            else
            {
                this.Title = title;
            }
            
            // to ensure "expires" is required (not null)
            if (expires == null)
            {
                throw new InvalidDataException("expires is a required property for ApplicationAPIKey and cannot be null");
            }
            else
            {
                this.Expires = expires;
            }
            
            // to ensure "id" is required (not null)
            if (id == null)
            {
                throw new InvalidDataException("id is a required property for ApplicationAPIKey and cannot be null");
            }
            else
            {
                this.Id = id;
            }
            
            // to ensure "createdBy" is required (not null)
            if (createdBy == null)
            {
                throw new InvalidDataException("createdBy is a required property for ApplicationAPIKey and cannot be null");
            }
            else
            {
                this.CreatedBy = createdBy;
            }
            
            // to ensure "accountID" is required (not null)
            if (accountID == null)
            {
                throw new InvalidDataException("accountID is a required property for ApplicationAPIKey and cannot be null");
            }
            else
            {
                this.AccountID = accountID;
            }
            
            // to ensure "applicationID" is required (not null)
            if (applicationID == null)
            {
                throw new InvalidDataException("applicationID is a required property for ApplicationAPIKey and cannot be null");
            }
            else
            {
                this.ApplicationID = applicationID;
            }
            
            // to ensure "created" is required (not null)
            if (created == null)
            {
                throw new InvalidDataException("created is a required property for ApplicationAPIKey and cannot be null");
            }
            else
            {
                this.Created = created;
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
        /// ID of the API Key
        /// </summary>
        /// <value>ID of the API Key</value>
        [DataMember(Name="id", EmitDefaultValue=false)]
        public int Id { get; set; }

        /// <summary>
        /// ID of user who created
        /// </summary>
        /// <value>ID of user who created</value>
        [DataMember(Name="createdBy", EmitDefaultValue=false)]
        public int CreatedBy { get; set; }

        /// <summary>
        /// ID of account the key is used for
        /// </summary>
        /// <value>ID of account the key is used for</value>
        [DataMember(Name="accountID", EmitDefaultValue=false)]
        public int AccountID { get; set; }

        /// <summary>
        /// ID of application the key is used for
        /// </summary>
        /// <value>ID of application the key is used for</value>
        [DataMember(Name="applicationID", EmitDefaultValue=false)]
        public int ApplicationID { get; set; }

        /// <summary>
        /// The date the API key was created
        /// </summary>
        /// <value>The date the API key was created</value>
        [DataMember(Name="created", EmitDefaultValue=false)]
        public DateTime Created { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ApplicationAPIKey {\n");
            sb.Append("  Title: ").Append(Title).Append("\n");
            sb.Append("  Expires: ").Append(Expires).Append("\n");
            sb.Append("  Platform: ").Append(Platform).Append("\n");
            sb.Append("  Id: ").Append(Id).Append("\n");
            sb.Append("  CreatedBy: ").Append(CreatedBy).Append("\n");
            sb.Append("  AccountID: ").Append(AccountID).Append("\n");
            sb.Append("  ApplicationID: ").Append(ApplicationID).Append("\n");
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
            return this.Equals(input as ApplicationAPIKey);
        }

        /// <summary>
        /// Returns true if ApplicationAPIKey instances are equal
        /// </summary>
        /// <param name="input">Instance of ApplicationAPIKey to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(ApplicationAPIKey input)
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
                ) && 
                (
                    this.Id == input.Id ||
                    (this.Id != null &&
                    this.Id.Equals(input.Id))
                ) && 
                (
                    this.CreatedBy == input.CreatedBy ||
                    (this.CreatedBy != null &&
                    this.CreatedBy.Equals(input.CreatedBy))
                ) && 
                (
                    this.AccountID == input.AccountID ||
                    (this.AccountID != null &&
                    this.AccountID.Equals(input.AccountID))
                ) && 
                (
                    this.ApplicationID == input.ApplicationID ||
                    (this.ApplicationID != null &&
                    this.ApplicationID.Equals(input.ApplicationID))
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
                if (this.Title != null)
                    hashCode = hashCode * 59 + this.Title.GetHashCode();
                if (this.Expires != null)
                    hashCode = hashCode * 59 + this.Expires.GetHashCode();
                if (this.Platform != null)
                    hashCode = hashCode * 59 + this.Platform.GetHashCode();
                if (this.Id != null)
                    hashCode = hashCode * 59 + this.Id.GetHashCode();
                if (this.CreatedBy != null)
                    hashCode = hashCode * 59 + this.CreatedBy.GetHashCode();
                if (this.AccountID != null)
                    hashCode = hashCode * 59 + this.AccountID.GetHashCode();
                if (this.ApplicationID != null)
                    hashCode = hashCode * 59 + this.ApplicationID.GetHashCode();
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
            yield break;
        }
    }

}
