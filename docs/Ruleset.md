# TalonOne.Model.Ruleset
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Id** | **int** | Internal ID of this entity. | 
**Created** | **DateTime** | The time this entity was created. | 
**UserId** | **int** | The ID of the user associated with this entity. | 
**Rules** | [**List&lt;Rule&gt;**](Rule.md) | Set of rules to apply. | 
**StrikethroughRules** | [**List&lt;Rule&gt;**](Rule.md) | Set of rules to apply for strikethrough. | [optional] 
**Bindings** | [**List&lt;Binding&gt;**](Binding.md) | An array that provides objects with variable names (name) and talang expressions to whose result they are bound (expression) during rule evaluation. The order of the evaluation is decided by the position in the array. | 
**RbVersion** | **string** | The version of the rulebuilder used to create this ruleset. | [optional] 
**Activate** | **bool** | Indicates whether this created ruleset should be activated for the campaign that owns it. | [optional] 
**CampaignId** | **int** | The ID of the campaign that owns this entity. | [optional] 
**TemplateId** | **int** | The ID of the campaign template that owns this entity. | [optional] 
**ActivatedAt** | **DateTime** | Timestamp indicating when this Ruleset was activated. | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

