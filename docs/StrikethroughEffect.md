# TalonOne.Model.StrikethroughEffect
The effect produced for the catalog item.
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**CampaignId** | **long** | The ID of the campaign that effect belongs to. | 
**RulesetId** | **long** | The ID of the ruleset containing the rule that triggered this effect. | 
**RuleIndex** | **long** | The position of the rule that triggered this effect within the ruleset. | 
**RuleName** | **string** | The name of the rule that triggered this effect. | 
**Type** | **string** | The type of this effect. | 
**Props** | [**Object**](.md) |  | 
**StartTime** | **DateTime** | The start of the time frame where the effect is active in UTC. | [optional] 
**EndTime** | **DateTime** | The end of the time frame where the effect is active in UTC. | [optional] 
**SelectedPriceType** | **string** | The selected price type for this cart item (e.g. the price for members only). | [optional] 
**SelectedPrice** | **decimal** | The value of the selected price type to apply to the SKU targeted by this effect, before any discounts are applied. | [optional] 
**AdjustmentReferenceId** | **string** | The reference identifier of the selected price adjustment for this cart item. | [optional] 
**Targets** | **List&lt;Object&gt;** | A list of entities (e.g. audiences) targeted by this effect. | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

