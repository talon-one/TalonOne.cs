# TalonOne.Model.CartItem
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Name** | **string** | Name of item | 
**Sku** | **string** | Stock keeping unit of item | 
**Quantity** | **int** | Quantity of item. **Important:** If you enabled [cart item flattening](https://help.talon.one/hc/en-us/articles/360016036899-Flattening-Cart-Items), the quantity is always one and the same cart item might receive multiple per-item discounts. Ensure you can process multiple discounts on one cart item correctly.  | 
**Price** | **decimal** | Price of item | 
**Category** | **string** | Type, group or model of the item | [optional] 
**Weight** | **decimal** | Weight of item in grams | [optional] 
**Height** | **decimal** | Height of item in mm | [optional] 
**Width** | **decimal** | Width of item in mm | [optional] 
**Length** | **decimal** | Length of item in mm | [optional] 
**Position** | **decimal** | Position of the Cart Item in the Cart (calculated internally) | [optional] 
**Attributes** | [**Object**](.md) | Arbitrary properties associated with this item. You can use built-in attributes or create your own. See [Attributes](https://docs.talon.one/docs/dev/concepts/attributes).  | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

