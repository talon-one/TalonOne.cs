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
    /// CatalogItem
    /// </summary>
    [DataContract]
    public partial class CatalogItem :  IEquatable<CatalogItem>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="CatalogItem" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected CatalogItem() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="CatalogItem" /> class.
        /// </summary>
        /// <param name="id">Internal ID of this entity. (required).</param>
        /// <param name="created">The time this entity was created. (required).</param>
        /// <param name="sku">The stock keeping unit of the item. (required).</param>
        /// <param name="price">Price of the item..</param>
        /// <param name="catalogid">The ID of the catalog the item belongs to. (required).</param>
        /// <param name="version">The version of the catalog item. (required).</param>
        /// <param name="attributes">attributes.</param>
        /// <param name="product">product.</param>
        public CatalogItem(int id = default(int), DateTime created = default(DateTime), string sku = default(string), decimal price = default(decimal), int catalogid = default(int), int version = default(int), List<ItemAttribute> attributes = default(List<ItemAttribute>), Product product = default(Product))
        {
            this.Id = id;
            this.Created = created;
            // to ensure "sku" is required (not null)
            this.Sku = sku ?? throw new ArgumentNullException("sku is a required property for CatalogItem and cannot be null");
            this.Catalogid = catalogid;
            this.Version = version;
            this.Price = price;
            this.Attributes = attributes;
            this.Product = product;
        }
        
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
        /// The stock keeping unit of the item.
        /// </summary>
        /// <value>The stock keeping unit of the item.</value>
        [DataMember(Name="sku", EmitDefaultValue=false)]
        public string Sku { get; set; }

        /// <summary>
        /// Price of the item.
        /// </summary>
        /// <value>Price of the item.</value>
        [DataMember(Name="price", EmitDefaultValue=true)]
        public decimal Price { get; set; }

        /// <summary>
        /// The ID of the catalog the item belongs to.
        /// </summary>
        /// <value>The ID of the catalog the item belongs to.</value>
        [DataMember(Name="catalogid", EmitDefaultValue=false)]
        public int Catalogid { get; set; }

        /// <summary>
        /// The version of the catalog item.
        /// </summary>
        /// <value>The version of the catalog item.</value>
        [DataMember(Name="version", EmitDefaultValue=false)]
        public int Version { get; set; }

        /// <summary>
        /// Gets or Sets Attributes
        /// </summary>
        [DataMember(Name="attributes", EmitDefaultValue=false)]
        public List<ItemAttribute> Attributes { get; set; }

        /// <summary>
        /// Gets or Sets Product
        /// </summary>
        [DataMember(Name="product", EmitDefaultValue=false)]
        public Product Product { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class CatalogItem {\n");
            sb.Append("  Id: ").Append(Id).Append("\n");
            sb.Append("  Created: ").Append(Created).Append("\n");
            sb.Append("  Sku: ").Append(Sku).Append("\n");
            sb.Append("  Price: ").Append(Price).Append("\n");
            sb.Append("  Catalogid: ").Append(Catalogid).Append("\n");
            sb.Append("  Version: ").Append(Version).Append("\n");
            sb.Append("  Attributes: ").Append(Attributes).Append("\n");
            sb.Append("  Product: ").Append(Product).Append("\n");
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
            return this.Equals(input as CatalogItem);
        }

        /// <summary>
        /// Returns true if CatalogItem instances are equal
        /// </summary>
        /// <param name="input">Instance of CatalogItem to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(CatalogItem input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.Id == input.Id ||
                    this.Id.Equals(input.Id)
                ) && 
                (
                    this.Created == input.Created ||
                    (this.Created != null &&
                    this.Created.Equals(input.Created))
                ) && 
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
                    this.Catalogid == input.Catalogid ||
                    this.Catalogid.Equals(input.Catalogid)
                ) && 
                (
                    this.Version == input.Version ||
                    this.Version.Equals(input.Version)
                ) && 
                (
                    this.Attributes == input.Attributes ||
                    this.Attributes != null &&
                    input.Attributes != null &&
                    this.Attributes.SequenceEqual(input.Attributes)
                ) && 
                (
                    this.Product == input.Product ||
                    (this.Product != null &&
                    this.Product.Equals(input.Product))
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
                hashCode = hashCode * 59 + this.Id.GetHashCode();
                if (this.Created != null)
                    hashCode = hashCode * 59 + this.Created.GetHashCode();
                if (this.Sku != null)
                    hashCode = hashCode * 59 + this.Sku.GetHashCode();
                hashCode = hashCode * 59 + this.Price.GetHashCode();
                hashCode = hashCode * 59 + this.Catalogid.GetHashCode();
                hashCode = hashCode * 59 + this.Version.GetHashCode();
                if (this.Attributes != null)
                    hashCode = hashCode * 59 + this.Attributes.GetHashCode();
                if (this.Product != null)
                    hashCode = hashCode * 59 + this.Product.GetHashCode();
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
            // Version (int) minimum
            if(this.Version < (int)1)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for Version, must be a value greater than or equal to 1.", new [] { "Version" });
            }

            yield break;
        }
    }

}
