# TalonOne.Model.Selector
A named pipeline of steps (filter, sort, map, etc.) that filters or transforms a list of cart items. Replaces `cartItemFilter` [bindings](https://docs.talon.one/management-api#tag/Campaigns/operation/getRuleset.responses.200.bindings) in V1 rulesets.
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Name** | **string** | The name of the selector binding. | 
**Type** | **string** | A binding of type &#x60;selector&#x60;. | 
**Source** | **string** | The attribute path the pipeline draws items from. | 
**Steps** | **List&lt;Object&gt;** | Ordered pipeline steps applied to the source items. | 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

