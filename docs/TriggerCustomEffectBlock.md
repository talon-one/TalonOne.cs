# TalonOne.Model.TriggerCustomEffectBlock
A block that triggers a configured custom effect and passes its required parameters.
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Id** | **string** | Unique identifier for this block. | [optional] [readonly] 
**Type** | **string** | Identifies the block variant and determines which additional properties are present in it. | 
**Tags** | **List&lt;string&gt;** | Semantic labels attached to this block. | [optional] [readonly] 
**CustomEffect** | [**TriggerCustomEffectBlockCustomEffect**](TriggerCustomEffectBlockCustomEffect.md) |  | 
**Params** | [**Object**](.md) | The custom effect&#39;s parameters, in configured order. Each property name is the parameter&#39;s title, lowercased with spaces replaced by underscores (for example, &#x60;Order ID&#x60; becomes &#x60;order_id&#x60;); falls back to &#x60;param_0&#x60;, &#x60;param_1&#x60;, and so on if a title is blank or collides with another. | [optional] 
**Target** | [**TriggerCustomEffectBlockTarget**](TriggerCustomEffectBlockTarget.md) |  | 
**OnError** | **Dictionary&lt;string, List&lt;Object&gt;&gt;** | Named error handlers evaluated when a specific error occurs. | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

