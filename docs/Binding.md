# TalonOne.Model.Binding
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Name** | **string** | A descriptive name for the value to be bound. | 
**Type** | **string** | The kind of binding. Possible values are: - &#x60;bundle&#x60; - &#x60;cartItemFilter&#x60; - &#x60;subledgerBalance&#x60; - &#x60;templateParameter&#x60;  | [optional] 
**Expression** | **List&lt;Object&gt;** | A Talang expression that is evaluated, and its result is bound to the name of the binding. The first element must be one of the functions or operators supported by Talang, followed by its arguments. The arguments can be strings, numbers, or nested expressions. For example: - &#x60;[\&quot;list\&quot;, \&quot;10014\&quot;, \&quot;10015\&quot;]&#x60; calls the &#x60;list&#x60; function to build a list of strings. - &#x60;[\&quot;+\&quot;, 2, 0]&#x60; uses the &#x60;+&#x60; operator to add two numbers.  | 
**ValueType** | **string** | The data type of the value. One of the following: - &#x60;string&#x60; - &#x60;number&#x60; - &#x60;boolean&#x60;  | [optional] 
**MinValue** | **decimal** | The minimum value allowed for this placeholder. | [optional] 
**MaxValue** | **decimal** | The maximum value allowed for this placeholder. | [optional] 
**AttributeId** | **long** | Identifier of the attribute attached to the placeholder. | [optional] 
**Description** | **string** | Description of the placeholder field and its value in the template. This text can be shown when creating campaigns from this template. | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

