# TalonOne.Model.Effect
A generic effect that is fired by a triggered campaign. The props property will contain information specific to the specific effect type.
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**CampaignId** | **long** | The ID of the campaign that triggered this effect. | 
**RulesetId** | **long** | The ID of the ruleset that was active in the campaign when this effect was triggered. | 
**RuleIndex** | **long** | The position of the rule that triggered this effect within the ruleset. | 
**RuleName** | **string** | The name of the rule that triggered this effect. | 
**EffectType** | **string** | The type of effect that was triggered. See [API effects](https://docs.talon.one/docs/dev/integration-api/api-effects). | 
**TriggeredByCoupon** | **long** | The ID of the coupon that was being evaluated when this effect was triggered. | [optional] 
**TriggeredForCatalogItem** | **long** | The ID of the catalog item that was being evaluated when this effect was triggered. | [optional] 
**ConditionIndex** | **long** | The index of the condition that was triggered. | [optional] 
**EvaluationGroupID** | **long** | The ID of the evaluation group. For more information, see [Managing campaign evaluation](https://docs.talon.one/docs/product/applications/managing-campaign-evaluation). | [optional] 
**EvaluationGroupMode** | **string** | The evaluation mode of the evaluation group. For more information, see [Managing campaign evaluation](https://docs.talon.one/docs/product/applications/managing-campaign-evaluation). | [optional] 
**CampaignRevisionId** | **long** | The revision ID of the campaign that was used when triggering the effect. | [optional] 
**CampaignRevisionVersionId** | **long** | The revision version ID of the campaign that was used when triggering the effect. | [optional] 
**SelectedPriceType** | **string** | The selected price type for the SKU targeted by this effect. | [optional] 
**SelectedPrice** | **decimal** | The value of the selected price type to apply to the SKU targeted by this effect, before any discounts are applied. | [optional] 
**AdjustmentReferenceId** | **Guid** | The reference identifier of the selected price adjustment for this SKU. This is only returned if the &#x60;selectedPrice&#x60; resulted from a price adjustment. | [optional] 
**Props** | [**Object**](.md) |  | 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

