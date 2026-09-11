# TalonOne.Model.UpdateAttributeValueBlock
A block that sets or updates an attribute. The `type` may be empty for [built-in attributes](https://docs.talon.one/docs/dev/concepts/attributes).
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Id** | **string** | Unique identifier for this block. | [optional] [readonly] 
**Type** | **string** | Identifies the block variant and determines which additional properties are present in it. | 
**Tags** | **List&lt;string&gt;** | Semantic labels attached to this block. | [optional] [readonly] 
**Operator** | **string** | The update operation applied to the attribute. | 
**Attribute** | [**UpdateAttributeValueBlockAttribute**](UpdateAttributeValueBlockAttribute.md) |  | 
**Value** | [**Object**](.md) | The value of the attribute. Omitted when operator is set to &#x60;toggle&#x60;. | [optional] 
**Target** | [**UpdateAttributeValueBlockTarget**](UpdateAttributeValueBlockTarget.md) |  | 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

