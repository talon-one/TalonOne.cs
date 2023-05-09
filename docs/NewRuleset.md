# TalonOne.Model.NewRuleset
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Rules** | [**List&lt;Rule&gt;**](Rule.md) | Set of rules to apply. | 
**StrikethroughRules** | [**List&lt;Rule&gt;**](Rule.md) | Set of rules to apply for strikethrough. | [optional] 
**Bindings** | [**List&lt;Binding&gt;**](Binding.md) | An array that provides objects with variable names (name) and talang expressions to whose result they are bound (expression) during rule evaluation. The order of the evaluation is decided by the position in the array. | 
**RbVersion** | **string** | The version of the rulebuilder used to create this ruleset. | [optional] 
**Activate** | **bool** | Indicates whether this created ruleset should be activated for the campaign that owns it. | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

