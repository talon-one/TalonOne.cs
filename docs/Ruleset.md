# TalonOne.Model.Ruleset
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Id** | **int** | Unique ID for this entity. | 
**Created** | **DateTime** | The exact moment this entity was created. | 
**UserId** | **int** | The ID of the account that owns this entity. | 
**Rules** | [**List&lt;Rule&gt;**](Rule.md) | Set of rules to apply. | 
**Bindings** | [**List&lt;Binding&gt;**](Binding.md) | An array that provides objects with variable names (name) and talang expressions to whose result they are bound (expression) during rule evaluation. The order of the evaluation is decided by the position in the array. | 
**RbVersion** | **string** | A string indicating which version of the rulebuilder was used to create this ruleset. | [optional] 
**Activate** | **bool** | A boolean indicating whether this newly created ruleset should also be activated for the campaign that owns it | [optional] 
**CampaignId** | **int** | The ID of the campaign that owns this entity. | [optional] 
**TemplateId** | **int** | The ID of the campaign template that owns this entity. | [optional] 
**ActivatedAt** | **DateTime** | Timestamp indicating when this Ruleset was activated. | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

