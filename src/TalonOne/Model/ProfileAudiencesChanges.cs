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
    /// ProfileAudiencesChanges
    /// </summary>
    [DataContract]
    public partial class ProfileAudiencesChanges :  IEquatable<ProfileAudiencesChanges>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ProfileAudiencesChanges" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected ProfileAudiencesChanges() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="ProfileAudiencesChanges" /> class.
        /// </summary>
        /// <param name="adds">The IDs of the audiences for the customer to join. (required).</param>
        /// <param name="deletes">The IDs of the audiences for the customer to leave. (required).</param>
        public ProfileAudiencesChanges(List<int> adds = default(List<int>), List<int> deletes = default(List<int>))
        {
            // to ensure "adds" is required (not null)
            if (adds == null)
            {
                throw new InvalidDataException("adds is a required property for ProfileAudiencesChanges and cannot be null");
            }
            else
            {
                this.Adds = adds;
            }
            
            // to ensure "deletes" is required (not null)
            if (deletes == null)
            {
                throw new InvalidDataException("deletes is a required property for ProfileAudiencesChanges and cannot be null");
            }
            else
            {
                this.Deletes = deletes;
            }
            
        }
        
        /// <summary>
        /// The IDs of the audiences for the customer to join.
        /// </summary>
        /// <value>The IDs of the audiences for the customer to join.</value>
        [DataMember(Name="adds", EmitDefaultValue=true)]
        public List<int> Adds { get; set; }

        /// <summary>
        /// The IDs of the audiences for the customer to leave.
        /// </summary>
        /// <value>The IDs of the audiences for the customer to leave.</value>
        [DataMember(Name="deletes", EmitDefaultValue=true)]
        public List<int> Deletes { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ProfileAudiencesChanges {\n");
            sb.Append("  Adds: ").Append(Adds).Append("\n");
            sb.Append("  Deletes: ").Append(Deletes).Append("\n");
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
            return this.Equals(input as ProfileAudiencesChanges);
        }

        /// <summary>
        /// Returns true if ProfileAudiencesChanges instances are equal
        /// </summary>
        /// <param name="input">Instance of ProfileAudiencesChanges to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(ProfileAudiencesChanges input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.Adds == input.Adds ||
                    this.Adds != null &&
                    input.Adds != null &&
                    this.Adds.SequenceEqual(input.Adds)
                ) && 
                (
                    this.Deletes == input.Deletes ||
                    this.Deletes != null &&
                    input.Deletes != null &&
                    this.Deletes.SequenceEqual(input.Deletes)
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
                if (this.Adds != null)
                    hashCode = hashCode * 59 + this.Adds.GetHashCode();
                if (this.Deletes != null)
                    hashCode = hashCode * 59 + this.Deletes.GetHashCode();
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