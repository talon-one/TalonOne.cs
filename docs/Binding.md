# TalonOne.Model.Binding
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Name** | **string** | A descriptive name for the value to be bound. | 
**Type** | **string** | The kind of binding. Possible values are: - &#x60;bundle&#x60; - &#x60;cartItemFilter&#x60; - &#x60;subledgerBalance&#x60; - &#x60;templateParameter&#x60;  | [optional] 
**Expression** | **List&lt;Object&gt;** | A Talang expression that will be evaluated and its result attached to the name of the binding. | 
**ValueType** | **string** | Can be one of the following: - &#x60;string&#x60; - &#x60;number&#x60; - &#x60;boolean&#x60;  | [optional] 
**MinValue** | **decimal** | The minimum value allowed for this placeholder. | [optional] 
**MaxValue** | **decimal** | The maximum value allowed for this placeholder. | [optional] 
**AttributeId** | **int** | Id of the attribute attached to the placeholder. | [optional] 
**Description** | **string** | Describes the placeholder field and value in the template. This description can be used when creating campaigns from this template. | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

