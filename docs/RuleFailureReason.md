# TalonOne.Model.RuleFailureReason
Details about why a rule failed.
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**CampaignID** | **long** | The ID of the campaign that contains the rule that failed. | 
**CampaignName** | **string** | The name of the campaign that contains the rule that failed. | 
**RulesetID** | **long** | The ID of the ruleset that contains the rule that failed. | 
**CouponID** | **long** | The ID of the coupon that was being evaluated at the time of the rule failure. | [optional] 
**CouponValue** | **string** | The code of the coupon that was being evaluated at the time of the rule failure. | [optional] 
**ReferralID** | **long** | The ID of the referral that was being evaluated at the time of the rule failure. | [optional] 
**ReferralValue** | **string** | The code of the referral that was being evaluated at the time of the rule failure. | [optional] 
**RuleIndex** | **long** | The index of the rule that failed within the ruleset. | 
**RuleName** | **string** | The name of the rule that failed within the ruleset. | 
**ConditionIndex** | **long** | The index of the condition that failed. | [optional] 
**EffectIndex** | **long** | The index of the effect that failed. | [optional] 
**Details** | **string** | More details about the failure. | [optional] 
**EvaluationGroupID** | **long** | The ID of the evaluation group. For more information, see [Managing campaign evaluation](https://docs.talon.one/docs/product/applications/managing-campaign-evaluation). | [optional] 
**EvaluationGroupMode** | **string** | The evaluation mode of the evaluation group. For more information, see [Managing campaign evaluation](https://docs.talon.one/docs/product/applications/managing-campaign- | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

