# TalonOne.Model.StrikethroughChangedItem
The information of affected items.
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Id** | **long** | The ID of the event that triggered the strikethrough labeling. | 
**CatalogId** | **long** | The ID of the catalog that the changed item belongs to. | 
**Sku** | **string** | The unique SKU of the changed item. | 
**Version** | **long** | The version of the changed item. | 
**Price** | **decimal** | The price of the changed item. | 
**Prices** | [**Dictionary&lt;string, PriceDetail&gt;**](PriceDetail.md) | A map of keys and values representing the price types and related price adjustment details for this cart item.       The keys correspond to the &#x60;priceType&#x60; names.  | [optional] 
**EvaluatedAt** | **DateTime** | The evaluation time of the changed item. | 
**Effects** | [**List&lt;StrikethroughEffect&gt;**](StrikethroughEffect.md) |  | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

