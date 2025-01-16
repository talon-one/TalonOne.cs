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
    /// Service provider configuration details.
    /// </summary>
    [DataContract]
    public partial class ScimServiceProviderConfigResponse :  IEquatable<ScimServiceProviderConfigResponse>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ScimServiceProviderConfigResponse" /> class.
        /// </summary>
        /// <param name="bulk">bulk.</param>
        /// <param name="changePassword">changePassword.</param>
        /// <param name="documentationUri">The URI that points to the SCIM service provider&#39;s documentation, providing further details about the service&#39;s capabilities and usage..</param>
        /// <param name="filter">filter.</param>
        /// <param name="patch">patch.</param>
        /// <param name="schemas">A list of SCIM schemas that define the structure and data types supported by the service provider..</param>
        /// <param name="sort">sort.</param>
        public ScimServiceProviderConfigResponse(ScimServiceProviderConfigResponseBulk bulk = default(ScimServiceProviderConfigResponseBulk), ScimServiceProviderConfigResponseChangePassword changePassword = default(ScimServiceProviderConfigResponseChangePassword), string documentationUri = default(string), ScimServiceProviderConfigResponseFilter filter = default(ScimServiceProviderConfigResponseFilter), ScimServiceProviderConfigResponsePatch patch = default(ScimServiceProviderConfigResponsePatch), List<string> schemas = default(List<string>), ScimServiceProviderConfigResponseSort sort = default(ScimServiceProviderConfigResponseSort))
        {
            this.Bulk = bulk;
            this.ChangePassword = changePassword;
            this.DocumentationUri = documentationUri;
            this.Filter = filter;
            this.Patch = patch;
            this.Schemas = schemas;
            this.Sort = sort;
        }
        
        /// <summary>
        /// Gets or Sets Bulk
        /// </summary>
        [DataMember(Name="bulk", EmitDefaultValue=false)]
        public ScimServiceProviderConfigResponseBulk Bulk { get; set; }

        /// <summary>
        /// Gets or Sets ChangePassword
        /// </summary>
        [DataMember(Name="changePassword", EmitDefaultValue=false)]
        public ScimServiceProviderConfigResponseChangePassword ChangePassword { get; set; }

        /// <summary>
        /// The URI that points to the SCIM service provider&#39;s documentation, providing further details about the service&#39;s capabilities and usage.
        /// </summary>
        /// <value>The URI that points to the SCIM service provider&#39;s documentation, providing further details about the service&#39;s capabilities and usage.</value>
        [DataMember(Name="documentationUri", EmitDefaultValue=false)]
        public string DocumentationUri { get; set; }

        /// <summary>
        /// Gets or Sets Filter
        /// </summary>
        [DataMember(Name="filter", EmitDefaultValue=false)]
        public ScimServiceProviderConfigResponseFilter Filter { get; set; }

        /// <summary>
        /// Gets or Sets Patch
        /// </summary>
        [DataMember(Name="patch", EmitDefaultValue=false)]
        public ScimServiceProviderConfigResponsePatch Patch { get; set; }

        /// <summary>
        /// A list of SCIM schemas that define the structure and data types supported by the service provider.
        /// </summary>
        /// <value>A list of SCIM schemas that define the structure and data types supported by the service provider.</value>
        [DataMember(Name="schemas", EmitDefaultValue=false)]
        public List<string> Schemas { get; set; }

        /// <summary>
        /// Gets or Sets Sort
        /// </summary>
        [DataMember(Name="sort", EmitDefaultValue=false)]
        public ScimServiceProviderConfigResponseSort Sort { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ScimServiceProviderConfigResponse {\n");
            sb.Append("  Bulk: ").Append(Bulk).Append("\n");
            sb.Append("  ChangePassword: ").Append(ChangePassword).Append("\n");
            sb.Append("  DocumentationUri: ").Append(DocumentationUri).Append("\n");
            sb.Append("  Filter: ").Append(Filter).Append("\n");
            sb.Append("  Patch: ").Append(Patch).Append("\n");
            sb.Append("  Schemas: ").Append(Schemas).Append("\n");
            sb.Append("  Sort: ").Append(Sort).Append("\n");
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
            return this.Equals(input as ScimServiceProviderConfigResponse);
        }

        /// <summary>
        /// Returns true if ScimServiceProviderConfigResponse instances are equal
        /// </summary>
        /// <param name="input">Instance of ScimServiceProviderConfigResponse to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(ScimServiceProviderConfigResponse input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.Bulk == input.Bulk ||
                    (this.Bulk != null &&
                    this.Bulk.Equals(input.Bulk))
                ) && 
                (
                    this.ChangePassword == input.ChangePassword ||
                    (this.ChangePassword != null &&
                    this.ChangePassword.Equals(input.ChangePassword))
                ) && 
                (
                    this.DocumentationUri == input.DocumentationUri ||
                    (this.DocumentationUri != null &&
                    this.DocumentationUri.Equals(input.DocumentationUri))
                ) && 
                (
                    this.Filter == input.Filter ||
                    (this.Filter != null &&
                    this.Filter.Equals(input.Filter))
                ) && 
                (
                    this.Patch == input.Patch ||
                    (this.Patch != null &&
                    this.Patch.Equals(input.Patch))
                ) && 
                (
                    this.Schemas == input.Schemas ||
                    this.Schemas != null &&
                    input.Schemas != null &&
                    this.Schemas.SequenceEqual(input.Schemas)
                ) && 
                (
                    this.Sort == input.Sort ||
                    (this.Sort != null &&
                    this.Sort.Equals(input.Sort))
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
                if (this.Bulk != null)
                    hashCode = hashCode * 59 + this.Bulk.GetHashCode();
                if (this.ChangePassword != null)
                    hashCode = hashCode * 59 + this.ChangePassword.GetHashCode();
                if (this.DocumentationUri != null)
                    hashCode = hashCode * 59 + this.DocumentationUri.GetHashCode();
                if (this.Filter != null)
                    hashCode = hashCode * 59 + this.Filter.GetHashCode();
                if (this.Patch != null)
                    hashCode = hashCode * 59 + this.Patch.GetHashCode();
                if (this.Schemas != null)
                    hashCode = hashCode * 59 + this.Schemas.GetHashCode();
                if (this.Sort != null)
                    hashCode = hashCode * 59 + this.Sort.GetHashCode();
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
