# TalonOne.Model.RulesetV2
Ruleset in the V2 JSON block format.
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Id** | **long** | Internal ID of this entity. | [optional] [readonly] 
**Created** | **DateTime** | The time this entity was created. | [optional] [readonly] 
**UserId** | **long** | The ID of the user that created this ruleset. | [optional] [readonly] 
**CampaignId** | **long** | The ID of the campaign that owns this entity. | [optional] [readonly] 
**TemplateId** | **long** | The ID of the campaign template that owns this entity. | [optional] [readonly] 
**ActivatedAt** | **DateTime** | Timestamp indicating when this ruleset was activated. | [optional] [readonly] 
**PromotionRules** | [**List&lt;RuleV2&gt;**](RuleV2.md) | Set of promotion rules. | 
**StrikethroughRules** | [**List&lt;RuleV2&gt;**](RuleV2.md) | Set of strikethrough rules. | [optional] 
**Selectors** | [**List&lt;Selector&gt;**](Selector.md) | Variable bindings of type selector. | [optional] [readonly] 
**Bundles** | [**List&lt;Bundle&gt;**](Bundle.md) | Variable bindings of type bundle. | [optional] [readonly] 
**Parameters** | [**List&lt;TemplateParameter&gt;**](TemplateParameter.md) | Variable bindings of type template parameter. | [optional] [readonly] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

