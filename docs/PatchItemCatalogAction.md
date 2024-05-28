# TalonOne.Model.PatchItemCatalogAction
The specific properties of the \"PATCH\" catalog sync action.  **Note:**   - If you do not provide a new `price` value, the existing `price` value is retained.   - If you do not provide a new `product` value, the `product` value is set to `null`. 
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Sku** | **string** | The unique SKU of the item to patch. | 
**Price** | **decimal** | Price of the item. | [optional] 
**Attributes** | [**Object**](.md) | The attributes of the item to patch. | [optional] 
**Product** | [**Product**](Product.md) |  | [optional] 
**CreateIfNotExists** | **bool** | Indicates whether to create an item if the SKU does not exist. | [optional] [default to false]

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

