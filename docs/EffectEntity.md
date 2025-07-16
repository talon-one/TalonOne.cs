# TalonOne.Model.EffectEntity
Definition of all properties that are present on all effects, independent of their type.
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**CampaignId** | **int** | The ID of the campaign that triggered this effect. | 
**RulesetId** | **int** | The ID of the ruleset that was active in the campaign when this effect was triggered. | 
**RuleIndex** | **int** | The position of the rule that triggered this effect within the ruleset. | 
**RuleName** | **string** | The name of the rule that triggered this effect. | 
**EffectType** | **string** | The type of effect that was triggered. See [API effects](https://docs.talon.one/docs/dev/integration-api/api-effects). | 
**TriggeredByCoupon** | **int** | The ID of the coupon that was being evaluated when this effect was triggered. | [optional] 
**TriggeredForCatalogItem** | **int** | The ID of the catalog item that was being evaluated when this effect was triggered. | [optional] 
**ConditionIndex** | **int** | The index of the condition that was triggered. | [optional] 
**EvaluationGroupID** | **int** | The ID of the evaluation group. For more information, see [Managing campaign evaluation](https://docs.talon.one/docs/product/applications/managing-campaign-evaluation). | [optional] 
**EvaluationGroupMode** | **string** | The evaluation mode of the evaluation group. For more information, see [Managing campaign evaluation](https://docs.talon.one/docs/product/applications/managing-campaign-evaluation). | [optional] 
**CampaignRevisionId** | **int** | The revision ID of the campaign that was used when triggering the effect. | [optional] 
**CampaignRevisionVersionId** | **int** | The revision version ID of the campaign that was used when triggering the effect. | [optional] 
**SelectedPriceType** | **string** | The selected price type for the SKU targeted by this effect. | [optional] 
**SelectedPrice** | **decimal** | The value of the selected price type to apply to the SKU targeted by this effect, before any discounts are applied. | [optional] 
**AdjustmentReferenceId** | **Guid** | The reference identifier of the selected price adjustment for this SKU. This is only returned if the &#x60;selectedPrice&#x60; resulted from a price adjustment. | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

