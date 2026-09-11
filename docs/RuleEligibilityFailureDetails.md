# TalonOne.Model.RuleEligibilityFailureDetails
The details about why the customer was not eligible for the rule in the current session.
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**FailureCode** | **string** | A code identifying why the customer was not eligible for the rule in the current session. | 
**CouponID** | **long** | The ID of the coupon that was being evaluated when the rule failed.  | [optional] 
**CouponValue** | **string** | The coupon code that was being evaluated when the rule failed.  | [optional] 
**ReferralID** | **long** | The ID of the referral that was being evaluated when the rule failed.  | [optional] 
**ReferralValue** | **string** | The referral code that was being evaluated when the rule failed.  | [optional] 
**ConditionIndex** | **long** | The index of the condition that caused the rule to fail. | [optional] 
**EffectIndex** | **long** | The index of the effect that caused the rule to fail. | [optional] 
**Details** | **string** | Additional details about the failure. | 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

