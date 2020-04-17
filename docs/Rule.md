
# TalonOne.Model.Rule

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Title** | **string** | A short description of the rule. | 
**Description** | **string** | A longer, more detailed description of the rule. | [optional] 
**Bindings** | [**List&lt;Binding&gt;**](Binding.md) | An array that provides objects with variable names (name) and talang expressions to whose result they are bound (expression) during rule evaluation. The order of the evaluation is decided by the position in the array. | [optional] 
**Condition** | **List&lt;Object&gt;** | A Talang expression that will be evaluated in the context of the given event. | 
**Effects** | **List&lt;Object&gt;** | An array of effectful Talang expressions in arrays that will be evaluated when a rule matches. | 

[[Back to Model list]](../README.md#documentation-for-models)
[[Back to API list]](../README.md#documentation-for-api-endpoints)
[[Back to README]](../README.md)

