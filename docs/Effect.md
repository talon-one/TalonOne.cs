# TalonOne.Model.Effect
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
**Props** | [**Object**](.md) | The properties of the effect. See [API effects](https://docs.talon.one/docs/dev/integration-api/api-effects). | 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

