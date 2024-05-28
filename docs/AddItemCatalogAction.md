# TalonOne.Model.AddItemCatalogAction
The specific properties of the \"ADD\" catalog sync action. 
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Sku** | **string** | The unique SKU of the item to add. | 
**Price** | **decimal** | Price of the item. | [optional] 
**Attributes** | [**Object**](.md) | The attributes of the item to add. | [optional] 
**Product** | [**Product**](Product.md) |  | [optional] 
**ReplaceIfExists** | **bool** | Indicates whether to replace the attributes of the item if the same SKU exists.  **Note**: When set to &#x60;true&#x60;:   - If you do not provide a new &#x60;price&#x60; value, the existing &#x60;price&#x60; value is retained.   - If you do not provide a new &#x60;product&#x60; value, the &#x60;product&#x60; value is set to &#x60;null&#x60;.  | [optional] [default to false]

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

