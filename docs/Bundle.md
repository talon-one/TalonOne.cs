# TalonOne.Model.Bundle
A named bundle definition consisting of selector sources with matching constraints. Replaces `bundle` [bindings](https://docs.talon.one/management-api#tag/Campaigns/operation/getRuleset.responses.200.bindings) in V1 rulesets.
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Id** | **string** | An identifier derived from the bundle content. | 
**Name** | **string** | The name of the bundle. | 
**Type** | **string** | A binding of type &#x60;bundle&#x60;. | 
**Sources** | **List&lt;string&gt;** | The selector sources of bundle items. Each source is expressed as a &#x60;{{$selectorName}}&#x60; reference. | 
**Counts** | **List&lt;long&gt;** | The number of items to retrieve from each corresponding source in &#x60;sources&#x60;. | 
**Matchers** | **List&lt;string&gt;** | Attribute names that the bundled items must share. | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

