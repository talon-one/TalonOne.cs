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
    /// NewImport
    /// </summary>
    [DataContract]
    public partial class NewImport :  IEquatable<NewImport>, IValidatableObject
    {
        /// <summary>
        /// The name of the entity that was imported.
        /// </summary>
        /// <value>The name of the entity that was imported.</value>
        [JsonConverter(typeof(StringEnumConverter))]
        public enum EntityEnum
        {
            
            /// <summary>
            /// Enum Coupon for value: Coupon
            /// </summary>
            [EnumMember(Value = "Coupon")]
            Coupon = 1
        }

        /// <summary>
        /// The name of the entity that was imported.
        /// </summary>
        /// <value>The name of the entity that was imported.</value>
        [DataMember(Name="entity", EmitDefaultValue=false)]
        public EntityEnum Entity { get; set; }
        /// <summary>
        /// Initializes a new instance of the <see cref="NewImport" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected NewImport() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="NewImport" /> class.
        /// </summary>
        /// <param name="entity">The name of the entity that was imported. (required).</param>
        public NewImport(EntityEnum entity = default(EntityEnum))
        {
            // to ensure "entity" is required (not null)
            if (entity == null)
            {
                throw new InvalidDataException("entity is a required property for NewImport and cannot be null");
            }
            else
            {
                this.Entity = entity;
            }
        }
        

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class NewImport {\n");
            sb.Append("  Entity: ").Append(Entity).Append("\n");
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
            return this.Equals(input as NewImport);
        }

        /// <summary>
        /// Returns true if NewImport instances are equal
        /// </summary>
        /// <param name="input">Instance of NewImport to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(NewImport input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.Entity == input.Entity ||
                    (this.Entity != null &&
                    this.Entity.Equals(input.Entity))
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
                if (this.Entity != null)
                    hashCode = hashCode * 59 + this.Entity.GetHashCode();
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
