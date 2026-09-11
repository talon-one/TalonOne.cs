# TalonOne.Model.BestPriorPrice
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Id** | **long** | The ID of the historical price. | 
**Sku** | **string** | sku | 
**ObservedAt** | **DateTime** | The date and time when the price was observed. | 
**ContextIds** | **List&lt;string&gt;** | The identifiers of the relevant context at the time the price was observed. Includes the context IDs of any price adjustments and of the campaigns that influenced the final price.  | 
**Price** | **decimal** | Price of the item. | 
**Metadata** | [**BestPriorPriceMetadata**](BestPriorPriceMetadata.md) |  | 
**Target** | [**Object**](.md) |  | 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

