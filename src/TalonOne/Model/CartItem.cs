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
    /// CartItem
    /// </summary>
    [DataContract]
    public partial class CartItem :  IEquatable<CartItem>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="CartItem" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected CartItem() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="CartItem" /> class.
        /// </summary>
        /// <param name="name">Name of item..</param>
        /// <param name="sku">Stock keeping unit of item. (required).</param>
        /// <param name="quantity">Number of units of this item. Due to [cart item flattening](https://docs.talon.one/docs/product/rules/understanding-cart-item-flattening), if you provide a quantity greater than 1, the item will be split in as many items as the provided quantity. This will impact the number of **per-item** effects triggered from your campaigns.  (required).</param>
        /// <param name="returnedQuantity">Number of returned items, calculated internally based on returns of this item..</param>
        /// <param name="remainingQuantity">Remaining quantity of the item, calculated internally based on returns of this item..</param>
        /// <param name="price">Price of the item in the currency defined by your Application. This field is required if this item is not part of a [catalog](https://docs.talon.one/docs/product/account/dev-tools/managing-cart-item-catalogs). If it is part of a catalog, setting a price here overrides the price from the catalog. .</param>
        /// <param name="category">Type, group or model of the item..</param>
        /// <param name="product">product.</param>
        /// <param name="weight">Weight of item in grams..</param>
        /// <param name="height">Height of item in mm..</param>
        /// <param name="width">Width of item in mm..</param>
        /// <param name="length">Length of item in mm..</param>
        /// <param name="position">Position of the Cart Item in the Cart (calculated internally)..</param>
        /// <param name="attributes">Use this property to set a value for the attributes of your choice. [Attributes](https://docs.talon.one/docs/dev/concepts/attributes) represent any information to attach to this cart item.  Custom _cart item_ attributes must be created in the Campaign Manager before you set them with this property. .</param>
        /// <param name="additionalCosts">Use this property to set a value for the additional costs of this item, such as a shipping cost. They must be created in the Campaign Manager before you set them with this property. See [Managing additional costs](https://docs.talon.one/docs/product/account/dev-tools/managing-additional-costs). .</param>
        /// <param name="catalogItemID">The [catalog item ID](https://docs.talon.one/docs/product/account/dev-tools/managing-cart-item-catalogs/#synchronizing-a-cart-item-catalog)..</param>
        public CartItem(string name = default(string), string sku = default(string), int quantity = default(int), int returnedQuantity = default(int), int remainingQuantity = default(int), decimal price = default(decimal), string category = default(string), Product product = default(Product), decimal weight = default(decimal), decimal height = default(decimal), decimal width = default(decimal), decimal length = default(decimal), decimal position = default(decimal), Object attributes = default(Object), Dictionary<string, AdditionalCost> additionalCosts = default(Dictionary<string, AdditionalCost>), int catalogItemID = default(int))
        {
            // to ensure "sku" is required (not null)
            this.Sku = sku ?? throw new ArgumentNullException("sku is a required property for CartItem and cannot be null");
            this.Quantity = quantity;
            this.Name = name;
            this.ReturnedQuantity = returnedQuantity;
            this.RemainingQuantity = remainingQuantity;
            this.Price = price;
            this.Category = category;
            this.Product = product;
            this.Weight = weight;
            this.Height = height;
            this.Width = width;
            this.Length = length;
            this.Position = position;
            this.Attributes = attributes;
            this.AdditionalCosts = additionalCosts;
            this.CatalogItemID = catalogItemID;
        }
        
        /// <summary>
        /// Name of item.
        /// </summary>
        /// <value>Name of item.</value>
        [DataMember(Name="name", EmitDefaultValue=false)]
        public string Name { get; set; }

        /// <summary>
        /// Stock keeping unit of item.
        /// </summary>
        /// <value>Stock keeping unit of item.</value>
        [DataMember(Name="sku", EmitDefaultValue=false)]
        public string Sku { get; set; }

        /// <summary>
        /// Number of units of this item. Due to [cart item flattening](https://docs.talon.one/docs/product/rules/understanding-cart-item-flattening), if you provide a quantity greater than 1, the item will be split in as many items as the provided quantity. This will impact the number of **per-item** effects triggered from your campaigns. 
        /// </summary>
        /// <value>Number of units of this item. Due to [cart item flattening](https://docs.talon.one/docs/product/rules/understanding-cart-item-flattening), if you provide a quantity greater than 1, the item will be split in as many items as the provided quantity. This will impact the number of **per-item** effects triggered from your campaigns. </value>
        [DataMember(Name="quantity", EmitDefaultValue=false)]
        public int Quantity { get; set; }

        /// <summary>
        /// Number of returned items, calculated internally based on returns of this item.
        /// </summary>
        /// <value>Number of returned items, calculated internally based on returns of this item.</value>
        [DataMember(Name="returnedQuantity", EmitDefaultValue=false)]
        public int ReturnedQuantity { get; set; }

        /// <summary>
        /// Remaining quantity of the item, calculated internally based on returns of this item.
        /// </summary>
        /// <value>Remaining quantity of the item, calculated internally based on returns of this item.</value>
        [DataMember(Name="remainingQuantity", EmitDefaultValue=false)]
        public int RemainingQuantity { get; set; }

        /// <summary>
        /// Price of the item in the currency defined by your Application. This field is required if this item is not part of a [catalog](https://docs.talon.one/docs/product/account/dev-tools/managing-cart-item-catalogs). If it is part of a catalog, setting a price here overrides the price from the catalog. 
        /// </summary>
        /// <value>Price of the item in the currency defined by your Application. This field is required if this item is not part of a [catalog](https://docs.talon.one/docs/product/account/dev-tools/managing-cart-item-catalogs). If it is part of a catalog, setting a price here overrides the price from the catalog. </value>
        [DataMember(Name="price", EmitDefaultValue=false)]
        public decimal Price { get; set; }

        /// <summary>
        /// Type, group or model of the item.
        /// </summary>
        /// <value>Type, group or model of the item.</value>
        [DataMember(Name="category", EmitDefaultValue=false)]
        public string Category { get; set; }

        /// <summary>
        /// Gets or Sets Product
        /// </summary>
        [DataMember(Name="product", EmitDefaultValue=false)]
        public Product Product { get; set; }

        /// <summary>
        /// Weight of item in grams.
        /// </summary>
        /// <value>Weight of item in grams.</value>
        [DataMember(Name="weight", EmitDefaultValue=false)]
        public decimal Weight { get; set; }

        /// <summary>
        /// Height of item in mm.
        /// </summary>
        /// <value>Height of item in mm.</value>
        [DataMember(Name="height", EmitDefaultValue=false)]
        public decimal Height { get; set; }

        /// <summary>
        /// Width of item in mm.
        /// </summary>
        /// <value>Width of item in mm.</value>
        [DataMember(Name="width", EmitDefaultValue=false)]
        public decimal Width { get; set; }

        /// <summary>
        /// Length of item in mm.
        /// </summary>
        /// <value>Length of item in mm.</value>
        [DataMember(Name="length", EmitDefaultValue=false)]
        public decimal Length { get; set; }

        /// <summary>
        /// Position of the Cart Item in the Cart (calculated internally).
        /// </summary>
        /// <value>Position of the Cart Item in the Cart (calculated internally).</value>
        [DataMember(Name="position", EmitDefaultValue=false)]
        public decimal Position { get; set; }

        /// <summary>
        /// Use this property to set a value for the attributes of your choice. [Attributes](https://docs.talon.one/docs/dev/concepts/attributes) represent any information to attach to this cart item.  Custom _cart item_ attributes must be created in the Campaign Manager before you set them with this property. 
        /// </summary>
        /// <value>Use this property to set a value for the attributes of your choice. [Attributes](https://docs.talon.one/docs/dev/concepts/attributes) represent any information to attach to this cart item.  Custom _cart item_ attributes must be created in the Campaign Manager before you set them with this property. </value>
        [DataMember(Name="attributes", EmitDefaultValue=false)]
        public Object Attributes { get; set; }

        /// <summary>
        /// Use this property to set a value for the additional costs of this item, such as a shipping cost. They must be created in the Campaign Manager before you set them with this property. See [Managing additional costs](https://docs.talon.one/docs/product/account/dev-tools/managing-additional-costs). 
        /// </summary>
        /// <value>Use this property to set a value for the additional costs of this item, such as a shipping cost. They must be created in the Campaign Manager before you set them with this property. See [Managing additional costs](https://docs.talon.one/docs/product/account/dev-tools/managing-additional-costs). </value>
        [DataMember(Name="additionalCosts", EmitDefaultValue=false)]
        public Dictionary<string, AdditionalCost> AdditionalCosts { get; set; }

        /// <summary>
        /// The [catalog item ID](https://docs.talon.one/docs/product/account/dev-tools/managing-cart-item-catalogs/#synchronizing-a-cart-item-catalog).
        /// </summary>
        /// <value>The [catalog item ID](https://docs.talon.one/docs/product/account/dev-tools/managing-cart-item-catalogs/#synchronizing-a-cart-item-catalog).</value>
        [DataMember(Name="catalogItemID", EmitDefaultValue=false)]
        public int CatalogItemID { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class CartItem {\n");
            sb.Append("  Name: ").Append(Name).Append("\n");
            sb.Append("  Sku: ").Append(Sku).Append("\n");
            sb.Append("  Quantity: ").Append(Quantity).Append("\n");
            sb.Append("  ReturnedQuantity: ").Append(ReturnedQuantity).Append("\n");
            sb.Append("  RemainingQuantity: ").Append(RemainingQuantity).Append("\n");
            sb.Append("  Price: ").Append(Price).Append("\n");
            sb.Append("  Category: ").Append(Category).Append("\n");
            sb.Append("  Product: ").Append(Product).Append("\n");
            sb.Append("  Weight: ").Append(Weight).Append("\n");
            sb.Append("  Height: ").Append(Height).Append("\n");
            sb.Append("  Width: ").Append(Width).Append("\n");
            sb.Append("  Length: ").Append(Length).Append("\n");
            sb.Append("  Position: ").Append(Position).Append("\n");
            sb.Append("  Attributes: ").Append(Attributes).Append("\n");
            sb.Append("  AdditionalCosts: ").Append(AdditionalCosts).Append("\n");
            sb.Append("  CatalogItemID: ").Append(CatalogItemID).Append("\n");
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
            return this.Equals(input as CartItem);
        }

        /// <summary>
        /// Returns true if CartItem instances are equal
        /// </summary>
        /// <param name="input">Instance of CartItem to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(CartItem input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.Name == input.Name ||
                    (this.Name != null &&
                    this.Name.Equals(input.Name))
                ) && 
                (
                    this.Sku == input.Sku ||
                    (this.Sku != null &&
                    this.Sku.Equals(input.Sku))
                ) && 
                (
                    this.Quantity == input.Quantity ||
                    this.Quantity.Equals(input.Quantity)
                ) && 
                (
                    this.ReturnedQuantity == input.ReturnedQuantity ||
                    this.ReturnedQuantity.Equals(input.ReturnedQuantity)
                ) && 
                (
                    this.RemainingQuantity == input.RemainingQuantity ||
                    this.RemainingQuantity.Equals(input.RemainingQuantity)
                ) && 
                (
                    this.Price == input.Price ||
                    this.Price.Equals(input.Price)
                ) && 
                (
                    this.Category == input.Category ||
                    (this.Category != null &&
                    this.Category.Equals(input.Category))
                ) && 
                (
                    this.Product == input.Product ||
                    (this.Product != null &&
                    this.Product.Equals(input.Product))
                ) && 
                (
                    this.Weight == input.Weight ||
                    this.Weight.Equals(input.Weight)
                ) && 
                (
                    this.Height == input.Height ||
                    this.Height.Equals(input.Height)
                ) && 
                (
                    this.Width == input.Width ||
                    this.Width.Equals(input.Width)
                ) && 
                (
                    this.Length == input.Length ||
                    this.Length.Equals(input.Length)
                ) && 
                (
                    this.Position == input.Position ||
                    this.Position.Equals(input.Position)
                ) && 
                (
                    this.Attributes == input.Attributes ||
                    (this.Attributes != null &&
                    this.Attributes.Equals(input.Attributes))
                ) && 
                (
                    this.AdditionalCosts == input.AdditionalCosts ||
                    this.AdditionalCosts != null &&
                    input.AdditionalCosts != null &&
                    this.AdditionalCosts.SequenceEqual(input.AdditionalCosts)
                ) && 
                (
                    this.CatalogItemID == input.CatalogItemID ||
                    this.CatalogItemID.Equals(input.CatalogItemID)
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
                if (this.Name != null)
                    hashCode = hashCode * 59 + this.Name.GetHashCode();
                if (this.Sku != null)
                    hashCode = hashCode * 59 + this.Sku.GetHashCode();
                hashCode = hashCode * 59 + this.Quantity.GetHashCode();
                hashCode = hashCode * 59 + this.ReturnedQuantity.GetHashCode();
                hashCode = hashCode * 59 + this.RemainingQuantity.GetHashCode();
                hashCode = hashCode * 59 + this.Price.GetHashCode();
                if (this.Category != null)
                    hashCode = hashCode * 59 + this.Category.GetHashCode();
                if (this.Product != null)
                    hashCode = hashCode * 59 + this.Product.GetHashCode();
                hashCode = hashCode * 59 + this.Weight.GetHashCode();
                hashCode = hashCode * 59 + this.Height.GetHashCode();
                hashCode = hashCode * 59 + this.Width.GetHashCode();
                hashCode = hashCode * 59 + this.Length.GetHashCode();
                hashCode = hashCode * 59 + this.Position.GetHashCode();
                if (this.Attributes != null)
                    hashCode = hashCode * 59 + this.Attributes.GetHashCode();
                if (this.AdditionalCosts != null)
                    hashCode = hashCode * 59 + this.AdditionalCosts.GetHashCode();
                hashCode = hashCode * 59 + this.CatalogItemID.GetHashCode();
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
            // Sku (string) minLength
            if(this.Sku != null && this.Sku.Length < 1)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for Sku, length must be greater than 1.", new [] { "Sku" });
            }

            // Quantity (int) minimum
            if(this.Quantity < (int)1)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for Quantity, must be a value greater than or equal to 1.", new [] { "Quantity" });
            }

            yield break;
        }
    }

}
