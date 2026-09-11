# TalonOne.Model.AwardItemBlock
A block that awards a free cart item to the customer. The item is identified by SKU and name and has a configurable quantity.
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Id** | **string** | Unique identifier for this block. | [optional] [readonly] 
**Type** | **string** | Identifies the block variant and determines which additional properties are present in it. | 
**Tags** | **List&lt;string&gt;** | Semantic labels attached to this block. | [optional] [readonly] 
**Sku** | **string** | The stock keeping unit of the item to award. | 
**Name** | **string** | The display name of the item to award. | 
**Quantity** | **string** | The number of items to award. Supports template placeholders (e.g. \&quot;{{$Session.Total / 2}}\&quot;) for dynamic quantities. | 
**Partial** | **bool** | When set to &#x60;true&#x60;, applies a partial item reward if the remaining budget is insufficient to award the full reward. | [optional] 
**OnFailure** | **List&lt;Object&gt;** | Blocks evaluated when this block fails or returns false. | [optional] 
**OnError** | **Dictionary&lt;string, List&lt;Object&gt;&gt;** | Named error handlers evaluated when a specific error occurs. | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

