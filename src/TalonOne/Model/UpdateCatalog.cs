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
    /// UpdateCatalog
    /// </summary>
    [DataContract]
    public partial class UpdateCatalog :  IEquatable<UpdateCatalog>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="UpdateCatalog" /> class.
        /// </summary>
        /// <param name="description">A description of this cart item catalog..</param>
        /// <param name="name">Name of this cart item catalog..</param>
        /// <param name="subscribedApplicationsIds">A list of the IDs of the applications that are subscribed to this catalog..</param>
        public UpdateCatalog(string description = default(string), string name = default(string), List<int> subscribedApplicationsIds = default(List<int>))
        {
            this.Description = description;
            this.Name = name;
            this.SubscribedApplicationsIds = subscribedApplicationsIds;
        }
        
        /// <summary>
        /// A description of this cart item catalog.
        /// </summary>
        /// <value>A description of this cart item catalog.</value>
        [DataMember(Name="description", EmitDefaultValue=false)]
        public string Description { get; set; }

        /// <summary>
        /// Name of this cart item catalog.
        /// </summary>
        /// <value>Name of this cart item catalog.</value>
        [DataMember(Name="name", EmitDefaultValue=false)]
        public string Name { get; set; }

        /// <summary>
        /// A list of the IDs of the applications that are subscribed to this catalog.
        /// </summary>
        /// <value>A list of the IDs of the applications that are subscribed to this catalog.</value>
        [DataMember(Name="subscribedApplicationsIds", EmitDefaultValue=false)]
        public List<int> SubscribedApplicationsIds { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class UpdateCatalog {\n");
            sb.Append("  Description: ").Append(Description).Append("\n");
            sb.Append("  Name: ").Append(Name).Append("\n");
            sb.Append("  SubscribedApplicationsIds: ").Append(SubscribedApplicationsIds).Append("\n");
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
            return this.Equals(input as UpdateCatalog);
        }

        /// <summary>
        /// Returns true if UpdateCatalog instances are equal
        /// </summary>
        /// <param name="input">Instance of UpdateCatalog to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(UpdateCatalog input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.Description == input.Description ||
                    (this.Description != null &&
                    this.Description.Equals(input.Description))
                ) && 
                (
                    this.Name == input.Name ||
                    (this.Name != null &&
                    this.Name.Equals(input.Name))
                ) && 
                (
                    this.SubscribedApplicationsIds == input.SubscribedApplicationsIds ||
                    this.SubscribedApplicationsIds != null &&
                    input.SubscribedApplicationsIds != null &&
                    this.SubscribedApplicationsIds.SequenceEqual(input.SubscribedApplicationsIds)
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
                if (this.Description != null)
                    hashCode = hashCode * 59 + this.Description.GetHashCode();
                if (this.Name != null)
                    hashCode = hashCode * 59 + this.Name.GetHashCode();
                if (this.SubscribedApplicationsIds != null)
                    hashCode = hashCode * 59 + this.SubscribedApplicationsIds.GetHashCode();
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