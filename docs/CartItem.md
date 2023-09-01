# TalonOne.Model.CartItem
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Name** | **string** | Name of item. | [optional] 
**Sku** | **string** | Stock keeping unit of item. | 
**Quantity** | **int** | Quantity of item. **Important:** If you enabled [cart item flattening](https://docs.talon.one/docs/product/campaigns/managing-general-settings#flattening), the quantity is always one and the same cart item might receive multiple per-item discounts. Ensure you can process multiple discounts on one cart item correctly.  | 
**ReturnedQuantity** | **int** | Number of returned items, calculated internally based on returns of this item. | [optional] 
**RemainingQuantity** | **int** | Remaining quantity of the item, calculated internally based on returns of this item. | [optional] 
**Price** | **decimal** | Price of the item in the currency defined by your Application. This field is required if this item is not part of a [catalog](https://docs.talon.one/docs/product/account/dev-tools/managing-cart-item-catalogs). If it is part of a catalog, setting a price here overrides the price from the catalog.  | [optional] 
**Category** | **string** | Type, group or model of the item. | [optional] 
**Weight** | **decimal** | Weight of item in grams. | [optional] 
**Height** | **decimal** | Height of item in mm. | [optional] 
**Width** | **decimal** | Width of item in mm. | [optional] 
**Length** | **decimal** | Length of item in mm. | [optional] 
**Position** | **decimal** | Position of the Cart Item in the Cart (calculated internally). | [optional] 
**Attributes** | [**Object**](.md) | Use this property to set a value for the attributes of your choice. [Attributes](https://docs.talon.one/docs/dev/concepts/attributes) represent any information to attach to this cart item.  Custom _cart item_ attributes must be created in the Campaign Manager before you set them with this property.  | [optional] 
**AdditionalCosts** | [**Dictionary&lt;string, AdditionalCost&gt;**](AdditionalCost.md) | Use this property to set a value for the additional costs of this item, such as a shipping cost. They must be created in the Campaign Manager before you set them with this property. See [Managing additional costs](https://docs.talon.one/docs/product/account/dev-tools/managing-additional-costs).  | [optional] 
**CatalogItemID** | **int** | The [catalog item ID](https://docs.talon.one/docs/product/account/dev-tools/managing-cart-item-catalogs/#synchronizing-cart-item-catalogs). | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

