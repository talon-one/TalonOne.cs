# TalonOne.Model.RuleFailureReason
Details about why a rule failed.
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**CampaignID** | **int** | The ID of the campaign that contains the rule that failed | 
**CampaignName** | **string** | The name of the campaign that contains the rule that failed | 
**RulesetID** | **int** | The ID of the ruleset that contains the rule that failed | 
**CouponID** | **int** | The ID of the coupon that was being evaluated at the time of the rule failure | [optional] 
**CouponValue** | **string** | The value of the coupon that was being evaluated at the time of the rule failure | [optional] 
**ReferralID** | **int** | The ID of the referral that was being evaluated at the time of the rule failure | [optional] 
**ReferralValue** | **string** | The value of the referral that was being evaluated at the time of the rule failure | [optional] 
**RuleIndex** | **int** | The index of the rule that failed within the ruleset | 
**RuleName** | **string** | The name of the rule that failed within the ruleset | 
**ConditionIndex** | **int** | The index of the condition that failed | [optional] 
**EffectIndex** | **int** | The index of the effect that failed | [optional] 
**Details** | **string** | More details about the failure | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

