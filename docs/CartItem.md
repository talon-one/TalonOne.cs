# TalonOne.Model.CartItem
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Name** | **string** | Name of item. | [optional] 
**Sku** | **string** | Stock keeping unit of item. | 
**Quantity** | **int** | Number of units of this item. Due to [cart item flattening](https://docs.talon.one/docs/product/rules/understanding-cart-item-flattening), if you provide a quantity greater than 1, the item will be split in as many items as the provided quantity. This will impact the number of **per-item** effects triggered from your campaigns.  | 
**ReturnedQuantity** | **int** | Number of returned items, calculated internally based on returns of this item. | [optional] 
**RemainingQuantity** | **int** | Remaining quantity of the item, calculated internally based on returns of this item. | [optional] 
**Price** | **decimal** | Price of the item in the currency defined by your Application. This field is required if this item is not part of a [catalog](https://docs.talon.one/docs/product/account/dev-tools/managing-cart-item-catalogs). If it is part of a catalog, setting a price here overrides the price from the catalog.  | [optional] 
**Category** | **string** | Type, group or model of the item. | [optional] 
**Product** | [**Product**](Product.md) |  | [optional] 
**Weight** | **decimal** | Weight of item in grams. | [optional] 
**Height** | **decimal** | Height of item in mm. | [optional] 
**Width** | **decimal** | Width of item in mm. | [optional] 
**Length** | **decimal** | Length of item in mm. | [optional] 
**Position** | **decimal** | Position of the Cart Item in the Cart (calculated internally). | [optional] 
**Attributes** | [**Object**](.md) | Use this property to set a value for the attributes of your choice. [Attributes](https://docs.talon.one/docs/dev/concepts/attributes) represent any information to attach to this cart item.  Custom _cart item_ attributes must be created in the Campaign Manager before you set them with this property.  **Note:** Any previously defined attributes that you do not include in the array will be removed.  | [optional] 
**AdditionalCosts** | [**Dictionary&lt;string, AdditionalCost&gt;**](AdditionalCost.md) | Use this property to set a value for the additional costs of this item, such as a shipping cost. They must be created in the Campaign Manager before you set them with this property. See [Managing additional costs](https://docs.talon.one/docs/product/account/dev-tools/managing-additional-costs).  | [optional] 
**CatalogItemID** | **int** | The catalog item ID. | [optional] 
**SelectedPriceType** | **string** | The selected price type for this cart item (e.g. the price for members only). | [optional] 
**AdjustmentReferenceId** | **Guid** | The reference ID of the selected price adjustment for this cart item. Only returned if the selected price resulted from a price adjustment. | [optional] 
**AdjustmentEffectiveFrom** | **DateTime** | The date and time from which the price adjustment is effective. Only returned if the selected price resulted from a price adjustment that contains this field. | [optional] 
**AdjustmentEffectiveUntil** | **DateTime** | The date and time until which the price adjustment is effective. Only returned if the selected price resulted from a price adjustment that contains this field. | [optional] 
**Prices** | [**Dictionary&lt;string, PriceDetail&gt;**](PriceDetail.md) | A map of keys and values representing the price types and related price adjustment details for this cart item. The keys correspond to the &#x60;priceType&#x60; names.  | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

