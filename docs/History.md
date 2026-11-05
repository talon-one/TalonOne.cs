# TalonOne.Model.History
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Id** | **long** | The ID of the historical price. | 
**ObservedAt** | **DateTime** | The date and time when the price was observed. | 
**ContextIds** | **List&lt;string&gt;** | The identifiers of the relevant context (the sales events, e.g. \&quot;Spring Sale\&quot;, \&quot;Summer Sale\&quot;) at the time the price was observed. Includes the context IDs of any price adjustments and of the campaigns that influenced the final price.  | 
**Price** | **decimal** | Price of the item. | 
**Metadata** | [**BestPriorPriceMetadata**](BestPriorPriceMetadata.md) |  | 
**Target** | [**Object**](.md) |  | 
**ExcludedAt** | **DateTime** | The date and time when the historical price ID was excluded. | [optional] 
**ExclusionReason** | **string** | The reason for excluding this historical price ID. | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

