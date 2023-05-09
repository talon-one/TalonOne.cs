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
    /// The specific properties of the \&quot;ADD\&quot; catalog sync action.
    /// </summary>
    [DataContract]
    public partial class AddItemCatalogAction :  IEquatable<AddItemCatalogAction>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="AddItemCatalogAction" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected AddItemCatalogAction() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="AddItemCatalogAction" /> class.
        /// </summary>
        /// <param name="sku">The unique SKU of the item to add. (required).</param>
        /// <param name="price">Price of the item..</param>
        /// <param name="attributes">The attributes of the item to add..</param>
        /// <param name="replaceIfExists">Indicates whether to replace the attributes of the item if the same SKU exists. (default to false).</param>
        public AddItemCatalogAction(string sku = default(string), decimal price = default(decimal), Object attributes = default(Object), bool replaceIfExists = false)
        {
            // to ensure "sku" is required (not null)
            this.Sku = sku ?? throw new ArgumentNullException("sku is a required property for AddItemCatalogAction and cannot be null");
            this.Price = price;
            this.Attributes = attributes;
            this.ReplaceIfExists = replaceIfExists;
        }
        
        /// <summary>
        /// The unique SKU of the item to add.
        /// </summary>
        /// <value>The unique SKU of the item to add.</value>
        [DataMember(Name="sku", EmitDefaultValue=false)]
        public string Sku { get; set; }

        /// <summary>
        /// Price of the item.
        /// </summary>
        /// <value>Price of the item.</value>
        [DataMember(Name="price", EmitDefaultValue=true)]
        public decimal Price { get; set; }

        /// <summary>
        /// The attributes of the item to add.
        /// </summary>
        /// <value>The attributes of the item to add.</value>
        [DataMember(Name="attributes", EmitDefaultValue=false)]
        public Object Attributes { get; set; }

        /// <summary>
        /// Indicates whether to replace the attributes of the item if the same SKU exists.
        /// </summary>
        /// <value>Indicates whether to replace the attributes of the item if the same SKU exists.</value>
        [DataMember(Name="replaceIfExists", EmitDefaultValue=false)]
        public bool ReplaceIfExists { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class AddItemCatalogAction {\n");
            sb.Append("  Sku: ").Append(Sku).Append("\n");
            sb.Append("  Price: ").Append(Price).Append("\n");
            sb.Append("  Attributes: ").Append(Attributes).Append("\n");
            sb.Append("  ReplaceIfExists: ").Append(ReplaceIfExists).Append("\n");
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
            return this.Equals(input as AddItemCatalogAction);
        }

        /// <summary>
        /// Returns true if AddItemCatalogAction instances are equal
        /// </summary>
        /// <param name="input">Instance of AddItemCatalogAction to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(AddItemCatalogAction input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.Sku == input.Sku ||
                    (this.Sku != null &&
                    this.Sku.Equals(input.Sku))
                ) && 
                (
                    this.Price == input.Price ||
                    this.Price.Equals(input.Price)
                ) && 
                (
                    this.Attributes == input.Attributes ||
                    (this.Attributes != null &&
                    this.Attributes.Equals(input.Attributes))
                ) && 
                (
                    this.ReplaceIfExists == input.ReplaceIfExists ||
                    this.ReplaceIfExists.Equals(input.ReplaceIfExists)
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
                if (this.Sku != null)
                    hashCode = hashCode * 59 + this.Sku.GetHashCode();
                hashCode = hashCode * 59 + this.Price.GetHashCode();
                if (this.Attributes != null)
                    hashCode = hashCode * 59 + this.Attributes.GetHashCode();
                hashCode = hashCode * 59 + this.ReplaceIfExists.GetHashCode();
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
